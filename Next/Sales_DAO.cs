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

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class Sales_DAO : Master_DAO
    {
        private string connectionString = "Server = localhost; Database = PraticaProfissional1; Trusted_Connection = True;";


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

        public bool SaveToDb(Sales sale)
        {
            bool status = false;

            //string sql = "INSERT INTO SALES ( CLIENT_ID , SALE_TOTAL_VALUE, SALE_TOTAL_COST, SALE_DISCOUNT, TOTAL_ITEMS_QUANTITY, EMISSION_DATE, CANCEL_DATE, BILL_TO_RECEIVE_ID, DATE_CREATION, DATE_LAST_UPDATE) "
            //             + " VALUES ("
            //             + +sale.Client.id 
            //             + ", "
            //             + +sale.TotalValue
            //             + ", "
            //             + +sale.saleDiscountCash
            //             + ", "
            //             + +sale.totalItemsQuantity
            //             + ", '"
            //             + sale.emissionDate.ToString()
            //             + "', '"
            //             + sale.cancelDate.ToString()
            //             + "', "
            //             + +sale.BillToReceive.id
            //             + ", '"
            //             + sale.dateOfCreation.ToString()
            //             + "', '"
            //             + sale.dateOfLastUpdate.ToString()
            //             + "' );";

            //SqlConnection con = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.Text;
            //con.Open();
            //try
            //{
            //    int i = cmd.ExecuteNonQuery();
            //    if (i > 0)
            //    {
            //        MessageBox.Show("Register added with success!");
            //        status = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error : " + ex.Message);
            //    return status;
            //}
            //finally
            //{
            //    con.Close();
            //}
            return status;
        }

        public bool EditFromDB(Sales sale)
        {
            bool status = false;
            //string sql = "UPDATE SALES SET SALE_TOTAL_COST = "
            //             + +sale.totalCost
            //             + ", SALE_TOTAL_VALUE = "
            //             + +sale.totalValue
            //             + ", CLIENT_ID = "
            //             + +sale.client.id
            //             + ", SALE_DISCOUNT = "
            //             + +sale.saleDiscountCash
            //             + ", TOTAL_ITEMS_QUANTITY = "
            //             + +sale.totalItemsQuantity
            //             + ", EMISSION_DATE = '"
            //             + sale.emissionDate.ToString()
            //             + "', CANCEL_DATE = '"
            //             + sale.cancelDate.ToString()
            //             + "', BILL_TO_RECEIVE_ID = "
            //             + +sale.BillToReceive.id
            //             + ", DATE_LAST_UPDATE = '"
            //             + sale.dateOfLastUpdate.ToString()
            //             + "' WHERE ID_SALE = "
            //             + sale.id
            //             + " ;";

            //SqlConnection con = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.Text;
            //con.Open();
            //try
            //{
            //    int i = cmd.ExecuteNonQuery();
            //    if (i > 0)
            //    {
            //        MessageBox.Show("Register altered with success!");
            //        status = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error : " + ex.Message);
            //    return status;
            //}
            //finally
            //{
            //    con.Close();
            //}
            return status;
        }

        public override bool DeleteFromDb(int id)
        {
            bool status = false;
            string sql = "DELETE FROM SALES WHERE ID_SALE = " + id + " ;";

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

        public Sales SelectFromDb(int id)
        {
            string sql = "SELECT * FROM SALES WHERE ID_SALE = " + id + " ;";

            Sales sale = null;
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
                        sale = new Sales();
                      //  sale.Add(item);
                    }
                    else
                    {
                        sale = null;
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
            return sale;
        }

        public List<Sales> SelectClientsIdFromDb(int id)
        {
            string sql = "SELECT * FROM SALES WHERE CLIENT_ID = " + id + " ;";

            List<Sales> sale = null;
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
                        sale = new List<Sales>();
                        foreach (Sales item in reader)
                        {
                            sale.Add(item);
                        }
                    }
                    else
                    {
                        sale = null;
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
            return sale;
        }

        public List<Sales> SelectClientsNameFromDb(string name)
        {
            string sql = "SELECT * FROM SALES AS S JOIN CLIENTS AS C ON S.CLIENT_ID = C.PEOPLE_REGISTRATION AND C.CLIENT_NAME = '" + name + "';";

            List<Sales> sale = null;
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
                        sale = new List<Sales>();
                        foreach (Sales item in reader)
                        {
                            sale.Add(item);
                        }
                    }
                    else
                    {
                        sale = null;
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
            return sale;
        }

        public List<Sales> SelectEmissionDateFromDb(string date)
        {
            string sql = "SELECT * FROM SALES WHERE EMISSION_DATE >= '" + date + "';";
            List<Sales> sale = null;
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
                        sale = new List<Sales>();
                        foreach (Sales item in reader)
                        {
                            sale.Add(item);
                        }
                    }
                    else
                    {
                        sale = null;
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
            return sale;
        }

        public List<Sales> SelectCanceledDateFromDb(string date)
        {
            string sql = "SELECT * FROM SALES WHERE CANCEL_DATE >= '" + date + "';";
            List<Sales> sale = null;
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
                        sale = new List<Sales>();
                        foreach (Sales item in reader)
                        {
                            sale.Add(item);
                        }
                    }
                    else
                    {
                        sale = null;
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
            return sale;
        }

        public List<Sales> SelectTotalValueFromDb(decimal minValue)
        {
            string sql = "SELECT * FROM SALES WHERE SALE_TOTAL_VALUE >= " + minValue + ";";
            List<Sales> sale = null;
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
                        sale = new List<Sales>();
                        foreach (Sales item in reader)
                        {
                            sale.Add(item);
                        }
                    }
                    else
                    {
                        sale = null;
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
            return sale;
        }
        public List<Sales> SelectAllFromDb()
        {
            string sql = "SELECT * FROM SALES ;";
            List<Sales> sale = null;
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
                        sale = new List<Sales>();
                        foreach (Sales item in reader)
                        {
                            sale.Add(item);
                        }
                    }
                    else
                    {
                        sale = null;
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
            return sale;
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
