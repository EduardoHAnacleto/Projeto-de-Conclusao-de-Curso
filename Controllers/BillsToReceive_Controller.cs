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
    public class BillsToReceive_Controller
    {

        private BillsToReceive _billToReceive;
        private BillsToReceive_DAO _billToReceivesDAO = new BillsToReceive_DAO();

        public BillsToReceive_Controller()
        {

        }

        public bool SaveItem(BillsToReceive billToReceive)
        {
            _billToReceive = billToReceive;
            _billToReceive.dateOfCreation = DateTime.Now;
            _billToReceive.dateOfLastUpdate = _billToReceive.dateOfCreation;
            return _billToReceivesDAO.SaveToDb(_billToReceive);
        }
        public List<BillsToReceive> LoadItems()
        {
            return _billToReceivesDAO.SelectAllFromDb();
        }
        public BillsToReceive FindItemId(int saleId, int instalmentNum) 
        {
            return _billToReceivesDAO.SelectFromDb(saleId, instalmentNum);
        }
        public List<BillsToReceive> FindItemId(int billId)
        {
            return _billToReceivesDAO.SelectFromDb(billId);
        }
        public List<BillsToReceive> FindClientId(int id) 
        {
            return _billToReceivesDAO.SelectClientFromDb(id);
        }
        public List<BillsToReceive> FindSaleId(int id) 
        {
            return _billToReceivesDAO.SelectSaleFromDb(id);
        }
        public List<BillsToReceive> FindDueDate(DateTime date) 
        {
            return _billToReceivesDAO.SelectDueDateFromDb(date);
        }
        public List<BillsToReceive> FindIsPaid(bool isPaid)
        {
            return _billToReceivesDAO.SelectIsPaidFromDb(isPaid);
        }

        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _billToReceivesDAO.SelectDataSourceFromDB();
            return ds;
        }
        
        public bool CancelBills(int id, int userId)
        {
            return _billToReceivesDAO.CancelBillsFromDb(id, userId);
        }

        public bool SetPaidBillsFromDb(int id, int userId)
        {
            return _billToReceivesDAO.SetPaidBillsFromDb(id, userId);
        }

        internal bool PayBill(BillsToReceive billsToReceive)
        {
            return _billToReceivesDAO.PayBill(billsToReceive);
        }

        internal bool CancelBill(BillsToReceive billsToReceive)
        {
            return _billToReceivesDAO.CancelBill(billsToReceive);
        }

        public int GetNewId()
        {
            return _billToReceivesDAO.GetNewId();
        }
    }
}