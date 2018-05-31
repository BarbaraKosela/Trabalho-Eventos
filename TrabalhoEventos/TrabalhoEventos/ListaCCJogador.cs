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
    public partial class ListaCCJogador : Form
    {
        public ListaCCJogador()
        {
            InitializeComponent();
        }

        private void ListaCCJogador_Load(object sender, EventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void AtualizarLista()
        {
            dgvListaJogadores.Rows.Clear();
            string Busca = txtBusca.Text.ToLower().Trim();
            for (int i = 0; i < Program.cjogadores.Count; i++)
            {
                CJogador cjogador = Program.cjogadores[i];

                if (cjogador.NomeJogador.Contains(Busca))
                {
                    dgvListaJogadores.Rows.Add(new object[]{
                    cjogador.NomeJogador,  cjogador.DataNascimento, cjogador.Cpf, cjogador.Telefone, cjogador.TelefoneEmergencia, cjogador.FalarCom, cjogador.Endereco, cjogador.NumeroCasa, cjogador.Email, cjogador.NomeEquipe, cjogador.Estado, cjogador.Cidade,      
                    
                    });

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LinhaSeelecionada = dgvListaJogadores.CurrentRow.Index;

            if (dgvListaJogadores.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum campeonato selecionado !!");
                return;
            }

            CJogador cjogador = Program.cjogadores[LinhaSeelecionada];
            new CadastroJogador(cjogador, LinhaSeelecionada).ShowDialog();

            CadastroJogador cadastrojogador = new CadastroJogador(cjogador, LinhaSeelecionada); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvListaJogadores.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada !!");
                return;
            }

            int LinhaSelecionada = dgvListaJogadores.CurrentRow.Index;

            CJogador cjogador = Program.cjogadores[LinhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja apagar " + cjogador.NomeJogador + "o registro ?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.cjogadores.RemoveAt(LinhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com sucesso !!");
            }
            else
            {
                MessageBox.Show("Seu registro ainda esta salvo !!");
            }
        }


    }
}
