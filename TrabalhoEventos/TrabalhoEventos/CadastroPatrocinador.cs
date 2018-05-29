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
    public partial class CadastroPatrocinador : Form
    {
        public CadastroPatrocinador()
        {
            InitializeComponent();
        }

        private void CadastroPatrocinador_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNomeDoJogo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNomePatrocinador.Text.Length < 3)
            {
                MessageBox.Show("Nome deve conter no minimo 3 caracteres !!");
                txtNomePatrocinador.Focus();
                return;
            }
            if (mtbTelefone.Text.Length < 8)
            {
                MessageBox.Show("Telefone deve conter no minimo 8 caracteres !!");
                mtbTelefone.Focus();
                return;
            }
            if (mtbCpf.Text.Length < 11)
            {
                MessageBox.Show("Cpf deve ser preenchido !!");
                mtbCpf.Focus();
                return;
            }
            if (cbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o Estado !!");
                cbEstado.Focus();
                return;
            }
            if (cbCidade.SelectedIndex < 0)
            {
                MessageBox.Show("Coloque uma cidade !!");
                cbCidade.Focus();
                return;
            }
            if (cbEquipeSendoPatrocinada.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a equipe que vai ser patrocinada !! ");
                cbEquipeSendoPatrocinada.Focus();
                return;
            }
            if (cbTipoPatrocinio.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o tipo de patrocinio !!");
                cbTipoPatrocinio.Focus();
                return;
            }
        }
    }
}
