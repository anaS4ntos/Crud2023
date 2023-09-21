using System;
using Crud2023.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            // criar um objeto de transporte login

            LoginDTO loginDTO = new LoginDTO
            {
                User = txtUser.Text, 
                Secret = txtSecret.Text,
            };

            //chamar o metodo da BLL, para isso
            //é necessário criar um objeto que possua GetLoginBLL
            
            LoginBLL loginBLL = new LoginBLL();
            bool retorno = loginBLL.GetLoginBLL(loginDTO);
            if (retorno == true)
                MessageBox.Show("Login Ok!");
            else
                MessageBox.Show("Deu ruim!!!"); }

           private void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }

     

        private void FrmButtom_Click(object sender, EventArgs e)
        {
        }
            
      
   
   }
}
