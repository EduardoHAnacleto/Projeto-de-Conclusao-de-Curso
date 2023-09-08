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
using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;

namespace ProjetoEduardoAnacletoWindowsForm1.DAO
{
    public class Suppliers_DAO : Master_DAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public override int NewId()
        {
            var newId = "";
            string sql = "SELECT MAX(ID_SUPPLIER) FROM SUPPLIERS;";
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

        public bool SaveToDb(Suppliers obj)
        {
            bool status = false;

            string sql = "INSERT INTO SUPPLIERS ( SUPPLIER_NAME, SUPPLIER_REGISTRATION, SUPPLIER_EMAIL," +
                "SUPPLIER_PHONE1, SUPPLIER_PHONE2, SUPPLIER_PHONE3, SUPPLIER_PHONE_CLASS1, SUPPLIER_PHONE_CLASS2, SUPPLIER_PHONE_CLASS3," +
                "SUPPLIER_STREET_NAME, SUPPLIER_DISTRICT, SUPPLIER_HOUSE_NUMBER, SUPPLIER_HOME_TYPE, SUPPLIER_COMPLEMENT, SUPPLIER_ZIP_CODE," +
                " CITY_ID, SUPPLIER_SOCIAL_REASON, SUPPLIER_STATE_INSCRIPTION, DATE_CREATION, DATE_LAST_UPDATE) VALUES " +
                "(@NAME, @REGISTRATION, @EMAIL, @PHONE1, @PHONE2, @PHONE3, @PCLASS1, @PCLASS2, @PCLASS3," +
                "@STREET, @DISTRICT, @HOUSENUMBER, @HOMETYPE, @COMPLEMENT, @ZIPCODE, @CITYID, @SOCIAL, @INSCRIPTION, @DC, @DU)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@NAME", obj.name);
                    command.Parameters.AddWithValue("@REGISTRATION", obj.registrationNumber);
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
                    command.Parameters.AddWithValue("@SOCIAL", obj.socialReason);
                    command.Parameters.AddWithValue("@INSCRIPTION", obj.stateInscription);
                    command.Parameters.AddWithValue("@DC", obj.dateOfCreation);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Register added with success!");
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

        public bool EditFromDB(Suppliers obj)
        {
            bool status = false;

            string sql = "UPDATE SUPPLIERS SET SUPPLIER_NAME = @NAME, SUPPLIER_REGISTRATION = @REGISTRATION , " +
                "SUPPLIER_EMAIL = @EMAIL, SUPPLIER_PHONE1 = @PHONE1, SUPPLIER_PHONE2 = @PHONE2, " +
                "SUPPLIER_PHONE3 = @PHONE3, SUPPLIER_PHONE_CLASS1 = @PCLASS1, SUPPLIER_PHONE_CLASS2 = @PCLASS2, SUPPLIER_PHONE_CLASS3 = @PCLASS3," +
                "SUPPLIER_STREET_NAME = @STREET, SUPPLIER_DISTRICT = @DISTRICT, SUPPLIER_HOUSE_NUMBER = @HNUMBER, SUPPLIER_HOME_TYPE = @HTYPE," +
                "SUPPLIER_COMPLEMENT = @COMPLEMENT, SUPPLIER_ZIP_CODE = @ZIPCODE, CITY_ID = @CITYID," +
                "SUPPLIER_SOCIAL_REASON = @SOCIALREASON, SUPPLIER_STATE_INSCRIPTION = @STATEINSCIPTION ,DATE_LAST_UPDATE = @DU " +
                "WHERE ID_SUPPLIER = @ID ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", obj.id);
                    command.Parameters.AddWithValue("@NAME", obj.name);
                    command.Parameters.AddWithValue("@REGISTRATION", obj.registrationNumber);
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
                    command.Parameters.AddWithValue("@SOCIALREASON", obj.socialReason);
                    command.Parameters.AddWithValue("@STATEINSCIPTION", obj.stateInscription);
                    command.Parameters.AddWithValue("@CITYID", obj.city.id);
                    command.Parameters.AddWithValue("@DU", obj.dateOfLastUpdate);
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Register altered with success!");
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

