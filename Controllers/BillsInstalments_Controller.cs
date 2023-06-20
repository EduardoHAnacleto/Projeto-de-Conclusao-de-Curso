using ProjetoEduardoAnacletoWindowsForm1.DAO;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Controllers
{
    public class BillsInstalments_Controller
    {

        private BillsInstalments _billInstalment = new BillsInstalments();
        private BillsInstalments_DAO _billInstalmentsDAO = new BillsInstalments_DAO();

        public BillsInstalments_Controller()
        {

        }

        public bool SaveItem(BillsInstalments billInstalment)
        {
            _billInstalment = billInstalment;
            _billInstalment.dateOfCreation = DateTime.Now;
            _billInstalment.dateOfLastUpdate = _billInstalment.dateOfCreation;
            return _billInstalmentsDAO.SaveToDb(_billInstalment);
        }
        public List<BillsInstalments> LoadItems()
        {
            return _billInstalmentsDAO.SelectAllFromDb();
        }
        public BillsInstalments FindItemId(int instalmentNumber, int paymentConditionId, int paymentMethodId)
        {
            //return _billInstalmentsDAO.SelectFromDb(instalmentNumber, paymentConditionId, paymentMethodId);
            return null;
        }
        public List<BillsInstalments> FindInstalments(int paymentConditionId)
        {
            //return _billInstalmentsDAO.SelectDTByCondIdFromDB(paymentConditionId);
            return _billInstalmentsDAO.SelectInstalmentsFromDb(paymentConditionId);
        }
        public bool DeleteItem(int instalmentNumber, int paymentConditionId)
        {
            return _billInstalmentsDAO.DeleteFromDb(instalmentNumber, paymentConditionId);
        }
        public bool DeleteItem(int paymentConditionId)
        {
            return _billInstalmentsDAO.DeleteFromDb(paymentConditionId);
        }
        public void UpdateItem(BillsInstalments billInstalment)
        {
            _billInstalment = billInstalment;
            string format = "yyyy-MM-dd";
            _billInstalment.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _billInstalmentsDAO.EditFromDB(_billInstalment);
        }
        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _billInstalmentsDAO.SelectDataSourceFromDB();
            return ds;
        }
    }
}