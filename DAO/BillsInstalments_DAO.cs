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

namespace ProjetoEduardoAnacletoWindowsForm1.DAO
{
    public class BillsInstalments_DAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private readonly PaymentMethods_Controller _paymethodController = new PaymentMethods_Controller();

        public bool SaveToDb(BillsInstalments obj)
        {
            bool status = false;

            string sql = "INSERT INTO BILLSINSTALMENTS ( PAYCONDITION_ID, INSTALMENT_NUMBER, PAYMETHOD_ID, TOTAL_DAYS, VALUE_PERCENTAGE," +
                " DATE_CREATION, DATE_LAST_UPDATE) VALUES (@ID, @INSTALNUMBER, @METHODID, @DAYS, @VALUEPERC, @DC, @DU)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", obj.id);
                    command.Parameters.AddWithValue("@INSTALNUMBER", obj.InstalmentNumber);
                    command.Parameters.AddWithValue("@METHODID", obj.PaymentMethod.id);
                    command.Parameters.AddWithValue("@DAYS", obj.TotalDays);
                    command.Parameters.AddWithValue("@VALUEPERC", (decimal) obj.ValuePercentage);
                    command.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
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

        public bool EditFromDB(BillsInstalments obj)
        {
            bool status = false;

            string sql = "UPDATE BILLSINSTALMENTS SET PAYMETHOD_ID = @PAYID, TOTAL_DAYS = @DAYS, VALUE_PERCENTAGE = @VALUEPERC, " +
                " DATE_LAST_UPDATE = @DU " +
                "WHERE PAYCONDITION_ID = @ID AND INSTALMENT_NUMBER = @INUM; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", obj.id);
                    command.Parameters.AddWithValue("@INUM", obj.InstalmentNumber);
                    command.Parameters.AddWithValue("@PAYID", obj.PaymentMethod.id);
                    command.Parameters.AddWithValue("@DAYS", obj.TotalDays);
                    command.Parameters.AddWithValue("@VALUEPERC", (decimal)obj.ValuePercentage);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
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

        public bool DeleteFromDb(int id)
        {
            bool status = false;

            string sql = "DELETE FROM BILLSINSTALMENTS WHERE PAYCONDITION_ID = @ID ; ";
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

        public bool DeleteFromDb(int id, int iNumber)
        {
            bool status = false;

            string sql = "DELETE FROM BILLSINSTALMENTS WHERE PAYCONDITION_ID = @ID AND INSTALMENT_NUMBER = @INUM ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@INUM", iNumber);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
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

        public BillsInstalments SelectFromDb(int id, int instalNum)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BILLINSTALMENTS WHERE PAYCONDITION_ID = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                BillsInstalments obj = new BillsInstalments
                                {
                                    id = Convert.ToInt32(reader["PAYCONDITION_ID"]),
                                    InstalmentNumber = Convert.ToInt32(reader["instalment_number"]),
                                    PaymentMethod = _paymethodController.FindItemId(Convert.ToInt32(reader["paymethod_id"])),
                                    TotalDays = Convert.ToInt32(reader["total_days"]),
                                    ValuePercentage = Convert.ToDouble(reader["value_percentage"]),
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

        public List<BillsInstalments> SelectAllFromDb()
        {
            string sql = "SELECT * FROM BILLSINSTALMENTS ;";
            List<BillsInstalments> bill = null;
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
                        bill = new List<BillsInstalments>();
                        foreach (BillsInstalments item in reader)
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

        public List<BillsInstalments> SelectInstalmentsFromDb(int payConditionId)
        {
            string sql = "SELECT * FROM BILLSINSTALMENTS WHERE PAYCONDITION_ID = @ID;";
            List<BillsInstalments> bill = new List<BillsInstalments>();
            PaymentMethods_Controller _PMController = new PaymentMethods_Controller();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", payConditionId);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        BillsInstalments item = new BillsInstalments() 
                        {
                            id = Convert.ToInt32(reader["PAYCONDITION_ID"]),
                            InstalmentNumber = Convert.ToInt32(reader["INSTALMENT_NUMBER"]),
                            TotalDays = Convert.ToInt32(reader["total_days"]),
                            PaymentMethod = _PMController.FindItemId(Convert.ToInt32(reader["PAYMETHOD_ID"])),
                            ValuePercentage = Convert.ToDouble(reader["VALUE_PERCENTAGE"]),
                            dateOfCreation = Convert.ToDateTime(reader["date_creation"]),
                            dateOfLastUpdate = Convert.ToDateTime(reader["date_last_update"])
                        };
                        bill.Add(item);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                if (bill.Count > 0)
                {
                    return bill;
                }
                else
                {
                    return null;
                }

            }
        }

        public List<BillsInstalments> SelectDTByCondIdFromDB(int payConditionId)
        {
            string sql = "SELECT * FROM BILLSINSTALMENTS WHERE PAYCONDITION_ID = " + payConditionId + ";";
            List<BillsInstalments> list = new List<BillsInstalments>();
            PaymentMethods_Controller _PMController = new PaymentMethods_Controller();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, connectionString);
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        BillsInstalments item = new BillsInstalments()
                        {
                            id = Convert.ToInt32(dr["PAYCONDITION_ID"]),
                            InstalmentNumber = Convert.ToInt32(dr["INSTALMENT_NUMBER"]),
                            TotalDays = Convert.ToInt32(dr["total_days"]),
                            PaymentMethod = _PMController.FindItemId(Convert.ToInt32(dr["PAYMETHOD_ID"])),
                            ValuePercentage = Convert.ToDouble(dr["VALUE_PERCENTAGE"]),
                            dateOfCreation = Convert.ToDateTime(dr["date_creation"]),
                            dateOfLastUpdate = Convert.ToDateTime(dr["date_last_update"])
                        };
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
            return list;
        }

        public DataTable SelectDataSourceFromDB() 
        {
            string sql = "SELECT * FROM BILLSINSTALMENTS ;";
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
