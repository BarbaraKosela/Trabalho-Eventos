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
    public partial class ListarEquipeConvidado : Form
    {
        public ListarEquipeConvidado()
        {
            InitializeComponent();
        }

        private void btnCadastrarEquipe_Click(object sender, EventArgs e)
        {
            new SistemaCadastrarEquipe().ShowDialog();
        }
    }
}
