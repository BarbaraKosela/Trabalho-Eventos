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
        public int posicao = -1;
        public CPatrocinador cpatrocinador;
        private CPatrocinador cpatrocinador1;
        private int LinhaSeelecionada;

        public CadastroPatrocinador()
        {
            InitializeComponent();
        }

        public CadastroPatrocinador(CPatrocinador cpatrocinador1, int LinhaSeelecionada)
        {
            // TODO: Complete member initialization
            this.cpatrocinador1 = cpatrocinador1;
            this.LinhaSeelecionada = LinhaSeelecionada;
        }

        public void CadastrarPatrocinador(CJogador cjogador, int posicao)
        {
            InitializeComponent();
            this.posicao = posicao;

            txtNomePatrocinador.Text = cpatrocinador.NomeDoPatrocinador;
            txtTelefone.Text = cpatrocinador.Telefone;
            mtbCpf.Text = cpatrocinador.Cpf;
            txtEquipe.Text = cpatrocinador.NomeDaEquipeSendoPatrocinada;
            cbTipoPatrocinio.SelectedItem = cpatrocinador.TipoPatrocinio;
            txtEstado.Text = cpatrocinador.Estado;
            txtCidade.Text = cpatrocinador.Cidade;
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
            if (txtTelefone.Text.Length < 8)
            {
                MessageBox.Show("Telefone deve conter no minimo 8 caracteres !!");
                txtTelefone.Focus();
                return;
            }
            if (mtbCpf.Text.Length < 11)
            {
                MessageBox.Show("Cpf deve ser preenchido !!");
                mtbCpf.Focus();
                return;
            }
            if (txtEstado.Text.Length < 2)
            {
                MessageBox.Show("Estado deve conter no minimo 2 caracteres");
                txtEstado.Focus();
                return;
            }
            if (txtCidade.Text.Length < 4)
            {
                MessageBox.Show("Estado deve conter no minimo 2 caracteres");
                txtCidade.Focus();
                return;
            }
            if (txtEquipe.Text.Length < 4)
            {
                MessageBox.Show("Coloque o nome da equipe que vai patrocinar !! ");
                txtEquipe.Focus();
                return;
            }
            if (cbTipoPatrocinio.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o tipo de patrocinio !!");
                cbTipoPatrocinio.Focus();
                return;
            }

            CPatrocinador cpatrocinador = new CPatrocinador() 
            {
                NomeDoPatrocinador = txtNomePatrocinador.Text,
                Telefone = txtTelefone.Text,
                Cpf = mtbCpf.Text,
                NomeDaEquipeSendoPatrocinada = txtEquipe.Text,
                TipoPatrocinio = cbTipoPatrocinio.SelectedItem.ToString(),
                Estado = txtEstado.Text,
                Cidade = txtCidade.Text

            };

            if (posicao >= 0)
            {
                Program.cpatrocinadores[posicao] = cpatrocinador;
                MessageBox.Show("Cadastro realizado com sucesso !!");
                LimparCampos();

            }
            else
            {
                Program.cpatrocinadores.Add(cpatrocinador);
                MessageBox.Show("Cadastro realizado com sucesso !!");
                LimparCampos();
            }
        }

        public void LimparCampos()
        {
            txtNomePatrocinador.Text = "";
            txtTelefone.Text = "";
            mtbCpf.Text = "";
            txtEquipe.Text = "";
            cbTipoPatrocinio.SelectedIndex = -1;
            txtEstado.Text = "";
            txtCidade.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEquipe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
