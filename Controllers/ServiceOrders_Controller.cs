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
    public class ServiceOrders_Controller : Master_Controller
    {
        private ServiceOrders _serviceOrder = new ServiceOrders();
        private ServiceOrders_DAO _serviceOrdersDAO = new ServiceOrders_DAO();

        public ServiceOrders_Controller()
        {

        }

        public void SaveItem(ServiceOrders serviceOrder)
        {
            _serviceOrder = serviceOrder;
            _serviceOrder.dateOfCreation = DateTime.Now;
            _serviceOrder.dateOfLastUpdate = _serviceOrder.dateOfCreation;
            _serviceOrdersDAO.SaveToDb(_serviceOrder);
        }
        public new List<ServiceOrders> LoadItems()
        {
            return _serviceOrdersDAO.SelectAllFromDb();
        }
        public ServiceOrders FindItemId(int id)
        {
            return _serviceOrdersDAO.SelectFromDb(id);
        }
        public List<ServiceOrders> FindClientId(int id)
        {
            return _serviceOrdersDAO.SelectClientFromDb(id);
        }
        public List<ServiceOrders> FindServiceId(int id)
        {
            return _serviceOrdersDAO.SelectServiceFromDb(id);
        }
        public List<ServiceOrders> FindServiceName(string name)
        {
            return _serviceOrdersDAO.SelectServiceFromDb(name);
        }
        public List<ServiceOrders> FindDate(DateTime date)
        {
            return _serviceOrdersDAO.SelectDateTimeFromDb(date);
        }
        public new void DeleteItem(int id)
        {
            _serviceOrdersDAO.DeleteFromDb(id);
        }
        public void UpdateItem(ServiceOrders serviceOrder)
        {
            _serviceOrder = serviceOrder;
            string format = "yyyy-MM-dd";
            _serviceOrder.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _serviceOrdersDAO.EditFromDB(_serviceOrder);
        }

        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _serviceOrdersDAO.SelectDataSourceFromDB();
            return ds;
        }
    }
}