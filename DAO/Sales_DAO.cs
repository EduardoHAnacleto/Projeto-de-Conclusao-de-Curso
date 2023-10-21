using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ProjetoEduardoAnacletoWindowsForm1.DAO;
using System.Configuration;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using NUnit.Framework;
using System.Transactions;
using Microsoft.Win32;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class Sales_DAO : Master_DAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private readonly Users_Controller _usersController = new Users_Controller();
        private readonly Clients_Controller _clientsController = new Clients_Controller();
       // private readonly BillsToReceive_Controller _billToReceiveController = new BillsToReceive_Controller();
        private readonly SaleItems_Controller _saleItemsController = new SaleItems_Controller();
        private readonly PaymentConditions_Controller _pcController = new PaymentConditions_Controller();

        public Sales_DAO()
        {
            
        }

        public override int NewId()
        {
            var newId = "";
            string sql = "SELECT MAX(ID_SALE) FROM SALES;";
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
                MessageBox.Show("Erro: " + ex.Message);
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

        //public bool SaveToDb2(Sales sale)
        //{
        //    bool status = false;
        //    string sql = "INSERT INTO SALES (CLIENT_ID, USER_ID, SALE_TOTAL_COST, SALE_TOTAL_VALUE, SALE_DISCOUNT_CASH, SALE_DISCOUNT_PERC," +
        //        "TOTAL_ITEMS_QUANTITY, DATE_CREATION, DATE_LAST_UPDATE ) "
        //                 + " VALUES (@CLIENTID, @USERID, @SALECOST, @SALEVALUE, @SALEDISCCASH, @SALEDISCPERC, @TOTALQTD, @DC, @DU);" +
        //                 " SELECT SCOPE_IDENTITY();";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        SqlTransaction transaction = null;
        //        try
        //        {
        //            SqlCommand command = new SqlCommand(sql, connection);
        //            command.Parameters.AddWithValue("@CLIENTID", sale.Client.id);
        //            command.Parameters.AddWithValue("@USERID", sale.User.id);
        //            command.Parameters.AddWithValue("@SALECOST", (decimal)sale.TotalCost);
        //            command.Parameters.AddWithValue("@SALEVALUE", (decimal)sale.TotalValue);
        //            command.Parameters.AddWithValue("@SALEDISCCASH", (decimal)sale.SaleDiscountCash);
        //            command.Parameters.AddWithValue("@SALEDISCPERC", (decimal)sale.SaleDiscountPerc);
        //            command.Parameters.AddWithValue("@TOTALQTD", sale.TotalItemsQuantity);
        //            command.Parameters.AddWithValue("@DC", sale.dateOfLastUpdate);
        //            command.Parameters.AddWithValue("@DU", sale.dateOfLastUpdate);

        //            transaction = connection.BeginTransaction();
        //            command.Transaction = transaction;
        //            int i = Convert.ToInt32(command.ExecuteScalar());
        //            if (i > 0)
        //            {
        //                foreach (SaleItems item in sale.SaleItems)
        //                {
        //                    if (item != null)
        //                    {
        //                        item.id = i;
        //                        status = _saleItemsController.SaveItem(item);
        //                        if (!status)
        //                        {
        //                            MessageBox.Show("An error has occurred.");
        //                            transaction.Rollback();
        //                            break;
        //                        }
        //                    }
        //                }
        //                transaction.Commit();
        //                MessageBox.Show("Register added with success!");
        //                return true;
        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //            if (ex.Number == 50000 && ex.Class == 16 && ex.State == 1)
        //            {
        //                transaction?.Rollback();
        //                return false;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error : " + ex.Message);
        //            transaction?.Rollback();
        //            return status;
        //        }
        //        finally
        //        {
        //            //transaction?.Dispose();
        //            connection.Close();
        //        }
        //        return status;
        //    }
        //}
        public bool SaveToDb(Sales sale, List<BillsToReceive> billList)
        {
            bool status = false;

            string sqlSale = "INSERT INTO SALES (CLIENT_ID, USER_ID, SALE_TOTAL_COST, SALE_TOTAL_VALUE, " +
                "TOTAL_ITEMS_QUANTITY, DATE_CREATION, SALE_CANCEL_DATE, paycondition_id ) "
                         + " VALUES (@CLIENTID, @USERID, @SALECOST, @SALEVALUE, @TOTALQTD, @DC, @CANCELDATE, @PAYCONDID);";

            string sqlItemsSale = "INSERT INTO SALEITEMS ( SALE_ID, PRODUCT_ID, QUANTITY, ITEM_VALUE, ITEM_COST, DISCOUNT_CASH," +
                "TOTAL_VALUE , DATE_CREATION, DATE_LAST_UPDATE ) "
                         + " VALUES (@ID, @PRODID, @QTD, @PRODVALUE, @PRODCOST, @DISCCASH, @TOTALVALUE, @DC, @DU);";
            string sqlBillsToReceive = "INSERT INTO BILLSTORECEIVE (ID_BILL, SALE_ID, INSTALMENTVALUE, ISPAID, CLIENT_ID, PAYMETHOD_ID, INSTALMENTNUMBER, " +
                "INSTALMENTSQTD, DUEDATE, EMISSIONDATE, PAIDDATE, DATE_CREATION, DATE_LAST_UPDATE, DATE_CANCELLED, PAYCOND_ID, USER_ID ) "
                         + " VALUES (@BILLID, @SALEID, @IVALUE, @ISPAID, @CLIENTID, @METHODID, @INUM, @IQTD, @DUEDATE, @EMDATE, @PDATE, @DC, @DU, @DCANCEL, @PAYCONDID, @USERID);";
            string sqlStockChange = "UPDATE PRODUCTS SET STOCK = @RESTOCK WHERE ID_PRODUCT = @ID ; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction tran = connection.BeginTransaction();
                try
                {                
                    //<Sale
                    SqlCommand command = new SqlCommand(sqlSale, connection);
                    command.Transaction = tran;
                    command.Parameters.AddWithValue("@CLIENTID", sale.Client.id);
                    command.Parameters.AddWithValue("@USERID", sale.User.id);
                    command.Parameters.AddWithValue("@SALECOST", sale.TotalCost);
                    command.Parameters.AddWithValue("@SALEVALUE", sale.TotalValue);
                    command.Parameters.AddWithValue("@TOTALQTD", sale.TotalItemsQuantity);
                    command.Parameters.AddWithValue("@PAYCONDID", sale.PaymentCondition.id);
                    command.Parameters.AddWithValue("@DC", DateTime.Now);
                    command.Parameters.AddWithValue("@CANCELDATE", DBNull.Value);

                    command.ExecuteNonQuery();
                    //>Sale

                    //<ProductStock
                    foreach (var prod in sale.SaleItems)
                    {
                        SqlCommand commandStockChange = new SqlCommand(sqlStockChange, connection);
                        commandStockChange.Transaction = tran;
                        commandStockChange.Parameters.AddWithValue("@ID", prod.Product.id);
                        commandStockChange.Parameters.AddWithValue("@RESTOCK", prod.Product.stock - prod.Quantity);

                        commandStockChange.ExecuteNonQuery();
                    }
                    //>ProductStock

                    int newId = this.GetLastId();

                    //<ItemsSale
                    foreach (var obj in sale.SaleItems)
                    {
                        SqlCommand commandItemsSale = new SqlCommand(sqlItemsSale, connection);
                        commandItemsSale.Transaction = tran;
                        commandItemsSale.Parameters.AddWithValue("@ID", newId);
                        commandItemsSale.Parameters.AddWithValue("@PRODID", obj.Product.id);
                        commandItemsSale.Parameters.AddWithValue("@PRODVALUE", obj.ProductValue);
                        commandItemsSale.Parameters.AddWithValue("@PRODCOST", obj.ProductCost);
                        commandItemsSale.Parameters.AddWithValue("@TOTALVALUE", obj.TotalValue);
                        commandItemsSale.Parameters.AddWithValue("@DISCCASH", obj.ItemDiscountCash);
                        commandItemsSale.Parameters.AddWithValue("@QTD", obj.Quantity);
                        commandItemsSale.Parameters.AddWithValue("@DC", DateTime.Now.Date);
                        commandItemsSale.Parameters.AddWithValue("@DU", DateTime.Now.Date);

                        commandItemsSale.ExecuteNonQuery();
                    }
                    //>ItemsSale

                    //<BillsToReceive
                    BillsToReceive_Controller billsController = new BillsToReceive_Controller();
                    int newBillId = billsController.GetNewId();
                    foreach (var obj in billList)
                    {
                        SqlCommand commandBills = new SqlCommand(sqlBillsToReceive, connection);
                        commandBills.Transaction = tran;
                        commandBills.Parameters.AddWithValue("@BILLID", newBillId);
                        commandBills.Parameters.AddWithValue("@ISPAID", obj.IsPaid);
                        commandBills.Parameters.AddWithValue("@CLIENTID", obj.Client.id);
                        commandBills.Parameters.AddWithValue("@SALEID", newId);
                        commandBills.Parameters.AddWithValue("@METHODID", obj.PaymentMethod.id);
                        commandBills.Parameters.AddWithValue("@INUM", obj.InstalmentNumber);
                        commandBills.Parameters.AddWithValue("@IQTD", obj.InstalmentsQtd);
                        commandBills.Parameters.AddWithValue("@IVALUE", obj.InstalmentValue);
                        commandBills.Parameters.AddWithValue("@EMDATE", obj.EmissionDate);
                        commandBills.Parameters.AddWithValue("@PAYCONDID", obj.PaymentCondition.id);
                        commandBills.Parameters.AddWithValue("@DUEDATE", obj.DueDate);
                        commandBills.Parameters.AddWithValue("@USERID", obj.User.id);
                        commandBills.Parameters.AddWithValue("@PDATE", DBNull.Value);
                        commandBills.Parameters.AddWithValue("@DCANCEL", DBNull.Value);
                        commandBills.Parameters.AddWithValue("@DC", DateTime.Now);
                        commandBills.Parameters.AddWithValue("@DU", DateTime.Now.Date);

                        commandBills.ExecuteNonQuery();
                    }
                    //>BillsToReceive
                    tran.Commit();
                    status = true;
                    MessageBox.Show("Venda salva com sucesso.");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
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

        public bool EditFromDB(Sales sale)
        {
            bool status = false;
            string sql;
            sql = "UPDATE SALES SET SALE_CANCEL_DATE = @CANCELDATE " +
                  "WHERE SALE_ID = @ID ; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", sale.id);
                    if (sale.CancelDate != null)
                    {
                        command.Parameters.AddWithValue("@CANCELDATE", sale.CancelDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@CANCELDATE", DBNull.Value);
                    }


                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        if (status)
                        {
                            MessageBox.Show("Venda Cancelada com sucesso!");
                        }
                    }

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 50000 && ex.Class == 16 && ex.State == 1)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public override bool DeleteFromDb(int id)
        {
            bool status = false;
            string sql = "DELETE FROM SALES WHERE ID_SALE = @ID ;";
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
                        MessageBox.Show("Registro apagado com sucesso.");
                        status = true;
                    }

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547 || ex.Number == 2061)
                    {
                        MessageBox.Show("Não é possível apagar esse registro pois ele está ligado a outro registro.", "Não é possível apagar registro.");
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public Sales SelectFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SALES WHERE ID_SALE = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Sales obj = new Sales();

                                obj.id = id;
                                obj.User = _usersController.FindItemId(Convert.ToInt32(reader["user_id"]));
                                obj.Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"]));
                                obj.SaleItems = _saleItemsController.FindSaleId(id);
                                obj.TotalCost = Convert.ToDecimal(reader["sale_total_cost"]);
                                obj.TotalValue = Convert.ToDecimal(reader["sale_total_value"]);
                                obj.PaymentCondition = _pcController.FindItemId(Convert.ToInt32(reader["paycondition_id"]));
                                obj.TotalItemsQuantity = Convert.ToInt32(reader["total_items_quantity"]);
                                // obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
                                obj.dateOfCreation = Convert.ToDateTime(reader["date_creation"]);

                                if (reader["sale_cancel_date"].ToString() != string.Empty)
                                {
                                    obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
                                }
                                else
                                {
                                    obj.CancelDate = null;
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

        public List<Sales> SelectClientsIdFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SALES WHERE CLIENT_ID = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<Sales> list = new List<Sales>();
                                foreach (Sales item in reader)
                                {
                                    Sales obj = new Sales();

                                    obj.id = Convert.ToInt32(reader["id_sale"]); ;
                                    obj.User = _usersController.FindItemId(Convert.ToInt32(reader["user_id"]));
                                    obj.Client = _clientsController.FindItemId(id);
                                    obj.SaleItems = _saleItemsController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.PaymentCondition = _pcController.FindItemId(Convert.ToInt32(reader["paycondition_id"]));
                                    obj.TotalCost = Convert.ToDecimal(reader["sale_total_cost"]);
                                    obj.TotalValue = Convert.ToDecimal(reader["sale_total_value"]);
                                    obj.TotalItemsQuantity = Convert.ToInt32(reader["total_items_quantity"]);
                                    if (reader["sale_cancel_date"].ToString() != string.Empty)
                                    {
                                        obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
                                    }
                                    else
                                    {
                                        obj.CancelDate = null;
                                    }

                                    obj.dateOfCreation = Convert.ToDateTime(reader["date_creation"]);
                                    obj.dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]);
                                    list.Add(obj);
                                }
                                return list;
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


        public List<Sales> SelectDateOfCreationFromDb(DateTime date)
        {
            List<Sales> list = new List<Sales>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SALES WHERE EMISSION_DATE >= @DATE ;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@DATE", date);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                foreach (Sales item in reader)
                                {
                                    Sales obj = new Sales();

                                    obj.id = Convert.ToInt32(reader["id_sale"]); ;
                                    obj.User = _usersController.FindItemId(Convert.ToInt32(reader["user_id"]));
                                    obj.Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"]));
                                    obj.SaleItems = _saleItemsController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.TotalCost = Convert.ToDecimal(reader["sale_total_cost"]);
                                    obj.PaymentCondition = _pcController.FindItemId(Convert.ToInt32(reader["paycondition_id"]));
                                    obj.TotalValue = Convert.ToDecimal(reader["sale_total_value"]);
                                    obj.TotalItemsQuantity = Convert.ToInt32(reader["total_items_quantity"]);

                                    if (reader["sale_cancel_date"].ToString() != string.Empty)
                                    {
                                        obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
                                    }
                                    else
                                    {
                                        obj.CancelDate = null;
                                    }
                                    obj.dateOfCreation = Convert.ToDateTime(reader["date_creation"]);
                                    obj.dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]);
                                    list.Add(obj);
                                }
                                return list;
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

        public List<Sales> SelectCanceledDateFromDb(DateTime date)
        {
            List<Sales> list = new List<Sales>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SALES WHERE CANCEL_DATE >= @DATE ;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@DATE", date);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                foreach (Sales item in reader)
                                {
                                    Sales obj = new Sales();

                                    obj.id = Convert.ToInt32(reader["id_sale"]); ;
                                    obj.User = _usersController.FindItemId(Convert.ToInt32(reader["user_id"]));
                                    obj.Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"]));
                                    obj.SaleItems = _saleItemsController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.TotalCost = Convert.ToDecimal(reader["sale_total_cost"]);
                                    obj.TotalValue = Convert.ToDecimal(reader["sale_total_value"]);
                                    obj.PaymentCondition = _pcController.FindItemId(Convert.ToInt32(reader["paycondition_id"]));
                                    obj.TotalItemsQuantity = Convert.ToInt32(reader["total_items_quantity"]);
                                    if (reader["sale_cancel_date"].ToString() != string.Empty)
                                    {
                                        obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
                                    }
                                    else
                                    {
                                        obj.CancelDate = null;
                                    }
                                    obj.dateOfCreation = Convert.ToDateTime(reader["date_creation"]);
                                    obj.dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]);
                                    list.Add(obj);
                                }
                                return list;
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

        public List<Sales> SelectTotalValueFromDb(decimal minValue)
        {
            List<Sales> list = new List<Sales>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SALES WHERE SALE_TOTAL_VALUE >= @VALUE ;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@VALUE", minValue);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                foreach (Sales item in reader)
                                {
                                    Sales obj = new Sales();

                                    obj.id = Convert.ToInt32(reader["id_sale"]); ;
                                    obj.User = _usersController.FindItemId(Convert.ToInt32(reader["user_id"]));
                                    obj.Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"]));
                                    obj.SaleItems = _saleItemsController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.TotalCost = Convert.ToDecimal(reader["sale_total_cost"]);
                                    obj.TotalValue = Convert.ToDecimal(reader["sale_total_value"]);
                                    obj.PaymentCondition = _pcController.FindItemId(Convert.ToInt32(reader["paycondition_id"]));
                                    obj.TotalItemsQuantity = Convert.ToInt32(reader["total_items_quantity"]);
                                    if (reader["sale_cancel_date"].ToString() != string.Empty)
                                    {
                                        obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
                                    }
                                    else
                                    {
                                        obj.CancelDate = null;
                                    }
                                    obj.dateOfCreation = Convert.ToDateTime(reader["date_creation"]);
                                    obj.dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]);
                                    list.Add(obj);
                                }
                                return list;
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

        public List<Sales> SelectAllFromDb()
        {
            List<Sales> list = new List<Sales>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SALES ;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                foreach (Sales item in reader)
                                {
                                    Sales obj = new Sales();

                                    obj.id = Convert.ToInt32(reader["id_sale"]); ;
                                    obj.User = _usersController.FindItemId(Convert.ToInt32(reader["user_id"]));
                                    obj.Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"]));
                                    obj.SaleItems = _saleItemsController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.TotalCost = Convert.ToDecimal(reader["sale_total_cost"]);
                                    obj.TotalValue = Convert.ToDecimal(reader["sale_total_value"]);
                                    obj.PaymentCondition = _pcController.FindItemId(Convert.ToInt32(reader["paycondition_id"]));
                                    obj.TotalItemsQuantity = Convert.ToInt32(reader["total_items_quantity"]);
                                    if (reader["sale_cancel_date"].ToString() != string.Empty)
                                    {
                                        obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
                                    }
                                    else
                                    {
                                        obj.CancelDate = null;
                                    }
                                    obj.dateOfCreation = Convert.ToDateTime(reader["date_creation"]);
                                    obj.dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]);
                                    list.Add(obj);
                                }
                                return list;
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

        public override DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM SALES ;";
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

        internal int GetLastId()
        {
            string sql = "SELECT IDENT_CURRENT ('SALES');";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                int i = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                return i;
            }
        }

        //public bool CancelSale(int id)
        //{
        //    bool status = false;
        //    string sql;
        //    sql = "UPDATE SALES SET SALE_CANCEL_DATE = @CANCELDATE " +
        //          "WHERE ID_SALE = @ID ; ";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            SqlCommand command = new SqlCommand(sql, connection);
        //            command.Parameters.AddWithValue("@ID", id);
        //            command.Parameters.AddWithValue("@CANCELDATE", DateTime.Now.Date);

        //            connection.Open();
        //            int i = command.ExecuteNonQuery();
        //            connection.Close();
        //            if (i > 0)
        //            {
        //                status = true;
        //                if (status)
        //                {
        //                    Products_Controller prodController = new Products_Controller();
        //                    var obj = this.SelectFromDb(id);
        //                    foreach (var prod in obj.SaleItems)
        //                    {
        //                        status = prodController.RestoreStock(prod.id, prod.Quantity);
        //                    }
        //                }
        //                if (status)
        //                {
        //                    MessageBox.Show("Venda Cancelada com sucesso.");
        //                }
        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //            if (ex.Number == 50000 && ex.Class == 16 && ex.State == 1)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Erro: " + ex.Message);
        //            return false;
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //        return status;
        //    }
        //}

        public bool CancelSale(Sales sale)
        {
            bool status = false;
            string sqlSale = "UPDATE SALES SET SALE_CANCEL_DATE = @CANCELDATE, CANCEL_MOTIVE = @CANCELMOT, USER_ID = @USER " +
                  "WHERE ID_SALE = @ID ; ";
            string sqlBills = "UPDATE BILLSTORECEIVE SET DATE_CANCELLED = @CANCELDATE, MOTIVE_CANCELLED = @CANCELMOT, USER_ID = @USERID, DATE_LAST_UPDATE = @UPDATE " +
                    "WHERE SALE_ID = @SALEID; ";
            string sqlAddStock = "UPDATE PRODUCTS SET STOCK = STOCK + @RESTOCK " +
                    "WHERE ID_PRODUCT = @ID ; ";
            string sqlItemsSale = "UPDATE SALEITEMS SET CANCEL_DATE = @CANCELDATE WHERE SALE_ID = @SALEID; ";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction tran = connection.BeginTransaction();
                try
                {
                    //<Sale
                    SqlCommand command = new SqlCommand(sqlSale, connection);
                    command.Transaction = tran;
                    command.Parameters.AddWithValue("@ID", sale.id);
                    command.Parameters.AddWithValue("@USER", sale.User.id);
                    command.Parameters.AddWithValue("@CANCELMOT", sale.CancelMotive);
                    command.Parameters.AddWithValue("@CANCELDATE", DateTime.Now.Date);

                    command.ExecuteNonQuery();
                    //>Sale

                    //<Bills
                    SqlCommand commandBills = new SqlCommand(sqlBills, connection);
                    commandBills.Transaction = tran;
                    commandBills.Parameters.AddWithValue("@USER", sale.User.id);
                    commandBills.Parameters.AddWithValue("@CANCELMOT", sale.CancelMotive);
                    commandBills.Parameters.AddWithValue("@CANCELDATE", DateTime.Today.Date);
                    commandBills.Parameters.AddWithValue("@UPDATE", DateTime.Today.Date);
                    commandBills.Parameters.AddWithValue("@SALEID", sale.id);
                    commandBills.Parameters.AddWithValue("@USERID", sale.User.id);

                    commandBills.ExecuteNonQuery();
                    //>Bills

                    //<SaleItems
                    SqlCommand commandItemsSale = new SqlCommand(sqlItemsSale, connection);
                    commandItemsSale.Transaction = tran;
                    commandItemsSale.Parameters.AddWithValue("@ID", sale.id);

                    commandItemsSale.ExecuteNonQuery();
                    //>SaleItems

                    //<Stock
                    foreach (var obj in sale.SaleItems)
                    {
                        SqlCommand commandStock = new SqlCommand(sqlAddStock, connection);
                        commandStock.Transaction = tran;
                        commandStock.Parameters.AddWithValue("@RESTOCK", obj.Quantity);
                        commandStock.Parameters.AddWithValue("@ID", obj.Product.id);

                        commandStock.ExecuteNonQuery();
                    }
                    //>Stock

                    tran.Commit();
                    status = true;
                    MessageBox.Show("Venda cancelada com sucesso.");
                }
                catch (SqlException ex)
                {
                    tran.Rollback();
                    if (ex.Number == 50000 && ex.Class == 16 && ex.State == 1)
                    {
                        Console.WriteLine(ex.Message);
                        return status;
                    }
                }
                catch (Exception ex)
                {
                    tran.Rollback();
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
