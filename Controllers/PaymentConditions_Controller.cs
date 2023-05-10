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
    public class PaymentConditions_Controller : Master_Controller
    {

        private PaymentConditions _paymentCondition;
        private PaymentConditions_DAO _paymentConditionsDAO = new PaymentConditions_DAO();

        public PaymentConditions_Controller()
        {

        }

        public void SaveItem(PaymentConditions paymentCondition)
        {
            _paymentCondition = paymentCondition;
            _paymentConditionsDAO.SaveToDb(_paymentCondition);
        }
        public new List<PaymentConditions> LoadItems()
        {
            return _paymentConditionsDAO.SelectAllFromDb();
        }
        public PaymentConditions FindItemId(int id)
        {
            return _paymentConditionsDAO.SelectFromDb(id);
        }
        public PaymentConditions FindItemName(string name)
        {
            return _paymentConditionsDAO.SelectFromDb(name);
        }
        public new void DeleteItem(int id)
        {
            _paymentConditionsDAO.DeleteFromDb(id);
        }
        public void UpdateItem(PaymentConditions paymentCondition)
        {
            _paymentCondition = paymentCondition;
            string format = "yyyy-MM-dd";
            _paymentCondition.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _paymentConditionsDAO.EditFromDB(_paymentCondition);
        }
        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _paymentConditionsDAO.SelectDataSourceFromDB();
            return ds;
        }
        public DataTable PopulateInstalmentsDGV(int id) //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _paymentConditionsDAO.SelectInstalmentsDataSourceFromDB(id);
            return ds;
        }
        public override int BringNewId()
        {
            return _paymentConditionsDAO.NewId();
        }
    }
}