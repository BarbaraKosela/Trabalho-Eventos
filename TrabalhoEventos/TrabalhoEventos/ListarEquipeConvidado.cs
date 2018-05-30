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
    public partial class ListarEquipeConvidado : Form
    {
        public ListarEquipeConvidado()
        {
            InitializeComponent();
        }

        private void btnCadastrarEquipe_Click(object sender, EventArgs e)
        {
            new SistemaCadastrarEquipe().ShowDialog();
        }

        private void ListarEquipeConvidado_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnAtualizarEquipe_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            dgvListarEquipe.Rows.Clear();
            for (int i = 0; i < Program.cadastroDeConvidados.Count; i++)
            {
                string busca = txtBuscaEquipe.Text.ToLower();
                EquipeConvidado cadastroEquipeConvidado2 = Program.cadastroEquipeConvidado[i];
                if (cadastroEquipeConvidado2.NomeEquipe.Contains(busca))
                {
                    dgvListarEquipe.Rows.Add(new object[]{

                    cadastroEquipeConvidado2.SeuNome, cadastroEquipeConvidado2.SuaIdade, cadastroEquipeConvidado2.NomeCampeao, cadastroEquipeConvidado2.NomeLider
                    });
                }
            }


        }

        private void btnEditarEquipe_Click(object sender, EventArgs e)
        {
            if (dgvListarEquipe.CurrentRow == null)
            {
                MessageBox.Show("Não há equipe selecionada");
                return;
            }

            int linhaSelecionada = dgvListarEquipe.CurrentRow.Index;
            EquipeConvidado cadastroEquipeConvidado2 = Program.cadastroEquipeConvidado[linhaSelecionada];
            new SistemaCadastrarEquipe(cadastroEquipeConvidado2, linhaSelecionada).ShowDialog();
        }

        private void btnApagarEquipe_Click(object sender, EventArgs e)
        {
            if (dgvListarEquipe.CurrentRow == null)
            {
                MessageBox.Show("Não há equipe selecionada");
                return;
            }

            int linhaSelecionada = dgvListarEquipe.CurrentRow.Index;
            EquipeConvidado cadastroEquipeConvidado2 = Program.cadastroEquipeConvidado[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja mesmo apagar a equipe " + cadastroEquipeConvidado2.NomeEquipe + " ?", "AVISO!", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.cadastroEquipeConvidado.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Seu registro de equipe foi apagado com sucesso");

            }

            else
            {
                MessageBox.Show("Seu registro de equipe está salvo");
            }
        }

        private void ListarEquipeConvidado_Activated(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void txtBuscaEquipe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }

        private void txtBuscaEquipe_Leave(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
