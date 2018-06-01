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
    public partial class ListaFuncJogos : Form
    {
        public ListaFuncJogos()
        {
            InitializeComponent();
        }

        public void AtualizarLista()
        {
            dvgFuncJogos.Rows.Clear();
            string Busca = txtBuscaJogos.Text.ToLower().Trim();
            for (int i = 0; i < Program.FJogos.Count; i++)
            {
                CcFuncJogos CcFuncJogos = Program.FJogos[i];
                if (CcFuncJogos.nomej.Contains(Busca))
                    dvgFuncJogos.Rows.Add(new object[]{
                 CcFuncJogos.nomej, CcFuncJogos.Sala, CcFuncJogos.Especialização, CcFuncJogos.idadej, CcFuncJogos.endereçoj, CcFuncJogos.celularj, CcFuncJogos.cidadej, CcFuncJogos.CEPj, CcFuncJogos.CPFj, CcFuncJogos.telefonej, CcFuncJogos.salarioj, CcFuncJogos.RGj 
            });
            }




        }

        private void ListaFuncJogos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dvgFuncJogos.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada !!");
                return;
            }

            int LinhaSelecionada = dvgFuncJogos.CurrentRow.Index;

            CcFuncJogos  ccFuncJogos = Program.FJogos[LinhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja remover " + ccFuncJogos.nomej +  "o cadastro ?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.FJogos.RemoveAt(LinhaSelecionada);
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
            int LinhaSelecionada = dvgFuncJogos.CurrentRow.Index;

            if (dvgFuncJogos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um Funcionário!");
                return;
            }

            CcFuncJogos ccFuncJogos = Program.FJogos[LinhaSelecionada];
            new CadastroFuncJogos(ccFuncJogos, LinhaSelecionada).ShowDialog();

            CadastroFuncJogos cadastroFuncJogos = new CadastroFuncJogos(ccFuncJogos, LinhaSelecionada);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
