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
    public partial class CadastroFuncTerceirizado : Form
    {
        public CadastroFuncTerceirizado()
        {
            InitializeComponent();
        }

        
        public int posicao = -1;

        public CadastroFuncTerceirizado(CcFuncTerceirizado CcFuncTerceirizado, int posição)
        {
            InitializeComponent();
            this.posicao = posicao;
            txtNome.Text = CcFuncTerceirizado.nomet;
            nupIdade.Value = CcFuncTerceirizado.idadet;
            txtEndereco.Text = CcFuncTerceirizado.endereçot;
            mtxtCelular.Text = Convert.ToString(CcFuncTerceirizado.celulart);
            txtCidade.Text = CcFuncTerceirizado.cidadet;
            mtxtCPF.Text = Convert.ToString(CcFuncTerceirizado.CPFt);
            mtxtTelefone.Text = Convert.ToString(CcFuncTerceirizado.telefonet);
            txtSalario.Text = Convert.ToString(CcFuncTerceirizado.salariot);
            txtRG.Text = Convert.ToString(CcFuncTerceirizado.RGt);

        }

        private void CadastroFuncTerceirizado_Load(object sender, EventArgs e)
        {

        }

        private void txtCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
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
                double Salário = Convert.ToDouble(txtSalario.Text);
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


            CcFuncTerceirizado CcFuncTerceirizado = new CcFuncTerceirizado()
            {
                nomet = txtNome.Text,
                idadet = Convert.ToInt32(nupIdade.Value),
                endereçot = txtEndereco.Text,
                celulart = Convert.ToString(mtxtCelular.Text),
                emailt = txtEmail.Text,
                cidadet = txtCidade.SelectedItem.ToString(),
                CPFt= Convert.ToString(mtxtCPF.Text),
                telefonet = Convert.ToString(mtxtTelefone.Text),
                salariot= Convert.ToString(txtSalario.Text),
                RGt = Convert.ToString(txtRG.Text),
            };

            if (posicao >= 0)
            {
                Program.FTerceirizado[posicao] = CcFuncTerceirizado;
                MessageBox.Show("Cadastro realizado com Sucesso");
            }
            else
            {
                Program.FTerceirizado.Add(CcFuncTerceirizado);
                MessageBox.Show("Cadastro realizado com sucesso");

            }
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            nupIdade.Text = "";
            txtEndereco.Text = "";
            mtxtCelular.Text = "";
            txtEmail.Text = "";
            txtCidade.Text = "";
            mtxtCPF.Text = "";
            mtxtTelefone.Text = "";
            txtSalario.Text = "";
            txtRG.Text = "";
        }

        private void mtxtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaFuncTerceirizados ListaFuncTerceirizados = new ListaFuncTerceirizados();
            ListaFuncTerceirizados.Show();
        }
        }
    }

