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
    public class ProductGroups_Controller : Master_Controller
    { 

        private ProductGroups _productGroup = new ProductGroups();
        private ProductGroups_DAO _productGroupsDAO = new ProductGroups_DAO();

    public ProductGroups_Controller()
    {

    }

    public void SaveItem(ProductGroups productGroup)
    {
        _productGroup = productGroup;
        _productGroupsDAO.SaveToDb(_productGroup);
    }
    public new List<ProductGroups> LoadItems()
    {
        return _productGroupsDAO.SelectAllFromDb();
    }
    public ProductGroups FindItemId(int id)
    {
        return _productGroupsDAO.SelectFromDb(id);
    }
    public ProductGroups FindItemName(string name)
    {
        return _productGroupsDAO.SelectFromDb(name);
    }
    public new void DeleteItem(int id)
    {
        _productGroupsDAO.DeleteFromDb(id);
    }
    public void UpdateItem(ProductGroups productGroup)
    {
        _productGroup = productGroup;
        string format = "yyyy-MM-dd";
        _productGroup.dateOfLastUpdate = DateTime.Parse(DateTime.Now.ToString(format));
        _productGroupsDAO.EditFromDB(_productGroup);
    }
    public DataTable PopulateDGV() //Cria obj DataTable chama a DAO para trazer a conexao da tabela da DB
    {
        DataTable ds = new DataTable();
        ds = _productGroupsDAO.SelectDataSourceFromDB();
        return ds;
    }

    public override int BringNewId()
    {
        return _productGroupsDAO.NewId();
     }

    }
}