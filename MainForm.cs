using ProjetoEduardoAnacletoWindowsForm1.A_To_do;
using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.DAO;
using ProjetoEduardoAnacletoWindowsForm1.Forms;
using ProjetoEduardoAnacletoWindowsForm1.Forms_Find;
using ProjetoEduardoAnacletoWindowsForm1.FormsCreate;
using ProjetoEduardoAnacletoWindowsForm1.InheritForms;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using ProjetoEduardoAnacletoWindowsForm1.Next;
using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoEduardoAnacletoWindowsForm1
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {   
            InitializeComponent();

        }

        private Users _user = new Users();

        private void SetUser()
        {
            Users user = new Users();
            user.id = 3;
            user.userLogin = "Usuario Teste";
            _user = user;
        }
        //string connectionString = "Server = localhost; Database = PraticaProfissional1; Trusted_Connection = True;";

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Find_Employees formFindEmployee = new Frm_Find_Employees();
            formFindEmployee.ShowDialog();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Create_Users frmManageUser = new Frm_Create_Users();
            frmManageUser.ShowDialog();
        }

        private void phoneClassificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Find_PhoneClassifications formFindPhoneClass = new Frm_Find_PhoneClassifications();
            formFindPhoneClass.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Find_Products frmFindProducts = new Frm_Find_Products();
            frmFindProducts.ShowDialog();
        }

        private void productGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Find_ProductGroups frmFindProductGroups = new Frm_Find_ProductGroups();
            frmFindProductGroups.ShowDialog();
        }

        private void brandsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Find_Brands frmFindBrands = new Frm_Find_Brands();
            frmFindBrands.ShowDialog();
        }

        private void citiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Find_Cities FrmFindCities = new Frm_Find_Cities();
            FrmFindCities.ShowDialog();
        }

        private void statesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Find_States FrmFindStates = new Frm_Find_States();
            FrmFindStates.ShowDialog();
        }

        private void countriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Find_Countries FrmFindCountries = new Frm_Find_Countries();
            FrmFindCountries.ShowDialog();
        }

        private void methodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Find_PaymentMethods FrmFindPaymentMethods = new Frm_Find_PaymentMethods();
            FrmFindPaymentMethods.ShowDialog();
        }

        private void conditionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Frm_Find_PaymentConditions FrmFindPaymentConditions = new Frm_Find_PaymentConditions();
           FrmFindPaymentConditions.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Find_Clients formFindClient = new Frm_Find_Clients();
            formFindClient.ShowDialog();
        }

        private void formTesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Botao pra teste de Formularios

            //PaymentConditions_DAO dao = new PaymentConditions_DAO();
            //dao.testando();
            Products_DAO dao = new Products_DAO();
            dao.RestoreStock(2, 1);
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Find_Suppliers frmFindSuppliers = new Frm_Find_Suppliers();
            frmFindSuppliers.ShowDialog();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Find_Services frmFindServices = new Frm_Find_Services();
            frmFindServices.ShowDialog();
        }

        private void findBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.id = 3;
            user.AccessLevel = 3;
            user.userLogin = "teste";
            Frm_Find_BillsToReceive frmFindBillsToReceive = new Frm_Find_BillsToReceive(user);
            frmFindBillsToReceive.ShowDialog();
        }


        private void newSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.id = 3;
            user.userLogin = "teste";
            Frm_Sale frmSale = new Frm_Sale(user);
            frmSale.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            Users_Controller userController = new Users_Controller();
            user = userController.FindItemId(3);
            Frm_Create_Purchases frmCreatePurchases = new Frm_Create_Purchases();
            frmCreatePurchases.SetUser(user);
            frmCreatePurchases.ShowDialog();
        }


        private void buscarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.id = 3;
            user.userLogin = "teste";
            Frm_Find_Sales frmFindSales = new Frm_Find_Sales();
            frmFindSales.SetUser(user);
            frmFindSales.ShowDialog();
        }

        private void buscarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            Users_Controller userController = new Users_Controller();
            user = userController.FindItemId(3);
            Frm_Find_Purchases frmFindPurchases = new Frm_Find_Purchases();
            frmFindPurchases.SetUser(user);
            frmFindPurchases.ShowDialog();
        }

        private void novaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            Users_Controller userController = new Users_Controller();
            user = userController.FindItemId(3);
            Frm_Create_Purchases frmCreatePurchases = new Frm_Create_Purchases();
            frmCreatePurchases.SetUser(user);
            frmCreatePurchases.ShowDialog();

        }

        private void addNewBillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void billsToReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            Users_Controller userController = new Users_Controller();
            user = userController.FindItemId(3);
            Frm_Find_BillsToReceive frmFindBillsToReceive = new Frm_Find_BillsToReceive(user);
            frmFindBillsToReceive.ShowDialog();
        }

        private void billsToPayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            Users_Controller userController = new Users_Controller();
            user = userController.FindItemId(3);
            Frm_Find_BillsToPay frmFindBillsToPay = new Frm_Find_BillsToPay(user);
            frmFindBillsToPay.ShowDialog();
        }
    }
}

