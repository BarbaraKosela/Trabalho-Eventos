using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoEventos
{
    public partial class SistemaCadastrarConvidados : Form
    {
        private int posicao = -1;
        public SistemaCadastrarConvidados()
        {
            InitializeComponent();
        }

        public SistemaCadastrarConvidados(Convidados cadastroDeConvidados, int posicao)
        {
            InitializeComponent();
            this.posicao = posicao;
            txtNomeConvidado.Text = cadastroDeConvidados.NomeConvidado;
            txtIdadeConvidado.Text = Convert.ToString(cadastroDeConvidados.IdadeConvidado);
            txtNumeroCrachaConvidado.Text = Convert.ToString(cadastroDeConvidados.NumeroCrachaConvidado);
            txtCPFConvidado.Text = Convert.ToString(cadastroDeConvidados.CPFConvidado);
            cbSalaAtuarConvidado.SelectedItem = cadastroDeConvidados.SalaAtualConvidado;
            txtEquipeConvidado.Text = cadastroDeConvidados.NomeEquipeConvidado;
            txtEmailConvidado.Text = cadastroDeConvidados.EmailConvidado;
            txtNicknameConvidado.Text = cadastroDeConvidados.NicknameConvidado;
            cbJogabilidadeConvidado.SelectedItem = cadastroDeConvidados.JogabilidadeConvidado;
            txtNomeDoJogoConvidado.Text = cadastroDeConvidados.NomeJogoCampeaoConvidado;
            cbGeneroConvidado.SelectedItem = cadastroDeConvidados.GeneroConvidado;
            cbMeioDeTransmissaoConvidado.SelectedItem = cadastroDeConvidados.MeioDeTransmissãoConvidado;
            cbDificuldadeConvidado.SelectedItem = cadastroDeConvidados.DificuldadeConvidado;

        }

        private void btnSalvarConvidado_Click(object sender, EventArgs e)
        {
            
                if (txtNomeConvidado.Text.Length < 4)
                {
                    MessageBox.Show("O nome do convidado deve conter no mínimo quatro caracteres");
                    txtNomeConvidado.Focus();
                    return;
                }
                try
                {
                    string nome = Convert.ToString(txtNomeConvidado.Text);
                }
                catch
                {
                    MessageBox.Show("Por favor, digite apenas letras no nome!");
                    txtNomeConvidado.Focus();
                    return;
                }

                if (txtIdadeConvidado.Text.Length < 0)
                {
                    MessageBox.Show("Por favor, digite uma idade válida, acima de 0");
                    txtIdadeConvidado.Focus();
                    return;
                }

                else if (txtIdadeConvidado.Text.Length > 130)
                {
                    MessageBox.Show("Por favor, digite uma idade válida, abaixo de 130");
                    txtIdadeConvidado.Focus();
                    return;
                }
            
        }
       

    }
}
