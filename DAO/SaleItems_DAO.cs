using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public class SaleItems_DAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private readonly Products_Controller _prodController = new Products_Controller();

        public bool SaveToDb(SaleItems obj)
        {
            bool status = false;

            string sql = "INSERT INTO SALEITEMS ( SALE_ID, PRODUCT_ID, QUANTITY, ITEM_VALUE, ITEM_COST, DISCOUNT_CASH," +
                "TOTAL_VALUE , DATE_CREATION, DATE_LAST_UPDATE ) "
                         + " VALUES (@ID, @PRODID, @QTD, @PRODVALUE, @PRODCOST, @DISCCASH, @TOTALVALUE, @DC, @DU);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", obj.id);
                    command.Parameters.AddWithValue("@PRODID", obj.Product.id);
                    command.Parameters.AddWithValue("@PRODVALUE", obj.ProductValue);
                    command.Parameters.AddWithValue("@PRODCOST", obj.ProductCost);
                    command.Parameters.AddWithValue("@TOTALVALUE", obj.TotalValue);
                    command.Parameters.AddWithValue("@DISCCASH", obj.ItemDiscountCash);
                    command.Parameters.AddWithValue("@QTD", obj.Quantity);
                    command.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();

                    if (i > 0)
                    {
                        status = true;
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
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public bool EditFromDB(SaleItems obj)
        {
            bool status = false;

            string sql = "UPDATE SALEITEMS SET PRODUCT_ID = @PRODID, QUANTITY = @QTD, ITEM_VALUE = @ITEMVALUE, ITEM_COST = @ITEMCOST, " +
                " DISCOUNT_CASH = @DISCCASH, TOTAL_VALUE = @TOTAL, DATE_LAST_UPDATE = @DU " +
                "WHERE SALE_ID = @ID ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@PRODID", obj.id);
                    command.Parameters.AddWithValue("@QTD", obj.Quantity);
                    command.Parameters.AddWithValue("@ITEMVALUE", (decimal)obj.ProductValue);
                    command.Parameters.AddWithValue("@ITEMCOST", (decimal)obj.ProductCost);
                    command.Parameters.AddWithValue("@DISCCASH", (decimal)obj.ItemDiscountCash);
                    command.Parameters.AddWithValue("@TOTAL", (decimal)obj.TotalValue);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
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

        public List<SaleItems> SelectFromDb(int id)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE SALE_ID = @ID ;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        List<SaleItems> list = new List<SaleItems>();
                        foreach (SaleItems item in reader)
                        {
                            SaleItems obj = new SaleItems
                            {
                                id = Convert.ToInt32(reader["sale_id"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                ProductValue = Convert.ToDecimal(reader["item_value"]),
                                ProductCost = Convert.ToDecimal(reader["item_cost"]),
                                TotalValue = Convert.ToDecimal(reader["total_value"]),
                                ItemDiscountCash = Convert.ToDecimal(reader["discount_cash"]),
                                dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
                            };
                            list.Add(obj);
                        }
                        return list;
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
            return null;
        }

        public List<SaleItems> SelectProductIdFromDb(int id)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE PRODUCT_ID = @ID ;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        List<SaleItems> list = new List<SaleItems>();
                        foreach (SaleItems item in reader)
                        {
                            SaleItems obj = new SaleItems
                            {
                                id = Convert.ToInt32(reader["sale_id"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                ProductValue = Convert.ToDecimal(reader["item_value"]),
                                ProductCost = Convert.ToDecimal(reader["item_cost"]),
                                TotalValue = Convert.ToDecimal(reader["total_value"]),
                                ItemDiscountCash = Convert.ToDecimal(reader["discount_cash"]),
                                dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
                            };
                            list.Add(obj);
                        }
                        return list;
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
            return null;
        }

        public List<SaleItems> SelectTotalValueFromDb(decimal minValue)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE TOTAL_VALUE >= @MINVALUE ;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("@MINVALUE", minValue);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        List<SaleItems> list = new List<SaleItems>();
                        foreach (SaleItems item in reader)
                        {
                            SaleItems obj = new SaleItems
                            {
                                id = Convert.ToInt32(reader["sale_id"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                ProductValue = Convert.ToDecimal(reader["item_value"]),
                                ProductCost = Convert.ToDecimal(reader["item_cost"]),
                                TotalValue = Convert.ToDecimal(reader["total_value"]),
                                ItemDiscountCash = Convert.ToDecimal(reader["discount_cash"]),
                                dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
                            };
                            list.Add(obj);
                        }
                        return list;
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
            return null;
        }

        public List<SaleItems> SelectSaleIdFromDb2(int id)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE SALE_ID = @ID ;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        List<SaleItems> list = new List<SaleItems>();
                        foreach (SaleItems item in reader)
                        {
                            SaleItems obj = new SaleItems
                            {
                                id = id,
                                Product          = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity         = Convert.ToInt32(reader["quantity"]),
                                ProductValue     = Convert.ToDecimal(reader["item_value"]),
                                ProductCost      = Convert.ToDecimal(reader["item_cost"]),
                                TotalValue       = Convert.ToDecimal(reader["total_value"]),
                                ItemDiscountCash = Convert.ToDecimal(reader["discount_cash"]),
                                dateOfCreation   = Convert.ToDateTime(reader["date_creation"]),
                                dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
                            };
                            list.Add(obj);
                        }
                        return list;
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
            return null;
        }

        public List<SaleItems> SelectSaleIdFromDb(int id)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE SALE_ID = @ID ;";
            List<SaleItems> list = new List<SaleItems>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        SaleItems obj = new SaleItems
                        {
                            id = id,
                            Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                            Quantity = Convert.ToInt32(reader["quantity"]),
                            ProductValue = Convert.ToDecimal(reader["item_value"]),
                            ProductCost = Convert.ToDecimal(reader["item_cost"]),
                            TotalValue = Convert.ToDecimal(reader["total_value"]),
                            ItemDiscountCash = Convert.ToDecimal(reader["discount_cash"]),
                            dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                            dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
                        };
                        list.Add(obj);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                if (list.Count > 0)
                {
                    return list;
                }
                else
                {
                    return null;
                }
            }
        }

        public List<SaleItems> SelectAllFromDb()
        {
            string sql = "SELECT * FROM SALEITEMS ;";
            List<SaleItems> saleItems = null;
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
                        saleItems = new List<SaleItems>();
                        foreach (SaleItems item in reader)
                        {
                            saleItems.Add(item);
                        }
                    }
                    else
                    {
                        saleItems = null;
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
            return saleItems;
        }

        public bool DeleteFromDb(int id)
        {
            bool status = false;
            string sql = "DELETE FROM SALEITEMS WHERE SALE_ID = @ID ;";
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

        public DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM SALEITEMS ;";
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

        //public bool CancelSaleItems(int saleId)
        //{
        //    bool status = false;

        //    string sql = "UPDATE SALEITEMS SET CANCEL_DATE = @CANCELDATE, DATE_LAST_UPDATE = @DU " +
        //        "WHERE SALE_ID = @SALEID; ";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            SqlCommand command = new SqlCommand(sql, connection);
        //            command.Parameters.AddWithValue("@CANCELDATE", DateTime.Now.Date); // 2 == Cancelado
        //            command.Parameters.AddWithValue("@SALEID", saleId);
        //            command.Parameters.AddWithValue("@DU", DateTime.Now.Date);
        //            connection.Open();
        //            int i = command.ExecuteNonQuery();
        //            if (i > 0)
        //            {
        //                MessageBox.Show("Items cancelados.");
        //                status = true;
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error : " + ex.Message);
        //            return status;
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //        return status;
        //    }
        //}
    }
}
