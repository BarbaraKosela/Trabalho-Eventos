using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLivraria
{
    public partial class CadastroFuncAlimentação : Form
    {
        public CadastroFuncAlimentação()
        {
            InitializeComponent();
        }

        public int posicao = -1;

        public CadastroFuncAlimentação(CcFuncAlimentação CcFuncAlimentação, int posição)
        {
            InitializeComponent();
            this.posicao = posicao;
            txtNomeFuncAlimentacao.Text = CcFuncAlimentação.Nome;
            cbRestaurante.Text = CcFuncAlimentação.restaurante;
            cbPosiçãoFuncAlim.Text = CcFuncAlimentação.posição;
            txtEnderçoFuncAlim.Text = CcFuncAlimentação.Endereço;
            nupIdadeFuncAliment.Value = CcFuncAlimentação.Idade;
            mtxtCelularFuncAlim.Text = Convert.ToString(CcFuncAlimentação.Celular);
            txtCidade.Text = CcFuncAlimentação.Cidade;
            mtxtCPFFuncAlim.Text = Convert.ToString(CcFuncAlimentação.Cpf);
            mtxtTelefoneFuncAlim.Text = Convert.ToString(CcFuncAlimentação.Telefone);
            txtSalarioFuncAlim.Text = Convert.ToString(CcFuncAlimentação.Salario);
            txtRGFuncAlim.Text = Convert.ToString(CcFuncAlimentação.Rg);

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroFuncAlimentação_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
             if (txtNomeFuncAlimentacao.Text.Length < 4)
            {
                MessageBox.Show("Nome deve conter no mínimo 4 caracteres");
                txtNome.Focus();
                return;
            }


            if (txtEnderçoFuncAlim.Text.Length < 8)
            {
                MessageBox.Show("Endereço deve conter pelo menos 8 caracteres");
                txtNome.Focus();
                return;
            }

            if (txtCidade.Text.Length < 3)
            {
                MessageBox.Show("Selecione uma Cidade");
                txtNome.Focus();
                return;
            }

            if (txtRGFuncAlim.Text.Length < 6)
            {
                MessageBox.Show("RG deve conter pelo menos 6 caracteres");
                txtNome.Focus();
                return;
            }
            try
            {
                double Salário = Convert.ToDouble(txtSalarioFuncAlim.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Salário deve conter somente números");
            }
            if (txtEmailFuncAlim.Text.Length < 7)
            {
                MessageBox.Show("Email deve conter no mínimo 7 caracteres");
                txtNome.Focus();
                return;
            }


            CcFuncAlimentação CcFuncAlimentação = new CcFuncAlimentação()
            {
                Nome = txtNomeFuncAlimentacao.Text,
                restaurante = cbRestaurante.SelectedItem.ToString(),
                Idade= Convert.ToInt32(nupIdade.Value),
                Endereço = txtEndereco.Text,
                Celular = Convert.ToString(mtxCel.Text),
                Email = txtEmailFuncAlim.Text,
                Cidade = txtCidade.SelectedItem.ToString(),
                CEP = Convert.ToString(mtxCEPFuncAlim.Text),
                Cpf = Convert.ToString(mtxtCPFFuncAlim.Text),
                Salario = Convert.ToString(txtSalarioFuncAlim.Text),
                Rg = Convert.ToString(txtRGFuncAlim.Text),
            };

            if (posicao >= 0)
            {
                Program.FAlimentação[posicao] = CcFuncAlimentação;
                MessageBox.Show("Cadastro realizado com Sucesso");
            }
            else
            {
                Program.FAlimentação.Add(CcFuncAlimentação);
                MessageBox.Show("Cadastro realizado com sucesso");

            }

            LimparCampos();
        }
        private void LimparCampos()
        {

            txtNomeFuncAlimentacao.Text = "";
            cbRestaurante.Text = "";
            cbPosiçãoFuncAlim.Text = "";
            txtEnderçoFuncAlim.Text = "";
            nupIdadeFuncAliment.Text = "";
            mtxtCelularFuncAlim.Text = "";
            txtCidade.Text = "";
            mtxtCPFFuncAlim.Text = "";
            mtxtTelefoneFuncAlim.Text = "";
            txtSalarioFuncAlim.Text = "";
            txtRGFuncAlim.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaFuncAlimentação ListaFuncAlimentação = new ListaFuncAlimentação();
            ListaFuncAlimentação.Show();
        }

        }
    }

