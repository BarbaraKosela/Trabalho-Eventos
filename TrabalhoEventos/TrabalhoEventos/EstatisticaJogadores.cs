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
    public partial class EstatisticaJogadores : Form
    {
        public EstatisticaJogadores()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EstatisticaJogadores_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int QtdPatrocinadores = Program.cpatrocinadores.Count;
            int QtdJogadores = Program.cjogadores.Count;
            int QtdEquipes = Program.cequipes.Count;
            int QtdCampeonato = Program.ccampeonatos.Count;
            int Total = QtdPatrocinadores + QtdJogadores + QtdEquipes + QtdCampeonato;


            lbCampeonato.Text = Convert.ToString(QtdCampeonato);
            lbCla.Text = Convert.ToString(QtdEquipes);
            lbJogadores.Text = Convert.ToString(QtdJogadores);
            lbPatrocinadores.Text = Convert.ToString(QtdPatrocinadores);
            LBTotal.Text = Convert.ToString(Total);
        }
    }
}
