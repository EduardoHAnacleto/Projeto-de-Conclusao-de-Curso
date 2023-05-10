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

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public class OSItems_DAO
    {
        private string connectionString = string.Empty;
        private readonly Products_Controller _prodController = new Products_Controller();

        public bool SaveToDb(OSItems obj)
        {
            bool status = false;

            string sql = "INSERT INTO OSITEMS ( OS_ID, PRODUCT_ID, QUANTITY, ITEM_VALUE, ITEM_COST, DISCOUNT_CASH, DISCOUNT_PERC," +
                "TOTAL_VALUE , DATE_CREATION, DATE_LAST_UPDATE ) "
                         + " VALUES (@ID, @PRODVALUE, @PRODCOST, @TOTALVALUE, @DISCCASH, @DISCPERC, @QTD, @DC, @DU);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", obj.OSId);
                    command.Parameters.AddWithValue("@PRODVALUE", (decimal)obj.ProductValue);
                    command.Parameters.AddWithValue("@PRODCOST", (decimal)obj.ProductCost);
                    command.Parameters.AddWithValue("@TOTALVALUE", (decimal)obj.TotalValue);
                    command.Parameters.AddWithValue("@DISCCASH", (decimal)obj.ItemDiscountCash);
                    command.Parameters.AddWithValue("@DISCPERC", (decimal)obj.ItemDiscountPerc);
                    command.Parameters.AddWithValue("@QTD", obj.Quantity);
                    command.Parameters.AddWithValue("@DC", obj.dateOfLastUpdate);
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
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public List<OSItems> SelectFromDb(int id)
        {
            string sql = "SELECT * FROM OSITEMS WHERE OS_ID = @ID ;";
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
                        List<OSItems> list = new List<OSItems>();
                        foreach (OSItems item in reader)
                        {
                            OSItems obj = new OSItems
                            {
                                id = Convert.ToInt32(reader["OS_ID"]),
                                OSId = Convert.ToInt32(reader["id_sale"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                ProductValue = Convert.ToDouble(reader["item_value"]),
                                ProductCost = Convert.ToDouble(reader["item_cost"]),
                                TotalValue = Convert.ToDouble(reader["total_value"]),
                                ItemDiscountCash = Convert.ToDouble(reader["discount_cash"]),
                                ItemDiscountPerc = Convert.ToDouble(reader["discount_perc"]),
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
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public List<OSItems> SelectProductIdFromDb(int id)
        {
            string sql = "SELECT * FROM OSITEMS WHERE PRODUCT_ID = @ID ;";
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
                        List<OSItems> list = new List<OSItems>();
                        foreach (OSItems item in reader)
                        {
                            OSItems obj = new OSItems
                            {
                                id = Convert.ToInt32(reader["OS_ID"]),
                                OSId = Convert.ToInt32(reader["OS_ID"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                ProductValue = Convert.ToDouble(reader["item_value"]),
                                ProductCost = Convert.ToDouble(reader["item_cost"]),
                                TotalValue = Convert.ToDouble(reader["total_value"]),
                                ItemDiscountCash = Convert.ToDouble(reader["discount_cash"]),
                                ItemDiscountPerc = Convert.ToDouble(reader["discount_perc"]),
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
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public List<OSItems> SelectTotalValueFromDb(decimal minValue)
        {
            string sql = "SELECT * FROM OSITEMS WHERE TOTAL_VALUE >= @MINVALUE ;";
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
                        List<OSItems> list = new List<OSItems>();
                        foreach (OSItems item in reader)
                        {
                            OSItems obj = new OSItems
                            {
                                id = Convert.ToInt32(reader["OS_ID"]),
                                OSId = Convert.ToInt32(reader["OS_ID"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                ProductValue = Convert.ToDouble(reader["item_value"]),
                                ProductCost = Convert.ToDouble(reader["item_cost"]),
                                TotalValue = Convert.ToDouble(reader["total_value"]),
                                ItemDiscountCash = Convert.ToDouble(reader["discount_cash"]),
                                ItemDiscountPerc = Convert.ToDouble(reader["discount_perc"]),
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
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public List<OSItems> SelectSaleIdFromDb(int id)
        {
            string sql = "SELECT * FROM OSITEMS WHERE OS_ID = @ID ;";
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
                        List<OSItems> list = new List<OSItems>();
                        foreach (OSItems item in reader)
                        {
                            OSItems obj = new OSItems
                            {
                                id = Convert.ToInt32(reader["OS_ID"]),
                                OSId = Convert.ToInt32(reader["OS_ID"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                ProductValue = Convert.ToDouble(reader["item_value"]),
                                ProductCost = Convert.ToDouble(reader["item_cost"]),
                                TotalValue = Convert.ToDouble(reader["total_value"]),
                                ItemDiscountCash = Convert.ToDouble(reader["discount_cash"]),
                                ItemDiscountPerc = Convert.ToDouble(reader["discount_perc"]),
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
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public List<OSItems> SelectAllFromDb()
        {
            string sql = "SELECT * FROM OSITEMS ;";
            List<OSItems> saleItems = null;
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
                        saleItems = new List<OSItems>();
                        foreach (OSItems item in reader)
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
            string sql = "DELETE FROM OSITEMS WHERE OS_ID = @ID ;";
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
