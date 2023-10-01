using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
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
    public class Clients_DAO : Master_DAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public override int NewId()
        {
            var newId = "";
            string sql = "SELECT MAX(ID_CLIENT) FROM CLIENTS;";
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

        public bool SaveToDb(Clients obj)
        {
            bool status = false;

            string sql = "INSERT INTO CLIENTS ( CLIENT_NAME, CLIENT_GENDER, CLIENT_REGISTRATION, CLIENT_AGE, CLIENT_DOB, CLIENT_EMAIL," +
                "CLIENT_PHONE1, CLIENT_PHONE2, CLIENT_PHONE3, CLIENT_PHONE_CLASS1, CLIENT_PHONE_CLASS2, CLIENT_PHONE_CLASS3," +
                "CLIENT_STREET_NAME, CLIENT_DISTRICT, CLIENT_HOUSE_NUMBER, CLIENT_HOME_TYPE, CLIENT_COMPLEMENT, CLIENT_ZIP_CODE," +
                "CITY_ID, CLIENT_TYPE, DATE_CREATION, DATE_LAST_UPDATE, PAYCOND_ID) VALUES " +
                "(@NAME, @GENDER, @REGISTRATION, @AGE, @DOB, @EMAIL, @PHONE1, @PHONE2, @PHONE3, @PCLASS1, @PCLASS2, @PCLASS3," +
                "@STREET, @DISTRICT, @HOUSENUMBER, @HOMETYPE, @COMPLEMENT, @ZIPCODE, @CITYID, @TYPE, @DC, @DU, @PAYCONDID)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@NAME", obj.name);
                    command.Parameters.AddWithValue("PAYCONDID", obj.PaymentCondition.id);
                    command.Parameters.AddWithValue("@GENDER", obj.gender);
                    command.Parameters.AddWithValue("@REGISTRATION", obj.registrationNumber);
                    command.Parameters.AddWithValue("@AGE", obj.age);
                    command.Parameters.AddWithValue("@DOB", obj.dateOfBirth);
                    command.Parameters.AddWithValue("@EMAIL", obj.email);
                    command.Parameters.AddWithValue("@PHONE1", obj.phoneNumber1);
                    command.Parameters.AddWithValue("@PHONE2", obj.phoneNumber2);
                    command.Parameters.AddWithValue("@PHONE3", obj.phoneNumber3);
                    command.Parameters.AddWithValue("@PCLASS1", obj.phoneClass1.id);
                    command.Parameters.AddWithValue("@PCLASS2", obj.phoneClass2.id);
                    command.Parameters.AddWithValue("@PCLASS3", obj.phoneClass3.id);
                    command.Parameters.AddWithValue("@STREET", obj.streetName);
                    command.Parameters.AddWithValue("@DISTRICT", obj.district);
                    command.Parameters.AddWithValue("@HOUSENUMBER", obj.houseNumber);
                    command.Parameters.AddWithValue("@HOMETYPE", obj.homeType);
                    command.Parameters.AddWithValue("@COMPLEMENT", obj.complement);
                    command.Parameters.AddWithValue("@ZIPCODE", obj.zipCode);
                    command.Parameters.AddWithValue("@CITYID", obj.city.id);
                    command.Parameters.AddWithValue("@TYPE", obj.clientType);
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


        public bool EditFromDB(Clients obj)
        {
            bool status = false;

            string sql = "UPDATE CLIENTS SET CLIENT_NAME = @NAME, CLIENT_REGISTRATION = @REGISTRATION , CLIENT_GENDER = @GENDER, " +
                "CLIENT_AGE = @AGE, CLIENT_DOB = @DOB, CLIENT_EMAIL = @EMAIL, CLIENT_PHONE1 = @PHONE1, CLIENT_PHONE2 = @PHONE2, " +
                "CLIENT_PHONE3 = @PHONE3, CLIENT_PHONE_CLASS1 = @PCLASS1, CLIENT_PHONE_CLASS2 = @PCLASS2, CLIENT_PHONE_CLASS3 = @PCLASS3," +
                "CLIENT_STREET_NAME = @STREET, CLIENT_DISTRICT = @DISTRICT, CLIENT_HOUSE_NUMBER = @HNUMBER, CLIENT_HOME_TYPE = @HTYPE," +
                "CLIENT_COMPLEMENT = @COMPLEMENT, CLIENT_ZIP_CODE = @ZIPCODE, CITY_ID = @CITYID, CLIENT_TYPE = @CTYPE ,DATE_LAST_UPDATE = @DU," +
                " PAYCOND_ID = @PAYCONDID " +
                "WHERE ID_CLIENT = @ID ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", obj.id);
                    command.Parameters.AddWithValue("@NAME", obj.name);
                    command.Parameters.AddWithValue("PAYCONDID", obj.PaymentCondition.id);
                    command.Parameters.AddWithValue("@REGISTRATION", obj.registrationNumber);
                    command.Parameters.AddWithValue("@GENDER", obj.gender);
                    command.Parameters.AddWithValue("@AGE", obj.age);
                    command.Parameters.AddWithValue("@DOB", obj.dateOfBirth);
                    command.Parameters.AddWithValue("@EMAIL", obj.email);
                    command.Parameters.AddWithValue("@PHONE1", obj.phoneNumber1);
                    command.Parameters.AddWithValue("@PHONE2", obj.phoneNumber2);
                    command.Parameters.AddWithValue("@PHONE3", obj.phoneNumber3);
                    command.Parameters.AddWithValue("@PCLASS1", obj.phoneClass1.id);
                    command.Parameters.AddWithValue("@PCLASS2", obj.phoneClass2.id);
                    command.Parameters.AddWithValue("@PCLASS3", obj.phoneClass3.id);
                    command.Parameters.AddWithValue("@STREET", obj.streetName);
                    command.Parameters.AddWithValue("@DISTRICT", obj.district);
                    command.Parameters.AddWithValue("@HNUMBER", obj.houseNumber);
                    command.Parameters.AddWithValue("@HTYPE", obj.homeType);
                    command.Parameters.AddWithValue("@COMPLEMENT", obj.complement);
                    command.Parameters.AddWithValue("@ZIPCODE", obj.zipCode);
                    command.Parameters.AddWithValue("@CITYID", obj.city.id);
                    command.Parameters.AddWithValue("@CTYPE", obj.clientType);
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

            string sql = "DELETE FROM CLIENTS WHERE ID_CLIENT = @ID ; ";
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

        public Clients SelectFromDbByRN(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM CLIENTS WHERE CLIENT_REGISTRATION = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Cities_Controller _SController = new Cities_Controller();
                                PhoneClassifications_Controller _PCController = new PhoneClassifications_Controller();
                                PaymentConditions_Controller _payController = new PaymentConditions_Controller();
                                Clients obj = new Clients
                                {
                                    id = Convert.ToInt32(reader["id_client"]),
                                    name = Convert.ToString(reader["client_name"]),
                                    PaymentCondition = _payController.FindItemId(Convert.ToInt32(reader["paycond_id"])),
                                    gender = Convert.ToInt32(reader["client_gender"]),
                                    registrationNumber = Convert.ToString(reader["client_registration"]),
                                    age = Convert.ToInt32(reader["client_age"]),
                                    dateOfBirth = Convert.ToDateTime(reader["client_dob"]),
                                    email = Convert.ToString(reader["client_email"]),
                                    phoneNumber1 = Convert.ToString(reader["client_phone1"]),
                                    phoneNumber2 = Convert.ToString(reader["client_phone2"]),
                                    phoneNumber3 = Convert.ToString(reader["client_phone3"]),
                                    phoneClass1 = _PCController.FindItemId(Convert.ToInt32(reader["client_phone_class1"])),
                                    phoneClass2 = _PCController.FindItemId(Convert.ToInt32(reader["client_phone_class2"])),
                                    phoneClass3 = _PCController.FindItemId(Convert.ToInt32(reader["client_phone_class3"])),
                                    streetName = Convert.ToString(reader["CLIENT_STREET_NAME"]),
                                    district = Convert.ToString(reader["CLIENT_DISTRICT"]),
                                    houseNumber = Convert.ToString(reader["CLIENT_HOUSE_NUMBER"]),
                                    homeType = Convert.ToString(reader["CLIENT_HOME_TYPE"]),
                                    complement = Convert.ToString(reader["CLIENT_COMPLEMENT"]),
                                    zipCode = Convert.ToString(reader["CLIENT_ZIP_CODE"]),
                                    clientType = Convert.ToInt32(reader["client_type"]),
                                    city = _SController.FindItemId(Convert.ToInt32(reader["city_id"])),
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
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }


        public Clients SelectFromDb(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM CLIENTS WHERE CLIENT_NAME = @NAME";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NAME", name);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Cities_Controller _SController = new Cities_Controller();
                                PhoneClassifications_Controller _PCController = new PhoneClassifications_Controller();
                                PaymentConditions_Controller _payController = new PaymentConditions_Controller();
                                Clients obj = new Clients
                                {
                                    id = Convert.ToInt32(reader["id_client"]),
                                    name = Convert.ToString(reader["client_name"]),
                                    PaymentCondition = _payController.FindItemId(Convert.ToInt32(reader["paycond_id"])),
                                    gender = Convert.ToInt32(reader["client_gender"]),
                                    registrationNumber = Convert.ToString(reader["client_registration"]),
                                    age = Convert.ToInt32(reader["client_age"]),
                                    dateOfBirth = Convert.ToDateTime(reader["client_dob"]),
                                    email = Convert.ToString(reader["client_email"]),
                                    phoneNumber1 = Convert.ToString(reader["client_phone1"]),
                                    phoneNumber2 = Convert.ToString(reader["client_phone2"]),
                                    phoneNumber3 = Convert.ToString(reader["client_phone3"]),
                                    phoneClass1 = _PCController.FindItemId(Convert.ToInt32(reader["client_phone_class1"])),
                                    phoneClass2 = _PCController.FindItemId(Convert.ToInt32(reader["client_phone_class2"])),
                                    phoneClass3 = _PCController.FindItemId(Convert.ToInt32(reader["client_phone_class3"])),
                                    streetName = Convert.ToString(reader["CLIENT_STREET_NAME"]),
                                    district = Convert.ToString(reader["CLIENT_DISTRICT"]),
                                    houseNumber = Convert.ToString(reader["CLIENT_HOUSE_NUMBER"]),
                                    homeType = Convert.ToString(reader["CLIENT_HOME_TYPE"]),
                                    complement = Convert.ToString(reader["CLIENT_COMPLEMENT"]),
                                    zipCode = Convert.ToString(reader["CLIENT_ZIP_CODE"]),
                                    clientType = Convert.ToInt32(reader["client_type"]),
                                    city = _SController.FindItemId(Convert.ToInt32(reader["city_id"])),
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
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }

        public Clients SelectFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM CLIENTS WHERE ID_CLIENT = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Cities_Controller _SController = new Cities_Controller();
                                PhoneClassifications_Controller _PCController = new PhoneClassifications_Controller();
                                PaymentConditions_Controller _payController = new PaymentConditions_Controller();
                                Clients obj = new Clients
                                {
                                    id = Convert.ToInt32(reader["id_client"]),
                                    name = Convert.ToString(reader["client_name"]),
                                    PaymentCondition = _payController.FindItemId(Convert.ToInt32(reader["paycond_id"])),
                                    gender = Convert.ToInt32(reader["client_gender"]),
                                    registrationNumber = Convert.ToString(reader["client_registration"]),
                                    age = Convert.ToInt32(reader["client_age"]),
                                    dateOfBirth = Convert.ToDateTime(reader["client_dob"]),
                                    email = Convert.ToString(reader["client_email"]),
                                    phoneNumber1 = Convert.ToString(reader["client_phone1"]),
                                    phoneNumber2 = Convert.ToString(reader["client_phone2"]),
                                    phoneNumber3 = Convert.ToString(reader["client_phone3"]),
                                    phoneClass1 = _PCController.FindItemId(Convert.ToInt32(reader["client_phone_class1"])),
                                    phoneClass2 = _PCController.FindItemId(Convert.ToInt32(reader["client_phone_class2"])),
                                    phoneClass3 = _PCController.FindItemId(Convert.ToInt32(reader["client_phone_class3"])),
                                    streetName = Convert.ToString(reader["CLIENT_STREET_NAME"]),
                                    district = Convert.ToString(reader["CLIENT_DISTRICT"]),
                                    houseNumber = Convert.ToString(reader["CLIENT_HOUSE_NUMBER"]),
                                    homeType = Convert.ToString(reader["CLIENT_HOME_TYPE"]),
                                    complement = Convert.ToString(reader["CLIENT_COMPLEMENT"]),
                                    zipCode = Convert.ToString(reader["CLIENT_ZIP_CODE"]),
                                    clientType = Convert.ToInt32(reader["client_type"]),
                                    city = _SController.FindItemId(Convert.ToInt32(reader["city_id"])),
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

        public List<Clients> SelectAllFromDb()
        {
            string sql = "SELECT * FROM CLIENTS ;";
            List<Clients> clients = null;
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
                        clients = new List<Clients>();
                        foreach (Clients item in reader)
                        {
                            clients.Add(item);
                        }
                    }
                    else
                    {
                        clients = null;
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
            return clients;
        }

        public override DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM CLIENTS ;";
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
