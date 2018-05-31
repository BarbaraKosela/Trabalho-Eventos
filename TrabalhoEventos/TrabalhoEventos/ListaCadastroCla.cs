﻿using System;
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
    public partial class ListaCadastroCla : Form
    {


        public ListaCadastroCla()
        {
            InitializeComponent();
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
            dgvListaCadastroCla.Rows.Clear();
            string Busca = txtBusca.Text.ToLower().Trim();
            for (int i = 0; i < Program.cequipes.Count; i++)
            {
                CEquipes cequipe = Program.cequipes[i];
                if (cequipe.NomeDaEquipe.Contains(Busca))
                {
                    dgvListaCadastroCla.Rows.Add(new object[]{

                    cequipe.NomeDaEquipe, cequipe.EstadoOrigem, cequipe.CidadeOrigem, cequipe.NomeLider, cequipe.CpfLider, cequipe.TelefoneLider, cequipe.FraseCla,cequipe.ParticipouDoJogo, cequipe.GeneroJogo, cequipe.QuantidadeIntegrantes, cequipe.FraseTaca,
});
                    /*cequipe.NomeJogo,*/ 
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
            int LinhaSeelecionada = dgvListaCadastroCla.CurrentRow.Index;

            if (dgvListaCadastroCla.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhum campeonato selecionado !!");
                return;
            }

            CEquipes cequipe = Program.cequipes[LinhaSeelecionada];
            new CadastroEquipe(cequipe, LinhaSeelecionada).ShowDialog();

            CadastroEquipe cadastroequipe = new CadastroEquipe(cequipe, LinhaSeelecionada); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvListaCadastroCla.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada !!");
                return;
            }

            int LinhaSelecionada = dgvListaCadastroCla.CurrentRow.Index;

            CEquipes cequipe = Program.cequipes[LinhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja apagar " + cequipe.NomeDaEquipe + "o registro ?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.cequipes.RemoveAt(LinhaSelecionada);
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