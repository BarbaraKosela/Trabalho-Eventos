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
    public partial class CadastrarConvidados : Form
    {
        public CadastrarConvidados()
        {
            InitializeComponent();
        }

        private void btnCadastrarConvidado_Click(object sender, EventArgs e)
        {
            SistemaCadastrarConvidados cadastrarConvidados = new SistemaCadastrarConvidados();
            cadastrarConvidados.Show();
        }

        private void btnCadastrarEquipamento_Click(object sender, EventArgs e)
        {
            CadastrarEquipamento cadastrarEquipamento = new CadastrarEquipamento();
            cadastrarEquipamento.Show();
        }

        private void btnCadastrarAtendimentoJogador_Click(object sender, EventArgs e)
        {
            SistemaCadastrarAtendimentoAoJogador sistemaCadastrarAtendimentoAoJogador = new SistemaCadastrarAtendimentoAoJogador();
            sistemaCadastrarAtendimentoAoJogador.Show();
        }

        private void btnCadastrarEquipe_Click(object sender, EventArgs e)
        {
            SistemaCadastrarEquipe sistemaCadastrarEquipe = new SistemaCadastrarEquipe();
            sistemaCadastrarEquipe.Show();
        }

        private void btnVoltarPaginaPrincipalConvidado_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
