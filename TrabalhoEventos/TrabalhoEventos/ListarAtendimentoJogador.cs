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
                AtendimentoJogador cadastroConvidados = Program.atendimentoAoJogador[i];
                if (cadastroConvidados.EmailNecessarioAtendimento.Contains(busca))
                {
                    dgvListarAtendimento.Rows.Add(new object[]{

                    cadastroConvidados.EmailNecessarioAtendimento, cadastroConvidados.Responsabilidade, cadastroConvidados.AtenderPorVez, cadastroConvidados.EquipeColaboradora
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
            Convidados cadastroConvidados = Program.cadastroDeConvidados[linhaSelecionada];
            new SistemaCadastrarConvidados(cadastroConvidados, linhaSelecionada).ShowDialog();
        }





    }
}
