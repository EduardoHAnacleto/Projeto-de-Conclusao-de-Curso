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
    public class Products_Controller : Master_Controller
    {
        private Products _product = new Products();
        private Products_DAO _productsDAO = new Products_DAO();

        public Products_Controller()
        {

        }

        public void SaveItem(Products product)
        {
            _product = product;
            _product.dateOfCreation = DateTime.Now;
            _product.dateOfLastUpdate = _product.dateOfCreation;
            _productsDAO.SaveToDb(_product);
        }
        public new List<Products> LoadItems()
        {
            return _productsDAO.SelectAllFromDb();
        }
        public Products FindItemId(int id)
        {
            return _productsDAO.SelectFromDb(id);
        }
        public Products FindItemName(string name)
        {
            return _productsDAO.SelectFromDb(name);
        }
        public Products FindItemBarCode(long id)
        {
            return _productsDAO.SelectFromDb(id);
        }
        public new void DeleteItem(int id)
        {
            _productsDAO.DeleteFromDb(id);
        }

        public void UpdateItem(Products product)
        {
            _product = product;
            string format = "yyyy-MM-dd";
            _product.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
            _productsDAO.EditFromDB(_product);
        }
        public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
        {
            DataTable ds = new DataTable();
            ds = _productsDAO.SelectDataSourceFromDB();
            return ds;
        }

        public new int BringNewId()
        {
            return _productsDAO.NewId();
        }
        public bool UpdatePriceNStock(int prodId, int stock, decimal prodCost)
        {
            return _productsDAO.UpdatePriceNStockDb(prodId, stock, prodCost);
        }
        

    }
}
