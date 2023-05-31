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
    public class Cities_Controller
    {
        private Cities _city = new Cities();
        private Cities_DAO _DAO = new Cities_DAO();

        public Cities_Controller()
        {

        }

        public void SaveItem(Cities city)
        {
            _city = city;
            _city.dateOfCreation = DateTime.Now;
            _city.dateOfLastUpdate = _city.dateOfCreation;
            _DAO.SaveToDb(_city);
        }
        public List<Cities> LoadItems()
        {
            return _DAO.SelectAllFromDb();
        }

        public States FindStateItemId(int id) 
        {
            States_Controller sController = new States_Controller();
            return sController.FindItemId(id);
        }

        public States FindStateNameId(string name)
        {
            States_Controller sController = new States_Controller();
            return sController.FindItemName(name);
        }

        public Cities FindItemId(int id)
        {
            return _DAO.SelectFromDb(id);
        }
        public Cities FindItemName(string name)
        {
            return _DAO.SelectFromDb(name);
        }
        public void DeleteItem(int id)
        {
            _DAO.DeleteFromDb(id);
        }
        public void UpdateItem(Cities city)
        {
            _city = city;
            string format = "yyyy-MM-dd";
            _city.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _DAO.EditFromDB(_city);
        }

        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _DAO.SelectDataSourceFromDB();
            return ds;
        }

        public int BringNewId()
        {
            return _DAO.NewId();
        }

    }
}