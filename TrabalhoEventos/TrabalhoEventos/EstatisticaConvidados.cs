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
    public partial class EstatisticaConvidados : Form
    {
        int QtdConvidado = 0, QtdEdquipamento = 0, QtdAtendimento = 0, QtdEquipe = 0;


        public EstatisticaConvidados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QtdConvidado = Program.cadastroDeConvidados.Count;
            MessageBox.Show("Quantidade de cadastros de convidados: " + QtdConvidado);
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QtdEdquipamento = Program.cadastroDeEquipamento.Count;
            MessageBox.Show("Quantidade de cadastros de equipamentos: " + QtdEdquipamento);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QtdEquipe = Program.cadastroEquipeConvidado.Count;
            MessageBox.Show("Quantidade de cadastros de equipes: " + QtdEquipe);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QtdAtendimento = Program.atendimentoAoJogador.Count;
            MessageBox.Show("Quantidade de cadastros de atendimentos: " + QtdAtendimento);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Total = QtdAtendimento + QtdConvidado + QtdEdquipamento + QtdEquipe;
            MessageBox.Show("Total de cadastro: " + Total);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
