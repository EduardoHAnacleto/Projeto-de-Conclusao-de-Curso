using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEduardoAnacletoWindowsForm1.DAO;
using ProjetoEduardoAnacletoWindowsForm1.Models;

namespace ProjetoEduardoAnacletoWindowsForm1.Controllers
{
    public class Master_Controller
    {
        public Master_Controller()
        {

        }

        Master_DAO _DAO = new Master_DAO();
        Object _Obj = null;

        public virtual void SaveItem(Object obj)
        {
            _Obj = obj;
            _DAO.SaveToDb(_Obj);
        }
        public virtual void LoadItems() 
        {
            //LoadFrmDb
        }
        public virtual void FindItem(string id)
        {
           //FindItem        
        }
        public virtual void DeleteItem(int id) 
        {
            //DeleteItem
        }
        public virtual bool UpdateItem(Object obj)
        {
            _Obj = obj;
            return _DAO.EditFromDB(_Obj);
        }

        public virtual int BringNewId()
        {
            return this._DAO.NewId();
        }

        ////////
        ///


    }
}
