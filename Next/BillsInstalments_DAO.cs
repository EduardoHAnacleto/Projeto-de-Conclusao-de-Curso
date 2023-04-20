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
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public bool SaveToDb(BillsInstalments instalment)
        {
            bool status = false;

            //string sql = "INSERT INTO BILLSINSTALMENTS ( INSTALMENT_NUMBER, PAYCONDITION_ID, PAYMETHOD_ID, DAYS_COUNT, VALUE_PERCENTAGE) "
            //             + " VALUES ("
            //             + +instalment.InstalmentNumber
            //             + ", "
            //             + instalment.paymentCondition.id
            //             + " , "
            //             + instalment.paymentMethod.id
            //             + " , "
            //             + instalment.totalDays
            //             + " , "
            //             + instalment.valuePercentage
            //             + " );";

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

        public bool EditFromDB(BillsInstalments instalment)
        {
            bool status = false;
            //string sql = "UPDATE BILLSINSTALMENTS SET VALUE_PERCENTAGE = "
            //             + instalment.valuePercentage
            //             + ", TOTAL_DAYS = "
            //             + +instalment.totalDays
            //             + ", PAYMETHOD_ID = "
            //             + instalment.paymentMethod.id
            //             + " WHERE INSTALMENT_NUMBER = "
            //             + instalment.InstalmentNumber
            //             + " AND PAYCONDITION_ID = "
            //             + instalment.paymentCondition.id
            //             + ";";

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

        public bool DeleteFromDb(int instalmentNumber, int paymentConditionId)
        {
            bool status = false;
            string sql = "DELETE FROM BILLSINSTALMENTS WHERE INSTALMENT_NUMBER = "
                         + instalmentNumber
                         + " AND PAYCONDITION_ID = "
                         + paymentConditionId
                         + ";";

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

        public BillsInstalments SelectFromDb(int instalmentNumber, int paymentConditionId)
        {
            string sql = "SELECT * FROM BILLSINSTALMENTS WHERE INSTALMENT_NUMBER = "
                         + instalmentNumber
                         + " AND PAYCONDITION_ID = "
                         + paymentConditionId
                         + ";";

            BillsInstalments bill = null;
            //SqlConnection con = new SqlConnection(connectionString);
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.CommandType = CommandType.Text;
            //try
            //{
            //    con.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        if (reader.HasRows)
            //        {
            //            bill = new BillsInstalments();
            //            var cond_DAO = new PaymentConditions_DAO();
            //            var method_DAO = new PaymentMethods_DAO();
            //            var payCondition = new PaymentConditions();
            //            var payMethod = new PaymentMethods();
            //            bill.InstalmentNumber = Convert.ToInt32(reader.GetSqlValue(0).ToString());
            //            payCondition = cond_DAO.SelectFromDb(Convert.ToInt32(reader.GetSqlValue(1).ToString()));
            //            payMethod = method_DAO.SelectFromDb(Convert.ToInt32(reader.GetSqlValue(2).ToString()));
            //            bill.paymentCondition = payCondition;
            //            bill.paymentMethod = payMethod;
            //            bill.totalDays = Convert.ToInt32(reader.GetSqlValue(3).ToString());
            //            bill.valuePercentage = Convert.ToDouble(reader.GetSqlValue(4).ToString());
            //            bill.dateOfCreation = Convert.ToDateTime(reader.GetSqlValue(5).ToString());
            //            bill.dateOfLastUpdate = Convert.ToDateTime(reader.GetSqlValue(6).ToString());
            //        }
            //        else
            //        {
            //            bill = null;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error : " + ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
            return bill;
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
            string sql = "SELECT * FROM PAYCONDITIONINSTALMENTS WHERE PAYCONDITION_ID = @ID;";
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
                        BillsInstalments item = new BillsInstalments();
                        item.id = Convert.ToInt32(reader["PAYCONDITION_ID"]);
                        item.InstalmentNumber = Convert.ToInt32(reader["INSTALMENT_NUMBER"]);
                        item.TotalDays = Convert.ToInt32(reader["DAYS_COUNT"]);
                        item.PaymentMethod = _PMController.FindItemId( Convert.ToInt32(reader["METHOD_ID"])) ;
                        item.ValuePercentage = Convert.ToDouble(reader["VALUE_PERCENTAGE"]);
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

        public DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
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
