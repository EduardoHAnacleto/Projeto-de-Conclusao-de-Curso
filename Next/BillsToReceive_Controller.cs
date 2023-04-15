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
    public class BillsToReceive_Controller
    {

        private BillsToReceive _billToReceive = new BillsToReceive();
        private BillsToReceive_DAO _billToReceivesDAO = new BillsToReceive_DAO();

        public BillsToReceive_Controller()
        {

        }

        public void SaveItem(BillsToReceive billToReceive)
        {
            _billToReceive = billToReceive;
            _billToReceivesDAO.SaveToDb(_billToReceive);
        }
        public List<BillsToReceive> LoadItems()
        {
            return _billToReceivesDAO.SelectAllFromDb();
        }
        public List<BillsToReceive> FindItemId(int id) 
        {
            return _billToReceivesDAO.SelectFromDb(id);
        }
        public List<BillsToReceive> FindPersonId(int id) 
        {
            return _billToReceivesDAO.SelectPersonFromDb(id);
        }
        public List<BillsToReceive> FindPersonName(string name)
        {
            return _billToReceivesDAO.SelectPersonFromDb(name);
        }
        public List<BillsToReceive> FindSaleId(int id) 
        {
            return _billToReceivesDAO.SelectSaleFromDb(id);
        }
        public List<BillsToReceive> FindDueDate(string date) 
        {
            return _billToReceivesDAO.SelectDueDateFromDb(date);
        }
        public List<BillsToReceive> FindEmissionDate(string date)
        {
            return _billToReceivesDAO.SelectEmissionDateFromDb(date);
        }
        public List<BillsToReceive> FindIsPaid(int status)
        {
            return _billToReceivesDAO.SelectIsPaidFromDb(status);
        }
        public void DeleteItem(int id)
        {
            _billToReceivesDAO.DeleteFromDb(id);
        }
        public void UpdateItem(BillsToReceive billToReceive)
        {
            _billToReceive = billToReceive;
            string format = "yyyy-MM-dd";
            _billToReceive.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _billToReceivesDAO.EditFromDB(_billToReceive);
        }
        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _billToReceivesDAO.SelectDataSourceFromDB();
            return ds;
        }
    }
}