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
    public class Suppliers_Controller : Master_Controller
    {

        private Suppliers _supplier = new Suppliers();
        private Suppliers_DAO _suppliersDAO = new Suppliers_DAO();

        public Suppliers_Controller()
        {

        }

        public override int BringNewId()
        {
            return _suppliersDAO.NewId();
        }

        public void SaveItem(Suppliers supplier)
        {
            _supplier = supplier;
            _suppliersDAO.SaveToDb(_supplier);
        }
        public new List<Suppliers> LoadItems()
        {
            return _suppliersDAO.SelectAllFromDb();
        }
        public Suppliers FindItemId(int id)
        {
            return _suppliersDAO.SelectFromDb(id);
        }
        public Suppliers FindItemName(string name)
        {
            return _suppliersDAO.SelectFromDb(name);
        }
        public Suppliers FindItemByRN(string regNumber)
        {
            return _suppliersDAO.SelectFromDbByRN(regNumber);
        }
        public new void DeleteItem(int id)
        {
            _suppliersDAO.DeleteFromDb(id);
        }
        public void UpdateItem(Suppliers supplier)
        {
            _supplier = supplier;
            string format = "yyyy-MM-dd";
            _supplier.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _suppliersDAO.EditFromDB(_supplier);
        }

        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _suppliersDAO.SelectDataSourceFromDB();
            return ds;
        }
    }
}