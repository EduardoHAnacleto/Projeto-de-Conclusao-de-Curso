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
    public class ServiceOrders_DAO
    {
        //private string connectionString = "Server = localhost; Database = PraticaProfissional1; Trusted_Connection = True;";
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public int NewId()
        {
            var newId = "";
            string sql = "SELECT MAX(ID_SERVICEORDER) FROM SERVICEORDERS;";
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

        public bool SaveToDb(ServiceOrders serviceOrder)
        {
            bool status = false;

            string sql = "INSERT INTO SERVICEORDERS ( CLIENT_ID, SERVICE_ID, EQUIPMENT, EXTRA_DETAILS, SO_DATETIME, DATE_CREATION, DATE_LAST_UPDATE) "
                         + " VALUES ("
                         + serviceOrder.client.id
                         + ", "
                         + serviceOrder.service.id
                         + ", '"
                         + serviceOrder.equipment
                         + "', '"
                         + serviceOrder.extraDetails
                         + "' ,'"
                         + serviceOrder.oSDateTime.ToString()
                         + "' , '"
                         + serviceOrder.dateOfCreation.ToShortTimeString()
                         + "', '"
                         + serviceOrder.dateOfLastUpdate.ToShortTimeString()
                         + "' );" ;

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

        public bool EditFromDB(ServiceOrders serviceOrder)
        {
            bool status = false;
            string sql = "UPDATE SERVICEORDERS SET EXTRA_DETAILS = '"
                         + serviceOrder.extraDetails
                         + "', EQUIPMENT = '"
                         + serviceOrder.equipment
                         + ", CLIENT_ID = "
                         + serviceOrder.client.id
                         + ", SERVICE_ID = "
                         + serviceOrder.service.id
                         + ", SO_DATETIME = '"
                         + serviceOrder.oSDateTime.ToString()
                         + "' ,DATE_LAST_UPDATE = '"
                         + serviceOrder.dateOfLastUpdate.ToShortTimeString()
                         + "' WHERE ID_SERVICEORDER = "
                         + serviceOrder.id
                         + " ;" ;

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
            string sql = "DELETE FROM SERVICEORDERS WHERE ID_SO = " + id + " ;";

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

        public List<ServiceOrders> SelectFromDb(int id)
        {
            string sql = "SELECT * FROM SERVICEORDERS WHERE ID_SO = " + id + " ;";

            List<ServiceOrders> serviceOrder = null;
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
                        serviceOrder = new List<ServiceOrders>();
                        foreach (ServiceOrders item in reader)
                        {
                            serviceOrder.Add(item);
                        }
                    }
                    else
                    {
                        serviceOrder = null;
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
            return serviceOrder;
        }
        public List<ServiceOrders> SelectClientFromDb(int id)
        {
            string sql = "SELECT * FROM SERVICEORDERS AS S JOIN PEOPLE AS P ON S.CLIENT_ID = P.ID_PERSON AND P.ID_PERSON = " + id + " ;";

            List<ServiceOrders> serviceOrder = null;
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
                        serviceOrder = new List<ServiceOrders>();
                        foreach (ServiceOrders item in reader)
                        {
                            serviceOrder.Add(item);
                        }
                    }
                    else
                    {
                        serviceOrder = null;
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
            return serviceOrder;
        }
        public List<ServiceOrders> SelectServiceFromDb(int id)
        {
            string sql = "SELECT * FROM SERVICEORDERS AS S JOIN SERVICES E ON S.ID_SO = E.ID_SERVICE AND S.SERVICE_ID = " + id + " ;";

            List<ServiceOrders> serviceOrder = null;
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
                        serviceOrder = new List<ServiceOrders>();
                        foreach (ServiceOrders item in reader)
                        {
                            serviceOrder.Add(item);
                        }
                    }
                    else
                    {
                        serviceOrder = null;
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
            return serviceOrder;
        }
        public List<ServiceOrders> SelectClientFromDb(string name)
        {
            string sql = "SELECT * FROM SERVICEORDERS AS S JOIN PEOPLE AS P ON S.CLIENT_ID = P.ID_PERSON AND P.PERSON_NAME = " + name + " ;";
            List<ServiceOrders> serviceOrder = null;
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
                        serviceOrder = new List<ServiceOrders>();
                        foreach (ServiceOrders item in reader)
                        {
                            serviceOrder.Add(item);
                        }
                    }
                    else
                    {
                        serviceOrder = null;
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
            return serviceOrder;
        }

        public List<ServiceOrders> SelectServiceFromDb(string serviceName)
        {
            string sql = "SELECT * FROM SERVICEORDERS AS S JOIN SERVICES E ON S.ID_SO = E.ID_SERVICE AND S.DESC_SERVICE = " + serviceName + " ;";
            List<ServiceOrders> serviceOrder = null;
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
                        serviceOrder = new List<ServiceOrders>();
                        foreach (ServiceOrders item in reader)
                        {
                            serviceOrder.Add(item);
                        }
                    }
                    else
                    {
                        serviceOrder = null;
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
            return serviceOrder;
        }

        public List<ServiceOrders> SelectDateTimeFromDb(string date)
        {
            string sql = "SELECT * FROM SERVICEORDERS WHERE SO_DATETIME >= '" + date + "';";
            List<ServiceOrders> serviceOrder = null;
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
                        serviceOrder = new List<ServiceOrders>();
                        foreach (ServiceOrders item in reader)
                        {
                            serviceOrder.Add(item);
                        }
                    }
                    else
                    {
                        serviceOrder = null;
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
            return serviceOrder;
        }
        public List<ServiceOrders> SelectAllFromDb()
        {
            string sql = "SELECT * FROM SERVICEORDERS ;";
            List<ServiceOrders> serviceOrder = null;
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
                        serviceOrder = new List<ServiceOrders>();
                        foreach (ServiceOrders item in reader)
                        {
                            serviceOrder.Add(item);
                        }
                    }
                    else
                    {
                        serviceOrder = null;
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
            return serviceOrder;
        }

        public DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM SERVICEORDERS ;";
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
