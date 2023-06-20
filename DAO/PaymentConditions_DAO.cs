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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NUnit.Framework.Internal;
using System.Drawing;
using System.Xml.Linq;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;

namespace ProjetoEduardoAnacletoWindowsForm1.DAO
{
    public class PaymentConditions_DAO : Master_DAO//OK
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        private readonly BillsInstalments_Controller _billsInstalmentsController = new BillsInstalments_Controller();

        public override int NewId()
        {
            var newId = "";
            string sql = "SELECT MAX(ID_PAYCONDITION) FROM PAYMENTCONDITIONS;";
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

        public bool SaveToDb(PaymentConditions cond)
        {
            bool status = false;

            string sql = "INSERT INTO PAYMENTCONDITIONS ( CONDITION_NAME, PAYMENT_FEES, FINE_VALUE, DISCOUNT_PERC, INSTALMENT_QUANTITY , DATE_CREATION, DATE_LAST_UPDATE ) "
                         + " VALUES (@CONDNAME, @FEES, @FINE, @DISCOUNT, @QNT, @DC, @DU);" +
                         " SELECT SCOPE_IDENTITY() ;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@CONDNAME", cond.conditionName);
                    command.Parameters.AddWithValue("@FEES", (decimal)cond.paymentFees);
                    command.Parameters.AddWithValue("@FINE", (decimal)cond.fineValue);
                    command.Parameters.AddWithValue("@DISCOUNT", (decimal)cond.discountPerc);
                    command.Parameters.AddWithValue("@QNT", cond.instalmentQuantity);
                    command.Parameters.AddWithValue("@DC", cond.dateOfCreation);
                    command.Parameters.AddWithValue("@DU", cond.dateOfLastUpdate);
                    connection.Open();
                    //int i = command.ExecuteNonQuery();
                    var x = Convert.ToDecimal(command.ExecuteScalar());
                    int i = Convert.ToInt32(x);
                    connection.Close();
                    if (i > 0)
                    {
                        foreach (BillsInstalments instalment in cond.BillsInstalments)
                        {
                            if (instalment != null)
                            {
                                instalment.id = i;
                                status = _billsInstalmentsController.SaveItem(instalment);
                                if (!status)
                                {
                                    MessageBox.Show("An error has occurred.");
                                    break;
                                }
                            }
                        }
                        if (status)
                        {
                            MessageBox.Show("Register added with success!");
                        }
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

        //public bool SaveInstalmentsToDb(List<BillsInstalments> instalments, int condId)
        //{
        //    bool status = false;

        //    string sqlString = "INSERT INTO PAYCONDITIONINSTALMENTS ( PAYCONDITION_ID, INSTALMENT_NUMBER, DAYS_COUNT, METHOD_ID, VALUE_PERCENTAGE)" +
        //            " VALUES (@CONDID, @INUM, @DAYS, @METHODID, @VALUEPERCENTAGE)";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            foreach (BillsInstalments bill in instalments)
        //            {
        //                SqlCommand command = new SqlCommand(sqlString, connection);
        //                command.Parameters.AddWithValue("@CONDID", condId);
        //                command.Parameters.AddWithValue("@INUM", bill.InstalmentNumber);
        //                command.Parameters.AddWithValue("@DAYS", bill.TotalDays);
        //                command.Parameters.AddWithValue("@METHODID", bill.PaymentMethod.id);
        //                command.Parameters.AddWithValue("@VALUEPERCENTAGE", (decimal)bill.ValuePercentage);
        //                int i = command.ExecuteNonQuery();
        //                if (i > 0)
        //                {
        //                    status = true;
        //                }
        //            }

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error : " + ex.Message);
        //            return status;
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //        return status;
        //    }
        //}

        public bool EditFromDB(PaymentConditions cond)
        {
            bool status = false;

            string sql = "UPDATE PAYMENTCONDITIONS SET CONDITION_NAME = @CONDNAME, PAYMENT_FEES = @FEES, FINE_VALUE = @FINE," +
                " DISCOUNT_PERC = @DISCOUNT, INSTALMENT_QUANTITY = @QNT , DATE_LAST_UPDATE = @DU " +
                "WHERE ID_PAYCONDITION = @ID ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", cond.id);
                    command.Parameters.AddWithValue("@CONDNAME", cond.conditionName);
                    command.Parameters.AddWithValue("@FEES", (decimal)cond.paymentFees);
                    command.Parameters.AddWithValue("@FINE", (decimal)cond.fineValue);
                    command.Parameters.AddWithValue("@DISCOUNT", (decimal)cond.discountPerc);
                    command.Parameters.AddWithValue("@QNT", cond.instalmentQuantity);
                    command.Parameters.AddWithValue("@DU", cond.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    connection.Close();
                    if (i > 0)
                    {
                        var toBeRemoved = _billsInstalmentsController.FindInstalments(cond.id);
                        if (!cond.BillsInstalments.Equals(toBeRemoved) && toBeRemoved.Count > 0)
                        {
                            status = _billsInstalmentsController.DeleteItem(cond.id);
                            if (!status)
                            {
                                throw new SystemException("An error has ocurred in database when reordering instalments.");
                            }
                            foreach (BillsInstalments item in cond.BillsInstalments)
                            {
                                status = _billsInstalmentsController.SaveItem(item);
                                if (!status)
                                {
                                    throw new SystemException("An error has ocurred in database when updating instalments.");
                                }
                            }
                            //foreach (BillsInstalments item in toBeRemoved)
                            //{
                            //    if (item != null)
                            //    {
                            //        status = _billsInstalmentsController.DeleteItem(item.id, item.InstalmentNumber);
                            //    }
                            //}
                            //foreach (BillsInstalments item in cond.BillsInstalments)
                            //{
                            //    if (item != null)
                            //    {
                            //        item.id = cond.id;
                            //        status = _billsInstalmentsController.SaveItem(item);
                            //        if (!status)
                            //        {
                            //            MessageBox.Show("An error has occurred.");
                            //            break;
                            //        }
                            //    }
                            //}
                        }
                        if (status)
                        {
                            MessageBox.Show("Register altered with success!");
                        }
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

        public override bool DeleteFromDb(int id)
        {
            bool status = false;

            string sql = "DELETE FROM PAYMENTCONDITIONS WHERE ID_PAYCONDITION = @ID ; ";
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

        public PaymentConditions SelectFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM PAYMENTCONDITIONS WHERE ID_PAYCONDITION = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PaymentConditions obj = new PaymentConditions
                                {
                                    id = Convert.ToInt32(reader["id_paycondition"]),
                                    conditionName = Convert.ToString(reader["condition_name"]),
                                    paymentFees = Convert.ToDouble(reader["payment_fees"]),
                                    fineValue = Convert.ToDouble(reader["fine_value"]),
                                    discountPerc = Convert.ToDouble(reader["discount_perc"]),
                                    instalmentQuantity = Convert.ToInt32(reader["instalment_quantity"]),
                                    BillsInstalments = _billsInstalmentsController.FindInstalments(Convert.ToInt32(reader["id_paycondition"])),
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

        public PaymentConditions SelectFromDb(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM PAYMENTCONDITIONS WHERE CONDITION_NAME = @NAME";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NAME", name);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PaymentConditions obj = new PaymentConditions
                                {
                                    id = Convert.ToInt32(reader["id_paycondition"]),
                                    conditionName = Convert.ToString(reader["condition_name"]),
                                    paymentFees = Convert.ToDouble(reader["payment_fees"]),
                                    fineValue = Convert.ToDouble(reader["fine_value"]),
                                    discountPerc = Convert.ToDouble(reader["discount_perc"]),
                                    instalmentQuantity = Convert.ToInt32(reader["instalment_quantity"]),
                                    BillsInstalments = _billsInstalmentsController.FindInstalments(Convert.ToInt32(reader["id_paycondition"])),
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

        public List<PaymentConditions> SelectAllFromDb()
        {
            string sql = "SELECT * FROM PAYMENTCONDITIONS ;";
            List<PaymentConditions> cond = null;
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
                        cond = new List<PaymentConditions>();
                        foreach (PaymentConditions item in reader)
                        {
                            cond.Add(item);
                        }
                    }
                    else
                    {
                        cond = null;
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
            return cond;
        }

        public override DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM PAYMENTCONDITIONS ;";
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

        public DataTable SelectInstalmentsDataSourceFromDB(int id) //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM PAYCONDITIONINSTALMENTS WHERE I.PAYCONDITION_ID = " + id + ";";
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