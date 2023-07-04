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

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class Sales_DAO : Master_DAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private readonly Users_Controller _usersController = new Users_Controller();
        private readonly Clients_Controller _clientsController = new Clients_Controller();
       // private readonly BillsToReceive_Controller _billToReceiveController = new BillsToReceive_Controller();
        private readonly SaleItems_Controller _saleItemsController = new SaleItems_Controller();

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

        public bool SaveToDb2(Sales sale)
        {
            bool status = false;
            string sql = "INSERT INTO SALES (CLIENT_ID, USER_ID, SALE_TOTAL_COST, SALE_TOTAL_VALUE, SALE_DISCOUNT_CASH, SALE_DISCOUNT_PERC," +
                "TOTAL_ITEMS_QUANTITY, DATE_CREATION, DATE_LAST_UPDATE ) "
                         + " VALUES (@CLIENTID, @USERID, @SALECOST, @SALEVALUE, @SALEDISCCASH, @SALEDISCPERC, @TOTALQTD, @DC, @DU);" +
                         " SELECT SCOPE_IDENTITY();";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = null;
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@CLIENTID", sale.Client.id);
                    command.Parameters.AddWithValue("@USERID", sale.User.id);
                    command.Parameters.AddWithValue("@SALECOST", (decimal)sale.TotalCost);
                    command.Parameters.AddWithValue("@SALEVALUE", (decimal)sale.TotalValue);
                    command.Parameters.AddWithValue("@SALEDISCCASH", (decimal)sale.SaleDiscountCash);
                    command.Parameters.AddWithValue("@SALEDISCPERC", (decimal)sale.SaleDiscountPerc);
                    command.Parameters.AddWithValue("@TOTALQTD", sale.TotalItemsQuantity);
                    command.Parameters.AddWithValue("@DC", sale.dateOfLastUpdate);
                    command.Parameters.AddWithValue("@DU", sale.dateOfLastUpdate);

                    transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    int i = Convert.ToInt32(command.ExecuteScalar());
                    if (i > 0)
                    {
                        foreach (SaleItems item in sale.SaleItems)
                        {
                            if (item != null)
                            {
                                item.id = i;
                                status = _saleItemsController.SaveItem(item);
                                if (!status)
                                {
                                    MessageBox.Show("An error has occurred.");
                                    transaction.Rollback();
                                    break;
                                }
                            }
                        }
                        transaction.Commit();
                        MessageBox.Show("Register added with success!");
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 50000 && ex.Class == 16 && ex.State == 1)
                    {
                        transaction?.Rollback();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                    transaction?.Rollback();
                    return status;
                }
                finally
                {
                    //transaction?.Dispose();
                    connection.Close();
                }
                return status;
            }
        }

        public bool SaveToDb(Sales sale)
        {
            bool status = false;

            string sql = "INSERT INTO SALES (CLIENT_ID, USER_ID, SALE_TOTAL_COST, SALE_TOTAL_VALUE, SALE_DISCOUNT_CASH, SALE_DISCOUNT_PERC," +
                "TOTAL_ITEMS_QUANTITY, DATE_CREATION, DATE_LAST_UPDATE ) "
                         + " VALUES (@CLIENTID, @USERID, @SALECOST, @SALEVALUE, @SALEDISCCASH, @SALEDISCPERC, @TOTALQTD, @DC, @DU);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@CLIENTID", sale.Client.id);
                    command.Parameters.AddWithValue("@USERID", sale.User.id);
                    command.Parameters.AddWithValue("@SALECOST", (decimal)sale.TotalCost);
                    command.Parameters.AddWithValue("@SALEVALUE", (decimal)sale.TotalValue);
                    command.Parameters.AddWithValue("@SALEDISCCASH", (decimal)sale.SaleDiscountCash);
                    command.Parameters.AddWithValue("@SALEDISCPERC", (decimal)sale.SaleDiscountPerc);
                    command.Parameters.AddWithValue("@TOTALQTD", sale.TotalItemsQuantity);
                    command.Parameters.AddWithValue("@DC", sale.dateOfLastUpdate);
                    command.Parameters.AddWithValue("@DU", sale.dateOfLastUpdate);
                    connection.Open();
                    //int i = command.ExecuteNonQuery();
                    var i = command.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        foreach (SaleItems item in sale.SaleItems)
                        {
                            if (item != null)
                            {
                                status = _saleItemsController.SaveItem(item);
                                if (!status)
                                {
                                    MessageBox.Show("An error has occurred.");
                                    break;
                                }
                            }
                        }
                        if (status)
                        {
                            MessageBox.Show("Register added with success!");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 50000 && ex.Class == 16 && ex.State == 1)
                    {
                        MessageBox.Show("Error : " + ex.Message);
                        return false;
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

        public bool EditFromDB(Sales sale)
        {
            bool status = false;
            string sql;
            if (sale.CancelDate == null)
            {
                sql = "UPDATE SALES SET CLIENT_ID = @CLIENTID, USER_ID = @USERID, SALE_TOTAL_COST = @SALECOST," +
                    " SALE_TOTAL_VALUE = @SALEVALUE, SALE_DISCOUNT_CASH = @SALEDISCCASH, SALE_DISCOUNT_PERC = @SALEDISCPERC ," +
                    " TOTAL_ITEMS_QUANTITY = @TOTALQTD, DATE_LAST_UPDATE = @DU " +
                    "WHERE ID_SALE = @ID ; ";
            }
            else
            {
                sql = "UPDATE SALES SET CLIENT_ID = @CLIENTID, USER_ID = @USERID, SALE_TOTAL_COST = @SALECOST," +
                    " SALE_TOTAL_VALUE = @SALEVALUE, SALE_DISCOUNT_CASH = @SALEDISCCASH, SALE_DISCOUNT_PERC = @SALEDISCPERC ," +
                    " TOTAL_ITEMS_QUANTITY = @TOTALQTD, SALE_CANCEL_DATE = @CANCELDATE, DATE_LAST_UPDATE = @DU " +
                    "WHERE ID_SALE = @ID ; ";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@CLIENTID", sale.Client.id);
                    command.Parameters.AddWithValue("@USERID", sale.User.id);
                    command.Parameters.AddWithValue("@SALECOST", (decimal)sale.TotalCost);
                    command.Parameters.AddWithValue("@SALEVALUE", (decimal)sale.TotalValue);
                    command.Parameters.AddWithValue("@SALEDISCCASH", (decimal)sale.SaleDiscountCash);
                    command.Parameters.AddWithValue("@SALEDISCPERC", (decimal)sale.SaleDiscountPerc);
                    command.Parameters.AddWithValue("@TOTALQTD", sale.TotalItemsQuantity);
                    command.Parameters.AddWithValue("@CANCELDATE", sale.CancelDate);
                    command.Parameters.AddWithValue("@DC", sale.dateOfLastUpdate);
                    command.Parameters.AddWithValue("@DU", sale.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        var itemList = _saleItemsController.FindSaleId(sale.id); // Pega a lista de itens já no banco, remove os que foram removidos da lista
                        List<SaleItems> toBeRemoved = sale.SaleItems.Except(itemList).ToList();
                        foreach (SaleItems item in sale.SaleItems)
                        {
                            if (item != null)
                            {
                                status = _saleItemsController.UpdateItem(item);
                                if (!status)
                                {
                                    MessageBox.Show("An error has occurred.");
                                    break;
                                }
                            }
                        }
                        foreach (SaleItems item in toBeRemoved)
                        {
                            status = _saleItemsController.DeleteItem(item.id);
                            if (!status)
                            {
                                MessageBox.Show("An error has occurred.");
                                break;
                            }
                        }
                        if (status)
                        {
                            MessageBox.Show("Register altered with success!");
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
                    MessageBox.Show("Error : " + ex.Message);
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
                                obj.User = _usersController.FindItemId( Convert.ToInt32(reader["user_id"]));
                                obj.Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"]));
                               // obj.PaymentConditionId = Convert.ToInt32(reader["payConditionId"]);
                                obj.SaleItems = _saleItemsController.FindSaleId(id);
                                obj.TotalCost = Convert.ToDouble(reader["sale_total_cost"]);
                                obj.TotalValue = Convert.ToDouble(reader["sale_total_value"]);
                                obj.SaleDiscountCash = Convert.ToDouble(reader["sale_discount_cash"]);
                                obj.SaleDiscountPerc = Convert.ToDouble(reader["sale_discount_perc"]);
                                obj.TotalItemsQuantity = Convert.ToInt32(reader["total_items_quantity"]);
                               // obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
                                obj.dateOfCreation = Convert.ToDateTime(reader["date_creation"]);
                                obj.dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]);

                                if (reader["sale_cancel_date"].ToString() != string.Empty)
                                {
                                    DateTime date = Convert.ToDateTime(reader["sale_cancel_date"]);
                                    obj.CancelDate = date;
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
                    MessageBox.Show("Error : " + ex.Message);
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
                                    //obj.BillToReceive = _billToReceiveController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.SaleItems = _saleItemsController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.PaymentConditionId = Convert.ToInt32(reader["payConditionId"]);
                                    obj.TotalCost = Convert.ToDouble(reader["sale_total_cost"]);
                                    obj.TotalValue = Convert.ToDouble(reader["sale_total_value"]);
                                    obj.SaleDiscountCash = Convert.ToDouble(reader["sale_discount_cash"]);
                                    obj.SaleDiscountPerc = Convert.ToDouble(reader["sale_discount_perc"]);
                                    obj.TotalItemsQuantity = Convert.ToInt32(reader["total_items_quantity"]);
                                    obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
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
                    MessageBox.Show("Error : " + ex.Message);
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
                                    //obj.BillToReceive = _billToReceiveController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.SaleItems = _saleItemsController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.TotalCost = Convert.ToDouble(reader["sale_total_cost"]);
                                    obj.PaymentConditionId = Convert.ToInt32(reader["payConditionId"]);
                                    obj.TotalValue = Convert.ToDouble(reader["sale_total_value"]);
                                    obj.SaleDiscountCash = Convert.ToDouble(reader["sale_discount_cash"]);
                                    obj.SaleDiscountPerc = Convert.ToDouble(reader["sale_discount_perc"]);
                                    obj.TotalItemsQuantity = Convert.ToInt32(reader["total_items_quantity"]);
                                    obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
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
                    MessageBox.Show("Error : " + ex.Message);
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
                                    //obj.BillToReceive = _billToReceiveController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.SaleItems = _saleItemsController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.TotalCost = Convert.ToDouble(reader["sale_total_cost"]);
                                    obj.TotalValue = Convert.ToDouble(reader["sale_total_value"]);
                                    obj.PaymentConditionId = Convert.ToInt32(reader["payConditionId"]);
                                    obj.SaleDiscountCash = Convert.ToDouble(reader["sale_discount_cash"]);
                                    obj.SaleDiscountPerc = Convert.ToDouble(reader["sale_discount_perc"]);
                                    obj.TotalItemsQuantity = Convert.ToInt32(reader["total_items_quantity"]);
                                    obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
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
                    MessageBox.Show("Error : " + ex.Message);
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
                                    //obj.BillToReceive = _billToReceiveController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.SaleItems = _saleItemsController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.TotalCost = Convert.ToDouble(reader["sale_total_cost"]);
                                    obj.TotalValue = Convert.ToDouble(reader["sale_total_value"]);
                                    obj.SaleDiscountCash = Convert.ToDouble(reader["sale_discount_cash"]);
                                    obj.PaymentConditionId = Convert.ToInt32(reader["payConditionId"]);
                                    obj.SaleDiscountPerc = Convert.ToDouble(reader["sale_discount_perc"]);
                                    obj.TotalItemsQuantity = Convert.ToInt32(reader["total_items_quantity"]);
                                    obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
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
                    MessageBox.Show("Error : " + ex.Message);
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
                                    //obj.BillToReceive = _billToReceiveController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.SaleItems = _saleItemsController.FindSaleId(Convert.ToInt32(reader["id_sale"]));
                                    obj.TotalCost = Convert.ToDouble(reader["sale_total_cost"]);
                                    obj.TotalValue = Convert.ToDouble(reader["sale_total_value"]);
                                    obj.SaleDiscountCash = Convert.ToDouble(reader["sale_discount_cash"]);
                                    obj.SaleDiscountPerc = Convert.ToDouble(reader["sale_discount_perc"]);
                                    obj.PaymentConditionId = Convert.ToInt32(reader["payConditionId"]);
                                    obj.TotalItemsQuantity = Convert.ToInt32(reader["total_items_quantity"]);
                                    obj.CancelDate = Convert.ToDateTime(reader["sale_cancel_date"]);
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
                    MessageBox.Show("Error : " + ex.Message);
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
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
    }
}
