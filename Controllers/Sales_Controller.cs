using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
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
    public class Sales_Controller : Master_Controller
    {
        private Sales _sale = new Sales();
        private Sales_DAO _salesDAO = new Sales_DAO();

        public Sales_Controller()
        {

        }

        public bool SaveItem(Sales sale)
        {
            _sale = sale;
            _sale.dateOfLastUpdate = DateTime.Now;
            return _salesDAO.SaveToDb(_sale);
        }
        public new List<Sales> LoadItems()
        {
            return _salesDAO.SelectAllFromDb();
        }
        public Sales FindItemId(int id)
        {
            return _salesDAO.SelectFromDb(id);
        }
        public List<Sales> FindEmissionDate(DateTime date)
        {
            return _salesDAO.SelectDateOfCreationFromDb(date);
        }
        public List<Sales> FindCanceledDate(DateTime date)
        {
            return _salesDAO.SelectCanceledDateFromDb(date);
        }
        public List<Sales> FindTotalValue(decimal minValue)
        {
            decimal value = (decimal)minValue;
            return _salesDAO.SelectTotalValueFromDb(value);
        }
        public new void DeleteItem(int id)
        {
            _salesDAO.DeleteFromDb(id);
        }
        public bool UpdateItem(Sales sale)
        {
            _sale = sale;
            return _salesDAO.EditFromDB(_sale);
        }

        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _salesDAO.SelectDataSourceFromDB();
            return ds;
        }

        public override int BringNewId()
        {
            return _salesDAO.NewId();
        }

        public int GetLastId()
        {
           return _salesDAO.GetLastId();
        }

        public bool CancelSale(int id)
        {
            return _salesDAO.CancelSale(id);
        }
    }
}