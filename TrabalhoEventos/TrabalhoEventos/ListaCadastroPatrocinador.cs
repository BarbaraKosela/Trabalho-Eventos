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
    public partial class ListaCadastroPatrocinador : Form
    {
        public ListaCadastroPatrocinador()
        {
            InitializeComponent();
        }

        private void ListaCadastroPatrocinador_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void AtualizarLista()
        {
            dgvListaPatrocinador.Rows.Clear();
            string Busca = txtBusca.Text.ToLower().Trim();
            for (int i = 0; i < Program.cpatrocinadores.Count; i++)
            {
                CPatrocinador cpatrocinador = Program.cpatrocinadores[i];

                if (cpatrocinador.NomeDoPatrocinador .Contains(Busca))
                {
                    dgvListaPatrocinador.Rows.Add(new object[]{

                        cpatrocinador.NomeDoPatrocinador, cpatrocinador.Telefone, cpatrocinador.Cpf, cpatrocinador.NomeDaEquipeSendoPatrocinada, cpatrocinador.TipoPatrocinio, cpatrocinador.Estado, cpatrocinador.Cidade,
                   
                    
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
            int LinhaSeelecionada = dgvListaPatrocinador.CurrentRow.Index;

            if (dgvListaPatrocinador.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum campeonato selecionado !!");
                return;
            }

            CPatrocinador cpatrocinador = Program.cpatrocinadores[LinhaSeelecionada];
            new CadastroPatrocinador(cpatrocinador, LinhaSeelecionada).ShowDialog();

            CadastroPatrocinador cadastropatrocinador = new CadastroPatrocinador(cpatrocinador, LinhaSeelecionada); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvListaPatrocinador.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada !!");
                return;
            }

            int LinhaSelecionada = dgvListaPatrocinador.CurrentRow.Index;

            CPatrocinador cpatrocinador = Program.cpatrocinadores[LinhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja apagar " + cpatrocinador.NomeDoPatrocinador + "o registro ?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.cpatrocinadores.RemoveAt(LinhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com sucesso !!");
            }
            else
            {
                MessageBox.Show("Seu registro ainda esta salvo !!");
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AtualizarLista();
        }
    }
}
