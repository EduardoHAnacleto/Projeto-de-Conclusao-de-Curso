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
    public class Employees_Controller : Master_Controller
    {

        private Employees _employee = new Employees();
        private Employees_DAO _employeeDAO = new Employees_DAO();

        public Employees_Controller()
        {

        }

        public override int BringNewId()
        {
            return _employeeDAO.NewId();
        }

        public void SaveItem(Employees employee)
        {
            _employee = employee;
            _employeeDAO.SaveToDb(_employee);
        }
        public new List<Employees> LoadItems()
        {
            return _employeeDAO.SelectAllFromDb();
        }
        public Employees FindItemId(int id)
        {
            return _employeeDAO.SelectFromDb(id);
        }
        public Employees FindItemName(string name)
        {
            return _employeeDAO.SelectFromDb(name);
        }
        public new void DeleteItem(int id)
        {
            _employeeDAO.DeleteFromDb(id);
        }
        public void UpdateItem(Employees employee)
        {
            _employee = employee;
            string format = "yyyy-MM-dd";
            _employee.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _employeeDAO.EditFromDB(_employee);
        }
        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _employeeDAO.SelectDataSourceFromDB();
            return ds;
        }
        public Employees FindItemByRN(string regNumber)
        {
            return _employeeDAO.SelectFromDbByRN(regNumber);
        }
        
    }
}
