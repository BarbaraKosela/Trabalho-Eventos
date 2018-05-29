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
    public partial class CadastrarEquipamento : Form
    {
        private int posicao2 = -1;
        public CadastrarEquipamento()
        {
            InitializeComponent();
        }


        public CadastrarEquipamento(Equipamento cadastroEquipamentos, int posicao2)
        {
            InitializeComponent();
            this.posicao2 = posicao2;
            cbEquipamentoSolicitadoConvidado.SelectedItem = cadastroEquipamentos.EquipamentoConvidado;
            cbAreaConvidado.SelectedItem = cadastroEquipamentos.AreaNecessitadaConvidado;
            cbAcompanhamentoConvidado.SelectedItem = cadastroEquipamentos.AcompanhamentoConvidado;
            cbAlimentacaoConvidado.SelectedItem = cadastroEquipamentos.AlimentacaoBasicaConvidado;
            txtNumeroCrachaConvidado2.Text = Convert.ToString(cadastroEquipamentos.NumeroCrachaConvidado2);
            txtEmailChamadaConvidado.Text = cadastroEquipamentos.EmailNecessarioChamadaConvidado;


        }

        private void btnSalvarConvidado2_Click(object sender, EventArgs e)
        {
            if (cbEquipamentoSolicitadoConvidado.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o equipamento solicitado");
                cbEquipamentoSolicitadoConvidado.DroppedDown = true;
                return;
            }

            if (cbAreaConvidado.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a área em que estará ativo");
                cbAreaConvidado.DroppedDown = true;
                return;
            }

            if (cbAcompanhamentoConvidado.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o acompanhamento");
                cbAcompanhamentoConvidado.DroppedDown = true;
                return;
            }

            if (cbAlimentacaoConvidado.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a sua alimentação básica para o evento");
                cbAlimentacaoConvidado.DroppedDown = true;
                return;
            }

            if (txtNumeroCrachaConvidado2.Text.Length < 5)
            {
                MessageBox.Show("O número do crachá deve ter pelo menos 5 dígitos, favor digite novamente");
                txtNumeroCrachaConvidado2.Focus();
                return;
            }

            if (txtEmailChamadaConvidado.Text.Length < 5)
            {
                MessageBox.Show("O E-mail deve conter pelo menos 10 dígitos, contando com o @gmail.com, digite novamente");
                txtEmailChamadaConvidado.Focus();
                return;
            }

            
            
        }
    }
}
