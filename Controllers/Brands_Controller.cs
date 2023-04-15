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
    public class Brands_Controller : Master_Controller
    {
        private Brands _Obj = new Brands();
        private Brands_DAO _DAO = new Brands_DAO();

        public Brands_Controller()
        {
            
        }

        public void SaveItem(Brands brand)
        {
            _Obj = brand;
            _DAO.SaveToDb(_Obj);
        }
        public new List<Brands> LoadItems()
        {
            return _DAO.SelectAllFromDb();
        }
        public Brands FindItemId(int id)
        {
            return _DAO.SelectFromDb(id);
        }
        public Brands FindItemName(string name)
        {
            return _DAO.SelectFromDb(name);
        }
        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _DAO.SelectDataSourceFromDB();
            return ds;
        }

        public override void DeleteItem(int id)
        {
            _DAO.DeleteFromDb(id);
        }
        public void UpdateItem(Brands brand)
        {
            _Obj = brand;
            string format = "yyyy-MM-dd";
            _Obj.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _DAO.EditFromDB(_Obj);
        }

        public override int BringNewId()
        {
            return _DAO.NewId();
        }
    }
}