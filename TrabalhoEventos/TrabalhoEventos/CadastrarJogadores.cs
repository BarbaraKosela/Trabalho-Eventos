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
    public partial class CadastrarJogadores : Form
    {
        public CadastrarJogadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroCampeonato cadastroCampeonato = new CadastroCampeonato();
            cadastroCampeonato.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CadastroJogador cadastrojogador = new CadastroJogador();
            cadastrojogador.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroEquipe cadastroequipe = new CadastroEquipe();
            cadastroequipe.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroPatrocinador cadastropatrocinador = new CadastroPatrocinador();
            cadastropatrocinador.Show();
        }
    }
}
