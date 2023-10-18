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
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private readonly BillsInstalments_Controller _billsInstalmentsController = new BillsInstalments_Controller();
        private readonly PaymentMethods_Controller _paymentMethodsController = new PaymentMethods_Controller();
        private readonly Clients_Controller _clientsController = new Clients_Controller();
        private readonly Sales_Controller _salesController = new Sales_Controller();
        private readonly PaymentConditions_Controller _pcController = new PaymentConditions_Controller();
        private readonly Users_Controller _userController = new Users_Controller();

        public int GetNewId()
        {
            string sql = "SELECT MAX(ID_BILL) FROM BILLSTORECEIVE;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                string i = command.ExecuteScalar().ToString();
                connection.Close();
                if (i == "")
                {
                    return 1;
                }
                return Convert.ToInt32(i)+1;
            }
        }

        public bool SaveToDb(BillsToReceive obj)
        {
            bool status = false;

            string sql = "INSERT INTO BILLSTORECEIVE (ID_BILL, SALE_ID, INSTALMENTVALUE, ISPAID, CLIENT_ID, PAYMETHOD_ID, INSTALMENTNUMBER, " +
                "INSTALMENTSQTD, DUEDATE, EMISSIONDATE, PAIDDATE, DATE_CREATION, DATE_LAST_UPDATE, DATE_CANCELLED, PAYCOND_ID, USER_ID ) "
                         + " VALUES (@BILLID, @SALEID, @IVALUE, @ISPAID, @CLIENTID, @METHODID, @INUM, @IQTD, @DUEDATE, @EMDATE, @PDATE, @DC, @DU, @DCANCEL, @PAYCONDID, @USERID);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@BILLID", obj.id);
                    command.Parameters.AddWithValue("@ISPAID", obj.IsPaid);
                    command.Parameters.AddWithValue("@CLIENTID", obj.Client.id);
                    command.Parameters.AddWithValue("@SALEID", obj.Sale.id);
                    command.Parameters.AddWithValue("@METHODID", obj.PaymentMethod.id);
                    command.Parameters.AddWithValue("@INUM", obj.InstalmentNumber);
                    command.Parameters.AddWithValue("@IQTD", obj.InstalmentsQtd);
                    command.Parameters.AddWithValue("@IVALUE", obj.InstalmentValue);
                    command.Parameters.AddWithValue("@EMDATE", obj.EmissionDate);
                    command.Parameters.AddWithValue("@PAYCONDID", obj.PaymentCondition.id);
                    command.Parameters.AddWithValue("@DUEDATE", obj.DueDate);
                    command.Parameters.AddWithValue("@USERID", obj.User.id);
                    if (obj.PaidDate.HasValue)
                    {
                        command.Parameters.AddWithValue("@PDATE", obj.PaidDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@PDATE", DBNull.Value);
                    }
                    if (obj.CancelledDate.HasValue)
                    {
                        command.Parameters.AddWithValue("@DCANCEL", obj.CancelledDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@DCANCEL", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
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

        public BillsToReceive SelectFromDb(int billId, int instalmentNum)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BILLSTORECEIVE WHERE ID_BILL = @BILLID AND INSTALMENTNUMBER = @INSTALMENT ; ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@BILLID", billId);
                        command.Parameters.AddWithValue("@INSTALMENT", instalmentNum);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DateTime? cancelDate;
                                DateTime? paidDate;
                                if (reader["paidDate"] == DBNull.Value)
                                {
                                    paidDate = null;
                                }
                                else
                                {
                                    paidDate = Convert.ToDateTime(reader["paidDate"].ToString());
                                }

                                if (reader["DATE_CANCELLED"] == DBNull.Value)
                                {
                                    cancelDate = null;
                                }
                                else
                                {
                                    cancelDate = Convert.ToDateTime(reader["DATE_CANCELLED"].ToString());
                                }
                                BillsToReceive obj = new BillsToReceive()
                                {
                                    id = Convert.ToInt32(reader["id_bill"]),
                                    Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                    Sale = null,
                                    IsPaid = Convert.ToBoolean(reader["isPaid"]),
                                    PaidDate = paidDate,
                                    CancelledDate = cancelDate,
                                    DueDate = Convert.ToDateTime(reader["dueDate"]),
                                    EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                    InstalmentNumber = Convert.ToInt32(reader["instalmentNumber"]),
                                    InstalmentValue = Convert.ToDecimal(reader["instalmentValue"]),
                                    PaymentMethod = _paymentMethodsController.FindItemId(Convert.ToInt32(reader["payMethod_id"])),
                                    PaymentCondition = _pcController.FindItemId(Convert.ToInt32(reader["payCond_id"])),
                                    InstalmentsQtd = Convert.ToInt32(reader["instalmentsQtd"]),
                                    dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                    dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]),
                                    User = _userController.FindItemId(Convert.ToInt32(reader["user_id"])),
                                    CancelMotive = reader["motive_cancelled"].ToString()
                                };
                                if (Convert.ToInt32(reader["sale_id"]) != 0)
                                {
                                    obj.Sale = _salesController.FindItemId(Convert.ToInt32(reader["sale_id"]));
                                }
                                else
                                {
                                    obj.Sale = new Sales();
                                    obj.Sale.id = 0;
                                }
                                return obj;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }

        public List<BillsToReceive> SelectFromDb(int billId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BILLSTORECEIVE WHERE id_bill = @ID ; ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", billId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                List<BillsToReceive> list = new List<BillsToReceive>();
                                foreach (var row in reader)
                                {
                                    BillsToReceive obj = new BillsToReceive()
                                    {
                                        id = Convert.ToInt32(reader["id_bill"]),
                                        Sale = null,
                                        InstalmentNumber = Convert.ToInt32(reader["instalmentNumber"]),
                                        InstalmentValue = Convert.ToDecimal(reader["instalmentValue"]),
                                        PaidDate = null,
                                        Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                        PaymentMethod = _paymentMethodsController.FindItemId(Convert.ToInt32(reader["payMethod_id"])),
                                        PaymentCondition = _pcController.FindItemId(Convert.ToInt32(reader["payCond_id"])),
                                        InstalmentsQtd = Convert.ToInt32(reader["instalmentsQtd"]),
                                        DueDate = Convert.ToDateTime(reader["dueDate"]),
                                        EmissionDate = Convert.ToDateTime(reader["emissionDate"]),                                                                                                                                                                                                      
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        CancelledDate = null,
                                        CancelMotive = reader["motive_cancelled"].ToString(),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]),                                        
                                        User = _userController.FindItemId(Convert.ToInt32(reader["user_id"])),                                       
                                    };
                                    if (Convert.ToInt32(reader["sale_id"]) > 0)
                                    {
                                        obj.Sale = _salesController.FindItemId(Convert.ToInt32(reader["sale_id"]));
                                    }
                                    else
                                    {
                                        obj.Sale = new Sales();
                                        obj.Sale.id = 0;
                                    }
                                    if (reader["paidDate"] != DBNull.Value)
                                    {
                                        obj.PaidDate = Convert.ToDateTime(reader["paidDate"]);
                                    }
                                    if (reader["date_cancelled"] != DBNull.Value)
                                    {
                                        obj.CancelledDate = Convert.ToDateTime(reader["date_cancelled"]);
                                    }
                                    list.Add(obj);
                                }                              
                                return list;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
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
                                foreach (var row in reader)
                                {
                                    BillsToReceive obj = new BillsToReceive()
                                    {
                                        id = Convert.ToInt32(reader["id_bill"]),
                                        Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                        Sale = _salesController.FindItemId(Convert.ToInt32(reader["sale_id"])),
                                        //IsPaid = Convert.ToBoolean(reader["isPaid"]),
                                        PaidDate = null,
                                        DueDate = Convert.ToDateTime(reader["dueDate"]),
                                        EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                        InstalmentNumber = Convert.ToInt32(reader["instalmentNumber"]),
                                        InstalmentValue = Convert.ToDecimal(reader["instalmentValue"]),
                                        PaymentMethod = _paymentMethodsController.FindItemId(Convert.ToInt32(reader["payMethod_id"])),
                                        InstalmentsQtd = Convert.ToInt32(reader["instalmentsQtd"]),
                                        PaymentCondition = _pcController.FindItemId(Convert.ToInt32(reader["payCond_id"])),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]),
                                        CancelledDate = null,
                                        CancelMotive = reader["motive_cancelled"].ToString(),
                                        User = _userController.FindItemId(Convert.ToInt32(reader["user_id"]))
                                    };
                                    if (reader["paidDate"] != DBNull.Value)
                                    {
                                        obj.PaidDate = Convert.ToDateTime(reader["paidDate"]);
                                    }
                                    if (reader["date_cancelled"] != DBNull.Value)
                                    {
                                        obj.CancelledDate = Convert.ToDateTime(reader["date_cancelled"]);
                                    }
                                    list.Add(obj);
                                }
                                return list;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
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
                                        id = Convert.ToInt32(reader["id_bill"]),
                                        Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                        Sale = null,
                                        IsPaid = Convert.ToBoolean(reader["isPaid"]),
                                        PaidDate = Convert.ToDateTime(reader["paidDate"]),
                                        DueDate = Convert.ToDateTime(reader["dueDate"]),
                                        EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                        InstalmentNumber = Convert.ToInt32(reader["instalmentNumber"]),
                                        InstalmentValue = Convert.ToDecimal(reader["instalmentValue"]),
                                        PaymentMethod = _paymentMethodsController.FindItemId(Convert.ToInt32(reader["payMethod_id"])),
                                        InstalmentsQtd = Convert.ToInt32(reader["instalmentsQtd"]),
                                        PaymentCondition = _pcController.FindItemId(Convert.ToInt32(reader["payCond_id"])),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]),
                                        CancelMotive = reader["motive_cancelled"].ToString(),
                                        User = _userController.FindItemId(Convert.ToInt32(reader["user_id"]))
                                    };
                                    if (Convert.ToInt32(reader["sale_id"]) > 0)
                                    {
                                        obj.Sale = _salesController.FindItemId(Convert.ToInt32(reader["sale_id"]));
                                    }
                                    else
                                    {
                                        obj.Sale = new Sales();
                                        obj.Sale.id = 0;
                                    }
                                    if (reader["date_cancelled"] != DBNull.Value)
                                    {
                                        obj.CancelledDate = (DateTime)reader["date_cancelled"];
                                    }
                                    if (reader["paidDate"] != DBNull.Value)
                                    {
                                        obj.PaidDate = (DateTime)reader["paidDate"];
                                    }

                                    list.Add(obj);
                                }
                                return list;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
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
                MessageBox.Show("Erro : " + ex.Message);
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
                                        id = Convert.ToInt32(reader["id_bill"]),
                                        Client = _clientsController.FindItemId(Convert.ToInt32(reader["client_id"])),
                                        Sale = _salesController.FindItemId(Convert.ToInt32(reader["sale_id"])),
                                        IsPaid = Convert.ToBoolean(reader["isPaid"]),
                                        PaidDate = Convert.ToDateTime(reader["paidDate"]),
                                        DueDate = Convert.ToDateTime(reader["dueDate"]),
                                        EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                        InstalmentNumber = Convert.ToInt32(reader["instalmentNumber"]),
                                        InstalmentValue = Convert.ToDecimal(reader["instalmentValue"]),
                                        PaymentCondition = _pcController.FindItemId(Convert.ToInt32(reader["payCond_id"])),
                                        PaymentMethod = _paymentMethodsController.FindItemId(Convert.ToInt32(reader["payMethod_id"])),
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
                    MessageBox.Show("Erro : " + ex.Message);
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
                                        InstalmentValue = Convert.ToDecimal(reader["instalmentValue"]),
                                        PaymentCondition = _pcController.FindItemId(Convert.ToInt32(reader["payCond_id"])),
                                        PaymentMethod = _paymentMethodsController.FindItemId(Convert.ToInt32(reader["payMethod_id"])),
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
                    MessageBox.Show("Erro : " + ex.Message);
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
                MessageBox.Show("Erro : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool CancelBillsFromDb(int id, int userId)
        {
            {
                bool status = false;

                string sql = "UPDATE BILLSTORECEIVE SET DATE_CANCELLED = @CANCELDATE, USER_ID = @USERID " +
                    "WHERE SALE_ID = @SALEID; ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@CANCELDATE", DateTime.Today.Date);
                        command.Parameters.AddWithValue("@SALEID", id);
                        command.Parameters.AddWithValue("@USERID", userId);
                        connection.Open();
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
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

        public bool SetPaidBillsFromDb(int id, int userId)
        {
            {
                bool status = false;

                string sql = "UPDATE BILLSTORECEIVE SET PAIDDATE = @PAIDDATE, ISPAID = 1, USER_ID = @USERID " +
                    "WHERE ID_BILL = @ID; ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@PAIDDATE", DateTime.Today.Date);
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@USERID", userId);
                        connection.Open();
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
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

        internal bool PayBill(BillsToReceive obj)
        {
            {
                bool status = false;

                string sql = "UPDATE BILLSTORECEIVE SET PAIDDATE = @PAIDDATE, ISPAID = 1, USER_ID = @USERID, DATE_LAST_UPDATE = @UPDATE " +
                    "WHERE ID_BILL = @ID AND INSTALMENTNUMBER = @INUM; ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@PAIDDATE", (DateTime)obj.PaidDate);
                        command.Parameters.AddWithValue("@ID", obj.id);
                        command.Parameters.AddWithValue("@UPDATE", DateTime.Today.Date);
                        command.Parameters.AddWithValue("@INUM", obj.InstalmentNumber);
                        command.Parameters.AddWithValue("@USERID", obj.User.id);
                        connection.Open();
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
                            status = true;
                            MessageBox.Show("Conta paga com sucesso.");
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

        internal bool CancelBill(BillsToReceive obj)
        {
            {
                bool status = false;

                string sql = "UPDATE BILLSTORECEIVE SET DATE_CANCELLED = @CANCEL, ISPAID = 2, MOTIVE_CANCELLED = @MOTIVE, DATE_LAST_UPDATE = @UPDATE, USER_ID = @USERID " +
                    "WHERE ID_BILL = @ID; ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@MOTIVE", obj.CancelMotive);
                        command.Parameters.AddWithValue("@UPDATE", DateTime.Today.Date);
                        command.Parameters.AddWithValue("@CANCEL", DateTime.Today.Date);
                        command.Parameters.AddWithValue("@ID", obj.id);
                        command.Parameters.AddWithValue("@USERID", obj.User.id);
                        connection.Open();
                        int i = command.ExecuteNonQuery();
                        if (i > 0)
                        {
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
}

