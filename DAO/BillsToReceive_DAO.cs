using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public class BillsToReceive_DAO
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private readonly BillsInstalments_Controller _billsInstalmentsController = new BillsInstalments_Controller();
        private readonly PaymentConditions_Controller _paymentConditionsController = new PaymentConditions_Controller();
        private readonly Clients_Controller _clientsController = new Clients_Controller();
        private readonly Sales_Controller _salesController = new Sales_Controller();

        public bool SaveToDb(BillsToReceive obj)
        {
            bool status = false;

            string sql = "INSERT INTO BILLSTOPAY ( SALE_ID, INSTALMENTVALUE, ISPAID, CLIENT_ID, PAYCONDITION_ID, INSTALMENTNUMBER, " +
                "INSTALMENTSQTD, DUEDATE, EMISSIONDATE, DATE_CREATION, DATE_LAST_UPDATE ) "
                         + " VALUES (@SALEID, @IVALUE, @ISPAID, @CLIENTID, @CONDID, @INUM, @IQTD, @DUEDATE, @EMDATE, @DC, @DU);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ISPAID", obj.IsPaid);
                    command.Parameters.AddWithValue("@CLIENTID", obj.Client.id);
                    command.Parameters.AddWithValue("@SALEID", obj.Sale.id);
                    command.Parameters.AddWithValue("@CONDID", obj.PayCondition.id);
                    command.Parameters.AddWithValue("@INUM", obj.InstalmentNumber);
                    command.Parameters.AddWithValue("@IQTD", obj.InstalmentsQtd);
                    command.Parameters.AddWithValue("@IVALUE", obj.InstalmentValue);
                    command.Parameters.AddWithValue("@EMDATE", obj.EmissionDate);
                    command.Parameters.AddWithValue("@DUEDATE", obj.DueDate);
                    command.Parameters.AddWithValue("@PAIDDATE", obj.PaidDate);
                    command.Parameters.AddWithValue("@DC", obj.dateOfCreation);
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

        public bool EditFromDB(BillsToReceive obj)
        {
            bool status = false;

            string sql = "UPDATE BILLSTORECEIVE SET INSTALMENTVALUE = @IVALUE, ISPAID = @ISPAID, CLIENT_ID = @CLIENTID," +
                " PAYCONDITION_ID = @CONDID, INSTALMENTSQTD = @IQTD, DUEDATE = @DUEDATE, EMISSIONDATE = @EMDATE, DATE_LAST_UPDATE = @DU " +
                "WHERE SALEID = @SALEID AND INSTALMENTNUMBER = @INUM; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ISPAID", obj.IsPaid);
                    command.Parameters.AddWithValue("@CLIENTID", obj.Client.id);
                    command.Parameters.AddWithValue("@SALEID", obj.Sale.id);
                    command.Parameters.AddWithValue("@CONDID", obj.PayCondition.id);
                    command.Parameters.AddWithValue("@INUM", obj.InstalmentNumber);
                    command.Parameters.AddWithValue("@IQTD", obj.InstalmentsQtd);
                    command.Parameters.AddWithValue("@IVALUE", obj.InstalmentValue);
                    command.Parameters.AddWithValue("@EMDATE", obj.EmissionDate);
                    command.Parameters.AddWithValue("@DUEDATE", obj.DueDate);
                    command.Parameters.AddWithValue("@PAIDDATE", obj.PaidDate);
                    command.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
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

        public bool DeleteFromDb(int saleId, int InstalmentQtd)
        {
            bool status = false;
            string sql = "DELETE FROM BILLSTORECEIVE WHERE SALE_ID = @SALEID AND INSTALMENTNUMBER = @IQTD ;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@SALEID", saleId);
                    command.Parameters.AddWithValue("@IQTD", InstalmentQtd);
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

        public BillsToReceive SelectFromDb(int saleId, int InstalmentQtd)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BILLSTORECEIVE WHERE SALE_ID = @SALEID AND INSTALMENTNUMBER = @IQTD ; ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@SALEID", saleId);
                        command.Parameters.AddWithValue("@IQTD", InstalmentQtd);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                BillsToReceive obj = new BillsToReceive()
                                {
                                    id = Convert.ToInt32(reader["sale_id"]),
                                    Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                    Sale = _salesController.FindItemId(Convert.ToInt32(reader["sale_id"])),
                                    IsPaid = Convert.ToBoolean(reader["isPaid"]),
                                    PaidDate = Convert.ToDateTime(reader["paidDate"]),
                                    DueDate = Convert.ToDateTime(reader["dueDate"]),
                                    EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                    InstalmentNumber = Convert.ToInt32(reader["instalmentNumber"]),
                                    InstalmentValue = Convert.ToDouble(reader["instalmentValue"]),
                                    PayCondition = _paymentConditionsController.FindItemId(Convert.ToInt32(reader["paycondition_id"])),
                                    InstalmentsQtd = Convert.ToInt32(reader["instalmentsQtd"]),
                                    dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                    dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]),
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

        public List<BillsToReceive> SelectSaleFromDb(int saleId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BILLSTORECEIVE WHERE SALE_ID = @SALEID ; ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@SALEID", saleId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<BillsToReceive> list = new List<BillsToReceive>();
                                foreach (DataRow row in reader)
                                {
                                    BillsToReceive obj = new BillsToReceive()
                                    {
                                        id = Convert.ToInt32(reader["sale_id"]),
                                        Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                        Sale = _salesController.FindItemId(Convert.ToInt32(reader["sale_id"])),
                                        IsPaid = Convert.ToBoolean(reader["isPaid"]),
                                        PaidDate = Convert.ToDateTime(reader["paidDate"]),
                                        DueDate = Convert.ToDateTime(reader["dueDate"]),
                                        EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                        InstalmentNumber = Convert.ToInt32(reader["instalmentNumber"]),
                                        InstalmentValue = Convert.ToDouble(reader["instalmentValue"]),
                                        PayCondition = _paymentConditionsController.FindItemId(Convert.ToInt32(reader["paycondition_id"])),
                                        InstalmentsQtd = Convert.ToInt32(reader["instalmentsQtd"]),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]),
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

        public List<BillsToReceive> SelectClientFromDb(int clientId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BILLSTORECEIVE WHERE CLIENT_ID = @CLIENTID ; ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CLIENTID", clientId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<BillsToReceive> list = new List<BillsToReceive>();
                                foreach (DataRow row in reader)
                                {
                                    BillsToReceive obj = new BillsToReceive()
                                    {
                                        id = Convert.ToInt32(reader["sale_id"]),
                                        Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                        Sale = _salesController.FindItemId(Convert.ToInt32(reader["sale_id"])),
                                        IsPaid = Convert.ToBoolean(reader["isPaid"]),
                                        PaidDate = Convert.ToDateTime(reader["paidDate"]),
                                        DueDate = Convert.ToDateTime(reader["dueDate"]),
                                        EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                        InstalmentNumber = Convert.ToInt32(reader["instalmentNumber"]),
                                        InstalmentValue = Convert.ToDouble(reader["instalmentValue"]),
                                        PayCondition = _paymentConditionsController.FindItemId(Convert.ToInt32(reader["paycondition_id"])),
                                        InstalmentsQtd = Convert.ToInt32(reader["instalmentsQtd"]),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]),
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

        public List<BillsToReceive> SelectAllFromDb()
        {
            string sql = "SELECT * FROM BILLSTORECEIVE ;";
            List<BillsToReceive> bill = null;
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
                        bill = new List<BillsToReceive>();
                        foreach (BillsToReceive item in reader)
                        {
                            bill.Add(item);
                        }
                    }
                    else
                    {
                        bill = null;
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
            return bill;
        }

        public List<BillsToReceive> SelectIsPaidFromDb(bool isPaid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BILLSTORECEIVE WHERE ISPAID = @ISPAID ; ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ISPAID", isPaid);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<BillsToReceive> list = new List<BillsToReceive>();
                                foreach (DataRow row in reader)
                                {
                                    BillsToReceive obj = new BillsToReceive()
                                    {
                                        id = Convert.ToInt32(reader["sale_id"]),
                                        Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                        Sale = _salesController.FindItemId(Convert.ToInt32(reader["sale_id"])),
                                        IsPaid = Convert.ToBoolean(reader["isPaid"]),
                                        PaidDate = Convert.ToDateTime(reader["paidDate"]),
                                        DueDate = Convert.ToDateTime(reader["dueDate"]),
                                        EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                        InstalmentNumber = Convert.ToInt32(reader["instalmentNumber"]),
                                        InstalmentValue = Convert.ToDouble(reader["instalmentValue"]),
                                        PayCondition = _paymentConditionsController.FindItemId(Convert.ToInt32(reader["paycondition_id"])),
                                        InstalmentsQtd = Convert.ToInt32(reader["instalmentsQtd"]),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]),
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

        public List<BillsToReceive> SelectDueDateFromDb(DateTime dueDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BILLSTORECEIVE WHERE DUEDATE => @DUEDATE ; ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@DUEDATE", dueDate);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<BillsToReceive> list = new List<BillsToReceive>();
                                foreach (DataRow row in reader)
                                {
                                    BillsToReceive obj = new BillsToReceive()
                                    {
                                        id = Convert.ToInt32(reader["sale_id"]),
                                        Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                        Sale = _salesController.FindItemId(Convert.ToInt32(reader["sale_id"])),
                                        IsPaid = Convert.ToBoolean(reader["isPaid"]),
                                        PaidDate = Convert.ToDateTime(reader["paidDate"]),
                                        DueDate = Convert.ToDateTime(reader["dueDate"]),
                                        EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                        InstalmentNumber = Convert.ToInt32(reader["instalmentNumber"]),
                                        InstalmentValue = Convert.ToDouble(reader["instalmentValue"]),
                                        PayCondition = _paymentConditionsController.FindItemId(Convert.ToInt32(reader["paycondition_id"])),
                                        InstalmentsQtd = Convert.ToInt32(reader["instalmentsQtd"]),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]),
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

