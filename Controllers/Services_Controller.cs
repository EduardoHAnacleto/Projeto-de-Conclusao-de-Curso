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
    public class Services_Controller : Master_Controller
    {
        private Services _service = new Services();
        private Services_DAO _ServiceDAO = new Services_DAO();

        public Services_Controller()
        {

        }

        public void SaveItem(Services paymentMethod)
        {
            _service = paymentMethod;
            _service.dateOfCreation = DateTime.Now;
            _service.dateOfLastUpdate = _service.dateOfCreation;
            _ServiceDAO.SaveToDb(_service);
        }
        public new List<Services> LoadItems()
        {
            return _ServiceDAO.SelectAllFromDb();
        }
        public Services FindItemId(int id)
        {
            return _ServiceDAO.SelectFromDb(id);
        }
        public Services FindItemName(string name)
        {
            return _ServiceDAO.SelectFromDb(name);
        }
        public new void DeleteItem(int id)
        {
            _ServiceDAO.DeleteFromDb(id);
        }
        public void UpdateItem(Services paymentMethod)
        {
            _service = paymentMethod;
            string format = "yyyy-MM-dd";
            _service.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _ServiceDAO.EditFromDB(_service);
        }
        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _ServiceDAO.SelectDataSourceFromDB();
            return ds;
        }


        public override int BringNewId()
        {
            return _ServiceDAO.NewId();
        }
    }
}