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
    public class Clients_Controller : Master_Controller
    {
        private Clients _client;
        private readonly Clients_DAO _clientDAO = new Clients_DAO();

        public Clients_Controller()
        {

        }

        public override int BringNewId()
        {
            return _clientDAO.NewId();
        }

        public void SaveItem(Clients client)
        {
            _client = client;
            _client = SetPhoneClassToNull(_client);
            _clientDAO.SaveToDb(_client);
        }
        public new List<Clients> LoadItems()
        {
            return _clientDAO.SelectAllFromDb();
        }
        public Clients FindItemId(int id)
        {
            return _clientDAO.SelectFromDb(id);
        }
        public Clients FindItemName(string name)
        {
            return _clientDAO.SelectFromDb(name);
        }
        public new void DeleteItem(int id)
        {
            _clientDAO.DeleteFromDb(id);
        }
        public void UpdateItem(Clients client)
        {
            _client = client;
            string format = "yyyy-MM-dd";
            _client.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _clientDAO.EditFromDB(_client);
        }

        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _clientDAO.SelectDataSourceFromDB();
            return ds;
        }

        public Clients FindItemByRN(string regNumber)
        {
            return _clientDAO.SelectFromDbByRN(regNumber);
        }

        public Clients SetPhoneClassToNull(Clients client)
        {
            PhoneClassifications phone = null;
            if (client.phoneClass2 == null)
            {
                phone = new PhoneClassifications();
                phone.id = 7;
                client.phoneClass2 = phone;
            }
            if (client.phoneClass3 == null)
            {
                phone = new PhoneClassifications();
                phone.id = 7;
                client.phoneClass3 = phone;
            }
            return client;
        }
    }
}
