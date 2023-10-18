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
using System.Transactions;

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

            string sql = "UPDATE PURCHASES SET CANCELLEDDATE = @CANCELDATE, CANCELLEDMOTIVE = @CANCELMOTIVE, DATE_LAST_UPDATE = @DU " +
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

                    command.Parameters.AddWithValue("@CANCELMOTIVE", obj.CancelledMotive);
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
                                    CancelledMotive = reader["cancelledMotive"].ToString(),
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

            string sqlPurch = "UPDATE PURCHASES SET CANCELLEDDATE = @CANCELDATE, CANCELLEDMOTIVE = @CANCELMOTIVE, DATE_LAST_UPDATE = @DU, USER_ID = @USERID  " +
                " WHERE BILLMODEL = @BMODEL AND BILLNUMBER = @BNUM AND BILLSERIES = @BSERIES AND SUPPLIER_ID = @SUPPLIERID; ";

            string sqlBills = "UPDATE BILLSTOPAY SET DATE_CANCELLED = @DATECANCEL, USER_ID = @USERID, MOTIVE_CANCELLED = @MOTCANCEL, DATE_LAST_UPDATE = @UPDATE " +
                    "WHERE BILLNUMBER = @BNUMBER AND BILLSERIES = @BSERIES AND BILLMODEL = @BMODEL AND SUPPLIER_ID = @SUPPLIERID; ";

            string sqlProdStock = "UPDATE PRODUCTS SET STOCK = @RESTOCK, PRODUCT_COST = @PRODCOST WHERE ID_PRODUCT = @ID ; ";

            string sqlPurchItems = "UPDATE PURCHASEITEMS SET DATE_CANCELLED = @CANCELDATE, DATE_LAST_UPDATE = @DU" +
                    " WHERE BILLMODEL = @BMODEL AND BILLNUMBER = @BNUM, BILLSERIES = @BSERIES AND SUPPLIER_ID = @SUPPLIERID; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction tran = connection.BeginTransaction();
                try
                {
                    SqlCommand commandPurch = new SqlCommand(sqlPurch, connection);
                    commandPurch.Transaction = tran;
                    SqlCommand commandBills = new SqlCommand(sqlBills, connection);
                    commandBills.Transaction = tran;

                    // <Purchases
                    commandPurch.Parameters.AddWithValue("@BMODEL", obj.BillModel);
                    commandPurch.Parameters.AddWithValue("@BNUM", obj.BillNumber);
                    commandPurch.Parameters.AddWithValue("@BSERIES", obj.BillSeries);
                    commandPurch.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
                    commandPurch.Parameters.AddWithValue("@USERID", obj.User.id);
                    commandPurch.Parameters.AddWithValue("@CANCELMOTIVE", obj.CancelledMotive);
                    commandPurch.Parameters.AddWithValue("@CANCELDATE", DateTime.Now.Date);
                    commandPurch.Parameters.AddWithValue("@DU", DateTime.Now.Date);

                    commandPurch.ExecuteNonQuery();
                    // >Purchases

                    // <BillsToPay
                    commandBills.Parameters.AddWithValue("@BMODEL", obj.BillModel);
                    commandBills.Parameters.AddWithValue("@BNUMBER", obj.BillNumber);
                    commandBills.Parameters.AddWithValue("@BSERIES", obj.BillSeries);
                    commandBills.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
                    commandBills.Parameters.AddWithValue("@MOTCANCEL", obj.CancelledMotive);
                    commandBills.Parameters.AddWithValue("@USERID", obj.User.id);
                    commandBills.Parameters.AddWithValue("@DATECANCEL", DateTime.Now.Date);
                    commandBills.Parameters.AddWithValue("@UPDATE", DateTime.Now.Date);

                    commandBills.ExecuteNonQuery();
                    // >BillsToPay

                    // <PurchaseItems
                    foreach (var prod in obj.PurchasedItems)
                    {
                        SqlCommand commandPurchItems = new SqlCommand(sqlPurchItems, connection);
                        commandPurchItems.Transaction = tran;

                        commandPurchItems.Parameters.AddWithValue("@CANCELDATE", DateTime.Now.Date);
                        commandPurchItems.Parameters.AddWithValue("@BMODEL", obj.BillModel);
                        commandPurchItems.Parameters.AddWithValue("@BNUM", obj.BillNumber);
                        commandPurchItems.Parameters.AddWithValue("@BSERIES", obj.BillSeries);
                        commandPurchItems.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);

                        commandPurchItems.ExecuteNonQuery();
                    }
                    // >PurchaseItems

                    // <Product Stock
                    foreach (var prod in obj.PurchasedItems)
                    {
                        SqlCommand commandProdStock = new SqlCommand(sqlProdStock, connection);
                        commandProdStock.Transaction = tran;

                        commandProdStock.Parameters.AddWithValue("@ID", prod.Product.id);
                        commandProdStock.Parameters.AddWithValue("@PRODCOST", prod.PreUnCost);
                        commandProdStock.Parameters.AddWithValue("@RESTOCK", prod.Product.stock - prod.Quantity);

                        commandProdStock.ExecuteNonQuery();
                    }
                    // >ProductStock

                    tran.Commit();
                    status = true;
                }
                catch (SqlException ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Erro: " + ex.Message,
                        "Erro.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    status = false;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        internal bool NewPurchase(Purchases obj, List<BillsToPay> billList)
        {
            bool status = false;

            string sqlPurch = "INSERT INTO PURCHASES (BILLMODEL, BILLNUMBER, BILLSERIES, SUPPLIER_ID, EMISSIONDATE, ARRIVALDATE, FREIGHTCOST, PURCHASE_TOTALCOST, " +
                " PURCHASE_EXTRAEXPENSES, PURCHASE_INSURANCECOST, USER_ID, DATE_CREATION, DATE_LAST_UPDATE, PAYCONDITION_ID ) "
                         + " VALUES (@BMODEL, @BNUM, @BSERIES, @SUPPLIERID, @EMDATE, @ARRIVALDATE, @FREIGHT, @TOTALCOST, @EXPENSES," +
                         " @INSURANCE, @USERID, @DC, @DU, @PAYCONDID);";

            string sqlBills = "INSERT INTO BILLSTOPAY ( BILLNUMBER, BILLSERIES, BILLMODEL, INSTALMENTNUMBER, DUEDATE, billStatus, PAIDDATE," +
                "BILLVALUE, PAYMETHOD_ID, SUPPLIER_ID, EMISSIONDATE, DATE_CREATION, DATE_LAST_UPDATE, PAYCOND_ID, USER_ID ) "
                         + " VALUES (@BNUMBER, @BSERIES, @BMODEL, @INUMBER, @DUEDATE, @billStatus, @PDATE, @BVALUE, @METHODID, " +
                         " @SUPPLIERID, @EMISSIONDATE, @DC, @DU, @PAYCONDID, @USERID);";

            string sqlProdStock = "UPDATE PRODUCTS SET STOCK = @STOCK, PRODUCT_COST = @PCOST " +
                "WHERE ID_PRODUCT = @ID ; ";

            string sqlPurchItems = "INSERT INTO PURCHASEITEMS ( BILLMODEL, BILLNUMBER, BILLSERIES, SUPPLIER_ID, PRODUCT_ID, QUANTITY, PRODUCT_COST, PURCHASE_PERCENTAGE," +
                "DISCOUNT_CASH , WEIGHTED_AVG , DATE_CREATION, DATE_CANCELLED, PRE_ITEMCOST ) "
                         + " VALUES (@BILLMOD, @BILLNUM, @BILLSER, @SUPPLIERID, @PRODID, @QTD, @PRODCOST, @PURCHPERC, @DISCOUNT, @WEIGHTEDAVG, @DC, @DC, @PRECOST);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction tran = connection.BeginTransaction();
                try
                {
                    SqlCommand commandPurch = new SqlCommand(sqlPurch, connection);
                    commandPurch.Transaction = tran;

                    // <Purchases
                    commandPurch.Parameters.AddWithValue("@BMODEL", obj.BillModel);
                    commandPurch.Parameters.AddWithValue("@BNUM", obj.BillNumber);
                    commandPurch.Parameters.AddWithValue("@BSERIES", obj.BillSeries);
                    commandPurch.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
                    commandPurch.Parameters.AddWithValue("@EMDATE", obj.EmissionDate);
                    commandPurch.Parameters.AddWithValue("@PAYCONDID", obj.PaymentCondition.id);
                    commandPurch.Parameters.AddWithValue("@ARRIVALDATE", obj.ArrivalDate);
                    commandPurch.Parameters.AddWithValue("@FREIGHT", (decimal)obj.Freight_Cost);
                    commandPurch.Parameters.AddWithValue("@TOTALCOST", (decimal)obj.Total_Cost);
                    commandPurch.Parameters.AddWithValue("@EXPENSES", (decimal)obj.ExtraExpenses);
                    commandPurch.Parameters.AddWithValue("@INSURANCE", (decimal)obj.InsuranceCost);
                    commandPurch.Parameters.AddWithValue("@USERID", obj.User.id);
                    commandPurch.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                    commandPurch.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);

                    commandPurch.ExecuteNonQuery();
                    // >Purchases

                    // <BillsToPay
                    foreach (var bill in billList)
                    {
                        SqlCommand commandBills = new SqlCommand(sqlBills, connection);
                        commandBills.Transaction = tran;

                        commandBills.Parameters.AddWithValue("@BNUMBER", obj.BillNumber);
                        commandBills.Parameters.AddWithValue("@BSERIES", obj.BillSeries);
                        commandBills.Parameters.AddWithValue("@BMODEL", obj.BillModel);
                        commandBills.Parameters.AddWithValue("@INUMBER", bill.InstalmentNumber);
                        commandBills.Parameters.AddWithValue("@DUEDATE", bill.DueDate);
                        commandBills.Parameters.AddWithValue("@EMISSIONDATE", obj.EmissionDate);
                        commandBills.Parameters.AddWithValue("@PAYCONDID", obj.PaymentCondition.id);
                        commandBills.Parameters.AddWithValue("@billStatus", bill.Status);
                        commandBills.Parameters.AddWithValue("@USERID", obj.User.id);
                        commandBills.Parameters.AddWithValue("@PDATE", DBNull.Value);
                        commandBills.Parameters.AddWithValue("@BVALUE", bill.TotalValue);
                        commandBills.Parameters.AddWithValue("@METHODID", bill.PaymentMethod.id);
                        commandBills.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
                        commandBills.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                        commandBills.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);

                        commandBills.ExecuteNonQuery();
                    }
                    // >BillsToPay

                    // <PurchaseItems
                    foreach (var prod in obj.PurchasedItems)
                    {
                        SqlCommand commandPurchItems = new SqlCommand(sqlPurchItems, connection);
                        commandPurchItems.Transaction = tran;

                        commandPurchItems.Parameters.AddWithValue("@BILLNUM", obj.BillNumber);
                        commandPurchItems.Parameters.AddWithValue("@BILLMOD", obj.BillModel);
                        commandPurchItems.Parameters.AddWithValue("@BILLSER", obj.BillSeries);
                        commandPurchItems.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
                        commandPurchItems.Parameters.AddWithValue("@PRODID", prod.Product.id);
                        commandPurchItems.Parameters.AddWithValue("@QTD", prod.Quantity);
                        commandPurchItems.Parameters.AddWithValue("@PRODCOST", prod.NewBaseUnCost);
                        commandPurchItems.Parameters.AddWithValue("@PURCHPERC", prod.PurchasePercentage);
                        commandPurchItems.Parameters.AddWithValue("@WEIGHTEDAVG", prod.WeightedCostAverage);
                        commandPurchItems.Parameters.AddWithValue("@DISCOUNT", prod.DiscountCash);
                        commandPurchItems.Parameters.AddWithValue("@PRECOST", prod.PreUnCost);
                        commandPurchItems.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                        commandPurchItems.Parameters.AddWithValue("@DU", DBNull.Value);

                        commandPurchItems.ExecuteNonQuery();
                    }
                    // >PurchaseItems

                    // <Product Stock
                    foreach (var prod in obj.PurchasedItems)
                    {
                        SqlCommand commandProdStock = new SqlCommand(sqlProdStock, connection);
                        commandProdStock.Transaction = tran;

                        commandProdStock.Parameters.AddWithValue("@ID", prod.Product.id);
                        commandProdStock.Parameters.AddWithValue("@PCOST", prod.WeightedCostAverage);
                        commandProdStock.Parameters.AddWithValue("@STOCK", prod.Product.stock + prod.Quantity);

                        commandProdStock.ExecuteNonQuery();
                    }
                    // >ProductStock

                    tran.Commit();
                    status = true;
                }
                catch (SqlException ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Erro: " + ex.Message,
                        "Erro.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    status = false;
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
