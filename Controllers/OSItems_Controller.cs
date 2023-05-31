using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Next
{
    public class OSItems_Controller
    {
        private OSItems _OSItems = new OSItems();
        private OSItems_DAO _OSItemsDAO = new OSItems_DAO();

        public OSItems_Controller()
        {

        }

        public void SaveItem(OSItems saleItems)
        {
            _OSItems = saleItems;
            _OSItems.dateOfCreation = DateTime.Now;
            _OSItems.dateOfLastUpdate = _OSItems.dateOfCreation;
            _OSItemsDAO.SaveToDb(_OSItems);
        }
        public List<OSItems> LoadItems()
        {
            return _OSItemsDAO.SelectAllFromDb();
        }
        public List<OSItems> FindProductId(int id)
        {
            return _OSItemsDAO.SelectProductIdFromDb(id);
        }
        public List<OSItems> FindSaleId(int id)
        {
            return _OSItemsDAO.SelectSaleIdFromDb(id);
        }
        public List<OSItems> FindTotalValue(double minValue)
        {
            decimal value = (decimal)minValue;
            return _OSItemsDAO.SelectTotalValueFromDb(value);
        }
        public  void DeleteItem(int id)
        {
            _OSItemsDAO.DeleteFromDb(id);
        }
        public DataTable PopulateDGV()
        {
            DataTable ds = new DataTable();
            ds = _OSItemsDAO.SelectDataSourceFromDB();
            return ds;
        }
    }
}