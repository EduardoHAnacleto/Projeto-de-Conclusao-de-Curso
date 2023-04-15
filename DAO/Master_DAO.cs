using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.DAO
{
    public class Master_DAO
    {


        public virtual int NewId()
        {
            //
            return 0;
        }

        public virtual bool SaveToDb(Object obj)
        {
            throw new NotImplementedException();
        }

        public virtual bool EditFromDB(Object obj)
        {
            throw new NotImplementedException();
        }

        public virtual bool DeleteFromDb(int id)
        {
            throw new NotImplementedException();
        }

        public virtual DataTable SelectDataSourceFromDB() //Busca no banco um SqlDataAdapter e joga em um obj DataTable e devolve para COntroller para popular DGV
        {
            throw new NotImplementedException();
        }

    }
}
