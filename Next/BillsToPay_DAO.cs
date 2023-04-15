using ProjetoEduardoAnacletoWindowsForm1.Models;
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

namespace ProjetoEduardoAnacletoWindowsForm1.DAO
{
    public class BillsToPay_DAO //TO DO
    {
        //private string connectionString = "Server = localhost; Database = PraticaProfissional1; Trusted_Connection = True;";
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        public bool SaveToDb(BillsToPay bill)
        {
            //bool status = false;

            //string sql = "INSERT INTO BILLSTOPAY (NUM_PARC, NUM_DANFE, TIPO_DANFE, SERIE_DANFE, PAG_DANFE, VENC_FATURA, VALOR_FATURA, FORMAPAGTO_ID, FORNECEDOR_ID, IS_PAID, DATE_CREATION, DATE_LAST_UPDATE ) "
            //             + " VALUES ("
            //             + +bill.instalmentNumber
            //             + ", "
            //             + +bill.numDanfe
            //             + ", '"
            //             + +bill.tipoDanfe
            //             + "' , "
            //             + +bill.serieDanfe
            //             + " , "
            //             + +bill.pagDanfe
            //             + ", "
            //             + bill.dueDate
            //             + ", "
            //             + +bill.totalValue
            //             + ", "
            //             + +bill.isPaid
            //             + ", '"
            //             + bill.dateOfCreation.ToString()
            //             + "', '"
            //             + bill.dateOfLastUpdate.ToString()
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

        public bool EditFromDB(BillsToPay bill)
        {
            //bool status = false;
            //string sql = "UPDATE BILLSTOPAY SET VENC_FATURA = '"
            //             + bill.dueDate
            //             + "', VALOR_FATURA = "
            //             + bill.totalValue
            //             + " , FORMAPAGTO_ID = "
            //             + bill.paymentForm.id
            //             + ", FORNECEDOR_ID = "
            //             + bill.supplier.id
            //             + ", IS_PAID = "
            //             + bill.isPaid
            //             + ", DATE_LAST_UPDATE = '"
            //             + bill.dateOfLastUpdate.ToString()
            //             + "' WHERE NUM_DANFE = "
            //             + bill.numDanfe
            //             + " AND TIPO_DANFE = "
            //             + bill.tipoDanfe
            //             + " AND SERIE_DANFE = "
            //             + bill.DANFe.serieDanfe
            //             + "AND PAG_DANFE = "
            //             + bill.pagDanfe
            //             + " AND NUM_PARC= "
            //             + bill.instalmentNumber
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

        public bool DeleteFromDb(int numDanfe, int tipoDanfe, int serieDanfe, int pagDanfe, int numParc)
        {
            bool status = false;
            string sql = "DELETE FROM BILLSTOPAY WHERE NUM_DANFE = "
                         + numDanfe
                         + " AND TIPO_DANFE = "
                         + tipoDanfe
                         + " AND SERIE_DANFE = "
                         + serieDanfe
                         + "AND PAG_DANFE = "
                         + pagDanfe
                         + " AND NUM_PARC= "
                         + numParc
                         + " ;";

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

        public BillsToPay SelectFromDb(int numDanfe, int tipoDanfe, int serieDanfe, int pagDanfe, int numParc)
        {
            string sql = "SELECT * FROM BILLSTOPAY WHERE NUM_DANFE = "
                         + numDanfe
                         + " AND TIPO_DANFE = "
                         + tipoDanfe
                         + " AND SERIE_DANFE = "
                         + serieDanfe
                         + "AND PAG_DANFE = "
                         + pagDanfe
                         + " AND NUM_PARC= "
                         + numParc
                         + " ;";

            BillsToPay bill = null;
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
                        //DANFes_DAO danfe_DAO = new DANFes_DAO();
                        Suppliers_DAO supplier_DAO = new Suppliers_DAO();
                        PaymentMethods_DAO method_DAO = new PaymentMethods_DAO();

                        //var danfe = new DANFes();
                        var supplier = new Suppliers();
                        var method = new PaymentMethods();
                        bill = new BillsToPay();
                        int NDanfe = Convert.ToInt32(reader.GetSqlValue(0).ToString());
                        int TDanfe = Convert.ToInt32(reader.GetSqlValue(1).ToString());
                        int SDanfe = Convert.ToInt32(reader.GetSqlValue(2).ToString());
                        int PDanfe = Convert.ToInt32(reader.GetSqlValue(3).ToString());
                        //danfe = danfe_DAO.SelectFromDb(NDanfe,TDanfe,SDanfe,PDanfe);
                        //bill.instalmentNumber = Convert.ToInt32(reader.GetSqlValue(4).ToString());
                        bill.dueDate = Convert.ToDateTime(reader.GetSqlValue(5).ToString());
                        bill.totalValue = Convert.ToDouble(reader.GetSqlValue(6).ToString());
                        method = method_DAO.SelectFromDb(Convert.ToInt32(reader.GetSqlValue(7).ToString()));
                      //  supplier = supplier_DAO.SelectFromDb(Convert.ToInt32(reader.GetSqlValue(8).ToString()));

                        //bill.DANFe = danfe;
                      //  bill.paymentForm = method;
                        bill.supplier = supplier;
                        bill.dateOfCreation = Convert.ToDateTime(reader.GetSqlValue(9).ToString());
                        bill.dateOfLastUpdate = Convert.ToDateTime(reader.GetSqlValue(10).ToString());
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
        public List<BillsToPay> SelectSupplierFromDb(int supplierId)
        {
            string sql = "SELECT * FROM BILLSTOPAY WHERE SUPPLIER_ID = " + supplierId + " ;";

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
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return bill;
        }
        public List<BillsToPay> SelectPurchaseFromDb(int purchaseId)
        {
            string sql = "SELECT * FROM BILLSTOPAY WHERE PURCHASE_ID = " + purchaseId+ " ;";

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
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return bill;
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
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return bill;
        }

        public List<BillsToPay> SelectisPaidFromDb(int isPaid)
        {
            string sql = "SELECT * FROM BILLSTOPAY WHERE IS_PAID = " + isPaid + " ;";

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
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return bill;
        }

        public DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
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
    }
}
