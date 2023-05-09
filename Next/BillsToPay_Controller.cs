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
    public class BillsToPay_Controller
    {
        private BillsToPay _billToPay = new BillsToPay();
        private BillsToPay_DAO _billToPaysDAO = new BillsToPay_DAO();

        public BillsToPay_Controller()
        {

        }

        public void SaveItem(BillsToPay billToPay)
        {
            _billToPay = billToPay;
            _billToPaysDAO.SaveToDb(_billToPay);
        }
        public List<BillsToPay> LoadItems()
        {
            return _billToPaysDAO.SelectAllFromDb();
        }
        public BillsToPay FindItemId(int numDanfe, int tipoDanfe, int serieDanfe, int pagDanfe, int numParc)
        {
            return _billToPaysDAO.SelectFromDb(numDanfe, tipoDanfe, serieDanfe, pagDanfe, numParc);
        }
        public List<BillsToPay> FindSupplierId(int supplierId)
        {
            return _billToPaysDAO.SelectSupplierFromDb(supplierId);
        }
        public List<BillsToPay> FindIsPaid(bool isPaid)
        {
            return _billToPaysDAO.SelectisPaidFromDb(isPaid);
        }
        public void DeleteItem(int numDanfe, int tipoDanfe, int serieDanfe, int pagDanfe, int numParc)
        {
            _billToPaysDAO.DeleteFromDb(numDanfe, tipoDanfe, serieDanfe, pagDanfe, numParc);
        }
        public void UpdateItem(BillsToPay billToPay)
        {
            _billToPay = billToPay;
            string format = "yyyy-MM-dd";
            _billToPay.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _billToPaysDAO.EditFromDB(_billToPay);
        }

        public DataTable PopulateDGV() 
        {
            DataTable ds = new DataTable();
            ds = _billToPaysDAO.SelectDataSourceFromDB();
            return ds;
        }
    }
}