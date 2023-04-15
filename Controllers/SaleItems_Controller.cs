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
    public class SaleItems_Controller : Master_Controller
    {
        private SaleItems _SaleItems = new SaleItems();
        private SaleItems_DAO _SaleItemsDAO = new SaleItems_DAO();

        public SaleItems_Controller()
        {

        }

        public void SaveItem(SaleItems saleItems)
        {
            _SaleItems = saleItems;
            _SaleItemsDAO.SaveToDb(_SaleItems);
        }
        public new List<SaleItems> LoadItems()
        {
            return _SaleItemsDAO.SelectAllFromDb();
        }
        public List<SaleItems> FindItemId(int id)
        { 
            return _SaleItemsDAO.SelectFromDb(id);
        }
        public List<SaleItems> FindProductId(int id)
        {
            return _SaleItemsDAO.SelectProductFromDb(id);
        }
        public List<SaleItems> FindProductName(string name)
        {
            return _SaleItemsDAO.SelectProductFromDb(name);
        }
        public List<SaleItems> FindTotalValue(double minValue)
        {
            decimal value = (decimal)minValue;
            return _SaleItemsDAO.SelectTotalValueFromDb(value);
        }
        public List<SaleItems> FindSales(int id)
        {
            return _SaleItemsDAO.SelectSaleFromDb(id);
        }
        public new void DeleteItem(int id)
        {
            _SaleItemsDAO.DeleteFromDb(id);
        }
        public void UpdateItem(SaleItems employee)
        {
            _SaleItems = employee;
            string format = "yyyy-MM-dd";
            _SaleItems.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _SaleItemsDAO.EditFromDB(_SaleItems);
        }

        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _SaleItemsDAO.SelectDataSourceFromDB();
            return ds;
        }
    }
}
