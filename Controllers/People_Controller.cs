using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.DAO;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Controllers
{
    public class People_Controller : Master_Controller
    {

        private Clients _Obj = new Clients();
        private readonly Clients_DAO _DAO = new Clients_DAO();

        public People_Controller()
        {

        }

        public new virtual int BringNewId()
        {
            return _DAO.NewId();
        }

        public void SaveItem(Clients person)
        {
            _Obj = person;
            _DAO.SaveToDb(_Obj);          
        }
        public new List<Clients> LoadItems()
        {
            return _DAO.SelectAllFromDb();
        }
        public People FindItemId(string id)
        {
            return _DAO.SelectFromDb(id);        
        }
        public People FindItemName(string name)
        {
            return _DAO.SelectFromDb(name);        
        }
        public new void DeleteItem(int id)
        {
            _DAO.DeleteFromDb(id);
        }
        public void UpdateItem(Clients person)
        {
            _Obj = person;
            string format = "yyyy-MM-dd";
            _Obj.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _DAO.EditFromDB(_Obj);
        }

        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _DAO.SelectDataSourceFromDB();
            return ds;
        }
    }
}
