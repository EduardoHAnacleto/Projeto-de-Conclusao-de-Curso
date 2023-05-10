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
using ProjetoEduardoAnacletoWindowsForm1.Controllers;

namespace ProjetoEduardoAnacletoWindowsForm1.DAO
{
    public class Employees_DAO : Master_DAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public override int NewId()
        {
            var newId = "";
            string sql = "SELECT MAX(ID_EMPLOYEE) FROM EMPLOYEES;";
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

        public bool SaveToDb(Employees obj)
        {
            bool status = false;

            string sql = "INSERT INTO EMPLOYEES ( EMPLOYEE_NAME, EMPLOYEE_GENDER, EMPLOYEE_REGISTRATION, EMPLOYEE_AGE, EMPLOYEE_DOB, EMPLOYEE_EMAIL," +
                "EMPLOYEE_PHONE1, EMPLOYEE_PHONE2, EMPLOYEE_PHONE3, EMPLOYEE_PHONE_CLASS1, EMPLOYEE_PHONE_CLASS2, EMPLOYEE_PHONE_CLASS3," +
                "STREET_NAME, DISTRICT, HOUSE_NUMBER, HOME_TYPE, COMPLEMENT, ZIPCODE, ID_CITY, JOBROLE," +
                "BASESALARY, WEEKLYHOURS, EMPLOYEE_STATUS, ADMISSION_DATE, DISMISSED_DATE ,DATE_CREATION, DATE_LAST_UPDATE) VALUES " +
                "(@NAME, @GENDER, @REGISTRATION, @AGE, @DOB, @EMAIL, @PHONE1, @PHONE2, @PHONE3, @PCLASS1, @PCLASS2, @PCLASS3," +
                "@STREET, @DISTRICT, @HOUSENUMBER, @HOMETYPE, @COMPLEMENT, @ZIPCODE, @CITYID, @ROLE, @SALARY, @WEEKHOURS," +
                "@STATUS, @ADDATE, @DISDATE, @DC, @DU)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@NAME", obj.name);
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
                    command.Parameters.AddWithValue("@ROLE", obj.jobRole);
                    command.Parameters.AddWithValue("@SALARY", (decimal)obj.baseSalary);
                    command.Parameters.AddWithValue("@WEEKHOURS", obj.weeklyHours);
                    command.Parameters.AddWithValue("@STATUS", obj.jobStatus);
                    command.Parameters.AddWithValue("@ADDATE", obj.startDate);
                    command.Parameters.AddWithValue("@DISDATE", obj.endDate);
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

        public bool EditFromDB(Employees obj)
        {
            bool status = false;

            string sql = "UPDATE EMPLOYEES SET EMPLOYEE_NAME = @NAME, EMPLOYEE_REGISTRATION = @REGISTRATION , EMPLOYEE_GENDER = @GENDER, " +
                "EMPLOYEE_AGE = @AGE, EMPLOYEE_DOB = @DOB, EMPLOYEE_EMAIL = @EMAIL, EMPLOYEE_PHONE1 = @PHONE1, EMPLOYEE_PHONE2 = @PHONE2, " +
                "EMPLOYEE_PHONE3 = @PHONE3, EMPLOYEE_PHONE_CLASS1 = @PCLASS1, EMPLOYEE_PHONE_CLASS2 = @PCLASS2, EMPLOYEE_PHONE_CLASS3 = @PCLASS3," +
                "STREET_NAME = @STREET, DISTRICT = @DISTRICT, HOUSE_NUMBER = @HNUMBER, HOME_TYPE = @HTYPE," +
                "COMPLEMENT = @COMPLEMENT, ZIPCODE = @ZIPCODE, ID_CITY = @CITYID, JOBROLE = @JOBROLE, BASESALARY = @SALARY," +
                "WEEKLYHOURS = @WKHOURS, EMPLOYEE_STATUS = @STATUS, ADMISSION_DATE = @ADDATE, DISMISSED_DATE = @DIDATE ,DATE_LAST_UPDATE = @DU " +
                "WHERE ID_EMPLOYEE = @ID ; ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@ID", obj.id);
                    command.Parameters.AddWithValue("@NAME", obj.name);
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
                    command.Parameters.AddWithValue("@JOBROLE", obj.jobRole);
                    command.Parameters.AddWithValue("@SALARY", (decimal)obj.baseSalary);
                    command.Parameters.AddWithValue("@WKHOURS", obj.weeklyHours);
                    command.Parameters.AddWithValue("@STATUS", obj.jobStatus);
                    command.Parameters.AddWithValue("@ADDATE", obj.startDate);
                    command.Parameters.AddWithValue("@DIDATE", obj.endDate);
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

