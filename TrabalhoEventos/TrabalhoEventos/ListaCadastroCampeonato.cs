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
    public partial class ListaCadastroCampeonato : Form
    {
        public ListaCadastroCampeonato()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void AtualizarLista()
        {
            dgvListaCampeonato.Rows.Clear();
            string Busca = txtBuscaCampeonato.Text.ToLower().Trim();
            for (int i = 0; i < Program.ccampeonatos.Count; i++)
            {
                CCampeonato ccampeonato = Program.ccampeonatos[i];
                if (ccampeonato.nomeDoJogo.Contains(Busca))
                {
                    dgvListaCampeonato.Rows.Add(new object[]{
                        ccampeonato.nomeDocampeonato, ccampeonato.nomeDoJogo, ccampeonato.salaDoJogo, ccampeonato.tipoDeEquipamento, ccampeonato.generoDoJogo, ccampeonato.dataCampeonato, ccampeonato.horaCampeonato, ccampeonato.premio1,  ccampeonato.premio2, ccampeonato.premio3,ccampeonato.nivel, ccampeonato.quantidadeEquipes, ccampeonato.taxaEquipe,

                    });
                }
            }
        }
        public void button4_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void txtBuscaCampeonato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarLista();   
            }
        }

        private void txtBuscaCampeonato_TextChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LinhaSeelecionada = dgvListaCampeonato.CurrentRow.Index;

            if (dgvListaCampeonato.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum campeonato selecionado !!");
                return;
            }

            CCampeonato ccampeonato = Program.ccampeonatos[LinhaSeelecionada];
            new CadastroCampeonato(ccampeonato, LinhaSeelecionada).ShowDialog();

            CadastroCampeonato cadastrocampeonato = new CadastroCampeonato(ccampeonato, LinhaSeelecionada); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvListaCampeonato.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada !!");
                return;
            }

            int LinhaSelecionada = dgvListaCampeonato.CurrentRow.Index;

            CCampeonato ccampeonato = Program.ccampeonatos[LinhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja apagar o campeonato: (" + ccampeonato.nomeDocampeonato + " ) ??", "AVISO", MessageBoxButtons.YesNo);
            if (resultado  == DialogResult.Yes)
            {
                Program.ccampeonatos.RemoveAt(LinhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com sucesso !!");
            }
            else
            {
                MessageBox.Show("Seu registro ainda esta salvo !!");    
            }

        }

        private void dgvListaCampeonato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaCadastroCampeonato_Load(object sender, EventArgs e)
        {

        }


    }
}
