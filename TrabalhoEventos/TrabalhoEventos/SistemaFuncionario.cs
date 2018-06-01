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
    public partial class SistemaFuncionario : Form
    {
        public SistemaFuncionario()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new CadastroFuncAdministração().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CadastroFuncTerceirizado().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CadastroFuncAlimentação().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroFuncJogos().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
