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
    public partial class ListaFuncAlimentação : Form
    {
        public ListaFuncAlimentação()
        {
            InitializeComponent();
        }

        public void AtualizarLista()
        {
            dvgFuncAlim.Rows.Clear();
            string Busca = txtBuscaAlim.Text.ToLower().Trim();
            for (int i = 0; i < Program.FAlimentação.Count; i++)
            {
                CcFuncAlimentação CcFuncAlimentação = Program.FAlimentação[i];
                if (CcFuncAlimentação.Nome.Contains(Busca))
                    dvgFuncAlim.Rows.Add(new object[]{
                 CcFuncAlimentação.Nome, CcFuncAlimentação.restaurante, CcFuncAlimentação.posição, CcFuncAlimentação.CEP, CcFuncAlimentação.Idade, CcFuncAlimentação.Endereço, CcFuncAlimentação.Celular, CcFuncAlimentação.Cidade, CcFuncAlimentação.Cpf, CcFuncAlimentação.Telefone, CcFuncAlimentação.Salario, CcFuncAlimentação.Rg,
            });
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dvgFuncAlim.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada !!");
                return;
            }

            int LinhaSelecionada = dvgFuncAlim.CurrentRow.Index;

            CcFuncAlimentação CcFuncAlimentação = Program.FAlimentação[LinhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja remover " + CcFuncAlimentação.Nome + " o cadastro ?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.FAlimentação.RemoveAt(LinhaSelecionada);
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
            int LinhaSelecionada = dvgFuncAlim.CurrentRow.Index;

            if (dvgFuncAlim.CurrentRow == null)
            {
                MessageBox.Show("Selecione um Funcionário!");
                return;
            }

            CcFuncAlimentação CcFuncAlimentação = Program.FAlimentação[LinhaSelecionada];
            new CadastroFuncAlimentação(CcFuncAlimentação, LinhaSelecionada).ShowDialog();

            CadastroFuncAlimentação cadastroFuncAlim = new CadastroFuncAlimentação(CcFuncAlimentação, LinhaSelecionada);
        }
    }
}
