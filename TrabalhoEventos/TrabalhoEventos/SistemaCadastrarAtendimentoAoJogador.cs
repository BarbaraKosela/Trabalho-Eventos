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
    public partial class SistemaCadastrarAtendimentoAoJogador : Form
    {
        private int posicao3 = -1;
        public SistemaCadastrarAtendimentoAoJogador()
        {
            InitializeComponent();
        }


        public SistemaCadastrarAtendimentoAoJogador(AtendimentoJogador cadastroAtendimento, int posicao)
        {
            InitializeComponent();
            this.posicao3 = posicao;
            cbAtendimentoNumero.SelectedItem = cadastroAtendimento.AtenderPorVez;
            cbResponsavelPor.SelectedItem = cadastroAtendimento.Responsabilidade;
            txtNomeJogoAtual.Text = cadastroAtendimento.NomeAtuarJogo;
            txtEquipeColaboradoraConvidado.Text = cadastroAtendimento.EquipeColaboradora;
            txtNumeroCracha3.Text = Convert.ToString(cadastroAtendimento.NumeroCrachaConvidado3);
            cbDificuldadeAtendimento.SelectedItem = cadastroAtendimento.NivelAtuarJogadores;
            txtEmailCasoChamada.Text = cadastroAtendimento.EmailNecessarioAtendimento;
            cbAlimentacaoExtra.SelectedItem = cadastroAtendimento.AlimentacaoExtra;
        }

        private void btnSalvarAtendimento_Click(object sender, EventArgs e)
        {
            if (cbAtendimentoNumero.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a quantidade de pessoas que você pode atender");
                cbAtendimentoNumero.DroppedDown = true;
                return;
            }

            if (cbResponsavelPor.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o campo em que estará responsável para os jogadores");
                cbResponsavelPor.DroppedDown = true;
                return;
            }

            if (txtNomeJogoAtual.Text.Length < 3)
            {
                MessageBox.Show("Nome do jogo deve ter ao mínimo 3 caracteres, digite novamente");
                txtNomeJogoAtual.Focus();
                return;
            }

            if (txtEquipeColaboradoraConvidado.Text.Length < 3)
            {
                MessageBox.Show("Nome da equipe deve ter ao mínimo 3 caracteres, digite novamente");
                txtEquipeColaboradoraConvidado.Focus();
                return;
            }

            if (txtNumeroCracha3.Text.Length < 5)
            {
                MessageBox.Show("O número do seu crachá deve ter ao mínimo 5 dígitos, digite novamente");
                txtNumeroCracha3.Focus();
                return;
            }

            try
            {
                int numeroCracha = Convert.ToInt32(txtNumeroCracha3.Text);
            }

            catch
            {
                MessageBox.Show("Número do crachá pode conter apenas números, digite novamente");
                txtNumeroCracha3.Focus();
                return;
            }

            if (cbDificuldadeAtendimento.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione em que tipo de dificuldade irá atuar com os jogadores");
                cbDificuldadeAtendimento.DroppedDown = true;
                return;
            }

            if (txtEmailCasoChamada.Text.Length < 5)
            {
                MessageBox.Show("O E-mail deve conter pelo menos 10 dígitos, contando com o @gmail.com, digite novamente");
                txtNumeroCracha3.Focus();
                return;
            }

            if (cbAlimentacaoExtra.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a alimentação extra para com os jogadores");
                cbAlimentacaoExtra.DroppedDown = true;
                return;
            }

            AtendimentoJogador cadastroAtendimento = new AtendimentoJogador()

            {
                AtenderPorVez = cbAtendimentoNumero.SelectedItem.ToString(),
                Responsabilidade = cbResponsavelPor.SelectedItem.ToString(),
                NomeAtuarJogo = txtNomeJogoAtual.Text,
                EquipeColaboradora = txtEquipeColaboradoraConvidado.Text,
                NumeroCrachaConvidado3 = Convert.ToInt32(txtNumeroCracha3.Text),
                NivelAtuarJogadores = cbDificuldadeAtendimento.SelectedItem.ToString(),
                SimConvidado = rbSimFotografo.Checked,
                SimConvidado2 = rbSimSeguranca.Checked,
                EmailNecessarioAtendimento = txtEmailCasoChamada.Text,
                AlimentacaoExtra = cbAlimentacaoExtra.SelectedItem.ToString()
            };

            if (posicao3 >= 0)
            {
                Program.atendimentoAoJogador[posicao3] = cadastroAtendimento;
                MessageBox.Show("Cadastro de atendimento realizado com sucesso!");
            }

            else
            {
                Program.atendimentoAoJogador.Add(cadastroAtendimento);
                MessageBox.Show("Cadastro de atendimento realizado com sucesso!");
            }


            
        }

        private void Limpar()
        {
            cbAtendimentoNumero.SelectedIndex = -1;
            cbResponsavelPor.SelectedIndex = -1;
            txtNomeJogoAtual.Text = "";
            txtEquipeColaboradoraConvidado.Text = ""; 
            txtNumeroCracha3.Text = "";
            cbDificuldadeAtendimento.SelectedIndex = -1;
            txtEmailCasoChamada.Text = "";
            cbAlimentacaoExtra.SelectedIndex = -1; 
        }

        private void btnCancelarAtendimento_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarAtendimentoJogador listarAtendimento = new ListarAtendimentoJogador();
            listarAtendimento.Show();
        }




    }
}
