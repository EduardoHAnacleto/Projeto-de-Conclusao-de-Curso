using ProjetoEduardoAnacletoWindowsForm1.DAO;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Controllers
{
    public class Countries_Controller : Master_Controller
    {
        private Countries _country = new Countries();
        private Countries_DAO _countriesDAO = new Countries_DAO();

        public Countries_Controller()
        {

        }

        public void SaveItem(Countries country)
        {
            _country = country;
            _countriesDAO.SaveToDb(_country);
        }
        public new List<Countries> LoadItems()
        {
            return _countriesDAO.SelectAllFromDb();
        }
        public Countries FindItemId(int id)
        {
            return _countriesDAO.SelectFromDb(id);
        }
        public Countries FindItemName(string name)
        {
            return _countriesDAO.SelectFromDb(name);
        }
        public new void DeleteItem(int id)
        {
            _countriesDAO.DeleteFromDb(id);
        }

        public void UpdateItem(Countries country)
        {
            _country = country;
            string format = "yyyy-MM-dd";
            _country.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _countriesDAO.EditFromDB(_country);
        }

        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _countriesDAO.SelectDataSourceFromDB();
            return ds;
        }

        public new int BringNewId()
        {
            return _countriesDAO.NewId();
        }
    }
}