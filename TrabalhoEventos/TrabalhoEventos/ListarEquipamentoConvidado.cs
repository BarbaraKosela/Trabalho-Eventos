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
    public partial class ListarEquipamentoConvidado : Form
    {
        public ListarEquipamentoConvidado()
        {
            InitializeComponent();
        }

        private void ListarEquipamentoConvidado_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnCadastrarConvidado2_Click(object sender, EventArgs e)
        {
            new CadastrarEquipamento().ShowDialog();
        }

        private void btnAtualizarConvidado2_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            dgvListarEquipamento.Rows.Clear();
            for (int i = 0; i < Program.cadastroDeEquipamento.Count; i++)
            {
                string busca2 = txtBuscaEquipamentos.Text.ToLower();
                Equipamento cadastroEquipamento = Program.cadastroDeEquipamento[i];
                if (cadastroEquipamento.EmailNecessarioChamadaConvidado.Contains(busca2))
                {
                    dgvListarEquipamento.Rows.Add(new object[]{

                    cadastroEquipamento.EquipamentoConvidado, cadastroEquipamento.EmailNecessarioChamadaConvidado, cadastroEquipamento.AcompanhamentoConvidado, cadastroEquipamento.NumeroCrachaConvidado2
                    });
                }
            }

        }

        private void btnEditarConvidado2_Click(object sender, EventArgs e)
        {
            if (dgvListarEquipamento.CurrentRow == null)
            {
                MessageBox.Show("Não há convidado selecionado");
                return;
            }

            int linhaSelecionada = dgvListarEquipamento.CurrentRow.Index;
            Equipamento cadastroEquipamentos = Program.cadastroDeEquipamento[linhaSelecionada];
            new CadastrarEquipamento(cadastroEquipamentos, linhaSelecionada).ShowDialog();
        }

        private void btnApagarConvidado2_Click(object sender, EventArgs e)
        {
            if (dgvListarEquipamento.CurrentRow == null)
            {
                MessageBox.Show("Não há equipamento selecionado");
                return;
            }

            int linhaSelecionada = dgvListarEquipamento.CurrentRow.Index;
            Equipamento cadastroEquipamento = Program.cadastroDeEquipamento[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja mesmo apagar o equipamento " + cadastroEquipamento.EquipamentoConvidado + " ?", "AVISO!", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.cadastroDeEquipamento.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Seu registro de equipamento foi apagado com sucesso");

            }

            else
            {
                MessageBox.Show("Seu registro de equipamento está salvo");
            }
        }

        private void ListarEquipamentoConvidado_Activated(object sender, EventArgs e)
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

        private void txtBuscaEquipamentos_TextChanged(object sender, EventArgs e)
        {

        }









        
    }
}
