using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using System.Configuration;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class PurchaseItems_DAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private readonly Products_Controller _prodController = new Products_Controller();

        public bool SaveToDb(PurchaseItems obj)
        {
            bool status = false;

            string sql = "INSERT INTO PURCHASEITEMS ( ID_PURCHASE, PRODUCT_ID, QUANTITY, PRODUCT_COST, TOTAL_COST, PURCHASE_PERCENTAGE," +
                "WEIGHTED_AVG , DATE_CREATION, DATE_LAST_UPDATE ) "
                         + " VALUES (@ID, @PRODID, @QTD, @PRODCOST, @TOTALVALUE, @PURCHPERC, @WEIGHTEDAVG, @DC, @DU);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", obj.PurchaseId);
                    command.Parameters.AddWithValue("@PRODID", obj.Product.id);
                    command.Parameters.AddWithValue("@QTD", obj.Quantity);
                    command.Parameters.AddWithValue("@PRODCOST", (decimal)obj.NewBaseUnCost);
                    command.Parameters.AddWithValue("@TOTALVALUE", (decimal)obj.TotalBaseCost);
                    command.Parameters.AddWithValue("@PURCHPERC", (decimal)obj.PurchasePercentage);
                    command.Parameters.AddWithValue("@WEIGHTEDAVG", (decimal)obj.WeightedCostAverage);
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

        public List<PurchaseItems> SelectFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASEITEMS WHERE PURCHASE_ID = @ID ;";
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
                        List<PurchaseItems> list = new List<PurchaseItems>();
                        foreach (PurchaseItems item in reader)
                        {
                            PurchaseItems obj = new PurchaseItems 
                            {
                                id = Convert.ToInt32(reader["id_purchase"]),
                                PurchaseId = Convert.ToInt32(reader["id_purchase"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                NewBaseUnCost = Convert.ToDecimal(reader["product_cost"]),
                                TotalBaseCost = Convert.ToDecimal(reader["total_cost"]),
                                PurchasePercentage = Convert.ToDecimal(reader["purchase_percentage"]),
                                WeightedCostAverage = Convert.ToDecimal(reader["weighted_avg"]),
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

        public List<PurchaseItems> SelectProductIdFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASEITEMS WHERE PRODUCT_ID = @ID ;";
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
                        List<PurchaseItems> list = new List<PurchaseItems>();
                        foreach (PurchaseItems item in reader)
                        {
                            PurchaseItems obj = new PurchaseItems
                            {
                                id = Convert.ToInt32(reader["id_purchase"]),
                                PurchaseId = Convert.ToInt32(reader["id_purchase"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                NewBaseUnCost = Convert.ToDecimal(reader["product_cost"]),
                                TotalBaseCost = Convert.ToDecimal(reader["total_cost"]),
                                PurchasePercentage = Convert.ToDecimal(reader["purchase_percentage"]),
                                WeightedCostAverage = Convert.ToDecimal(reader["weighted_avg"]),
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

        public List<PurchaseItems> SelectTotalValueFromDb(decimal minValue)
        {
            string sql = "SELECT * FROM PURCHASEITEMS WHERE TOTAL_VALUE >= @MINVALUE ;";
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
                        List<PurchaseItems> list = new List<PurchaseItems>();
                        foreach (PurchaseItems item in reader)
                        {
                            PurchaseItems obj = new PurchaseItems
                            {
                                id = Convert.ToInt32(reader["id_purchase"]),
                                PurchaseId = Convert.ToInt32(reader["id_purchase"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                NewBaseUnCost = Convert.ToDecimal(reader["product_cost"]),
                                TotalBaseCost = Convert.ToDecimal(reader["total_cost"]),
                                PurchasePercentage = Convert.ToDecimal(reader["purchase_percentage"]),
                                WeightedCostAverage = Convert.ToDecimal(reader["weighted_avg"]),
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

        public List<PurchaseItems> SelectPurchaseIdFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASEITEMS WHERE ID_PURCHASE = @ID ;";
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
                        List<PurchaseItems> list = new List<PurchaseItems>();
                        foreach (PurchaseItems item in reader)
                        {
                            PurchaseItems obj = new PurchaseItems
                            {
                                id = Convert.ToInt32(reader["id_purchase"]),
                                PurchaseId = Convert.ToInt32(reader["id_purchase"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                NewBaseUnCost = Convert.ToDecimal(reader["product_cost"]),
                                TotalBaseCost = Convert.ToDecimal(reader["total_cost"]),
                                PurchasePercentage = Convert.ToDecimal(reader["purchase_percentage"]),
                                WeightedCostAverage = Convert.ToDecimal(reader["weighted_avg"]),
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

        public List<PurchaseItems> SelectAllFromDb()
        {
            string sql = "SELECT * FROM PURCHASEITEMS ;";
            List<PurchaseItems> purchaseItems = null;
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
                        purchaseItems = new List<PurchaseItems>();
                        foreach (PurchaseItems item in reader)
                        {
                            purchaseItems.Add(item);
                        }
                    }
                    else
                    {
                        purchaseItems = null;
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
            return purchaseItems;
        }

        public bool DeleteFromDb(int id)
        {
            bool status = false;
            string sql = "DELETE FROM SALES WHERE ID_PURCHASEITEMS = @ID ;";
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
            string sql = "SELECT * FROM PURCHASEITEMS ;";
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

