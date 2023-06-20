using ProjetoEduardoAnacletoWindowsForm1.DAO;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEduardoAnacletoWindowsForm1.Controllers
{
    public class Users_Controller : Master_Controller
    {
        private Users _Obj = new Users();
        private readonly Users_DAO _DAO = new Users_DAO();

        public Users_Controller()
        {
            
        }
        public override int BringNewId()
        {
            return _DAO.NewId();
        }
        public void SaveItem(Users person)
        {
            _Obj = person;
            _Obj.dateOfCreation = DateTime.Now;
            _Obj.dateOfLastUpdate = _Obj.dateOfCreation;
            _DAO.SaveToDb(_Obj);
        }
        public Users FindItemId(int id)
        {
            return _DAO.SelectFromDb(id);
        }

        public new void DeleteItem(int id)
        {
            _DAO.DeleteFromDb(id);
        }
        public void UpdateItem(Users person)
        {
            _Obj = person;
            string format = "yyyy-MM-dd";
            _Obj.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _DAO.EditFromDB(_Obj);
        }

        public Users LogUser(string login,string secret)
        {
            return _DAO.LogUser(login, secret);
        }
    }
}
