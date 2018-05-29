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
    public partial class CadastroFuncJogos : Form
    {
       public int posicao = -1;

        public CadastroFuncJogos()
        {
            InitializeComponent();
        }

       public CadastroFuncJogos(CcFuncJogos CcFuncJogos, int posição)
       {
           InitializeComponent();
           this.posicao = posicao;
           txtNome.Text = CcFuncJogos.nomej;
           cbSala.Text = CcFuncJogos.Sala;
           cbEspecializacao.Text = CcFuncJogos.Especialização;
           txtEndereco.Text = CcFuncJogos.endereçoj;
           nupIdade.Value = CcFuncJogos.idadej;
           mtxCel.Text = Convert.ToString(CcFuncJogos.celularj);
           txtCidade.Text = CcFuncJogos.cidadej;
           mtxCPF.Text = Convert.ToString(CcFuncJogos.CPFj);
           mtxTelefone.Text = Convert.ToString(CcFuncJogos.telefonej);
           txtSalário.Text = Convert.ToString(CcFuncJogos.salarioj);
           txtRG.Text = Convert.ToString(CcFuncJogos.RGj);
       }

        private void txtNome_TextChanged(object sender, EventArgs e)
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


            CcFuncJogos CcFuncJogos = new CcFuncJogos()
            {
                nomej = txtNome.Text,
                Sala = cbSala.SelectedItem.ToString(),
                Especialização = cbEspecializacao.SelectedItem.ToString(),
                idadej = Convert.ToInt32(nupIdade.Value),
                endereçoj = txtEndereco.Text,
                celularj = Convert.ToString(mtxCel.Text),
                emailj = txtEmail.Text,
                cidadej = txtCidade.SelectedItem.ToString(),
                CEPj = Convert.ToString(mtxCEP.Text),
                CPFj = Convert.ToString(mtxCPF.Text),
                telefonej = Convert.ToString(mtxTelefone.Text),
                salarioj = Convert.ToString(txtSalário.Text),
                RGj = Convert.ToString(txtRG.Text),
            };

            if (posicao >= 0)
            {
                Program.FJogos[posicao] = CcFuncJogos;
                MessageBox.Show("Cadastro realizado com Sucesso");
            }
            else
            {
                Program.FJogos.Add(CcFuncJogos);
                MessageBox.Show("Cadastro realizado com sucesso");

            }
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            cbSala.Text = "";
            cbEspecializacao.Text = "";
            nupIdade.Text = "";
            txtEndereco.Text = "";
            mtxCel.Text = "";
            txtEmail.Text = "";
            txtCidade.Text = "";
            mtxCEP.Text = "";
            mtxCPF.Text = "";
            mtxTelefone.Text = "";
            txtSalário.Text = "";
            txtRG.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaFuncJogos ListaFuncJogos = new ListaFuncJogos();
            ListaFuncJogos.Show();
        }

    }
}
