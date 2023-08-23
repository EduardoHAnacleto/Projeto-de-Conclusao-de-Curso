using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Utility
{
    public static class Utilities
    {
        public static bool EnterSearch(KeyPressEventArgs e)  
        {
            if (e.KeyChar == (char)13)
            {
                return true;
            }
            else return false;
        }

        public static int CalculateAge(DateTime dob)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - dob.Year;
            if (dob > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public static DateTime CalculateDateTimeAge(int age)
        {
            int nowYear = DateTime.Now.Year;
            int yob = nowYear - age;
            DateTime result = new DateTime(yob, 1, 1);
            return result;
        }

        public static string RemoveRegMask(string maskedTxt)
        {
            var text = maskedTxt.Replace(",", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty).
                Replace("(", string.Empty).Replace(")", string.Empty).Replace(" ", string.Empty).Replace("_", string.Empty).Replace(".",string.Empty);
            return text;
        }

        public static void Msgbox(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, buttons, icon);
        }

        public static bool IsMoreThanZero(int number, string camp)
        {
            if (number <= 0)
            {
                string message = $"{camp} campo deve ser maior que 0.";
                string caption = "Invalid camp.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Msgbox(message, caption, buttons, icon);
                return false;
            }
            else return true;
        }

        public static bool HasAnyDigits(string text, string camp) //Checa string para ver se tem apenas Numeros
        {
            bool status = text.Any(char.IsDigit);
            if (!status)
            {
                string message = $"{camp} - campo deve ter apenas caractéres.";
                string caption = "Campo inválido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Msgbox(message, caption, buttons, icon);
            }
            return status;
        }

        public static bool HasOnlyDigits(string text, string camp) //Checa string para ver se tem apenas Numeros
        {
            bool status = !string.IsNullOrWhiteSpace(text) && !System.Text.RegularExpressions.Regex.IsMatch(text, "[^0-9]");
            if (!status)
            {
                string message = $"{camp} - campo deve ter apenas números.";
                string caption = "Campo inválido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Msgbox(message, caption, buttons, icon);
            }
            return status;
        }

        public static bool HasOnlyLetters(string text, string camp) //Checa String para ver se tem Letras
        {
            bool status = text.Trim().All(c => Char.IsLetter(c) || c == ' ');
            if (!status)
            {
                string message = $"{camp} - campo deve ter apenas caractéres.";
                string caption = "Campo inválido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Msgbox(message, caption, buttons, icon);
            }
            return status;
        }

        public static bool HasOnlySpaces(string text, string camp)
        {
            bool status = String.IsNullOrWhiteSpace(text);
            if (status)
            {
                string message = $"{camp} - campo é requerido.";
                string caption = "Campo inválido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Msgbox(message, caption, buttons, icon);
            }
            return status;
        }

        public static bool IsNotSelected(Object item, string camp)
        {
            bool status = false;
            if (item == null)
            {
                status = true;
            }
            else if (item != null)
            {
                status = String.IsNullOrWhiteSpace(item.ToString());
            }
            if (status)
            {
                string message = $"{camp} deve ser selecionado.";
                string caption = "Campo é requerido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Msgbox(message, caption, buttons, icon);
            }
            return status;
        }

        public static bool IsDouble(string text, string camp)
        {
            bool status = true;
            try
            {
                double value = Convert.ToDouble(text);
                return status;
            }
            catch
            {
                string message = $"{camp} deve ser um número decimal.";
                string caption = "Campo inválido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Msgbox(message, caption, buttons, icon);
                return false;

            }
        }

        public static bool HasSpecialChars(string text, string camp)  //Checa string para ver se tem caracteres especiais
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            bool status = false;
            foreach (var item in specialChar)
            {
                if (text.Contains(item))
                {
                    status = true;
                }
            }
            if (status)
            {
                string message = $"{camp} - campo não pode ter caractéres especiais.";
                string caption = "Campo inválido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Msgbox(message, caption, buttons, icon);
            }
            return status;
        }

        public static bool HasDigits(string text, string camp) // Checa string para ver se tem digitos
        {
            bool status = text.Any(ch => char.IsDigit(ch));
            if (!status)
            {
                status = true;
                string message = $"{camp} - campo não deve possuir números.";
                string caption = "Campo inválido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Msgbox(message, caption, buttons, icon);
            }
            return status;
        }

        public static bool HasLetters(string text, string camp) //Checa String para ver se tem Letras
        {
            bool status = text.Trim().Any(ch => char.IsLetter(ch));
            if (!status)
            {
                status = true;
                string message = $"{camp} - campo não deve possuir caractéres.";
                string caption = "Campo inválido.";
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                Msgbox(message, caption, buttons, icon);
            }
            return status;
        }

        //public static bool MsgboxYesNo(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        //{
        //    DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}

        public static void MsgboxCantSearch()
        {
            string message = "Campos de texto vazios.";
            string caption = "Campos são requeridos.";
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons, icon);
        }

        public static bool AskToCreate()
        {
            string message = "Registro não encontrado. Deseja criar um novo?";
            string caption = "Não encontrado.";
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else return false;
        }

        public static bool AskToFind()
        {
            string message = "Registro não encontrado. Deseja encontrá-lo?";
            string caption = "Não encontrado.";
            MessageBoxIcon icon = MessageBoxIcon.Error;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, caption, buttons, icon);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else return false;
        }
    }
}
