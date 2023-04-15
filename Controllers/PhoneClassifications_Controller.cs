using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class PhoneClassifications_Controller : Master_Controller
    {
        private PhoneClassifications _phoneClass = new PhoneClassifications();
        private PhoneClassifications_DAO _phoneClassDAO = new PhoneClassifications_DAO();

        public PhoneClassifications_Controller()
        {

        }

        public void SaveItem(PhoneClassifications phoneClass)
        {
            _phoneClass = phoneClass;
            _phoneClassDAO.SaveToDb(_phoneClass);
        }
        //public List<PhoneClassifications> LoadItems()
        //{
        //    return _phoneClassDAO.SelectAllFromDb();
        //}

        public new DataTable LoadItems() //Teste
        {
            DataTable ds = new DataTable();
            ds = _phoneClassDAO.SelectDataSourceFromDB();
            return ds;
        }

        public PhoneClassifications FindItemId(int id)
        {
            return _phoneClassDAO.SelectFromDb(id);
        }
        public PhoneClassifications FindItemName(string name)
        {
            return _phoneClassDAO.SelectFromDb(name);
        }
        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _phoneClassDAO.SelectDataSourceFromDB();
            return ds;
        }

        public new void DeleteItem(int id)
        {
            _phoneClassDAO.DeleteFromDb(id);
        }
        public void UpdateItem(PhoneClassifications phoneClass)
        {
            _phoneClass = phoneClass;
            string format = "yyyy-MM-dd";
            _phoneClass.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _phoneClassDAO.EditFromDB(_phoneClass);
        }

        public new int BringNewId()
        {
            return _phoneClassDAO.NewId();
        }
    }
}