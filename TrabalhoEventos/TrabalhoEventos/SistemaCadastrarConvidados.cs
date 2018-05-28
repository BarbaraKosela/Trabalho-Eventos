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
    public partial class SistemaCadastrarConvidados : Form
    {
        private int posicao = -1;
        public SistemaCadastrarConvidados()
        {
            InitializeComponent();
        }

        public SistemaCadastrarConvidados(Convidados cadastroConvidados, int posicao)
        {
            InitializeComponent();
            this.posicao = posicao;
            txtNomeConvidado.Text = cadastroConvidados.NomeConvidado;
            txtIdadeConvidado.Text = Convert.ToString(cadastroConvidados.IdadeConvidado);
            txtNumeroCrachaConvidado.Text = Convert.ToString(cadastroConvidados.NumeroCrachaConvidado);
            txtCPFConvidado.Text = Convert.ToString(cadastroConvidados.CPFConvidado);
            cbSalaAtuarConvidado.SelectedItem = cadastroConvidados.SalaAtualConvidado;
            txtEquipeConvidado.Text = cadastroConvidados.NomeEquipeConvidado;
            txtEmailConvidado.Text = cadastroConvidados.EmailConvidado;
            txtNicknameConvidado.Text = cadastroConvidados.NicknameConvidado;
            cbJogabilidadeConvidado.SelectedItem = cadastroConvidados.JogabilidadeConvidado;
            txtNomeDoJogoConvidado.Text = cadastroConvidados.NomeJogoCampeaoConvidado;
            cbGeneroConvidado.SelectedItem = cadastroConvidados.GeneroConvidado;
            cbMeioDeTransmissaoConvidado.SelectedItem = cadastroConvidados.MeioDeTransmissãoConvidado;
            cbDificuldadeConvidado.SelectedItem = cadastroConvidados.DificuldadeConvidado;

        }

        private void btnSalvarConvidado_Click(object sender, EventArgs e)
        {
            
                if (txtNomeConvidado.Text.Length < 4)
                {
                    MessageBox.Show("O nome do convidado deve conter no mínimo quatro caracteres");
                    txtNomeConvidado.Focus();
                    return;
                }

                if (txtIdadeConvidado.Text.Length < -1)
                {
                    MessageBox.Show("Idade não é válida, por favor digite a idade acima de 0");
                    txtIdadeConvidado.Focus();
                    return;
                }

                if (txtNumeroCrachaConvidado.Text.Length < 5)
                {
                    MessageBox.Show("Por favor, o número do crachá deve ter 5 dígitos, digite novamente");
                    txtNumeroCrachaConvidado.Focus();
                    return;
                }

                if (txtCPFConvidado.Text.Length < 11)
                {
                    MessageBox.Show("CPF tem de ter 11 digitos, por favor digite novamente");
                    txtCPFConvidado.Focus();
                    return;
                }
                if (cbSalaAtuarConvidado.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione a sala em que irá atuar");
                    cbSalaAtuarConvidado.DroppedDown = true;
                    return;
                }

                if (txtEquipeConvidado.Text.Length < 3)
                {
                    MessageBox.Show("O nome da equipe tem que ser superior a 3 dígitos, favor digite novamente");
                    txtEquipeConvidado.Focus();
                    return;
                }

                if (txtEmailConvidado.Text.Length < 10)
                {
                    MessageBox.Show("o E-mail deve conter pelo menos 10 dígitos, contando com o @gmail.com, digite novamente");
                    txtEmailConvidado.Focus();
                    return;
                }

                if (txtNicknameConvidado.Text.Length < 3)
                {
                    MessageBox.Show("O seu Nicknamente deve ter pelo menos 3 dígitos, digite novamente");
                    txtNicknameConvidado.Focus();
                    return;
                }

                if (cbJogabilidadeConvidado.SelectedIndex < 0)
                {
                    MessageBox.Show("Selecione a jogabilidade");
                    cbJogabilidadeConvidado.DroppedDown = true;
                    return;
                }

                if (txtNomeDoJogoConvidado.Text.Length < 3)
                {
                    MessageBox.Show("O nome do jogo deve conter ao menos 3 dígitos, digite novamente");
                }

            



                Convidados cadastroConvidados = new Convidados()

                {
                    NomeConvidado = txtNomeConvidado.Text,
                    IdadeConvidado = Convert.ToInt32(txtIdadeConvidado),
                    NumeroCrachaConvidado = Convert.ToInt32(txtNumeroCrachaConvidado.Text),
                    CPFConvidado = Convert.ToDouble(txtCPFConvidado.Text),
                    SalaAtualConvidado = cbSalaAtuarConvidado.SelectedItem.ToString(),
                    NomeEquipeConvidado = txtEquipeConvidado.Text,
                    EmailConvidado = txtEmailConvidado.Text,
                    NicknameConvidado = txtNicknameConvidado.Text,
                    JogabilidadeConvidado = cbJogabilidadeConvidado.SelectedItem.ToString(),
                    NomeJogoCampeaoConvidado = txtNomeDoJogoConvidado.Text,
                    GeneroConvidado = cbGeneroConvidado.SelectedItem .ToString(),
                    MeioDeTransmissãoConvidado = cbMeioDeTransmissaoConvidado.SelectedItem.ToString(),
                    DificuldadeConvidado = cbDificuldadeConvidado.SelectedItem.ToString()

                };

                if (posicao >= 0)
                {
                    Program.cadastroDeConvidados[posicao] = cadastroConvidados;
                    MessageBox.Show("Cadastro de convidado realizado com sucesso!");
                }

                else
                {
                    Program.cadastroDeConvidados.Add(cadastroConvidados);
                    MessageBox.Show("Cadastro de convidado realizado com sucesso!");
                }


        }

        private void Limpar()
        {
            txtNomeConvidado.Text = "";
            txtIdadeConvidado.Text = "";
            txtNumeroCrachaConvidado.Text = "";
            txtCPFConvidado.Text = "";
            cbSalaAtuarConvidado.SelectedIndex = -1;
            txtEquipeConvidado.Text = "";
            txtEmailConvidado.Text = "";
            txtNicknameConvidado.Text = "";
            cbJogabilidadeConvidado.SelectedIndex = -1;
            txtNomeDoJogoConvidado.Text = "";
            cbGeneroConvidado.SelectedIndex = -1;
            cbMeioDeTransmissaoConvidado.SelectedIndex = -1;
            cbDificuldadeConvidado.SelectedIndex = -1;
        }

        private void btnCancelarConvidado_Click(object sender, EventArgs e)
        {
            Dispose();
        }

       
       

    }
}
