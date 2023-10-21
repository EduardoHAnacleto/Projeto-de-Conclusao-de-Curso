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
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using System.Xml.Linq;

namespace ProjetoEduardoAnacletoWindowsForm1.DAO
{
    public class Users_DAO : Master_DAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public override int NewId()
        {
            var newId = "";
            string sql = "SELECT MAX(ID_USER) FROM USERS;";
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
                MessageBox.Show("Erro: " + ex.Message);
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

        public bool SaveToDb(Users obj)
        {
            bool status = false;

            string sql = "INSERT INTO USERS ( USERLOGIN, USERPASSWORD, LEVELACCESS , DATE_CREATION, DATE_LAST_UPDATE) " +
                "VALUES (@LOGIN, @PASSWORD, @LVLACCESS, @DC, @DU)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@LOGIN", obj.userLogin);
                    command.Parameters.AddWithValue("@PASSWORD", obj.userPassword);
                    command.Parameters.AddWithValue("@LVLACCESS", obj.AccessLevel);
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


        public bool EditFromDB(Users obj)
        {
            bool status = false;

            string sql = "UPDATE BRANDS SET USER_PASSWORD = @PASSWORD, DATE_LAST_UPDATE = @DU " +
                "WHERE ID_USER = @ID ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", obj.id);
                    command.Parameters.AddWithValue("@PASSWORD", obj.userPassword);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registro alterado com sucesso.");
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

        public override bool DeleteFromDb(int id)
        {
            bool status = false;

            string sql = "DELETE FROM USERS WHERE ID_USER = @ID ; ";
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

        public Users SelectFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM USERS WHERE ID_USER = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Employees_Controller _EController = new Employees_Controller();
                                Users obj = new Users
                                {
                                    id = Convert.ToInt32(reader["id_user"]),
                                    userLogin = Convert.ToString(reader["userLogin"]),
                                    userPassword = Convert.ToString(reader["userPassword"]),
                                    AccessLevel = Convert.ToInt32(reader["levelAccess"]),
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

        public Users SelectFromDb(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM USERS WHERE USERLOGIN = @LOGIN";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@LOGIN", name);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Employees_Controller _EController = new Employees_Controller();
                                Users obj = new Users
                                {
                                    id = Convert.ToInt32(reader["id_user"]),
                                    userLogin = Convert.ToString(reader["userLogin"]),
                                    userPassword = Convert.ToString(reader["userPassword"]),
                                    AccessLevel = Convert.ToInt32(reader["levelAccess"]),
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

        public Users LogUser(string login, string secret)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM USERS WHERE USERLOGIN = @LOGIN AND USERPASSWORD = @SECRET";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@LOGIN", login);
                        command.Parameters.AddWithValue("@SECRET", secret);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Employees_Controller _EController = new Employees_Controller();
                                Users obj = new Users
                                {
                                    id = Convert.ToInt32(reader["id_user"]),
                                    userLogin = Convert.ToString(reader["userLogin"]),
                                    userPassword = Convert.ToString(reader["userPassword"]),
                                    AccessLevel = Convert.ToInt32(reader["levelAccess"]),
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


        public List<Users> SelectAllFromDb()
        {
            string sql = "SELECT * FROM USERS ;";
            List<Users> user = null;
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
                        user = new List<Users>();
                        foreach (Users item in reader)
                        {
                            user.Add(item);
                        }
                    }
                    else
                    {
                        user = null;
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
            return user;
        }

        public override DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM USERS ;";
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

