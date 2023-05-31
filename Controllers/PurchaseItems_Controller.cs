using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class PurchaseItems_Controller
    {
        private PurchaseItems _purchaseItems = new PurchaseItems();
        private PurchaseItems_DAO _purchaseItemsDAO = new PurchaseItems_DAO();

        public PurchaseItems_Controller()
        {

        }

        public void SaveItem(PurchaseItems purchaseItems)
        {
            _purchaseItems = purchaseItems;
            _purchaseItems.dateOfCreation = DateTime.Now;
            _purchaseItems.dateOfLastUpdate = _purchaseItems.dateOfCreation;
            _purchaseItemsDAO.SaveToDb(_purchaseItems);
        }
        public List<PurchaseItems> LoadItems()
        {
            return _purchaseItemsDAO.SelectAllFromDb();
        }
        public List<PurchaseItems> FindItemId(int id)
        {
            return _purchaseItemsDAO.SelectFromDb(id);
        }
        public List<PurchaseItems> FindProductId(int id)
        {
            return _purchaseItemsDAO.SelectProductIdFromDb(id);
        }
        public List<PurchaseItems> FindTotalValue(double minValue)
        {
            decimal value = (decimal)minValue;
            return _purchaseItemsDAO.SelectTotalValueFromDb(value);
        }
        public List<PurchaseItems> FindPurchaseId(int id)
        {
            return _purchaseItemsDAO.SelectPurchaseIdFromDb(id);
        }
        public void DeleteItem(int id)
        {
            _purchaseItemsDAO.DeleteFromDb(id);
        }

        public DataTable PopulateDGV() 
        {
            DataTable ds = new DataTable();
            ds = _purchaseItemsDAO.SelectDataSourceFromDB();
            return ds;
        }
    }
}
