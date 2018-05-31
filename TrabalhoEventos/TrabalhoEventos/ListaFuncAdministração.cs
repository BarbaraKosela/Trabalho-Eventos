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
    public partial class ListaFuncAdministração : Form
    {
        public ListaFuncAdministração()
        {
            InitializeComponent();
        }

        public void AtualizarLista()
        {
            dvgFuncAdmin.Rows.Clear();
            string Busca = txtBuscaAdmin.Text.ToLower().Trim();
            for (int i = 0; i < Program.FAdmin.Count; i++)
            {
                CcFuncAdmin CcFuncAdmin = Program.FAdmin[i];
                if (CcFuncAdmin.nome.Contains(Busca))
                    dvgFuncAdmin.Rows.Add(new object[]{
                 CcFuncAdmin.nome, CcFuncAdmin.Area, CcFuncAdmin.idade, CcFuncAdmin.endereço, CcFuncAdmin.celular, CcFuncAdmin.cidade, CcFuncAdmin.CEP, CcFuncAdmin.CPF, CcFuncAdmin.telefone, CcFuncAdmin.salario, CcFuncAdmin.RG,
            });
            }
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ListaFuncAdministração_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dvgFuncAdmin.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada !!");
                return;
            }

            int LinhaSelecionada = dvgFuncAdmin.CurrentRow.Index;

            CcFuncAdmin CcFuncAdmin = Program.FAdmin[LinhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja remover " + CcFuncAdmin.nome + "o cadastro ?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.FAdmin.RemoveAt(LinhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Cadastro removido com Sucesso!");
            }
            else
            {
                MessageBox.Show("Seu Cadastro Continua Salvo!");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = dvgFuncAdmin.CurrentRow.Index;

            if (dvgFuncAdmin.CurrentRow == null)
            {
                MessageBox.Show("Selecione um Funcionário!");
                return;
            }

            CcFuncAdmin CcFuncAdmin = Program.FAdmin[LinhaSelecionada];
            new CadastroFuncAdministração(CcFuncAdmin, LinhaSelecionada).ShowDialog();

            CadastroFuncAdministração cadastroFuncAdmin = new CadastroFuncAdministração(CcFuncAdmin, LinhaSelecionada);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
