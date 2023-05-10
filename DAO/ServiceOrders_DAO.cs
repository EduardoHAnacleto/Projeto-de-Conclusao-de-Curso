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
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using System.ServiceProcess;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class ServiceOrders_DAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private readonly Users_Controller _usersController = new Users_Controller();
        private readonly Clients_Controller _clientsController = new Clients_Controller();
        private readonly BillsToReceive_Controller _billToReceiveController = new BillsToReceive_Controller();
        private readonly Services_Controller _serviceController = new Services_Controller();
        //private readonly OSItems_Controller _oSITEMSController = new OSItems_Controller();

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

        public bool SaveToDb(ServiceOrders obj)
        {
            bool status = false;

            string sql = "INSERT INTO SERVICEORDERS ( SERVICE_ID, CLIENT_ID, USER_ID, EXTRA_DETAILS," +
                "SO_COST, SO_VALUE, SO_COMPLETE, SO_DISCOUNT_CASH, SO_DISCOUNT_PERC, DATE_CREATION, DATE_LAST_UPDATE ) "
                         + " VALUES (@EQUIP, @SERVICEID, @CLIENTID, @USERID, @DETAILS, @COST, @VALUE, @COMPLETEDATE, @DISCCASH," +
                         " @DISCPERC, @CANCELDATE, @DC, @DU);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@SERVICEID", obj.Service.id);
                    command.Parameters.AddWithValue("@CLIENTID", obj.Client.id);
                    command.Parameters.AddWithValue("@USERID", obj.User.id);
                    command.Parameters.AddWithValue("@DETAILS", obj.ExtraDetails);
                    command.Parameters.AddWithValue("@COST", (decimal)obj.ServiceCost);
                    command.Parameters.AddWithValue("@VALUE", (decimal)obj.OSTotalValue);
                    command.Parameters.AddWithValue("@COMPLETEDATE", obj.CompleteDate);
                    command.Parameters.AddWithValue("@DISCCASH", (decimal)obj.ServiceDiscountCash);
                    command.Parameters.AddWithValue("@DISCPERC", (decimal)obj.ServiceDiscountPerc);
                    command.Parameters.AddWithValue("@CANCELDATE", obj.CancelDate);
                    command.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        //if (SaveInstalmentsToDb(cond.BillsInstalments, cond.id))
                        //{
                            MessageBox.Show("Register added with success!");
                            status = true;
                        //}
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

        public bool EditFromDB(ServiceOrders obj)
        {
            bool status = false;

            string sql = "UPDATE SERVICEORDERS SET EXTRA_DETAILS = @DETAILS, SO_COST = @COST, SO_VALUE = @VALUE," +
                " SO_COMPLETEDATE = @COMPLETEDATE , SO_DISCOUNT_CASH = @DISCCASH, SO_DISCOUNT_PERC = @DISCPERC," +
                " SO_CANCELDATE = @CANCELDATE, DATE_LAST_UPDATE = @DU " +
                "WHERE ID_SERVICEORDER = @ID ; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@DETAILS", obj.ExtraDetails);
                    command.Parameters.AddWithValue("@COST", (decimal)obj.ServiceCost);
                    command.Parameters.AddWithValue("@VALUE", (decimal)obj.OSTotalValue);
                    command.Parameters.AddWithValue("@COMPLETEDATE", obj.CompleteDate);
                    command.Parameters.AddWithValue("@DISCCASH", (decimal)obj.ServiceDiscountCash);
                    command.Parameters.AddWithValue("@DISCPERC", (decimal)obj.ServiceDiscountPerc);
                    command.Parameters.AddWithValue("@CANCELDATE", obj.CancelDate);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        //if (EditInstalmentsToDb(cond.BillsInstalments, cond.id))
                        //{
                        MessageBox.Show("Register altered with success!");
                        status = true;
                        //}
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public bool DeleteFromDb(int id)
        {
            bool status = false;
            string sql = "DELETE FROM SERVICEORDERS WHERE ID_SERVICEORDER = @ID ;";
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

        public ServiceOrders SelectFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SERVICEORDERS WHERE ID_SERVICEORDER = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ServiceOrders obj = new ServiceOrders()
                                {
                                    id = id,
                                    User = _usersController.FindItemId(Convert.ToInt32(reader["user_id"])),
                                    Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                    Service = _serviceController.FindItemId(Convert.ToInt32(reader["service_id"])),
                                    OSTotalValue = Convert.ToDouble(reader["so_value"]),
                                    ServiceCost = Convert.ToDouble(reader["so_cost"]),
                                    ServiceDiscountCash = Convert.ToDouble(reader["so_discount_cash"]),
                                    ServiceDiscountPerc = Convert.ToDouble(reader["so_discount_perc"]),
                                    CompleteDate = Convert.ToDateTime(reader["so_completedate"]),
                                    CancelDate = Convert.ToDateTime(reader["so_canceldate"]),
                                    ExtraDetails = reader["extra_details"].ToString(),
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

        public List<ServiceOrders> SelectClientFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SERVICEORDERS WHERE CLIENT_ID = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<ServiceOrders> list = new List<ServiceOrders>();
                                foreach (ServiceOrders item in reader)
                                {
                                    ServiceOrders obj = new ServiceOrders()
                                    {
                                        id = id,
                                        User = _usersController.FindItemId(Convert.ToInt32(reader["user_id"])),
                                        Client = _clientsController.FindItemId(id),
                                        Service = _serviceController.FindItemId(Convert.ToInt32(reader["service_id"])),
                                        OSTotalValue = Convert.ToDouble(reader["so_value"]),
                                        ServiceCost = Convert.ToDouble(reader["so_cost"]),
                                        ServiceDiscountCash = Convert.ToDouble(reader["so_discount_cash"]),
                                        ServiceDiscountPerc = Convert.ToDouble(reader["so_discount_perc"]),
                                        CompleteDate = Convert.ToDateTime(reader["so_completedate"]),
                                        CancelDate = Convert.ToDateTime(reader["so_canceldate"]),
                                        ExtraDetails = reader["extra_details"].ToString(),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
                                    };
                                    list.Add(obj);
                                }
                                return list;
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

        public List<ServiceOrders> SelectServiceFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SERVICEORDERS AS S JOIN SERVICES E ON S.ID_SO = E.ID_SERVICE AND S.SERVICE_ID = @ID ;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<ServiceOrders> list = new List<ServiceOrders>();
                                foreach (ServiceOrders item in reader)
                                {
                                    ServiceOrders obj = new ServiceOrders()
                                    {
                                        id = Convert.ToInt32(reader["id_serviceorder"]),
                                        User = _usersController.FindItemId(Convert.ToInt32(reader["user_id"])),
                                        Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                        Service = _serviceController.FindItemId(Convert.ToInt32(reader["service_id"])),
                                        OSTotalValue = Convert.ToDouble(reader["so_value"]),
                                        ServiceCost = Convert.ToDouble(reader["so_cost"]),
                                        ServiceDiscountCash = Convert.ToDouble(reader["so_discount_cash"]),
                                        ServiceDiscountPerc = Convert.ToDouble(reader["so_discount_perc"]),
                                        CompleteDate = Convert.ToDateTime(reader["so_completedate"]),
                                        CancelDate = Convert.ToDateTime(reader["so_canceldate"]),
                                        ExtraDetails = reader["extra_details"].ToString(),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
                                    };
                                    list.Add(obj);
                                }
                                return list;
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

        public List<ServiceOrders> SelectServiceFromDb(string serviceName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SERVICEORDERS AS S JOIN SERVICES E ON S.ID_SO = E.ID_SERVICE AND S.DESC_SERVICE =  @SERVICENAME  ;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@SERVICENAME", serviceName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<ServiceOrders> list = new List<ServiceOrders>();
                                foreach (ServiceOrders item in reader)
                                {
                                    ServiceOrders obj = new ServiceOrders()
                                    {
                                        id = Convert.ToInt32(reader["id_serviceorder"]),
                                        User = _usersController.FindItemId(Convert.ToInt32(reader["user_id"])),
                                        Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                        Service = _serviceController.FindItemId(Convert.ToInt32(reader["service_id"])),
                                        OSTotalValue = Convert.ToDouble(reader["so_value"]),
                                        ServiceCost = Convert.ToDouble(reader["so_cost"]),
                                        ServiceDiscountCash = Convert.ToDouble(reader["so_discount_cash"]),
                                        ServiceDiscountPerc = Convert.ToDouble(reader["so_discount_perc"]),
                                        CompleteDate = Convert.ToDateTime(reader["so_completedate"]),
                                        CancelDate = Convert.ToDateTime(reader["so_canceldate"]),
                                        ExtraDetails = reader["extra_details"].ToString(),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
                                    };
                                    list.Add(obj);
                                }
                                return list;
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

        public List<ServiceOrders> SelectDateTimeFromDb(DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SERVICEORDERS WHERE SO_DATETIME >= @DATE ;"; 
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@DATE", date);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<ServiceOrders> list = new List<ServiceOrders>();
                                foreach (ServiceOrders item in reader)
                                {
                                    ServiceOrders obj = new ServiceOrders()
                                    {
                                        id = Convert.ToInt32(reader["id_serviceorder"]),
                                        User = _usersController.FindItemId(Convert.ToInt32(reader["user_id"])),
                                        Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                        Service = _serviceController.FindItemId(Convert.ToInt32(reader["service_id"])),
                                        OSTotalValue = Convert.ToDouble(reader["so_value"]),
                                        ServiceCost = Convert.ToDouble(reader["so_cost"]),
                                        ServiceDiscountCash = Convert.ToDouble(reader["so_discount_cash"]),
                                        ServiceDiscountPerc = Convert.ToDouble(reader["so_discount_perc"]),
                                        CompleteDate = Convert.ToDateTime(reader["so_completedate"]),
                                        CancelDate = Convert.ToDateTime(reader["so_canceldate"]),
                                        ExtraDetails = reader["extra_details"].ToString(),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
                                    };
                                    list.Add(obj);
                                }
                                return list;
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

        public List<ServiceOrders> SelectAllFromDb()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SERVICEORDERS ;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<ServiceOrders> list = new List<ServiceOrders>();
                                foreach (ServiceOrders item in reader)
                                {
                                    ServiceOrders obj = new ServiceOrders()
                                    {
                                        id = Convert.ToInt32(reader["id_serviceorder"]),
                                        User = _usersController.FindItemId(Convert.ToInt32(reader["user_id"])),
                                        Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                        Service = _serviceController.FindItemId(Convert.ToInt32(reader["service_id"])),
                                        OSTotalValue = Convert.ToDouble(reader["so_value"]),
                                        ServiceCost = Convert.ToDouble(reader["so_cost"]),
                                        ServiceDiscountCash = Convert.ToDouble(reader["so_discount_cash"]),
                                        ServiceDiscountPerc = Convert.ToDouble(reader["so_discount_perc"]),
                                        CompleteDate = Convert.ToDateTime(reader["so_completedate"]),
                                        CancelDate = Convert.ToDateTime(reader["so_canceldate"]),
                                        ExtraDetails = reader["extra_details"].ToString(),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
                                    };
                                    list.Add(obj);
                                }
                                return list;
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

        public DataTable SelectDataSourceFromDB() 
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
