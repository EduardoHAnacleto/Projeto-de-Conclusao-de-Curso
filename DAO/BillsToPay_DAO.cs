﻿using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using System.Configuration;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using System.Drawing.Drawing2D;

namespace ProjetoEduardoAnacletoWindowsForm1.DAO
{
    public class BillsToPay_DAO //TO DO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private readonly BillsInstalments_Controller _billsInstalmentsController = new BillsInstalments_Controller();
        private readonly PaymentConditions_Controller _paymentConditionsController = new PaymentConditions_Controller();
        private readonly PaymentMethods_Controller _paymentMethodsController = new PaymentMethods_Controller();
        private readonly Suppliers_Controller _suppliersController = new Suppliers_Controller();
        //private readonly Purchases_Controller _purchasesController = new Purchases_Controller();


        public bool SaveToDb(BillsToPay obj)
        {
            bool status = false;

            string sql = "INSERT INTO BILLSTOPAY ( BILLNUMBER, BILLSERIES, BILLMODEL, INSTALMENTNUMBER, DUEDATE, billStatus, PAIDDATE," +
                "BILLVALUE, PAYMETHOD_ID, SUPPLIER_ID, EMISSIONDATE, DATE_CREATION, DATE_LAST_UPDATE, PAYCOND_ID, USER_ID ) "
                         + " VALUES (@BNUMBER, @BSERIES, @BMODEL, @INUMBER, @DUEDATE, @billStatus, @PDATE, @BVALUE, @METHODID, " +
                         " @SUPPLIERID, @EMISSIONDATE, @DC, @DU, @PAYCONDID, @USERID);";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@BNUMBER", obj.BillNumber);
                    command.Parameters.AddWithValue("@BSERIES", obj.BillSeries);
                    command.Parameters.AddWithValue("@BMODEL", obj.BillModel);
                    command.Parameters.AddWithValue("@INUMBER", obj.InstalmentNumber);
                    command.Parameters.AddWithValue("@DUEDATE", obj.DueDate);
                    command.Parameters.AddWithValue("@EMISSIONDATE", obj.EmissionDate);
                    command.Parameters.AddWithValue("@PAYCONDID", obj.PaymentCondition.id);
                    command.Parameters.AddWithValue("@billStatus", obj.Status);
                    command.Parameters.AddWithValue("@USERID", obj.User.id);
                    if (obj.PaidDate.HasValue)
                    {
                        command.Parameters.AddWithValue("@PDATE", obj.PaidDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@PDATE", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@BVALUE", (decimal)obj.TotalValue);
                    command.Parameters.AddWithValue("@METHODID", obj.PaymentMethod.id);
                    command.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
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

        public bool EditFromDB(BillsToPay obj)
        {
            bool status = false;

            string sql = "UPDATE BILLSTOPAY SET DUEDATE = @DDATE, billStatus = @billStatus, PAIDDATE = @PDATE, BILLVALUE = @BVALUE, PAYMETHOD_ID = @METHODID, " +
                " EMISSIONDATE = @EMISSIONDATE, DATE_LAST_UPDATE = @DU " +
                "WHERE BILLNUMBER = @BNUMBER AND BILLSERIES = @BSERIES AND BILLMODEL = @BMODEL AND INSTALMENTNUMBER = @INUMBER AND SUPPLIER_ID = @SUPPLIERID; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@DDATE", obj.DueDate);
                    command.Parameters.AddWithValue("@billStatus", obj.Status);
                    if (obj.PaidDate.HasValue)
                    {
                        command.Parameters.AddWithValue("@PDATE", obj.PaidDate);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@PDATE", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@BVALUE", obj.TotalValue);
                    command.Parameters.AddWithValue("@METHODID", obj.PaymentMethod.id);
                    command.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
                    command.Parameters.AddWithValue("@BNUMBER", obj.BillNumber);
                    command.Parameters.AddWithValue("@EMISSIONDATE", obj.EmissionDate);
                    command.Parameters.AddWithValue("@BSERIES", obj.BillSeries);
                    command.Parameters.AddWithValue("@BMODEL", obj.BillModel);
                    command.Parameters.AddWithValue("@INUMBER", obj.InstalmentNumber);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro alterado com sucesso.");
                        status = true;
                    }

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547 || ex.Number == 2061)
                    {
                        MessageBox.Show("Não é possível apagar esse registro pois ele está ligado a outro registro.", "Não é possível apagar registro.");
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public bool DeleteFromDb(int billNumber, int billModel, int billSeries, int instalmentNumber, int supplierId)
        {
            bool status = false;
            string sql = "DELETE FROM BILLSTOPAY WHERE BILLNUMBER = @BNUM AND BILLMODEL = @BMODEL AND BILLSERIES = @BSERIES " +
                "AND INSTALMENTNUMBER = @INUM AND SUPPLIER_ID = @SUPPLIERID ;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@BNUM", billNumber);
                    command.Parameters.AddWithValue("@BMODEL", billModel);
                    command.Parameters.AddWithValue("@BSERIES", billSeries);
                    command.Parameters.AddWithValue("@INUM", instalmentNumber);
                    command.Parameters.AddWithValue("@SUPPLIERID", supplierId);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro apagado com sucesso.");
                        status = true;
                    }

                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547 || ex.Number == 2061)
                    {
                        MessageBox.Show("Não é possível apagar esse registro pois ele está ligado a outro registro.", "Não é possível apagar registro.");
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }

        public List<BillsToPay> SelectFromDb(int billNumber, int billModel, int billSeries, int supplierId)
        {
            var list = new List<BillsToPay>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BILLSTOPAY WHERE BILLNUMBER = @BNUM AND BILLMODEL = @BMODEL AND BILLSERIES = @BSERIES " +
                        " AND SUPPLIER_ID = @SUPPLIERID ;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@BNUM", billNumber);
                        command.Parameters.AddWithValue("BMODEL", billModel);
                        command.Parameters.AddWithValue("BSERIES", billSeries);
                        command.Parameters.AddWithValue("@SUPPLIERID", supplierId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                foreach (var row in reader)
                                {
                                    BillsToPay obj = new BillsToPay()
                                    {
                                        BillNumber = billNumber,
                                        BillModel = billModel,
                                        BillSeries = billSeries,
                                        InstalmentNumber = Convert.ToInt32(reader["instalmentNumber"]),

                                        Status = Convert.ToInt32(reader["billStatus"]),
                                        TotalValue = Convert.ToDecimal(reader["BillValue"]),
                                        DueDate = Convert.ToDateTime(reader["dueDate"]),
                                        EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                        Supplier = _suppliersController.FindItemId(Convert.ToInt32(reader["supplier_id"])),

                                        PaymentCondition = _paymentConditionsController.FindItemId(Convert.ToInt32(reader["payCond_id"])),
                                        PaymentMethod = _paymentMethodsController.FindItemId(Convert.ToInt32(reader["payMethod_id"])),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]),
                                    };
                                    if (reader["paidDate"] == DBNull.Value)
                                    {
                                        obj.PaidDate = null;
                                    }
                                    else
                                    {
                                        obj.PaidDate = Convert.ToDateTime(reader["paidDate"]);
                                    }
                                    if (reader["date_cancelled"] != DBNull.Value)
                                    {
                                        obj.CancelledDate = (DateTime)reader["date_cancelled"];
                                        obj.CancelMotive = reader["motive_cancelled"].ToString();
                                    }
                                    list.Add(obj);
                                }
                            }
                            return list;
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

        public BillsToPay SelectFromDb(int billNumber, int billModel, int billSeries, int instalmentNumber, int supplierId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BILLSTOPAY WHERE BILLNUMBER = @BNUM AND BILLMODEL = @BMODEL AND BILLSERIES = @BSERIES " +
                        "AND INSTALMENTNUMBER = @INUM AND SUPPLIER_ID = @SUPPLIERID ; ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@BNUM", billNumber);
                        command.Parameters.AddWithValue("BMODEL", billModel);
                        command.Parameters.AddWithValue("BSERIES", billSeries);
                        command.Parameters.AddWithValue("@INUM", instalmentNumber);
                        command.Parameters.AddWithValue("@SUPPLIERID", supplierId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                BillsToPay obj = new BillsToPay()
                                {
                                    BillNumber = billNumber,
                                    BillSeries = billSeries,
                                    BillModel = billModel,

                                    TotalValue = Convert.ToDecimal(reader["BillValue"]),
                                    DueDate = Convert.ToDateTime(reader["dueDate"]),
                                    EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                    Supplier = _suppliersController.FindItemId(Convert.ToInt32(reader["supplier_id"])),
                                    InstalmentNumber = Convert.ToInt32(reader["instalmentNumber"]),
                                    PaymentCondition = _paymentConditionsController.FindItemId(Convert.ToInt32(reader["payCond_id"])),
                                    PaymentMethod = _paymentMethodsController.FindItemId(Convert.ToInt32(reader["payMethod_id"])),
                                    dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                    dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]),
                                };
                                if (reader["paidDate"] != DBNull.Value)
                                {
                                    obj.PaidDate = Convert.ToDateTime(reader["paidDate"]);
                                    obj.Status = 1;
                                }
                                else
                                {
                                    obj.PaidDate = null;
                                    Purchases_Controller purchController = new Purchases_Controller();
                                    var purch = purchController.FindItemId(obj.BillModel, obj.BillNumber, obj.BillSeries, obj.Supplier.id);
                                    if (purch != null)
                                    {
                                        if (purch.CancelledDate == null)
                                        {
                                            obj.PaidDate = null;
                                            obj.Status = 0;
                                        }
                                        else
                                        {
                                            obj.Status = 2;
                                        }
                                    }
                                }
                                if (reader["date_cancelled"] != DBNull.Value)
                                {
                                    obj.CancelledDate = (DateTime)reader["date_cancelled"];
                                    obj.CancelMotive = reader["motive_cancelled"].ToString();
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

        public List<BillsToPay> SelectSupplierFromDb(int supplierId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BILLSTOPAY WHERE SUPPLIER_ID = @ID ;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", supplierId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<BillsToPay> list = new List<BillsToPay>();
                                foreach (var item in reader)
                                {
                                    BillsToPay obj = new BillsToPay()
                                    {
                                        BillNumber = Convert.ToInt32(reader["billNumber"]),
                                        BillSeries = Convert.ToInt32(reader["billModel"]),
                                        BillModel = Convert.ToInt32(reader["billSeries"]),

                                        PaymentCondition = _paymentConditionsController.FindItemId(Convert.ToInt32(reader["payCond_id"])),
                                        TotalValue = Convert.ToDecimal(reader["BillValue"]),
                                        Status = Convert.ToInt32(reader["billStatus"]),
                                        EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                        PaidDate = null,
                                        DueDate = Convert.ToDateTime(reader["dueDate"]),
                                        Supplier = _suppliersController.FindItemId(Convert.ToInt32(reader["supplier_id"])),
                                        PaymentMethod = _paymentMethodsController.FindItemId(Convert.ToInt32(reader["payMethod_id"])),
                                        dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                                        dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"]),
                                    };
                                    if (reader["paidDate"] != DBNull.Value)
                                    {
                                        obj.PaidDate = Convert.ToDateTime(reader["paidDate"]);
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

        public List<BillsToPay> SelectAllFromDb()
        {
            string sql = "SELECT * FROM BILLSTOPAY ;";
            List<BillsToPay> bill = null;
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
                        bill = new List<BillsToPay>();
                        foreach (BillsToPay item in reader)
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

        public List<BillsToPay> SelectisPaidFromDb(bool isPaid)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BILLSTOPAY WHERE IS_PAID = @ISPAID ;";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ISPAID", isPaid);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                List<BillsToPay> list = new List<BillsToPay>();
                                foreach (BillsToPay item in reader)
                                {
                                    BillsToPay obj = new BillsToPay()
                                    {
                                        BillNumber = Convert.ToInt32(reader["billNumber"]),
                                        BillSeries = Convert.ToInt32(reader["billModel"]),
                                        BillModel = Convert.ToInt32(reader["billSeries"]),

                                        TotalValue = Convert.ToDecimal(reader["BillValue"]),
                                        EmissionDate = Convert.ToDateTime(reader["emissionDate"]),
                                        Status = Convert.ToInt32(reader["billStatus"]),
                                        PaidDate = Convert.ToDateTime(reader["paidDate"]),
                                        PaymentCondition = _paymentConditionsController.FindItemId(Convert.ToInt32(reader["payCond_id"])),
                                        DueDate = Convert.ToDateTime(reader["dueDate"]),
                                        Supplier = _suppliersController.FindItemId(Convert.ToInt32(reader["supplier_id"])),
                                        PaymentMethod = _paymentMethodsController.FindItemId(Convert.ToInt32(reader["payMethod_id"])),
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
            string sql = "SELECT * FROM BILLSTOPAY ;";
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

        public bool CancelPurchaseBills(int billNum, int billModel, int billSeries, int supplierId, DateTime cancelDate, string cancelMotive, Users user)
        {
            bool status = false;

            string sql = "UPDATE BILLSTOPAY SET billStatus = @STATUS, DATE_CANCELLED = @DATECANCEL, USER_ID = @USERID , MOTIVE_CANCELLED = @MOTCANCEL, DATE_LAST_UPDATE = @DU " +
                "WHERE BILLNUMBER = @BNUMBER AND BILLSERIES = @BSERIES AND BILLMODEL = @BMODEL AND SUPPLIER_ID = @SUPPLIERID; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@STATUS", 2); // 2 == Cancelado
                    command.Parameters.AddWithValue("@SUPPLIERID", supplierId);
                    command.Parameters.AddWithValue("@DATECANCEL", cancelDate);
                    command.Parameters.AddWithValue("@BNUMBER", billNum);
                    command.Parameters.AddWithValue("@USERID", user.id);
                    command.Parameters.AddWithValue("@BSERIES", billSeries);
                    command.Parameters.AddWithValue("@BMODEL", billSeries);
                    command.Parameters.AddWithValue("@MOTCANCEL", cancelMotive);
                    command.Parameters.AddWithValue("@DU", DateTime.Now.Date);
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

        public bool SetPaidBillsFromDb(int billNum, int billModel, int billSeries, int supplierId, int instalmentNumber, Users user)
        {
            bool status = false;

            string sql = "UPDATE BILLSTOPAY SET PAIDDATE = @PAIDDATE, DATE_LAST_UPDATE = @DU, USER_ID = @USERID " +
                "WHERE BILLNUMBER = @BNUMBER AND BILLSERIES = @BSERIES AND BILLMODEL = @BMODEL AND SUPPLIER_ID = @SUPPLIERID AND INSTALMENTNUMBER = @INUM; ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@PAIDDATE", DateTime.Now);
                    command.Parameters.AddWithValue("@INUM", instalmentNumber);
                    command.Parameters.AddWithValue("@SUPPLIERID", supplierId);
                    command.Parameters.AddWithValue("@USERID", user.id);
                    command.Parameters.AddWithValue("@BNUMBER", billNum);
                    command.Parameters.AddWithValue("@BSERIES", billSeries);
                    command.Parameters.AddWithValue("@BMODEL", billSeries);
                    command.Parameters.AddWithValue("@DU", DateTime.Now);
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

        internal bool PayBill(BillsToPay obj)
        {
            {
                bool status = false;

                string sql = "UPDATE BILLSTOPAY SET PAIDDATE = @PAIDDATE, DATE_LAST_UPDATE = @UPDATE , USER_ID = @USERID " +
                    "WHERE BILLNUMBER = @BNUMBER AND BILLSERIES = @BSERIES AND BILLMODEL = @BMODEL AND SUPPLIER_ID = @SUPPLIERID AND INSTALMENTNUMBER = @INUM; ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@PAIDDATE", DateTime.Today.Date);
                        command.Parameters.AddWithValue("@ID", obj.id);
                        command.Parameters.AddWithValue("@UPDATE", DateTime.Today.Date);
                        command.Parameters.AddWithValue("@INUM", obj.InstalmentNumber);
                        command.Parameters.AddWithValue("@USERID", obj.User.id);
                        command.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
                        command.Parameters.AddWithValue("@BNUMBER", obj.BillNumber);
                        command.Parameters.AddWithValue("@BSERIES", obj.BillSeries);
                        command.Parameters.AddWithValue("@BMODEL", obj.BillModel);

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

        internal bool CancelBill(BillsToPay obj)
        {
            {
                bool status = false;

                string sql = "UPDATE BILLSTOPAY SET DATE_CANCELLED = @DATECANCEL, USER_ID = @USERID, MOTIVE_CANCELLED = @MOTCANCEL, DATE_LAST_UPDATE = @UPDATE " +
                    "WHERE BILLNUMBER = @BNUMBER AND BILLSERIES = @BSERIES AND BILLMODEL = @BMODEL AND SUPPLIER_ID = @SUPPLIERID; ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@UPDATE", DateTime.Today.Date);
                        command.Parameters.AddWithValue("@SUPPLIERID", obj.Supplier.id);
                        command.Parameters.AddWithValue("@USERID", obj.User.id);
                        command.Parameters.AddWithValue("@BNUMBER", obj.BillNumber);
                        command.Parameters.AddWithValue("@BSERIES", obj.BillSeries);
                        command.Parameters.AddWithValue("@BMODEL", obj.BillModel);
                        command.Parameters.AddWithValue("@DATECANCEL", (DateTime)obj.CancelledDate);
                        command.Parameters.AddWithValue("@MOTCANCEL", obj.CancelMotive);
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
