using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJogadores
{
    public partial class LoginSenha : Form
    {
       
     

        public LoginSenha()
        {
            InitializeComponent();
            txtSenha.UseSystemPasswordChar = true;

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "angrynerds" && txtSenha.Text == "angrynerds") 
            {
                this.Hide();
                var A = new AngryNerds();
                A.Closed += (s, args) => this.Close();
               A.Show();

            }
            else
            {
                MessageBox.Show("Senha Incorreta !! ");
                return;
            }

           
      
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
