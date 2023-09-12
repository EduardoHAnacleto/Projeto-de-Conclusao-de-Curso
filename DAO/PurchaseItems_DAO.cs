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

            string sql = "INSERT INTO PURCHASEITEMS ( BILLMODEL, BILLNUMBER, BILLSERIES, SUPPLIER_ID, PRODUCT_ID, QUANTITY, PRODUCT_COST, PURCHASE_PERCENTAGE," +
                "DISCOUNT_CASH , WEIGHTED_AVG , DATE_CREATION, DATE_CANCELLED ) "
                         + " VALUES (@BILLMOD, @BILLNUM, @BILLSER, @SUPPLIERID, @PRODID, @QTD, @PRODCOST, @PURCHPERC, @DISCOUNT, @WEIGHTEDAVG, @DC, @DC);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@BILLNUM", obj.BillNumberId);
                    command.Parameters.AddWithValue("@BILLMOD", obj.BillModelId);
                    command.Parameters.AddWithValue("@BILLSER", obj.BillSeriesId);
                    command.Parameters.AddWithValue("@SUPPLIERID", obj.SupplierId);
                    command.Parameters.AddWithValue("@PRODID", obj.Product.id);
                    command.Parameters.AddWithValue("@QTD", obj.Quantity);
                    command.Parameters.AddWithValue("@PRODCOST", obj.NewBaseUnCost);
                    command.Parameters.AddWithValue("@PURCHPERC", obj.PurchasePercentage);
                    command.Parameters.AddWithValue("@WEIGHTEDAVG", obj.WeightedCostAverage);
                    command.Parameters.AddWithValue("@DISCOUNT", obj.DiscountCash);
                    command.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                    if (obj.CancelledDate != null)
                    {
                        command.Parameters.AddWithValue("@DU", obj.CancelledDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@DU", DBNull.Value);
                    }

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

        public List<PurchaseItems> SelectFromDb(int bModel, int bNum, int bSeries, int supplierId)
        {
            string sql = "SELECT * FROM PURCHASEITEMS WHERE BILLMODEL = @BMODEL AND BILLNUMBER = @BNUM AND BILLSERIES = @BSERIES AND SUPPLIER_ID = @SUPPLIERID ;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("@BMODEL", bModel);
                cmd.Parameters.AddWithValue("@BNUM", bNum);
                cmd.Parameters.AddWithValue("@BSERIES", bSeries);
                cmd.Parameters.AddWithValue("@SUPPLIERID", supplierId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    List<PurchaseItems> list = new List<PurchaseItems>();
                    foreach (var item in reader)
                    {
                        PurchaseItems obj = new PurchaseItems
                        {
                            BillNumberId = Convert.ToInt32(reader["billModel"]),
                            BillModelId = Convert.ToInt32(reader["billNumber"]),
                            BillSeriesId = Convert.ToInt32(reader["billSeries"]),
                            SupplierId = Convert.ToInt32(reader["supplier_id"]),
                            Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                            Quantity = Convert.ToInt32(reader["quantity"]),
                            NewBaseUnCost = Convert.ToDecimal(reader["product_cost"]),
                            PurchasePercentage = Convert.ToDecimal(reader["purchase_percentage"]),
                            WeightedCostAverage = Convert.ToDecimal(reader["weighted_avg"]),
                            dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                            CancelledDate = null
                        };
                        if (reader["date_creation"] != DBNull.Value)
                        {
                            obj.CancelledDate = Convert.ToDateTime(reader["DATE_CANCELLED"]);
                        }
                        list.Add(obj);
                    }
                    return list;
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
                                BillNumberId = Convert.ToInt32(reader["billModel"]),
                                BillModelId = Convert.ToInt32(reader["billNumber"]),
                                BillSeriesId = Convert.ToInt32(reader["billSeries"]),
                                SupplierId = Convert.ToInt32(reader["supplier_id"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                NewBaseUnCost = Convert.ToDecimal(reader["product_cost"]),
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
                                BillNumberId = Convert.ToInt32(reader["billModel"]),
                                BillModelId = Convert.ToInt32(reader["billNumber"]),
                                BillSeriesId = Convert.ToInt32(reader["billSeries"]),
                                SupplierId = Convert.ToInt32(reader["supplier_id"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                NewBaseUnCost = Convert.ToDecimal(reader["product_cost"]),
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

        public List<PurchaseItems> SelectPurchaseIdFromDb(int bModel, int bNum, int bSeries, int supplierId)
        {
            string sql = "SELECT * FROM PURCHASEITEMS WHERE BILLMODEL = @BMODEL AND BILLNUMBER = @BNUM AND BILLSERIES = @BSERIES AND SUPPLIER_ID = @SUPPLIERID ;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("@BMODEL", bModel);
                cmd.Parameters.AddWithValue("@BNUM", bNum);
                cmd.Parameters.AddWithValue("@BSERIES", bSeries);
                cmd.Parameters.AddWithValue("@SUPPLIERID", supplierId);
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
                                BillNumberId = Convert.ToInt32(reader["billModel"]),
                                BillModelId = Convert.ToInt32(reader["billNumber"]),
                                BillSeriesId = Convert.ToInt32(reader["billSeries"]),
                                SupplierId = Convert.ToInt32(reader["supplier_id"]),
                                Product = _prodController.FindItemId(Convert.ToInt32(reader["product_id"])),
                                Quantity = Convert.ToInt32(reader["quantity"]),
                                NewBaseUnCost = Convert.ToDecimal(reader["product_cost"]),
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

        public bool DeleteFromDb(int bModel, int bNum, int bSeries, int supplierId)
        {
            bool status = false;
            string sql = "DELETE FROM PURCHASEITEMS WHERE BILLMODEL = @BMODEL AND BILLNUMBER = @BNUM, BILLSERIES = @BSERIES AND SUPPLIER_ID = @SUPPLIERID ;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@BMODEL", bModel);
                    command.Parameters.AddWithValue("@BNUM", bNum);
                    command.Parameters.AddWithValue("@BSERIES", bSeries);
                    command.Parameters.AddWithValue("@SUPPLIERID", supplierId);
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

