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
        public int posicao = -1;
        public CJogador cjogador;

        public CadastroJogador()
        {
            InitializeComponent();
        }

        public CadastroJogador(CJogador cjogador, int posicao)
        {
            InitializeComponent();
            this.posicao = posicao;

            txtNomeDoJogador.Text = cjogador.NomeJogador;
            mtbDataNascimento.Text = cjogador.DataNascimento;
            mtbCpf.Text = cjogador.Cpf;
            txtRg.Text = cjogador.Rg;
            txtTelefone.Text = cjogador.Telefone;
            txtTelefoneEmergencia.Text = cjogador.TelefoneEmergencia;
            txtFalarCom.Text = cjogador.FalarCom;
            txtEndereco.Text = cjogador.Endereco;
            txtNumeroCasa.Text = Convert.ToString(cjogador.NumeroCasa);
            txtEmail.Text = cjogador.Email;
            txtNomeCla.Text = cjogador.NomeEquipe;
            txtEstado.Text = cjogador.Estado;
            txtCidade.Text = cjogador.Cidade;
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

            if (txtNumeroCasa.Text.Length > 6)
            {
                MessageBox.Show("Numero da casa deve conter somente numeros e no maximo 6 caracter !!");
                txtNumeroCasa.Focus();
                return;
            }
            if (txtEmail.Text.Length < 5)
            {
                MessageBox.Show("Preencha o e-mail !!");
                txtEmail.Focus();
                return;
            }
            if (txtNomeCla.Text.Length < 0)
            {
                MessageBox.Show("Selecione a equipe que você e integrante !!");
                txtNomeCla.Focus();
                return;
            }
            if (txtEstado.Text.Length < 0)
            {
                MessageBox.Show("Selecione o Estado em que mora !!");
                txtEstado.Focus();
                return;
            }
            if (txtCidade.Text.Length < 0)
            {
                MessageBox.Show("Selecione a cidade em que mora !!");
                txtCidade.Focus();
                return;
            }

            CJogador cjogador = new CJogador()
            {
                NomeJogador = txtNomeDoJogador.Text,
                DataNascimento = mtbDataNascimento.Text,
                Cpf = mtbCpf.Text,
                Rg = txtRg.Text,
                Telefone = txtTelefone.Text,
                TelefoneEmergencia = txtTelefoneEmergencia.Text,
                FalarCom = txtFalarCom.Text,
                Endereco = txtEndereco.Text,
                NumeroCasa = Convert.ToInt32(txtNumeroCasa.Text),
                Email = txtEmail.Text,
                NomeEquipe = txtNomeCla.Text,
                Estado = txtEstado.Text,
                Cidade = txtCidade.Text
            };


            if (posicao >= 0)
            {
                Program.cjogadores[posicao] = cjogador;
                MessageBox.Show("Cadastro realizado com sucesso !!");
                LimparCampos();

            }
            else
            {
                Program.cjogadores.Add(cjogador);
                MessageBox.Show("Cadastro realizado com sucesso !!");
                LimparCampos();
            }

        }

        public void LimparCampos()
        {
            txtNomeDoJogador.Text = "";
            mtbDataNascimento.Text = "";
            mtbCpf.Text = "";
            txtRg.Text = "";
            txtTelefone.Text = "";
            txtTelefoneEmergencia.Text = "";
            txtFalarCom.Text = "";
            txtEndereco.Text = "";
            txtNumeroCasa.Text = "";
            txtEmail.Text = "";
            txtNomeCla.Text = "";
            txtEstado.Text = "";
            txtCidade.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ListaCCJogador().ShowDialog();
        }

        private void CadastroJogador_Load(object sender, EventArgs e)
        {

           
        }

        private void cbNomeEquipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNomeCla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