        public override bool DeleteFromDb(int id)
        {
            bool status = false;

            string sql = "DELETE FROM SUPPLIERS WHERE ID_SUPPLIER = @ID ; ";
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

        public Suppliers SelectFromDbByRN(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SUPPLIERS WHERE SUPPLIER_REGISTRATION = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Cities_Controller _SController = new Cities_Controller();
                                PhoneClassifications_Controller _PCController = new PhoneClassifications_Controller();
                                Suppliers obj = new Suppliers
                                {
                                    id = Convert.ToInt32(reader["id_supplier"]),
                                    name = Convert.ToString(reader["supplier_name"]),
                                    registrationNumber = Convert.ToString(reader["supplier_registration"]),
                                    email = Convert.ToString(reader["supplier_email"]),
                                    phoneNumber1 = Convert.ToString(reader["supplier_phone1"]),
                                    phoneNumber2 = Convert.ToString(reader["supplier_phone2"]),
                                    phoneNumber3 = Convert.ToString(reader["client_phone3"]),
                                    phoneClass1 = _PCController.FindItemId(Convert.ToInt32(reader["supplier_phone_class1"])),
                                    phoneClass2 = _PCController.FindItemId(Convert.ToInt32(reader["supplier_phone_class2"])),
                                    phoneClass3 = _PCController.FindItemId(Convert.ToInt32(reader["supplier_phone_class3"])),
                                    streetName = Convert.ToString(reader["SUPPLIER_STREET_NAME"]),
                                    district = Convert.ToString(reader["SUPPLIER_DISTRICT"]),
                                    houseNumber = Convert.ToString(reader["SUPPLIER_HOUSE_NUMBER"]),
                                    homeType = Convert.ToString(reader["SUPPLIER_HOME_TYPE"]),
                                    complement = Convert.ToString(reader["SUPPLIER_COMPLEMENT"]),
                                    zipCode = Convert.ToString(reader["SUPPLIER_ZIP_CODE"]),
                                    city = _SController.FindItemId(Convert.ToInt32(reader["city_id"])),
                                    socialReason = Convert.ToString(reader["supplier_social_reason"]),
                                    stateInscription = Convert.ToString(reader["supplier_state_inscription"]),
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

        public Suppliers SelectFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SUPPLIERS WHERE ID_SUPPLIER = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Cities_Controller _SController = new Cities_Controller();
                                PhoneClassifications_Controller _PCController = new PhoneClassifications_Controller();
                                Suppliers obj = new Suppliers
                                {
                                    id = Convert.ToInt32(reader["id_supplier"]),
                                    name = Convert.ToString(reader["supplier_name"]),
                                    registrationNumber = Convert.ToString(reader["supplier_registration"]),
                                    email = Convert.ToString(reader["supplier_email"]),
                                    phoneNumber1 = Convert.ToString(reader["supplier_phone1"]),
                                    phoneNumber2 = Convert.ToString(reader["supplier_phone2"]),
                                    phoneNumber3 = Convert.ToString(reader["supplier_phone3"]),
                                    phoneClass1 = _PCController.FindItemId(Convert.ToInt32(reader["supplier_phone_class1"])),
                                    phoneClass2 = _PCController.FindItemId(Convert.ToInt32(reader["supplier_phone_class2"])),
                                    phoneClass3 = _PCController.FindItemId(Convert.ToInt32(reader["supplier_phone_class3"])),
                                    streetName = Convert.ToString(reader["SUPPLIER_STREET_NAME"]),
                                    district = Convert.ToString(reader["SUPPLIER_DISTRICT"]),
                                    houseNumber = Convert.ToString(reader["SUPPLIER_HOUSE_NUMBER"]),
                                    homeType = Convert.ToString(reader["SUPPLIER_HOME_TYPE"]),
                                    complement = Convert.ToString(reader["SUPPLIER_COMPLEMENT"]),
                                    zipCode = Convert.ToString(reader["SUPPLIER_ZIP_CODE"]),
                                    city = _SController.FindItemId(Convert.ToInt32(reader["city_id"])),
                                    socialReason = Convert.ToString(reader["supplier_social_reason"]),
                                    stateInscription = Convert.ToString(reader["supplier_state_inscription"]),
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

        public Suppliers SelectFromDb(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM SUPPLIERS WHERE SUPPLIER_NAME = @NAME";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NAME", name);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Cities_Controller _SController = new Cities_Controller();
                                PhoneClassifications_Controller _PCController = new PhoneClassifications_Controller();
                                Suppliers obj = new Suppliers
                                {
                                    id = Convert.ToInt32(reader["id_supplier"]),
                                    name = Convert.ToString(reader["supplier_name"]),
                                    registrationNumber = Convert.ToString(reader["supplier_registration"]),
                                    email = Convert.ToString(reader["supplier_email"]),
                                    phoneNumber1 = Convert.ToString(reader["supplier_phone1"]),
                                    phoneNumber2 = Convert.ToString(reader["supplier_phone2"]),
                                    phoneNumber3 = Convert.ToString(reader["supplier_phone3"]),
                                    phoneClass1 = _PCController.FindItemId(Convert.ToInt32(reader["supplier_phone_class1"])),
                                    phoneClass2 = _PCController.FindItemId(Convert.ToInt32(reader["supplier_phone_class2"])),
                                    phoneClass3 = _PCController.FindItemId(Convert.ToInt32(reader["supplier_phone_class3"])),
                                    streetName = Convert.ToString(reader["SUPPLIER_STREET_NAME"]),
                                    district = Convert.ToString(reader["SUPPLIER_DISTRICT"]),
                                    houseNumber = Convert.ToString(reader["SUPPLIER_HOUSE_NUMBER"]),
                                    homeType = Convert.ToString(reader["SUPPLIER_HOME_TYPE"]),
                                    complement = Convert.ToString(reader["SUPPLIER_COMPLEMENT"]),
                                    zipCode = Convert.ToString(reader["SUPPLIER_ZIP_CODE"]),
                                    city = _SController.FindItemId(Convert.ToInt32(reader["city_id"])),
                                    socialReason = Convert.ToString(reader["supplier_social_reason"]),
                                    stateInscription = Convert.ToString(reader["supplier_state_inscription"]),
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

        public List<Suppliers> SelectAllFromDb()
        {
            string sql = "SELECT * FROM SUPPLIERS ;";
            List<Suppliers> people = null;
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
                        people = new List<Suppliers>();
                        foreach (Suppliers item in reader)
                        {
                            people.Add(item);
                        }
                    }
                    else
                    {
                        people = null;
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
            return people;
        }

        public override DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM SUPPLIERS ;";
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
