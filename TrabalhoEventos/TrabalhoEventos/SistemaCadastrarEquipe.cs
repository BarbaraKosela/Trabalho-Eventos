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
    public partial class SistemaCadastrarEquipe : Form
    {
        private int posicao4 = -1;
        public SistemaCadastrarEquipe()
        {
            InitializeComponent();
        }

        public SistemaCadastrarEquipe(EquipeConvidado cadastroEquipeConvidado2, int posicao)
        {
            InitializeComponent();
            this.posicao4 = posicao;
            txtNomeEquipe.Text = cadastroEquipeConvidado2.NomeEquipe;
            txtSeuNome.Text = cadastroEquipeConvidado2.SeuNome;
            txtIdadePessoa.Text = cadastroEquipeConvidado2.SuaIdade;
            cbFuncao.SelectedItem = cadastroEquipeConvidado2.Funcao;
            txtRG.Text = cadastroEquipeConvidado2.RG;
            txtCPF.Text = cadastroEquipeConvidado2.CPF;
            txtNomeCampeao.Text = cadastroEquipeConvidado2.NomeCampeao;
            txtNumeroCracha.Text = Convert.ToString(cadastroEquipeConvidado2.NumeroCracha);
            txtLiderDeEquipe.Text = cadastroEquipeConvidado2.NomeLider;
            txtEmailContato.Text = cadastroEquipeConvidado2.EmailContato;
            txtNumeroMembros.Text = Convert.ToString(cadastroEquipeConvidado2.NumeroMembros);

        }
        private void btnSalvarConvidado_Click(object sender, EventArgs e)
        {

            if (txtNomeEquipe.Text.Length < 3)
            {
                MessageBox.Show("Nome da equipe deve ter pelo menos 3 caracteres, digite novamente");
                txtNomeEquipe.Focus();
                return;
            }
            if (txtSeuNome.Text.Length < 3)
            {
                MessageBox.Show("Seu nome deve conter pelo menos 3 dígitos, digite novamente");
                txtSeuNome.Focus();
                return;
            }

            if (txtIdadePessoa.Text.Length < 0)
            {
                MessageBox.Show("Idade não é válida, digite novamente");
                txtIdadePessoa.Focus();
                return;
            }

            try
            {
                int idade = Convert.ToInt32(txtIdadePessoa.Text);
            }

            catch
            {
                
                    MessageBox.Show("Por favor, digite uma idade válida");
                    txtIdadePessoa.Focus();
                    return;
                
            }

            if (cbFuncao.SelectedIndex < 0)
            {
                
                    MessageBox.Show("Selecione a função que atua");
                    cbFuncao.DroppedDown = true;
                    return;
                
            }

            if (txtRG.Text.Length < 9)
            {
                MessageBox.Show("RG deve conter pelo menos 9 dígitos");
                txtRG.Focus();
                return;
            }

            if (txtCPF.Text.Length < 11)
            {
                MessageBox.Show("CPF deve conter pelo menos 11 dígitos");
                txtCPF.Focus();
                return;
            }

            if (txtNomeCampeao.Text.Length < 3)
            {
                MessageBox.Show("O nome do campeão que você patrocina deve ter ao mínimo 3 dígitos");
                txtNomeCampeao.Focus();
                return;
            }

            if (txtNumeroCracha.Text.Length < 5)
            {
                MessageBox.Show("Número do crachá deve ter pelo menos 5 dígitos");
                txtNumeroCracha.Focus();
                return;
            }

            try
            {
                int numeroCracha = Convert.ToInt32(txtNumeroCracha.Text);
            }

            catch
            {

                MessageBox.Show("Por favor, digite um número de crachá válido");
                txtNumeroCracha.Focus();
                return;

            }

            if (txtLiderDeEquipe.Text.Length < 3)
            {
                MessageBox.Show("Nome do líder deve ter pelo menos 5 dígitos");
                txtLiderDeEquipe.Focus();
                return;
            }

            if (txtEmailContato.Text.Length < 10)
            {
                MessageBox.Show("O E-mail deve conter pelo menos 10 dígitos, contando com o @gmail.com, digite novamente");
                txtEmailContato.Focus();
                return;
            }

            try
            {
                int numeroMembros = Convert.ToInt32(txtNumeroMembros.Text);
            }

            catch
            {

                MessageBox.Show("Por favor, digite o número de membros válido");
                txtNumeroMembros.Focus();
                return;

            }


            EquipeConvidado cadastroEquipeConvidado2 = new EquipeConvidado()
            {
                NomeEquipe = txtNomeEquipe.Text,
                SeuNome = txtSeuNome.Text,
                SuaIdade = Convert.ToString(txtIdadePessoa.Text),
                Funcao = cbFuncao.SelectedItem.ToString(),
                RG = txtRG.Text,
                CPF = txtCPF.Text,
                NomeCampeao = txtNomeCampeao.Text,
                NumeroCracha = Convert.ToInt32(txtNumeroCracha.Text),
                NomeLider = txtLiderDeEquipe.Text,
                EmailContato = txtEmailContato.Text,
                NumeroMembros = Convert.ToInt32(txtNumeroMembros.Text)
            };

            if (posicao4 >= 0)
            {
                Program.cadastroEquipeConvidado[posicao4] = cadastroEquipeConvidado2;
                MessageBox.Show("Cadastro de equipe realizado com sucesso!");
            }

            else
            {
                Program.cadastroEquipeConvidado.Add(cadastroEquipeConvidado2);
                MessageBox.Show("Cadastro de equipe realizado com sucesso!");
            }

        }

            private void Limpar()
        {
            txtNomeEquipe.Text = "";
            txtSeuNome.Text = "";
            txtIdadePessoa.Text = "";
            cbFuncao.SelectedItem = -1;
            txtRG.Text = "";
            txtCPF.Text = "";
            txtNomeCampeao.Text = ""; 
            txtNumeroCracha.Text = "";
            txtLiderDeEquipe.Text = "";
            txtEmailContato.Text = "";
            txtNumeroMembros.Text = "";

        }

        private void btnCancelarConvidado_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarEquipeConvidado listarEquipeConvidado = new ListarEquipeConvidado();
            listarEquipeConvidado.Show();
        }

        
    }
}
