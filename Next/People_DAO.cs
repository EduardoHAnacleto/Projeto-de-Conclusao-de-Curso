using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoEduardoAnacletoWindowsForm1.DAO
{
    public class People_DAO : Master_DAO //OK
    {
        private string connectionString = "Server = localhost; Database = PraticaProfissional1; Trusted_Connection = True;";
        //string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public bool SaveToDb(Clients person)
        {
            bool status = false;
            string sql = "INSERT INTO CLIENTS (PERSON_TYPE, PERSON_NAME, PERSON_GENDER, PERSON_AGE, PERSON_REGISTRATION,PERSON_DOB "
                         + "PERSON_EMAIL, PERSON_PHONE1, PERSON_PHONE2, PERSON_PHONE3, PERSON_PHONE_CLASS1, PERSON_PHONE_CLASS2, PERSON_PHONE_CLASS3, "
                         + "PERSON_STREET_NAME, PERSON_DISTRICT, PERSON_HOUSE_NUMBER, PERSON_HOME_TYPE, PERSON_COMPLEMENT, PERSON_ZIP_CODE, CITY_ID, DATE_CREATION, DATE_LAST_UPDATE) VALUES ('"
                         + person.clientType
                         + ", '"
                         + person.name
                         + "' , '"
                         + person.gender
                         + "' , "
                         + person.age
                         + " , '"
                         + person.registrationNumber
                         + "' , '"
                         + person.dateOfBirth.ToString()
                         + "' , '"
                         + person.email
                         + "','"
                         + person.phoneNumber1
                         + "' , '"
                         + person.phoneNumber2
                         + "' , '"
                         + person.phoneNumber3
                         + "' , '"
                         + person.phoneClass1.id
                         + "' , '"
                         + person.phoneClass2.id
                         + "' , '"
                         + person.phoneClass3.id
                         + "' , '"
                         + person.streetName
                         + "' , '"
                         + person.district
                         + "' , '"
                         + person.houseNumber
                         + "' , '"
                         + person.homeType
                         + "' , '"
                         + person.complement
                         + "' , '"
                         + person.zipCode
                         + "' , "
                         + person.city.id
                         + ", '"
                         + person.dateOfCreation.ToShortDateString()
                         + "', '"
                         + person.dateOfLastUpdate.ToShortDateString()
                         + "' );";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Register added with success!");
                    status = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ ex.Message);
                return status;
            }
            finally 
            { 
                con.Close();
            }
            return status;
        }

        public bool EditFromDB(Clients person)
        {
            bool status = false;
            string sql = "UPDATE CLIENTS SET PERSON_NAME = '"
                         + person.name
                         + "', PERSON_TYPE = "
                         + person.gender
                         + ", PERSON_GENDER = '"
                         + person.gender
                         + "' , PERSON_AGE = "
                         + person.age
                         + ", PERSON_DOB = '"
                         + person.dateOfBirth
                         + "', PERSON_EMAIL = '"
                         + person.email
                         + "', PERSON_PHONE1 = '"
                         + person.phoneNumber1
                         + "', PERSON_PHONE2 = '"
                         + person.phoneNumber2
                         + "', PERSON_PHONE3 = '"
                         + person.phoneNumber3
                         + "', PERSON_PHONE_CLASS1 = '"
                         + person.phoneClass1
                         + "', PERSON_PHONE_CLASS2 = '"
                         + person.phoneClass2
                         + "', PERSON_PHONE_CLASS3 = ' "
                         + person.phoneClass3
                         + "', PERSON_STREET_NAME = '"
                         + person.streetName
                         + "', PERSON_DISTRICT = '"
                         + person.district
                         + "', PERSON_HOUSE_NUMBER = '"
                         + person.houseNumber
                         + "', PERSON_HOME_TYPE = '"
                         + person.homeType
                         + "', PERSON_COMPLEMENT = '"
                         + person.complement
                         + "', PERSON_ZIP_CODE = '"
                         + person.zipCode
                         + "', CITY_ID = "
                         + person.city.id
                         + ", DATE_LAST_UPDATE = '"
                         + person.dateOfLastUpdate.ToShortDateString()
                         + "' WHERE PERSON_REGISTRATION = '"
                         + person.registrationNumber
                         + "' ;" ;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
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
                con.Close();
            }
            return status;
        }

        public bool DeleteFromDb(string id)
        {
            bool status = false;
            string sql = "DELETE FROM CLIENTS WHERE PERSON_REGISTRATION = '" + id + "' ;";

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

        public People SelectFromDbByRN(string id)
        {
            string sql = "SELECT * FROM CLIENTS WHERE PERSON_REGISTRATION = '" + id + "' ;" ;

            Clients person = null;
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
                        Cities city = new Cities();
                        Cities_DAO cities_DAO = new Cities_DAO();
                        PhoneClassifications phoneClass = new PhoneClassifications();
                        PhoneClassifications_DAO phoneClass_DAO = new PhoneClassifications_DAO();
                        person = new Clients();
                        person.clientType = Convert.ToInt32(reader.GetSqlValue(0).ToString());
                        person.registrationNumber = reader.GetSqlValue(1).ToString();
                        person.name = reader.GetSqlValue(2).ToString();
                        person.gender = Convert.ToInt32(reader.GetSqlValue(3).ToString());
                        person.age = Convert.ToInt32(reader.GetSqlValue(4).ToString());
                        person.dateOfBirth = Convert.ToDateTime(reader.GetSqlValue(5).ToString());
                        person.email = reader.GetSqlValue(6).ToString();
                        person.phoneNumber1 = reader.GetSqlValue(7).ToString();
                        person.phoneNumber2 = reader.GetSqlValue(8).ToString();
                        person.phoneNumber3 = reader.GetSqlValue(9).ToString();
                        phoneClass = phoneClass_DAO.SelectFromDb(Convert.ToInt32(reader.GetSqlValue(10).ToString()));
                        person.phoneClass1 = phoneClass;
                        phoneClass = phoneClass_DAO.SelectFromDb(Convert.ToInt32(reader.GetSqlValue(11).ToString()));
                        person.phoneClass2 = phoneClass;
                        phoneClass = phoneClass_DAO.SelectFromDb(Convert.ToInt32(reader.GetSqlValue(12).ToString()));
                        person.phoneClass3 = phoneClass;
                        person.streetName = reader.GetString(13).ToString();
                        person.district = reader.GetString(14).ToString();
                        person.houseNumber = reader.GetSqlValue(15).ToString();
                        person.complement = reader.GetString(16).ToString();
                        person.zipCode = reader.GetString(17).ToString();
                        city = cities_DAO.SelectFromDb(Convert.ToInt32(reader.GetSqlValue(18).ToString()));
                        person.city = city;
                        person.dateOfCreation = Convert.ToDateTime(reader.GetSqlValue(19).ToString());
                        person.dateOfLastUpdate = Convert.ToDateTime(reader.GetSqlValue(20).ToString());
                    }
                    else
                    {
                       person = null;
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
            return person;
        }


        public Clients SelectFromDb(string name)
        {
            string sql = "SELECT * FROM CLIENTS WHERE PERSON_NAME = '" + name + "';";
            Clients person = null;
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
                        Cities city = new Cities();
                        Cities_DAO cities_DAO = new Cities_DAO();
                        PhoneClassifications phoneClass = new PhoneClassifications();
                        PhoneClassifications_DAO phoneClass_DAO = new PhoneClassifications_DAO();
                        person = new Clients();
                        person.clientType = Convert.ToInt32(reader.GetSqlValue(0).ToString());
                        person.registrationNumber = reader.GetSqlValue(1).ToString();
                        person.name = reader.GetSqlValue(2).ToString();
                        person.gender = Convert.ToInt32(reader.GetSqlValue(3).ToString());
                        person.age = Convert.ToInt32(reader.GetSqlValue(4).ToString());
                        person.dateOfBirth = Convert.ToDateTime(reader.GetSqlValue(5).ToString());
                        person.email = reader.GetSqlValue(6).ToString();
                        person.phoneNumber1 = reader.GetSqlValue(7).ToString();
                        person.phoneNumber2 = reader.GetSqlValue(8).ToString();
                        person.phoneNumber3 = reader.GetSqlValue(9).ToString();
                        phoneClass = phoneClass_DAO.SelectFromDb(Convert.ToInt32(reader.GetSqlValue(10).ToString()));
                        person.phoneClass1 = phoneClass;
                        phoneClass = phoneClass_DAO.SelectFromDb(Convert.ToInt32(reader.GetSqlValue(11).ToString()));
                        person.phoneClass2 = phoneClass;
                        phoneClass = phoneClass_DAO.SelectFromDb(Convert.ToInt32(reader.GetSqlValue(12).ToString()));
                        person.phoneClass3 = phoneClass;
                        person.streetName = reader.GetString(13).ToString();
                        person.district = reader.GetString(14).ToString();
                        person.houseNumber = reader.GetSqlValue(15).ToString();
                        person.complement = reader.GetString(16).ToString();
                        person.zipCode = reader.GetString(17).ToString();
                        city = cities_DAO.SelectFromDb(Convert.ToInt32(reader.GetSqlValue(18).ToString()));
                        person.city = city;
                        person.dateOfCreation = Convert.ToDateTime(reader.GetSqlValue(19).ToString());
                        person.dateOfLastUpdate = Convert.ToDateTime(reader.GetSqlValue(20).ToString());
                    }
                    else
                    {
                        person = null;
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
            return person;
        }

        public List<Clients> SelectAllFromDb()
        {
            string sql = "SELECT * FROM CLIENTS ;";
            List<Clients> people = null;
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
                        people = new List<Clients>();
                        foreach (Clients item in reader)
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

        public new DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            string sql = "SELECT * FROM PEOPLE ;";
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
