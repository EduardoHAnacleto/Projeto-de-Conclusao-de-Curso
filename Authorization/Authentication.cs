using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Authorization
{
    public class Authentication : IAuthentication
    {
        private string Login { get; set; }
        private string Secret { get; set; }
        public Users User { get; set; }
        private int AccessLevel { get; set; }
        public bool IsAuthenticated { get; set; }

        public Authentication()
        {
            
        }

        public bool IsPermitted (int accessLevel, int requiredLevel)
        {
            if (accessLevel >= AccessLevel)
            {
                return true;
            }
            MessageBox.Show("Not authorized.");
            return false;
        }

        public bool LogUser (string login, string secret)
        {
            try
            {
                Users_Controller uController = new Users_Controller();
                Users user = uController.LogUser(login, secret);
                if (user != null)
                {
                    IsAuthenticated = true;
                    User = user;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("User not found.");
                return false;
            }            
        }
    }
}
