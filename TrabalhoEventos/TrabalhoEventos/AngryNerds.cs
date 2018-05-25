using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoEventos
{
    public partial class AngryNerds : Form
    {
        public AngryNerds()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnJogadores_Click(object sender, EventArgs e)
        {
            CadastrarJogadores cadastrarJogadores = new CadastrarJogadores();
            cadastrarJogadores.Show();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            CadastrarFuncionarios cadastrarFuncionarios = new CadastrarFuncionarios();
            cadastrarFuncionarios.Show();
        }

        private void btnConvidados_Click(object sender, EventArgs e)
        {
            CadastrarConvidados cadastrarConvidados = new CadastrarConvidados();
            cadastrarConvidados.Show();
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            MapaDoEvento mapaDoEvento = new MapaDoEvento();
            mapaDoEvento.Show();
        }
    }
}
