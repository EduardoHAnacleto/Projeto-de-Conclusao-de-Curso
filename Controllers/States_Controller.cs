using ProjetoEduardoAnacletoWindowsForm1.DAO;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjetoEduardoAnacletoWindowsForm1.Controllers
{
    public class States_Controller : Master_Controller
    {

        private States _state = new States();
        private States_DAO _DAO = new States_DAO();

        public States_Controller()
        {

        }

        public void SaveItem(States state)
        {
            _state = state;
            _state.dateOfCreation = DateTime.Now;
            _state.dateOfLastUpdate = _state.dateOfCreation;
            _DAO.SaveToDb(_state);
        }
        public new List<States> LoadItems()
        {
            return _DAO.SelectAllFromDb();
        }
        public States FindItemId(int id)
        {
            return _DAO.SelectFromDb(id);
        }

        public Countries FindCountryItemId(int id)
        {
            Countries_Controller cControler = new Countries_Controller();
            return cControler.FindItemId(id);
        }

        public Countries FindCountryNameId(string name)
        {
            Countries_Controller cControler = new Countries_Controller();
            return cControler.FindItemName(name);
        }

        public States FindItemName(string name)
        {
            return _DAO.SelectFromDb(name);
        }
        public new void DeleteItem(int id)
        {
            int Id = Convert.ToInt32(id);
            _DAO.DeleteFromDb(Id);
        }
        public void UpdateItem(States state)
        {
            _state = state;
            string format = "yyyy-MM-dd";
            _state.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _DAO.EditFromDB(_state);
        }
        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _DAO.SelectDataSourceFromDB();
            return ds;
        }

        public new int BringNewId()
        {
            return _DAO.NewId();
        }
    }
}