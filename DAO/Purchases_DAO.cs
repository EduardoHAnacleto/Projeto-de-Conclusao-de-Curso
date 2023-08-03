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

        internal int GetLastId()
        {
            string sql = "SELECT IDENT_CURRENT ('PURCHASES');";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                int i = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return i;
            }
        }

        public int NewId()
        {
            var newId = "";
            string sql = "SELECT MAX(ID_PURCHASE) FROM PURCHASES;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                newId = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            if (newId != "")
            {
                int id = Convert.ToInt32(newId) + 1;
                return id;
            }
            return 2;
        }

        public bool SaveToDb(Purchases obj)
        {
            bool status = false;

            string sql = "INSERT INTO PURCHASES ( PURCHASESTATUS, EMISSIONDATE, ARRIVALDATE, FREIGHTCOST, PURCHASE_TOTALCOST, " +
                "PURCHASE_TOTALVALUE, PURCHASE_EXTRAEXPENSES, PURCHASE_DISCOUNTCASH, PURCHASE_DISCOUNTPERC, PURCHASE_INSURANCECOST," +
                "SUPPLIER_ID, USER_ID, DATE_CREATION, DATE_LAST_UPDATE ) "
                         + " VALUES (@STATUS, @EMDATE, @ARRIVALDATE, @FREIGHT, @TOTALCOST, @TOTALVALUE, @EXPENSES, @DISCCASH, @DISCPERC," +
                         " @INSURANCE, @SUPPLIERID, @USERID, @DC, @DU);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@STATUS", obj.Status);
                    command.Parameters.AddWithValue("@EMDATE", obj.EmissionDate);
                    command.Parameters.AddWithValue("@ARRIVALDATE", obj.ArrivalDate);
                    command.Parameters.AddWithValue("@FREIGHT", (decimal)obj.Freight_Cost);
                    command.Parameters.AddWithValue("@TOTALCOST", (decimal)obj.Total_Cost);
                    command.Parameters.AddWithValue("@TOTALVALUE", (decimal)obj.Total_PurchaseValue);
                    command.Parameters.AddWithValue("@EXPENSES", (decimal)obj.ExtraExpenses);
                    command.Parameters.AddWithValue("@DISCCASH", (decimal)obj.DiscountCash);
                    command.Parameters.AddWithValue("@DISCPERC", (decimal)obj.DiscountPerc);
                    command.Parameters.AddWithValue("@INSURANCE", (decimal)obj.InsuranceCost);
                    command.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
                    command.Parameters.AddWithValue("@USERID", obj.User.id);
                    command.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Register added with success!");
                        status = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public bool EditFromDB(Purchases obj)
        {
            bool status = false;

            string sql = "UPDATE PURCHASES SET PURCHASESTATUS = @STATUS, EMISSIONDATE = @EMDATE, ARRIVALDATE = @ARRIVALDATE, FREIGHTCOST = @FREIGHT," +
                " PURCHASE_TOTALCOST = @TOTALCOST, PURCHASE_TOTALVALUE = @TOTALVALUE, PURCHASE_EXTRAEXPENSES = @EXPENSES, PURCHASE_DISCOUNTCASH = @DISCCASH," +
                " PURCHASE_DISCOUNTPERC = @DISCPERC, PURCHASE_INSURANCECOST = @INSURANCE, SUPPLIER_ID = @SUPPLIERID," +
                " USER_ID = @USERID, DATE_LAST_UPDATE = @USERID " +
                " WHERE ID_PURCHASE = @ID; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", obj.id);
                    command.Parameters.AddWithValue("@STATUS", obj.Status);
                    command.Parameters.AddWithValue("@EMDATE", obj.EmissionDate);
                    command.Parameters.AddWithValue("@ARRIVALDATE", obj.ArrivalDate);
                    command.Parameters.AddWithValue("@FREIGHT", (decimal)obj.Freight_Cost);
                    command.Parameters.AddWithValue("@TOTALCOST", (decimal)obj.Total_Cost);
                    command.Parameters.AddWithValue("@TOTALVALUE", (decimal)obj.Total_PurchaseValue);
                    command.Parameters.AddWithValue("@EXPENSES", (decimal)obj.ExtraExpenses);
                    command.Parameters.AddWithValue("@DISCCASH", (decimal)obj.DiscountCash);
                    command.Parameters.AddWithValue("@DISCPERC", (decimal)obj.DiscountPerc);
                    command.Parameters.AddWithValue("@INSURANCE", (decimal)obj.InsuranceCost);
                    command.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
                    command.Parameters.AddWithValue("@USERID", obj.User.id);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Register altered with success!");
                        status = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public bool DeleteFromDb(int id)
        {
            bool status = false;
            string sql = "DELETE FROM PURCHASES WHERE PURCHASE_ID = @ID ;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Register erased with success!");
                        status = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public Purchases SelectFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM PURCHASES WHERE PURCHASE_ID = @ID ; ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Purchases obj = new Purchases()
                                {
                                    id = Convert.ToInt32(reader["id_purchase"]),
                                    Status = Convert.ToInt32(reader["purchaseStatus"]),
                                    EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                    ArrivalDate = Convert.ToDateTime(reader["arrivalDate"]),
                                    Freight_Cost = Convert.ToDouble(reader["freightCost"]),
                                    Total_PurchaseValue = Convert.ToDouble(reader["purchase_totalValue"]),
                                    Total_Cost = Convert.ToDouble(reader["purchase_TotalCost"]),
                                    ExtraExpenses = Convert.ToDouble(reader["purchase_ExtraExpenses"]),
                                    DiscountCash = Convert.ToDouble(reader["purchase_DiscountCash"]),
                                    DiscountPerc = Convert.ToDouble(reader["purchase_DiscountPerc"]),
                                    InsuranceCost = Convert.ToDouble(reader["purchase_InsuranceCost"]),
                                    User = _userController.FindItemId(Convert.ToInt32(reader["user_id"])),
                                    PurchasedItems = _purchaseItemsController.FindItemId(Convert.ToInt32(reader["id_purchase"])),
                                    Supplier = _suppliersController.FindItemId(Convert.ToInt32(reader["supplier_id"])),
                                };
                                return obj;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
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
                MessageBox.Show("Error : " + ex.Message);
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
                MessageBox.Show("Error : " + ex.Message);
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
                MessageBox.Show("Error : " + ex.Message);
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
                MessageBox.Show("Error : " + ex.Message);
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
                MessageBox.Show("Error : " + ex.Message);
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
                MessageBox.Show("Error : " + ex.Message);
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
                MessageBox.Show("Error : " + ex.Message);
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
                MessageBox.Show("Error : " + ex.Message);
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

            string sql = "INSERT INTO PURCHASEBILLS ( PURCHASE_ID, BILLNUMBER, BILLMODEL, BILLSERIES, BILLPAGE, INSTALMENTNUMBER ) "
                         + " VALUES (@PURCHID, @BNUMBER, @BMODEL, @BSERIES, @BPAGE, @BINSTALNUM);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@PURCHID", purchase.id);
                    command.Parameters.AddWithValue("@BNUMBER", bill.BillNumber);
                    command.Parameters.AddWithValue("@BMODEL", bill.BillModel);
                    command.Parameters.AddWithValue("@BSERIES", bill.BillSeries);
                    command.Parameters.AddWithValue("@BPAGE", bill.BillPage);
                    command.Parameters.AddWithValue("@BINSTALNUM", bill.InstalmentNumber);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Register added with success!");
                        status = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
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
