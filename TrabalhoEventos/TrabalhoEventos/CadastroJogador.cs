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
        public int posicao;
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
            mtbDataNascimento.Text =  cjogador.DataNascimento;
            mtbCpf.Text = cjogador.Cpf;
            txtRg.Text = cjogador.Rg;
            txtTelefone.Text = cjogador.Telefone;
            txtTelefoneEmergencia.Text = cjogador.TelefoneEmergencia;
            txtFalarCom.Text =  cjogador.FalarCom;
            txtEndereco.Text = cjogador.Endereco;
            txtNumeroCasa.Text = Convert.ToString(cjogador.NumeroCasa);
            txtEmail.Text =  cjogador.Email;
            cbNomeEquipe.SelectedItem = cjogador.NomeEquipe;
            cbEstado.SelectedItem = cjogador.Estado;
            cbCidade.SelectedItem = cjogador.Cidade;

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
                NomeEquipe = cbNomeEquipe.SelectedItem.ToString(),
                Estado = cbEstado.SelectedItem.ToString(),
                Cidade = cbCidade.SelectedItem.ToString()
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
            cbNomeEquipe.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            cbCidade.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ListaCCJogador().ShowDialog();
        }
    }
}