            string sql = "DELETE FROM EMPLOYEES WHERE ID_EMPLOYEE = @ID ; ";
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

        public Employees SelectFromDbByRN(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM EMPLOYEES WHERE EMPLOYEE_REGISTRATION = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Cities_Controller _SController = new Cities_Controller();
                                PhoneClassifications_Controller _PCController = new PhoneClassifications_Controller();
                                Employees obj = new Employees
                                {
                                    id = Convert.ToInt32(reader["id_employee"]),
                                    name = Convert.ToString(reader["employee_name"]),
                                    gender = Convert.ToInt32(reader["employee_gender"]),
                                    registrationNumber = Convert.ToString(reader["employee_registration"]),
                                    age = Convert.ToInt32(reader["employee_age"]),
                                    dateOfBirth = Convert.ToDateTime(reader["employee_dob"]),
                                    email = Convert.ToString(reader["employee_email"]),
                                    phoneNumber1 = Convert.ToString(reader["employee_phone1"]),
                                    phoneNumber2 = Convert.ToString(reader["employee_phone2"]),
                                    phoneNumber3 = Convert.ToString(reader["employee_phone3"]),
                                    phoneClass1 = _PCController.FindItemId(Convert.ToInt32(reader["employee_phone_class1"])),
                                    phoneClass2 = _PCController.FindItemId(Convert.ToInt32(reader["employee_phone_class2"])),
                                    phoneClass3 = _PCController.FindItemId(Convert.ToInt32(reader["employee_phone_class3"])),
                                    streetName = Convert.ToString(reader["street_name"]),
                                    district = Convert.ToString(reader["district"]),
                                    houseNumber = Convert.ToString(reader["house_number"]),
                                    homeType = Convert.ToString(reader["home_type"]),
                                    complement = Convert.ToString(reader["complement"]),
                                    zipCode = Convert.ToString(reader["zipcode"]),
                                    city = _SController.FindItemId(Convert.ToInt32(reader["city_id"])),
                                    jobRole = Convert.ToString(reader["jobRole"]),
                                    baseSalary = Convert.ToDouble(reader["baseSalary"]),
                                    weeklyHours = Convert.ToInt32(reader["weeklyHours"]),
                                    jobStatus = Convert.ToInt32(reader["employee_status"]),
                                    startDate = Convert.ToDateTime(reader["admission_date"]),
                                    endDate = Convert.ToDateTime(reader["dismissed_date"]),
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


        public Employees SelectFromDb(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM EMPLOYEES WHERE EMPLOYEE_NAME = @NAME";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NAME", name);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Cities_Controller _SController = new Cities_Controller();
                                PhoneClassifications_Controller _PCController = new PhoneClassifications_Controller();
                                Employees obj = new Employees
                                {
                                    id = Convert.ToInt32(reader["id_employee"]),
                                    name = Convert.ToString(reader["employee_name"]),
                                    gender = Convert.ToInt32(reader["employee_gender"]),
                                    registrationNumber = Convert.ToString(reader["employee_registration"]),
                                    age = Convert.ToInt32(reader["employee_age"]),
                                    dateOfBirth = Convert.ToDateTime(reader["employee_dob"]),
                                    email = Convert.ToString(reader["employee_email"]),
                                    phoneNumber1 = Convert.ToString(reader["employee_phone1"]),
                                    phoneNumber2 = Convert.ToString(reader["employee_phone2"]),
                                    phoneNumber3 = Convert.ToString(reader["employee_phone3"]),
                                    phoneClass1 = _PCController.FindItemId(Convert.ToInt32(reader["employee_phone_class1"])),
                                    phoneClass2 = _PCController.FindItemId(Convert.ToInt32(reader["employee_phone_class2"])),
                                    phoneClass3 = _PCController.FindItemId(Convert.ToInt32(reader["employee_phone_class3"])),
                                    streetName = Convert.ToString(reader["street_name"]),
                                    district = Convert.ToString(reader["district"]),
                                    houseNumber = Convert.ToString(reader["house_number"]),
                                    homeType = Convert.ToString(reader["home_type"]),
                                    complement = Convert.ToString(reader["complement"]),
                                    zipCode = Convert.ToString(reader["zipcode"]),
                                    city = _SController.FindItemId(Convert.ToInt32(reader["city_id"])),
                                    jobRole = Convert.ToString(reader["jobRole"]),
                                    baseSalary = Convert.ToDouble(reader["baseSalary"]),
                                    weeklyHours = Convert.ToInt32(reader["weeklyHours"]),
                                    jobStatus = Convert.ToInt32(reader["employee_status"]),
                                    startDate = Convert.ToDateTime(reader["admission_date"]),
                                    endDate = Convert.ToDateTime(reader["dismissed_date"]),
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

        public Employees SelectFromDb(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM EMPLOYEES WHERE ID_EMPLOYEE = @ID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Cities_Controller _SController = new Cities_Controller();
                                PhoneClassifications_Controller _PCController = new PhoneClassifications_Controller();
                                Employees obj = new Employees
                                {
                                    id = Convert.ToInt32(reader["id_employee"]),
                                    name = Convert.ToString(reader["employee_name"]),
                                    gender = Convert.ToInt32(reader["employee_gender"]),
                                    registrationNumber = Convert.ToString(reader["employee_registration"]),
                                    age = Convert.ToInt32(reader["employee_age"]),
                                    dateOfBirth = Convert.ToDateTime(reader["employee_dob"]),
                                    email = Convert.ToString(reader["employee_email"]),
                                    phoneNumber1 = Convert.ToString(reader["employee_phone1"]),
                                    phoneNumber2 = Convert.ToString(reader["employee_phone2"]),
                                    phoneNumber3 = Convert.ToString(reader["employee_phone3"]),
                                    phoneClass1 = _PCController.FindItemId(Convert.ToInt32(reader["employee_phone_class1"])),
                                    phoneClass2 = _PCController.FindItemId(Convert.ToInt32(reader["employee_phone_class2"])),
                                    phoneClass3 = _PCController.FindItemId(Convert.ToInt32(reader["employee_phone_class3"])),
                                    streetName = Convert.ToString(reader["street_name"]),
                                    district = Convert.ToString(reader["district"]),
                                    houseNumber = Convert.ToString(reader["house_number"]),
                                    homeType = Convert.ToString(reader["home_type"]),
                                    complement = Convert.ToString(reader["complement"]),
                                    zipCode = Convert.ToString(reader["zipcode"]),
                                    city = _SController.FindItemId(Convert.ToInt32(reader["id_city"])),
                                    jobRole = Convert.ToString(reader["jobRole"]),
                                    baseSalary = Convert.ToDouble(reader["baseSalary"]),
                                    weeklyHours = Convert.ToInt32(reader["weeklyHours"]),
                                    jobStatus = Convert.ToInt32(reader["employee_status"]),
                                    startDate = Convert.ToDateTime(reader["admission_date"]),
                                    endDate = Convert.ToDateTime(reader["dismissed_date"]),
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

        public List<Employees> SelectAllFromDb()
        {
            string sql = "SELECT * FROM EMPLOYEES ;";
            List<Employees> people = null;
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
                        people = new List<Employees>();
                        foreach (Employees item in reader)
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
            string sql = "SELECT * FROM EMPLOYEES ;";
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
