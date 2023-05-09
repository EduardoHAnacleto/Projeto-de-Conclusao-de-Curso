using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class Purchases_DAO
    {
        private string connectionString = string.Empty;

        public int NewId()
        {
            var newId = "";
            string sql = "SELECT MAX(ID_PURCHASE) FROM PURCHASES;";
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
            return 1;
        }

        public bool SaveToDb(Purchases purchase)
        {
            //bool status = false;
            //string sql = "INSERT INTO PURCHASES ( DANFE_NUM, DANFE_TIPO, DANFE_SERIE, DANFE_PAG, SUPPLIER_ID, PAYCONDITION_ID, PURCHASE_STATUS," +
            //    " EMISSION_DATE, ARRIVAL_DATE, FREIGHT_COST, PURCHASE_TOTAL_VALUE, PURCHASE_TOTAL_COST, PURCHASE_COST_EXPENSES," +
            //    " PURCHASE_DISCOUNT, PURCHASE_INSURANCE,  DATE_CREATION, DATE_LAST_UPDATE) "
            //             + " VALUES ("
            //             + +purchase.billToPay.numDanfe
            //             + ", "
            //             + +purchase.billToPay.tipoDanfe
            //             + ", "
            //             + +purchase.billToPay.tipoDanfe
            //             + ", "
            //             + +purchase.billToPay.pagDanfe
            //             + ", "
            //             + +purchase.supplier.id
            //             + " , "
            //             + +purchase.payCondition.id
            //             + " , "
            //             + +purchase.id
            //             + " , "
            //             + +purchase.status
            //             + ", '"
            //             + purchase.emissionDate.ToString()
            //             + "', '"
            //             + purchase.arrivalDate.ToString()
            //             + ", "
            //             + +purchase.freight_Cost
            //             + ", "
            //             + +purchase.total_PurchaseValue
            //             + ", "
            //             + +purchase.expenses
            //             + ", "
            //             + +purchase.discount
            //             + ", "
            //             + +purchase.insurance
            //             + ", '"
            //             + purchase.dateOfCreation.ToString()
            //             + "', '"
            //             + purchase.dateOfLastUpdate.ToString()
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
            //return status;
            return true;
        }

        public bool EditFromDB(Purchases purchase)
        {
            //bool status = false;
            //string sql = "UPDATE PURCHASES SET SUPPLIER_ID = "
            //             + purchase.supplier.id
            //             + " , PAYCONDITION_ID = "
            //             + purchase.payCondition.id
            //             + " , DANFE_NUM = "
            //             + purchase.billToPay.numDanfe
            //             + " , DANFE_TIPO = "
            //             + purchase.billToPay.tipoDanfe
            //             + " , DANFE_SERIE = "
            //             + purchase.billToPay.serieDanfe
            //             + " , DANFE_PAG = "
            //             + purchase.billToPay.pagDanfe
            //             + " , PURCHASE_STATUS = "
            //             + purchase.status
            //             + " , FREIGHT_COST = "
            //             + purchase.freight_Cost
            //             + " , PURCHASE_TOTAL_VALUE = "
            //             + purchase.total_PurchaseValue
            //             + " , PURCHASE_TOTAL_COST = "
            //             + purchase.total_Cost
            //             + " , PURCHASE_COST_EXPENSES = "
            //             + purchase.expenses
            //             + " , PURCHASE_DISCOUNT = "
            //             + purchase.discount
            //             + " , PURCHASE_INSURANCE = "
            //             + purchase.insurance
            //             + " , ARRIVAL_DATE = '"
            //             + purchase.arrivalDate.ToString()
            //             + "' , EMISSION_DATE = '"
            //             + purchase.emissionDate.ToString()
            //             + "' , DATE_LAST_UPDATE = '"
            //             + purchase.dateOfLastUpdate.ToString()
            //             + "' WHERE ID_PURCHASE = "
            //             + purchase.id
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
            //return status;
            return true;
        }

        public bool DeleteFromDb(int id)
        {
            bool status = false;
            string sql = "DELETE FROM PURCHASES WHERE ID_PURCHASE = " + id + " ;";

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

        public Purchases SelectFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASES WHERE ID_PURCHASE = " + id + " ;";

            List<Purchases> purchase = null;
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
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
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
            return null;
        }

        public List<Purchases> SelectStatusFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASES WHERE PURCHASE_STATUS = " + id + " ;";

            List<Purchases> purchase = null;
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
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
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
            return purchase;
        }

        public List<Purchases> SelectEmissionDateFromDb(string date)
        {
            string sql = "SELECT * FROM PURCHASES WHERE EMISSION_DATE >= " + date + " ;";

            List<Purchases> purchase = null;
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
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
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
            return purchase;
        }

        public List<Purchases> SelectArrivalDateFromDb(string date)
        {
            string sql = "SELECT * FROM PURCHASES WHERE ARRIVAL_DATE >= " + date + " ;";

            List<Purchases> purchase = null;
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
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
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
            return purchase;
        }

        public List<Purchases> SelectTotalCostFromDb(decimal value)
        {
            string sql = "SELECT * FROM PURCHASES WHERE PURCHASE_TOTAL_COST = " + value + " ;";

            List<Purchases> purchase = null;
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
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
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
            return purchase;
        }

        public List<Purchases> SelectPayConditionFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASES WHERE ID_PAYCONDITION = " + id + " ;";

            List<Purchases> purchase = null;
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
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
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
            return purchase;
        }

        public List<Purchases> SelectSupplierFromDb(int id)
        {
            string sql = "SELECT * FROM PURCHASES WHERE SUPPLIER_ID = " + id + " ;";

            List<Purchases> purchase = null;
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
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
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
            return purchase;
        }
        public List<Purchases> SelectAllFromDb()
        {
            string sql = "SELECT * FROM PURCHASES ;";
            List<Purchases> purchase = null;
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
                        purchase = new List<Purchases>();
                        foreach (Purchases item in reader)
                        {
                            purchase.Add(item);
                        }
                    }
                    else
                    {
                        purchase = null;
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
            return purchase;
        }

        public DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM PURCHASES ;";
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
