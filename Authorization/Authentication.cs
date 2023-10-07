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
    public abstract class Authentication : IAuthentication
    {
        private string Login { get; set; }
        private string Secret { get; set; }
        public Users User { get; set; }
        public bool IsAuthenticated { get; set; }



        public static bool Authenticate (int accessLevel, int requiredLevel)
        {
            if (accessLevel >= requiredLevel)
            {
                return true;
            }
            MessageBox.Show("Usuário não autorizado.");
            return false;
        }

        public void WriteUserLogin()
        {
            //escreve no log o horario de login
        }

        public void WriteUserLogout()
        {
            //escreve no log o horario de loggout
        }

        public Users GetLoggedUser()
        {
            return User;
        }

        public static bool LogUser (string login, string secret)
        {
            try
            {
                Users_Controller uController = new Users_Controller();
                Users user = uController.LogUser(login, secret);
                if (user != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login ou senha estão incorretos.");
                return false;
            }            
        }
    }
}
