using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoEduardoAnacletoWindowsForm1.Properties;
using System.Configuration;
using System.Threading;

namespace ProjetoEduardoAnacletoWindowsForm1.DAO
{
    public class Brands_DAO : Master_DAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public override int NewId()
        {
            var newId = "";
            string sql = "SELECT MAX(ID_BRAND) FROM BRANDS;";
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
                MessageBox.Show("Erro : " + ex.Message);
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

        public bool SaveToDb(Brands obj)
        {
            bool status = false;

            string sql = "INSERT INTO BRANDS ( BRAND_NAME, DATE_CREATION, DATE_LAST_UPDATE) VALUES (@NAME, @DC, @DU);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@NAME", obj.brandName);
                    command.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro salvo com sucesso.");
                        status = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    return status;
                }
                finally
                {
                    connection.Close();
                }
                return status;
            }
        }


        public bool EditFromDB(Brands obj)
        {
            bool status = false;

            string sql = "UPDATE BRANDS SET BRAND_NAME = @NAME, DATE_LAST_UPDATE = @DU " +
                "WHERE ID_BRAND = @ID ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", obj.id);
                    command.Parameters.AddWithValue("@NAME", obj.brandName);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro salvo com sucesso.");
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


        public override bool DeleteFromDb(int id)
        {
            bool status = false;

            string sql = "DELETE FROM BRANDS WHERE ID_BRAND = @ID ; ";
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

        public Brands SelectFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BRANDS WHERE ID_BRAND = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Brands obj = new Brands
                                {
                                    id = Convert.ToInt32(reader["id_brand"]),
                                    brandName = Convert.ToString(reader["brand_name"]),
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
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally 
                {
                    connection.Close(); 
                }
            }
            return null; 
        }

        public Brands SelectFromDb(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM BRANDS WHERE BRAND_NAME = @NAME";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NAME", name);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Brands obj = new Brands
                                {
                                    id = Convert.ToInt32(reader["id_brand"]),
                                    brandName = Convert.ToString(reader["brand_name"]),
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
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
    

        public List<Brands> SelectAllFromDb()
        {
            string sql = "SELECT * FROM BRANDS ;";
            List<Brands> brand = null;
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
                        brand = new List<Brands>();
                        foreach (Brands item in reader)
                        {
                            brand.Add(item);
                        }
                    }
                    else
                    {
                        brand = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return brand;
        }

        public new DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM BRANDS ;";
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
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally 
            { 
                con.Close();
            }

            return dt;
        }
    }
}

