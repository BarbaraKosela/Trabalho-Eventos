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
    public partial class CadastroEquipe : Form
    {
        public CadastroEquipe()
        {
            InitializeComponent();
        }

        private void CadastroEquipe_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNomeDaEquipe_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNomeDaEquipe.Text.Length <= 4)
            {
                MessageBox.Show("Nome da equipe deve conter no minimo 4 caracteres !!");
                txtNomeJogo.Focus();
                return;
            }
            if (cbEstado.SelectedIndex <= 0)
            {
                MessageBox.Show("Deve se selecionar um estado que a equipe reside no momento !!");
                cbEstado.Focus();
                return;
            }
            if (cbCidade.SelectedIndex <= 0)
            {
                MessageBox.Show("Deve se selecionar uma cidade que a equipe reside no momento !!");
                cbCidade.Focus();
                return;
            }
            if (txtNomeLider.Text.Length <= 4)
            {
                MessageBox.Show("Nome do lider deve conter no minimo 4 caracter !!");
                txtNomeLider.Focus();
                return;
            }
            if (mtbCpf.Text.Length < 11)
            {
                MessageBox.Show("Deve-se colocar o cpf do lider !!");
                mtbCpf.Focus();
                return;
            }
            if (txtTelefone.Text.Length < 8)
            {
                MessageBox.Show("Deve-se colocar o telefone no minimo 8 digitos !!");
                txtTelefone.Focus();
                return;
            }
            if (txtNomeJogo.Text.Length < 3)
            {
                MessageBox.Show("Deve-se colocar o nome para o jogo no minimo 3 caracteres !!");
                txtNomeJogo.Focus();
                return;
            }
            if (cbCla.SelectedIndex <= 0)
            {
                MessageBox.Show("Selecione um clã !!");
                cbCla.Focus();
                return;
            }
            if ((rbSim.Checked == false) && (rbNao.Checked == false))
            {
                MessageBox.Show("Selecione se você já participou alguma deste evento !!");
                return;
                
            }
            if (cbGeneroJogo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o genero do jogo !!");
                cbGeneroJogo.Focus();
                return;

            }
            if (mtbQuantidadeintegrantes.Text.Length < 1)
            {
                MessageBox.Show("Coloque a quantidade de integrante do grupo !!");
                mtbQuantidadeintegrantes.Focus();
                return;
            }
            if (txtFraseTaca.Text.Length < 10)
            {
                MessageBox.Show("Digite a frase que será colocada na taça no minimo 10 caracteres");
                txtFraseTaca.Focus();
                return;
            }

        }
    }
}
