using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using System.Configuration;
using System.Drawing.Drawing2D;
using Microsoft.Win32;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class Purchases_DAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private readonly PaymentConditions_Controller _paymentConditionsController = new PaymentConditions_Controller();
        private readonly Suppliers_Controller _suppliersController = new Suppliers_Controller();
        private readonly PurchaseItems_Controller _purchaseItemsController = new PurchaseItems_Controller();
        private readonly BillsToPay_Controller _billsToPayController = new BillsToPay_Controller();
        private readonly Users_Controller _userController = new Users_Controller();

        public bool SaveToDb(Purchases obj)
        {
            bool status = false;

            string sql = "INSERT INTO PURCHASES (BILLMODEL, BILLNUMBER, BILLSERIES, SUPPLIER_ID, EMISSIONDATE, ARRIVALDATE, FREIGHTCOST, PURCHASE_TOTALCOST, " +
                " PURCHASE_EXTRAEXPENSES, PURCHASE_INSURANCECOST, USER_ID, DATE_CREATION, DATE_LAST_UPDATE, PAYCONDITION_ID ) "
                         + " VALUES (@BMODEL, @BNUM, @BSERIES, @SUPPLIERID, @EMDATE, @ARRIVALDATE, @FREIGHT, @TOTALCOST, @EXPENSES," +
                         " @INSURANCE, @USERID, @DC, @DU, @PAYCONDID);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@BMODEL", obj.BillModel);
                    command.Parameters.AddWithValue("@BNUM", obj.BillNumber);
                    command.Parameters.AddWithValue("@BSERIES", obj.BillSeries);
                    command.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
                    command.Parameters.AddWithValue("@EMDATE", obj.EmissionDate);
                    command.Parameters.AddWithValue("@PAYCONDID", obj.PaymentCondition.id);
                    command.Parameters.AddWithValue("@ARRIVALDATE", obj.ArrivalDate);
                    command.Parameters.AddWithValue("@FREIGHT", (decimal)obj.Freight_Cost);
                    command.Parameters.AddWithValue("@TOTALCOST", (decimal)obj.Total_Cost);
                    command.Parameters.AddWithValue("@EXPENSES", (decimal)obj.ExtraExpenses);
                    command.Parameters.AddWithValue("@INSURANCE", (decimal)obj.InsuranceCost);
                    command.Parameters.AddWithValue("@USERID", obj.User.id);
                    command.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Compra salva com sucesso.");
                        status = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public bool EditFromDB(Purchases obj, string cancelMotive)
        {
            bool status = false;

            string sql = "UPDATE PURCHASES SET CANCELLEDDATE = @CANCELDATE, DATE_LAST_UPDATE = @DU " +
                " WHERE BILLMODEL = @BMODEL AND BILLNUMBER = @BNUM AND BILLSERIES = @BSERIES AND SUPPLIER_ID = @SUPPLIERID; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@BMODEL", obj.BillModel);
                    command.Parameters.AddWithValue("@BNUM", obj.BillNumber);
                    command.Parameters.AddWithValue("@BSERIES", obj.BillSeries);
                    command.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);

                    command.Parameters.AddWithValue("@CANCELDATE", DateTime.Now.Date);
                    command.Parameters.AddWithValue("@DU", DateTime.Now.Date) ;
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {                                           
                        status = _billsToPayController.CancelPurchaseBills(obj.BillNumber, obj.BillModel, obj.BillSeries, obj.Supplier.id, (DateTime)obj.CancelledDate, cancelMotive, obj.User);
                        if (status)
                        {
                            Products_Controller pController = new Products_Controller();
                            foreach (var items in obj.PurchasedItems)
                            {
                                status = pController.RemoveStock(items.Product.id, items.Quantity);
                                status = pController.CancelPurchaseReturnCost(items.Product.id, items.PreUnCost);
                            }
                        }
                        if (status)
                        {
                            MessageBox.Show("Compra cancelada com sucesso.");
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public bool DeleteFromDb(int billModel, int billNumber, int billSeries, int supplierId)
        {
            bool status = false;
            string sql = "DELETE FROM PURCHASES WHERE BILLMODEL = @BMODEL AND BILLNUMBER = @BNUM AND BILLSERIES = @BSERIES AND SUPPLIER_ID = @SUPPLIERID ;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@BMODEL", billModel);
                    command.Parameters.AddWithValue("@BNUM", billNumber);
                    command.Parameters.AddWithValue("@BSERIES", billSeries);
                    command.Parameters.AddWithValue("@SUPPLIERID", supplierId);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro apagado com sucesso.");
                        status = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public Purchases SelectFromDb(int billModel, int billNumber, int billSeries, int supplierId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM PURCHASES WHERE BILLMODEL = @BMODEL AND BILLNUMBER = @BNUM AND BILLSERIES = @BSERIES AND SUPPLIER_ID = @SUPPLIERID ; ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@BMODEL", billModel);
                        command.Parameters.AddWithValue("@BNUM", billNumber);
                        command.Parameters.AddWithValue("@BSERIES", billSeries);
                        command.Parameters.AddWithValue("@SUPPLIERID", supplierId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Purchases obj = new Purchases()
                                {
                                    BillModel = Convert.ToInt32(reader["billModel"]),
                                    BillNumber = Convert.ToInt32(reader["billNumber"]),
                                    BillSeries = Convert.ToInt32(reader["billSeries"]),
                                    CancelledDate = null,
                                    EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                    ArrivalDate = Convert.ToDateTime(reader["arrivalDate"]),
                                    Freight_Cost = Convert.ToDecimal(reader["freightCost"]),
                                    PaymentCondition = _paymentConditionsController.FindItemId(Convert.ToInt32(reader["paycondition_id"])),
                                    Total_Cost = Convert.ToDecimal(reader["purchase_TotalCost"]),
                                    ExtraExpenses = Convert.ToDecimal(reader["purchase_ExtraExpenses"]),
                                    InsuranceCost = Convert.ToDecimal(reader["purchase_InsuranceCost"]),
                                    User = _userController.FindItemId(Convert.ToInt32(reader["user_id"])),
                                    PurchasedItems = _purchaseItemsController.FindItemId(billModel, billNumber, billSeries, supplierId),
                                    Supplier = _suppliersController.FindItemId(Convert.ToInt32(reader["supplier_id"]))
                                };
                                if (reader["cancelledDate"] != DBNull.Value) 
                                {
                                    obj.CancelledDate = Convert.ToDateTime(reader["cancelledDate"]);
                                }
                                return obj;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }

        public List<Purchases> SelectStatusFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASES WHERE PURCHASE_STATUS = " + id + " ;";

            List<Purchases> purchase = null;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return purchase;
        }

        public List<Purchases> SelectEmissionDateFromDb(string date)
        {
            string sql = "SELECT * FROM PURCHASES WHERE EMISSION_DATE >= " + date + " ;";

            List<Purchases> purchase = null;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return purchase;
        }

        public List<Purchases> SelectArrivalDateFromDb(string date)
        {
            string sql = "SELECT * FROM PURCHASES WHERE ARRIVAL_DATE >= " + date + " ;";

            List<Purchases> purchase = null;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return purchase;
        }

        public List<Purchases> SelectTotalCostFromDb(decimal value)
        {
            string sql = "SELECT * FROM PURCHASES WHERE PURCHASE_TOTAL_COST = " + value + " ;";

            List<Purchases> purchase = null;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return purchase;
        }

        public List<Purchases> SelectPayConditionFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASES WHERE ID_PAYCONDITION = " + id + " ;";

            List<Purchases> purchase = null;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return purchase;
        }

        public List<Purchases> SelectSupplierFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASES WHERE SUPPLIER_ID = " + id + " ;";

            List<Purchases> purchase = null;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return purchase;
        }
        public List<Purchases> SelectAllFromDb()
        {
            string sql = "SELECT * FROM PURCHASES ;";
            List<Purchases> purchase = null;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return purchase;
        }

        public DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM PURCHASES ;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connectionString);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool ConnectPurchaseBill(BillsToPay bill, Purchases purchase)
        {
            bool status = false;

            string sql = "INSERT INTO PURCHASEBILLS (BILLNUMBER, BILLMODEL, BILLSERIES, SUPPLIER_ID, INSTALMENTNUMBER ) "
                         + " VALUES (@BNUMBER, @BMODEL, @BSERIES, @SUPPLIERID, @INSTALMENTNUM);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@BNUMBER", bill.BillNumber);
                    command.Parameters.AddWithValue("@BMODEL", bill.BillModel);
                    command.Parameters.AddWithValue("@BSERIES", bill.BillSeries);
                    command.Parameters.AddWithValue("@SUPPLIERID", bill.Supplier.id);
                    command.Parameters.AddWithValue("@INSTALMENTNUM", bill.InstalmentNumber);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        status = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        internal bool CancelPurchase(Purchases obj)
        {
            bool status = false;

            string sql = "UPDATE PURCHASES SET CANCELLEDDATE = @CANCELDATE, DATE_LAST_UPDATE = @DU, USER_ID = @USERID  " +
                " WHERE BILLMODEL = @BMODEL AND BILLNUMBER = @BNUM AND BILLSERIES = @BSERIES AND SUPPLIER_ID = @SUPPLIERID; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@BMODEL", obj.BillModel);
                    command.Parameters.AddWithValue("@BNUM", obj.BillNumber);
                    command.Parameters.AddWithValue("@BSERIES", obj.BillSeries);
                    command.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
                    command.Parameters.AddWithValue("@USERID", obj.User.id);

                    command.Parameters.AddWithValue("@CANCELDATE", DateTime.Now.Date);
                    command.Parameters.AddWithValue("@DU", DateTime.Now.Date);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        status = true;
                        if (status)
                        {
                            Products_Controller pController = new Products_Controller();
                            foreach (var items in obj.PurchasedItems)
                            {
                                status = pController.RemoveStock(items.Product.id, items.Quantity);
                            }
                        }
                        if (status)
                        {
                            MessageBox.Show("Compra cancelada com sucesso.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }
    }
}
