using ProjetoEduardoAnacletoWindowsForm1.DAO;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.A_To_do
{
    public class Purchases_Controller
    {

        private Purchases _purchase = new Purchases();
        private Purchases_DAO _purchasesDAO = new Purchases_DAO();

        public Purchases_Controller()
        {

        }

        public void SaveItem(Purchases purchase)
        {
            _purchase = purchase;
            _purchasesDAO.SaveToDb(_purchase);
        }
        public List<Purchases> LoadItems()
        {
            return _purchasesDAO.SelectAllFromDb();
        }
        public List<Purchases> FindStatus(int WantedStatus)
        {
            return _purchasesDAO.SelectStatusFromDb(WantedStatus);
        }
        public List<Purchases> FindArrivalDate(DateTime arrivalDate)
        {
            string arrival = arrivalDate.ToString();
            return _purchasesDAO.SelectArrivalDateFromDb(arrival);
        }
        public List<Purchases> FindEmissionDate(DateTime emissionDate)
        {
            string emission = emissionDate.ToString();
            return _purchasesDAO.SelectEmissionDateFromDb(emission);
        }
        public List<Purchases> FindTotalCost(double totalCost)
        {
            decimal cost = (decimal)totalCost;
            return _purchasesDAO.SelectTotalCostFromDb(cost);
        }
        public List<Purchases> FindPayCondition(int payCondition)
        {
            return _purchasesDAO.SelectPayConditionFromDb(payCondition);
        }
        public List<Purchases> FindSupplier(int idSupplier)
        {
            return _purchasesDAO.SelectSupplierFromDb(idSupplier);
        }
        public void DeleteItem(int idBillToPay)
        {
            _purchasesDAO.DeleteFromDb(idBillToPay);
        }
        public void UpdateItem(Purchases purchase)
        {
            _purchase = purchase;
            string format = "yyyy-MM-dd";
            _purchase.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _purchasesDAO.EditFromDB(_purchase);
        }

        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _purchasesDAO.SelectDataSourceFromDB();
            return ds;
        }
    }
}