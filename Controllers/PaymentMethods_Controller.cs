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
    public class PaymentMethods_Controller : Master_Controller
    {
        private PaymentMethods _paymentMethod;
        private PaymentMethods_DAO _paymentMethodDAO = new PaymentMethods_DAO();

        public PaymentMethods_Controller()
        {

        }

        public void SaveItem(PaymentMethods paymentMethod)
        {
            _paymentMethod = paymentMethod;
            _paymentMethod.dateOfCreation = DateTime.Now;
            _paymentMethod.dateOfLastUpdate = _paymentMethod.dateOfCreation;
            _paymentMethodDAO.SaveToDb(_paymentMethod);
        }
        public new List<PaymentMethods> LoadItems()
        {
            return _paymentMethodDAO.SelectAllFromDb();
        }
        public PaymentMethods FindItemId(int id)
        {
            return _paymentMethodDAO.SelectFromDb(id);
        }
        public PaymentMethods FindItemName(string name)
        {
            return _paymentMethodDAO.SelectFromDb(name);
        }
        public new void DeleteItem(int id)
        {
            _paymentMethodDAO.DeleteFromDb(id);
        }
        public void UpdateItem(PaymentMethods paymentMethod)
        {
            _paymentMethod = paymentMethod;
            string format = "yyyy-MM-dd";
            _paymentMethod.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _paymentMethodDAO.EditFromDB(_paymentMethod);
        }
        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _paymentMethodDAO.SelectDataSourceFromDB();
            return ds;
        }

        public new int BringNewId()
        {
            return _paymentMethodDAO.NewId();
        }
    }
}