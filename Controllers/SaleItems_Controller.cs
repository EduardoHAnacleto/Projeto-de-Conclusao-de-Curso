using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.DAO;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Next;
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
        public List<SaleItems> FindProductId(int id)
        {
            return _SaleItemsDAO.SelectProductIdFromDb(id);
        }
        public List<SaleItems> FindSaleId(int id)
        {
            return _SaleItemsDAO.SelectSaleIdFromDb(id);
        }
        public List<SaleItems> FindTotalValue(double minValue)
        {
            decimal value = (decimal)minValue;
            return _SaleItemsDAO.SelectTotalValueFromDb(value);
        }
        public new void DeleteItem(int id)
        {
            _SaleItemsDAO.DeleteFromDb(id);
        }
        public DataTable PopulateDGV() 
        {
            DataTable ds = new DataTable();
            ds = _SaleItemsDAO.SelectDataSourceFromDB();
            return ds;
        }
    }
}
