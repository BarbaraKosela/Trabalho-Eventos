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
    public partial class ListarAtendimentoJogador : Form
    {
        public ListarAtendimentoJogador()
        {
            InitializeComponent();
        }

        private void btnCadastrarAtentendimento_Click(object sender, EventArgs e)
        {
            new SistemaCadastrarAtendimentoAoJogador().ShowDialog();
        }

        private void ListarAtendimentoJogador_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnAtualizarAtendimento_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            dgvListarAtendimento.Rows.Clear();
            for (int i = 0; i < Program.atendimentoAoJogador.Count; i++)
            {
                string busca = dgvListarAtendimento.Text.ToLower();
                AtendimentoJogador cadastroAtendimento = Program.atendimentoAoJogador[i];
                if (cadastroAtendimento.EmailNecessarioAtendimento.Contains(busca))
                {
                    dgvListarAtendimento.Rows.Add(new object[]{

                    cadastroAtendimento.EmailNecessarioAtendimento, cadastroAtendimento.Responsabilidade, cadastroAtendimento.AtenderPorVez, cadastroAtendimento.EquipeColaboradora
                    });
                } 
            }
        }

        private void btnEditarAtendimento_Click(object sender, EventArgs e)
        {
            if (dgvListarAtendimento.CurrentRow == null)
            {
                MessageBox.Show("Não há atendimento selecionado");
                return;
            }

            int linhaSelecionada = dgvListarAtendimento.CurrentRow.Index;
            AtendimentoJogador cadastroAtendimento = Program.atendimentoAoJogador[linhaSelecionada];
            new SistemaCadastrarAtendimentoAoJogador(cadastroAtendimento, linhaSelecionada).ShowDialog();
        }

        private void btnApagarAtendimento_Click(object sender, EventArgs e)
        {
            if (dgvListarAtendimento.CurrentRow == null)
            {
                MessageBox.Show("Não há atendimento selecionado");
                return;
            }

            int linhaSelecionada = dgvListarAtendimento.CurrentRow.Index;
            AtendimentoJogador cadastroAtendimento = Program.atendimentoAoJogador[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja mesmo apagar o atendimento de " + cadastroAtendimento.EmailNecessarioAtendimento + " ?", "AVISO!", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.atendimentoAoJogador.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Seu registro de atendimento foi apagado com sucesso");

            }

            else
            {
                MessageBox.Show("Seu registro de atendimento está salvo");
            }
        }

        private void ListarAtendimentoJogador_Activated(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void txtBuscaEquipamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }

        private void txtBuscaEquipamentos_Leave(object sender, EventArgs e)
        {
            AtualizarLista();
        }







    }
}
