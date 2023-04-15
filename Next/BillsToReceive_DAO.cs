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

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class BillsToReceive_DAO
    {
        private string connectionString = string.Empty;
        //string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public bool SaveToDb(BillsToReceive billToReceive)
        {
            bool status = false;

            string sql = "INSERT INTO SALEITEMS ( ID_BILL_TO_RECEIVE,IS_PAID, INSTALMENT_VALUE, PERSON_ID, PAYFORM_ID, INSTALMENT_NUMBER,"
                + " DUE_DATE, EMISSION_DATE, DATE_CREATION, DATE_LAST_UPDATE) "
                + " VALUES ("
                + billToReceive.id
                + ", "
                + billToReceive.isPaid
                + ", "
                + billToReceive.instalmentValue
                + ", "
                + billToReceive.person.id
                + ", "
                + billToReceive.paymentForm.id
                + ", "
                + billToReceive.billInstalment.id
                + ", "
                + billToReceive.instalmentValue
                + ", '"
                + billToReceive.dateOfCreation.ToString()
                + "', '"
                + billToReceive.dateOfLastUpdate.ToString()
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

        public bool EditFromDB(BillsToReceive billToReceive)
        {
            bool status = false;
            string sql = "UPDATE SALEITEMS SET " +
                "INSTALMENT_VALUE = " + billToReceive.instalmentValue +
                ",IS_PAID = " + billToReceive.isPaid+
                ",PERSON_ID = " +billToReceive.person.id+
                ",PAYFORM_ID = " +billToReceive.paymentForm.id+
                ",INSTALMENT_NUMBER = " + billToReceive.billInstalment.id+
                ",DATE_LAST_UPDATE = '" + billToReceive.dateOfLastUpdate.ToString() +
                "' WHERE ID_BILL_TO_RECEIVE = " + billToReceive.id + " ;";

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
            string sql = "DELETE FROM SALEITEMS WHERE IS_BILLS_TO_RECEIVE = " + id + " ;";

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

        public List<BillsToReceive> SelectPersonFromDb(int id)
        {
            string sql = "SELECT * FROM SALEITEMS AS S JOIN PEOPLE AS P ON P.ID_PERSON = S.PERSON_ID = " + id + " ;";

            List<BillsToReceive> billToReceive = null;
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
                        billToReceive = new List<BillsToReceive>();
                        foreach (BillsToReceive item in reader)
                        {
                            billToReceive.Add(item);
                        }
                    }
                    else
                    {
                        billToReceive = null;
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
            return billToReceive;
        }
        public List<BillsToReceive> SelectSaleFromDb(int id)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE SALE_ID = " + id + " ;";

            List<BillsToReceive> billToReceive = null;
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
                        billToReceive = new List<BillsToReceive>();
                        foreach (BillsToReceive item in reader)
                        {
                            billToReceive.Add(item);
                        }
                    }
                    else
                    {
                        billToReceive = null;
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
            return billToReceive;
        }
        public List<BillsToReceive> SelectFromDb(int id)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE ID_BILL_TO_RECEIVE = " + id + " ;";

            List<BillsToReceive> billToReceive = null;
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
                        billToReceive = new List<BillsToReceive>();
                        foreach (BillsToReceive item in reader)
                        {
                            billToReceive.Add(item);
                        }
                    }
                    else
                    {
                        billToReceive = null;
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
            return billToReceive;
        }
        public List<BillsToReceive> SelectIsPaidFromDb(int id)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE IS_PAID = " + id + " ;";

            List<BillsToReceive> billToReceive = null;
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
                        billToReceive = new List<BillsToReceive>();
                        foreach (BillsToReceive item in reader)
                        {
                            billToReceive.Add(item);
                        }
                    }
                    else
                    {
                        billToReceive = null;
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
            return billToReceive;
        }

        public List<BillsToReceive> SelectPersonFromDb(string name)
        {
            string sql = "SELECT * FROM SALEITEMS AS S JOIN PEOPLE AS P ON S.PERSON_ID = P.PersonId AND P.PERSON_NAME ='"
                         + name
                         + "';";
            List<BillsToReceive> billToReceive = null;
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
                        billToReceive = new List<BillsToReceive>();
                        foreach (BillsToReceive item in reader)
                        {
                            billToReceive.Add(item);
                        }
                    }
                    else
                    {
                        billToReceive = null;
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
            return billToReceive;
        }
        public List<BillsToReceive> SelectEmissionDateFromDb(string date)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE EMISSION_DATE = '" + date + "';";
            List<BillsToReceive> billToReceive = null;
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
                        billToReceive = new List<BillsToReceive>();
                        foreach (BillsToReceive item in reader)
                        {
                            billToReceive.Add(item);
                        }
                    }
                    else
                    {
                        billToReceive = null;
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
            return billToReceive;
        }
        public List<BillsToReceive> SelectDueDateFromDb(string date)
        {
            string sql = "SELECT * FROM SALEITEMS WHERE DUE_DATE = '" + date + "';";
            List<BillsToReceive> billToReceive = null;
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
                        billToReceive = new List<BillsToReceive>();
                        foreach (BillsToReceive item in reader)
                        {
                            billToReceive.Add(item);
                        }
                    }
                    else
                    {
                        billToReceive = null;
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
            return billToReceive;
        }
        public List<BillsToReceive> SelectAllFromDb()
        {
            string sql = "SELECT * FROM SALEITEMS ;";
            List<BillsToReceive> billToReceive = null;
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
                        billToReceive = new List<BillsToReceive>();
                        foreach (BillsToReceive item in reader)
                        {
                            billToReceive.Add(item);
                        }
                    }
                    else
                    {
                        billToReceive = null;
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
            return billToReceive;
        }

        public DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM BILLSTORECEIVE ;";
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

