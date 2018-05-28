using SistemaJogadores;
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
    public partial class ListarConvidado : Form
    {
        public ListarConvidado()
        {
            InitializeComponent();
        }

        private void ListarConvidado_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }



        private void btnCadastrarConvidado_Click(object sender, EventArgs e)
        {
            new SistemaCadastrarConvidados().ShowDialog();
        }

        private void btnAtualizarConvidado_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            dgvListarConvidados.Rows.Clear();
            for (int i = 0; i < Program.cadastroDeConvidados.Count; i++)
            {
                string busca = txtBuscaConvidado.Text.ToLower();
                Convidados cadastroConvidados = Program.cadastroDeConvidados[i];
                if (cadastroConvidados.NomeConvidado.Contains(busca))
                {
                    dgvListarConvidados.Rows.Add(new object[]{

                    cadastroConvidados.NomeConvidado, cadastroConvidados.IdadeConvidado, cadastroConvidados.NomeEquipeConvidado, cadastroConvidados.NumeroCrachaConvidado
                    });
                } 
            }
        }

        private void btnEditarConvidado_Click(object sender, EventArgs e)
        {
            if (dgvListarConvidados.CurrentRow == null)
            {
                MessageBox.Show("Não há convidado selecionado");
                return;
            }

            int linhaSelecionada = dgvListarConvidados.CurrentRow.Index;
            Convidados cadastroConvidados = Program.cadastroDeConvidados[linhaSelecionada];
            new SistemaCadastrarConvidados(cadastroConvidados, linhaSelecionada).ShowDialog();
        }

        private void btnApagarConvidado_Click(object sender, EventArgs e)
        {
            if (dgvListarConvidados.CurrentRow == null)
            {
                MessageBox.Show("Não há convidado selecionado");
                return;
            }

            int linhaSelecionada = dgvListarConvidados.CurrentRow.Index;
            Convidados cadastroConvidados = Program.cadastroDeConvidados[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja mesmo apagar o convidado " + cadastroConvidados.NomeConvidado + " ?", "AVISO!", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.cadastroDeConvidados.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Seu registro de convidado foi apagado com sucesso");

            }

            else
            {
                MessageBox.Show("Seu registro de convidado está salvo");
            }
        }
            private void ListaDePeca_Activated(object sender, EventArgs e)
        {
            AtualizarLista();
        }

            private void txtBuscaConvidado_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AtualizarLista();
                }
            }

            private void txtBuscaConvidado_Leave(object sender, EventArgs e)
            {
                AtualizarLista();
            }


        





    }
}
