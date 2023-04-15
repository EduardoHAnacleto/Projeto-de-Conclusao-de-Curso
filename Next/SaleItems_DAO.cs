using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoEduardoAnacletoWindowsForm1.DAO;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class SaleItems_DAO : Master_DAO
    {
        private string connectionString = string.Empty;

        public bool SaveToDb(SaleItems saleItems)
        {
            bool status = false;

            string sql = "INSERT INTO SALEITEMS ( ID_SALEITEM, PRODUCT_ID,  QUANTITY, SALE_VALUE, DISCOUNT, TOTAL_VALUE, DATE_CREATION, DATE_LAST_UPDATE) "
                         + " VALUES ("
                         + +saleItems.sale_id
                         + ", "
                         + +saleItems.product.id 
                         + ", "
                         + +saleItems.quantity
                         + ", "
                         + +saleItems.value
                         + ", "
                         + +saleItems.discount
                         + ", "                        
                         + saleItems.totalValue
                         + "', '"
                         + saleItems.dateOfCreation.ToString()
                         + "', '"
                         + saleItems.dateOfLastUpdate.ToString()
                         + "' );";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
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
                con.Close();
            }
            return status;
        }

        public bool EditFromDB(SaleItems saleItems)
        {
            bool status = false;
            string sql = "UPDATE SALEITEMS SET PRODUCT_ID = "
                         + +saleItems.product.id
                         + ", QUANTITY = "
                         + +saleItems.quantity
                         + ", SALE_VALUE = "
                         + +saleItems.value
                         + ", DISCOUNT = "
                         + +saleItems.discount
                         + ", TOTAL_VALUE = "
                         + +saleItems.totalValue
                         + ", DATE_LAST_UPDATE = '"
                         + saleItems.dateOfLastUpdate.ToString()
                         + "' WHERE ID_SALEITEM = "
                         + saleItems.id
                         + " ;";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
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
                con.Close();
            }
            return status;
        }

        public override bool DeleteFromDb(int id)
        {
            bool status = false;
            string sql = "DELETE FROM SALEITEMS WHERE ID_SALEITEM = " + id + " ;";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
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
                con.Close();
            }
            return status;
        }

        public List<SaleItems> SelectFromDb(int id)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE ID_SALEITEM = " + id + " ;";

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

        public List<SaleItems> SelectProductFromDb(int id)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE PRODUCT_ID = " + id + " ;";

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
        public List<SaleItems> SelectProductFromDb(string name)
        {
            string sql = "SELECT * FROM SALEITEMS AS S JOIN PRODUCTS AS P ON S.PRODUCT_ID = P.ID_PRODUCT AND S.PRODUCT_NAME = " + name + " ;";
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

        public List<SaleItems> SelectTotalValueFromDb(decimal minValue)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE TOTAL_VALUE >= " + minValue + " ;";

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

        public List<SaleItems> SelectSaleFromDb(int id)
        {
            string sql = "SELECT * FROM SALEITEMS AS S JOIN SALES AS A ON S.SALE_ID = A.ID_SALE S.SALE_ID = " + id + " ;";

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

        public override DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
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

