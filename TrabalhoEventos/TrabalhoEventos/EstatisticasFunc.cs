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
    public partial class EstatisticasFunc : Form
    {
        public EstatisticasFunc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int QuantidadeAdmin = Program.FAdmin.Count;

            int QuantidadeAlim = Program.FAlimentação.Count;

            int QuantidadeTerceirizados = Program.FTerceirizado.Count;

            int QuantidadeJogos = Program.FJogos.Count;

            int QuantidadeTotal = QuantidadeAdmin + QuantidadeAlim + QuantidadeJogos + QuantidadeTerceirizados;
            textBox1.Text = (string.Format("Quantidade de Funcionários Administração:{0}\r\nQuantidade de Funcionários Terceirizados:{1}\r\nQuantidade de Funcionários de Alimentação:{2}\r\nQuantidade de Funcionários do Setor de Jogos:{3}\r\nQuantidade de Funcionários Totais:{4}" ,QuantidadeAdmin, QuantidadeTerceirizados, QuantidadeAlim, QuantidadeJogos, QuantidadeTotal));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
