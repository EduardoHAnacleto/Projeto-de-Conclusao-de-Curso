using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using System.Collections;

namespace ProjetoEduardoAnacletoWindowsForm1.DAO
{
    public class Products_DAO : Master_DAO //Ok
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public override int NewId()
        {
            var newId = "";
            string sql = "SELECT MAX(ID_PRODUCT) FROM PRODUCTS;";
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

        public bool SaveToDb(Products obj)
        {
            bool status = false;

            string sql = "INSERT INTO PRODUCTS ( PRODUCT_NAME, PRODUCT_SALE_PRICE, PRODUCT_GROUP_ID, BRAND_ID, STOCK, PRODUCT_COST, PRODUCT_BARCODE, DATE_CREATION, DATE_LAST_UPDATE) "
                         + " VALUES (@NAME, @SALE, @GROUPID, @BRANDID, @STOCK, @COST, @BARCODE, @DC, @DU)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@NAME", obj.productName);
                    command.Parameters.AddWithValue("@SALE", (decimal)obj.salePrice);
                    command.Parameters.AddWithValue("@GROUPID", obj.productGroup.id);
                    command.Parameters.AddWithValue("@BRANDID", obj.brand.id);
                    command.Parameters.AddWithValue("@STOCK", obj.stock);
                    command.Parameters.AddWithValue("@COST", (decimal)obj.productCost);
                    command.Parameters.AddWithValue("@BARCODE", obj.productCost);
                    command.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
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

        public bool EditFromDB(Products obj)
        {
            bool status = false;

            string sql = "UPDATE PRODUCTS SET PRODUCT_NAME = @NAME, PRODUCT_SALE_PRICE = @SALEPRICE, PRODUCT_GROUP_ID = @PGID," +
                "BRAND_ID = @BRANDID, STOCK = @STOCK, PRODUCT_COST = @PCOST, PRODUCT_BARCODE = @BARCODE, DATE_LAST_UPDATE = @DU " +
                "WHERE ID_PRODUCT = @ID ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", obj.id);
                    command.Parameters.AddWithValue("@NAME", obj.productName);
                    command.Parameters.AddWithValue("@SALEPRICE", (decimal)obj.salePrice);
                    command.Parameters.AddWithValue("@PGID", obj.productGroup.id);
                    command.Parameters.AddWithValue("@BRANDID", obj.brand.id);
                    command.Parameters.AddWithValue("@STOCK", obj.stock);
                    command.Parameters.AddWithValue("@PCOST", (decimal)obj.productCost);
                    command.Parameters.AddWithValue("@BARCODE", obj.BarCode);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Register altered with success!");
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

        public override bool DeleteFromDb(int id)
        {
            bool status = false;

            string sql = "DELETE FROM PRODUCTS WHERE ID_PRODUCT = @ID ; ";
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

        public Products SelectFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM PRODUCTS WHERE ID_PRODUCT = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ProductGroups_Controller _PController = new ProductGroups_Controller();
                                Brands_Controller _BController = new Brands_Controller();
                                Products obj = new Products
                                {
                                    id = Convert.ToInt32(reader["id_product"]),
                                    productName = Convert.ToString(reader["product_name"]),
                                    salePrice = Convert.ToDecimal(reader["product_sale_price"]),
                                    productCost = Convert.ToDecimal(reader["product_cost"]),
                                    stock = Convert.ToInt32(reader["stock"]),
                                    productGroup = _PController.FindItemId(Convert.ToInt32(reader["product_group_id"])),
                                    BarCode = Convert.ToInt64(reader["product_barCode"]),
                                    brand = _BController.FindItemId(Convert.ToInt32(reader["brand_id"])),
                                    dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                    dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
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

        public Products SelectFromDb(long id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM PRODUCTS WHERE PRODUCT_BARCODE = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ProductGroups_Controller _PController = new ProductGroups_Controller();
                                Brands_Controller _BController = new Brands_Controller();
                                Products obj = new Products
                                {
                                    id = Convert.ToInt32(reader["id_product"]),
                                    productName = Convert.ToString(reader["product_name"]),
                                    salePrice = Convert.ToDecimal(reader["product_sale_price"]),
                                    productCost = Convert.ToDecimal(reader["product_cost"]),
                                    stock = Convert.ToInt32(reader["stock"]),
                                    productGroup = _PController.FindItemId(Convert.ToInt32(reader["product_group_id"])),
                                    BarCode = Convert.ToInt64(reader["product_barCode"]),
                                    brand = _BController.FindItemId(Convert.ToInt32(reader["brand_id"])),
                                    dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                    dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
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

        public Products SelectFromDb(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM PRODUCTS WHERE PRODUCT_NAME = @NAME";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NAME", name);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ProductGroups_Controller _PController = new ProductGroups_Controller();
                                Brands_Controller _BController = new Brands_Controller();
                                Products obj = new Products
                                {
                                    id = Convert.ToInt32(reader["id_product"]),
                                    productName = Convert.ToString(reader["product_name"]),
                                    salePrice = Convert.ToDecimal(reader["product_sale_price"]),
                                    productCost = Convert.ToDecimal(reader["product_cost"]),
                                    stock = Convert.ToInt32(reader["stock"]),
                                    BarCode = Convert.ToInt64(reader["product_barCode"]),
                                    productGroup = _PController.FindItemId(Convert.ToInt32(reader["product_group_id"])),
                                    brand = _BController.FindItemId(Convert.ToInt32(reader["brand_id"])),
                                    dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                    dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
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

        public List<Products> SelectAllFromDb()
        {
            string sql = "SELECT * FROM PRODUCTS ;";
            List<Products> prod = null;
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
                        prod = new List<Products>();
                        foreach (Products item in reader)
                        {
                            prod.Add(item);
                        }
                    }
                    else
                    {
                        prod = null;
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
            return prod;
        }

        public override DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM PRODUCTS ;";
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

        public bool UpdatePriceNStockDb(int prodId, int stock, decimal prodCost)
        {
            bool status = false;

            string sql = "UPDATE PRODUCTS SET STOCK = STOCK + @STOCK, PRODUCT_COST = @PCOST " +
                "WHERE ID_PRODUCT = @ID ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", prodId);
                    command.Parameters.AddWithValue("@STOCK", stock);
                    command.Parameters.AddWithValue("@PCOST", prodCost);

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

        public bool RestoreStock( SaleItems saleItems)
        {
            bool status = false;

            string sql = "UPDATE PRODUCTS SET STOCK = STOCK + @RESTOCK " +
                "WHERE ID_PRODUCT = @ID ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", saleItems.Product.id);
                    command.Parameters.AddWithValue("@RESTOCK", saleItems.Quantity);

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

        public bool RestoreStock(int prodId, int qtd)
        {
            bool status = false;

            string sql = "UPDATE PRODUCTS SET STOCK = STOCK + @RESTOCK " +
                "WHERE ID_PRODUCT = @ID ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", prodId);
                    command.Parameters.AddWithValue("@RESTOCK", qtd);

                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Estoque adicionado!");
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

        internal bool RemoveStock(int prodId, int qtd)
        {
            bool status = false;

            string sql = "UPDATE PRODUCTS SET STOCK = STOCK - @RESTOCK " +
                "WHERE ID_PRODUCT = @ID ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", prodId);
                    command.Parameters.AddWithValue("@RESTOCK", qtd);

                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Estoque removido!");
                        status = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
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
