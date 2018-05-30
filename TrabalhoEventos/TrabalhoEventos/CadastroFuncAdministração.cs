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
    public partial class CadastroFuncAdministração : Form
    {


        public CadastroFuncAdministração()
        {
            InitializeComponent();
        }

        public int posicao = -1;
        public CadastroFuncAdministração(CcFuncAdmin CcFuncAdmin, int posicao)
        {
            InitializeComponent();
            this.posicao = posicao;
            txtNome.Text = CcFuncAdmin.nome;
            cbArea.Text = CcFuncAdmin.Area;
            nupIdade.Value = CcFuncAdmin.idade;
            txtEndereco.Text = CcFuncAdmin.endereço;
            mtxtCel.Text = CcFuncAdmin.celular;
            txtCidade.Text = CcFuncAdmin.cidade;
            mtxtCEP.Text = Convert.ToString(CcFuncAdmin.CEP);
            mtxCPF.Text = Convert.ToString(CcFuncAdmin.CPF);
            mtxTelefone.Text = Convert.ToString(CcFuncAdmin.telefone);
            txtSalário.Text = Convert.ToString(CcFuncAdmin.salario);
            txtRG.Text = Convert.ToString(CcFuncAdmin.RG);

        }


        private void CadastroFuncAdministração_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length < 4)
            {
                MessageBox.Show("Nome deve conter no mínimo 4 caracteres");
                txtNome.Focus();
                return;
            }


            if (txtEndereco.Text.Length < 8)
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

            if (txtRG.Text.Length < 6)
            {
                MessageBox.Show("RG deve conter pelo menos 6 caracteres");
                txtNome.Focus();
                return;
            }
            try
            {
                double Salário = Convert.ToDouble(txtSalário.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Salário deve conter somente números");
            }
            if (txtEmail.Text.Length < 7)
            {
                MessageBox.Show("Email deve conter no mínimo 7 caracteres");
                txtNome.Focus();
                return;
            }


            CcFuncAdmin CcFuncAdmin = new CcFuncAdmin()
            {
                nome = txtNome.Text,
                Area = cbArea.SelectedItem.ToString(),
                idade = Convert.ToInt32(nupIdade.Value),
                endereço = txtEndereco.Text,
                celular = mtxtCel.Text,
                email = txtEmail.Text,
                cidade = txtCidade.SelectedItem.ToString(),
                CEP = Convert.ToString(mtxtCEP.Text),
                CPF = Convert.ToString(mtxCPF.Text),
                telefone = Convert.ToString(mtxTelefone.Text),
                salario = Convert.ToString(txtSalário.Text),
                RG = Convert.ToString(txtRG.Text),
            };

            if (posicao >= 0)
            {
                Program.FAdmin[posicao] = CcFuncAdmin;
                MessageBox.Show("Cadastro realizado com Sucesso");
            }
            else
            {
                Program.FAdmin.Add(CcFuncAdmin);
                MessageBox.Show("Cadastro realizado com sucesso");

            }
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            cbArea.Text = "";
            nupIdade.Text = "";
            txtEndereco.Text = "";
            mtxtCel.Text = "";
            txtEmail.Text = "";
            txtCidade.Text = "";
            mtxtCEP.Text = "";
            mtxCPF.Text = "";
            mtxTelefone.Text = "";
            txtSalário.Text = "";
            txtRG.Text = "";
        }



        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaFuncAdministração ListaFuncAdministração = new ListaFuncAdministração();
            ListaFuncAdministração.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void mtxtCel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}
