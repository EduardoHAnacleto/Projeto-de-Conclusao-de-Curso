using ProjetoEduardoAnacletoWindowsForm1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.InheritForms
{
    public partial class Frm_Create_Master : Form
    {
        public Frm_Create_Master()
        {
            InitializeComponent();
            this.InitiateForm();
            //edt_id.Controls[0].Visible = false;
        }

        public Object item = null;         //Objeto usado para levar pra form anterior
        public string requestedBy = null;   //Diz se o form foi chamado por um formPai
        public bool isPopulated = false;
        protected Master_Controller mController;

        public virtual void InitiateForm() //Padrão de inicio dos Forms, insere Datas e remove botoes do EDT_ID
        {
            lbl_CreationDate.Text = DateTime.Now.ToShortDateString();
            lbl_LastUpdate.Text = DateTime.Now.ToShortDateString();
            if (lbl_LastUpdate.Text == lbl_CreationDate.Text)
            {
                lbl_LastUpdate.Text = String.Empty;
            }
            edt_id.Controls[0].Visible = false;
        }

        public virtual void Populated(bool populated)
        {
            if (populated)
            {
                this.LockCamps();
                btn_SelectDelete.Enabled = false;
                btn_Edit.Enabled = true;
                btn_NewSave.Enabled = false;
            }
            else if (!populated)
            {
                btn_SelectDelete.Enabled = false;
                //btn_Edit.Enabled = false;
                btn_NewSave.Enabled = true;

                this.UnlockCamps();
                this.ClearCamps();
                try
                {
                    edt_id.Value = this.BringNewId();
                }
                catch (Exception e)
                {

                }
            }
        }

        public virtual int BringNewId() // Tras novo ID para o Form
        {
             return mController.BringNewId();
        }



        public virtual void Save() // Save
        {
            //
        }

        public virtual void EditObject() //EditObject
        {
            //
        }

        public virtual void DeleteObject() //DeleteObject
        {
            //
        }

        public virtual void Exit()  //Exit
        {
            this.Close();
        }

        public virtual void LockCamps() //Trava os Campos
        {
           //
        }

        public virtual void UnlockCamps() //Destrava os Campos
        {
            //
        }

        public virtual void ClearCamps() //Limpa os Campos
        {
            edt_id.Value = 0;
        }

        public virtual bool CheckCamps() // Checa os Campos
        {
            throw new NotImplementedException();
        }

        public virtual void SetNewId()
        {
            
        }

        private void btn_exit_Click(object sender, EventArgs e) //Click botão Exit, chama Exit()
        {
            Exit();
        }

        private void btn_SelectDelete_Click(object sender, EventArgs e) //Clica botão SelectDelete, chama Delete
        {
            DeleteObject();
        }

        private void btn_Edit_Click(object sender, EventArgs e) //Click botao Edit, chama EditObject()
        {
            EditObject();
        }

        private void btn_NewSave_Click(object sender, EventArgs e) //Click botao newSave, chama Save()
        {
            Save();
        }



    }
}
