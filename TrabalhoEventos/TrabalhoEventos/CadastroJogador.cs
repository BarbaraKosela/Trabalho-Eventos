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
    public partial class CadastroJogador : Form
    {
        public CadastroJogador()
        {
            InitializeComponent();
        }

        private void txtNomeDoJogo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNomeDoJogador.Text.Length < 3)
            {
                MessageBox.Show("Nome do jogador deve conter no minimo 3 caracteres !!");
                txtNomeDoJogador.Focus();
                return;
            }
            if (mtbDataNascimento.Text.Length < 8)
            {
                MessageBox.Show("Data de nascimento deve ser colocada !!");
                mtbDataNascimento.Focus();
                return;
            }
            if (mtbCpf.Text.Length < 11)
            {
                MessageBox.Show("Cpf deve ser preenchido !!");
                mtbCpf.Focus();
                return;
            }
            if (txtRg.Text.Length < 4)
            {
                MessageBox.Show("Coloque o numero do RG !!");
                txtRg.Focus();
                return;
            }
            if (txtTelefone.Text.Length < 8)
            {
                MessageBox.Show("Telefone deve conter no minimo 8 digitos !!");
                txtTelefone.Focus();
                return;
            }
            if (txtEndereco.Text.Length < 3)
            {
                MessageBox.Show("Coloque o endereço que reside !!");
                txtEndereco.Focus();
                return;
            }
            if (txtEmail.Text.Length < 5)
            {
                MessageBox.Show("Preencha o e-mail !!");
                txtEmail.Focus();
                return;
            }
            if (cbNomeEquipe.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a equipe que você e integrante !!");
                cbNomeEquipe.Focus();
                return;
            }
            if (cbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o Estado em que mora !!");
                cbEstado.Focus();
                return;
            }
            if (cbCidade.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a cidade em que mora !!");
                cbCidade.Focus();
                return;
            }
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
