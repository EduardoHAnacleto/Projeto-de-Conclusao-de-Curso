using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class PurchaseItems_DAO
    {
        private string connectionString = string.Empty;

        public bool SaveToDb(PurchaseItems purchaseItems)
        {
            bool status = false;

            string sql = "INSERT INTO PURCHASEITEMS ( ID_PURCHASEITEMS, PURCHASE_ID, PRODUCT_ID, TOTAL_VALUE, ITEMS_QUANTITY, ITEM_DISCOUNT, DATE_CREATION, DATE_LAST_UPDATE) "
                         + " VALUES ("
                         + +purchaseItems.id
                         + ", "
                         + +purchaseItems.purchase_id
                         + ", "
                         + +purchaseItems.product.id
                         + ", "
                         + +purchaseItems.totalValue
                         + ", "
                         + +purchaseItems.quantity
                         + ", "
                         + +purchaseItems.discount
                         + ", '"
                         + purchaseItems.dateOfCreation.ToShortDateString()
                         + "', '"
                         + purchaseItems.dateOfLastUpdate.ToShortDateString()
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

        public bool EditFromDB(PurchaseItems purchaseItems)
        {
            bool status = false;
            string sql = "UPDATE PURCHASEITEMS SET PRODUCT_ID = "
                         + +purchaseItems.product.id
                         + ", TOTAL_VALUE = "
                         + +purchaseItems.totalValue
                         + ", ITEMS_QUANTITY = "
                         + +purchaseItems.quantity 
                         + ", ITEM_DISCOUNT = "
                         + +purchaseItems.discount
                         + ", DATE_LAST_UPDATE = '"
                         + purchaseItems.dateOfLastUpdate.ToString()
                         + "' WHERE PURCHASE_ID = "
                         + purchaseItems.id
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

        public bool DeleteFromDb(int id)
        {
            bool status = false;
            string sql = "DELETE FROM PURCHASEITEMS WHERE PURCHASE_ID = " + id + " ;";

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

        public List<PurchaseItems> SelectFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASEITEMS WHERE PURCHASE_ID = " + id + " ;";

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
        public List<PurchaseItems> SelectProductIdFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASEITEMS WHERE PRODUCT_ID = " + id + " ;";

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
        public List<PurchaseItems> SelectProductNameFromDb(string name)
        {
            string sql = "SELECT * FROM PURCHASEITEMS AS P INNER JOIN PRODUCTS AS R ON P.PRODUCT_ID = R.ID_PRODUCT AND R.PRODUCT_NAME = '"
                         + name
                         + "';";
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
        public List<PurchaseItems> SelectTotalValueFromDb(decimal minValue)
        {
            string sql = "SELECT * FROM PURCHASEITEMS WHERE TOTAL_VALUE >= " + minValue + " ;";

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
        public List<PurchaseItems> SelectPurchaseIdFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASEITEMS AS P JOIN PURCHASES AS A ON P.PURCHASE_ID = A.PURCHASE_ID AND P.PURCHASE_ID = "
                         + id
                         + " ;";

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

