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
    public partial class ListaFuncTerceirizados : Form
    {
        public ListaFuncTerceirizados()
        {
            InitializeComponent();
        }

        public void AtualizarLista()
        {
            dvgFuncTerceirizados.Rows.Clear();
            string Busca = txtFuncTerceirizado.Text.ToLower().Trim();
            for (int i = 0; i < Program.FTerceirizado.Count; i++)
            {
                CcFuncTerceirizado CcFuncTerceirizado = Program.FTerceirizado[i];
                if (CcFuncTerceirizado.nomet.Contains(Busca))
                    dvgFuncTerceirizados.Rows.Add(new object[]{
                 CcFuncTerceirizado.nomet, CcFuncTerceirizado.idadet, CcFuncTerceirizado.endereçot, CcFuncTerceirizado.celulart, CcFuncTerceirizado.cidadet, CcFuncTerceirizado.CPFt, CcFuncTerceirizado.telefonet, CcFuncTerceirizado.salariot, CcFuncTerceirizado.RGt,

                    });
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = dvgFuncTerceirizados.CurrentRow.Index;

            if (dvgFuncTerceirizados.CurrentRow == null)
            {
                MessageBox.Show("Selecione um Funcionário!");
                return;
            }

            CcFuncTerceirizado CcFuncTerceirizado = Program.FTerceirizado[LinhaSelecionada];
            new CadastroFuncTerceirizado(CcFuncTerceirizado, LinhaSelecionada).ShowDialog();

            CadastroFuncTerceirizado cadastroFuncTerceirizado = new CadastroFuncTerceirizado(CcFuncTerceirizado, LinhaSelecionada);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dvgFuncTerceirizados.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada !!");
                return;
            }

            int LinhaSelecionada = dvgFuncTerceirizados.CurrentRow.Index;

            CcFuncTerceirizado CcFuncTerceirizado = Program.FTerceirizado[LinhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja remover " + CcFuncTerceirizado.nomet + " o cadastro ?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.FTerceirizado.RemoveAt(LinhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Cadastro removido com Sucesso!");
            }
            else
            {
                MessageBox.Show("Seu Cadastro Continua Salvo!");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
