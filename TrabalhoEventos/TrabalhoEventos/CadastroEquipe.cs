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
    public partial class CadastroEquipe : Form
    {
        OpenFileDialog openfiledialog = new OpenFileDialog();
        

        public CEquipes cequipe;
        public int posicao = -1;
        
        private int LinhaSeelecionada;

        public CadastroEquipe()
        {
            InitializeComponent();
        }

        

        public CadastroEquipe(CEquipes cequipe, int posicao)
        {

            this.posicao = posicao;
            InitializeComponent();
            textBox1.Text = cequipe.Imagem;
            txtNomeDaEquipe.Text = cequipe.NomeDaEquipe;
            txtEstado.Text = cequipe.EstadoOrigem;
            txtCidade.Text = cequipe.CidadeOrigem;
            txtNomeLider.Text = cequipe.NomeLider;
            mtbCpf.Text = cequipe.CpfLider;
            txtTelefone.Text = cequipe.TelefoneLider;            
            cbPesquisa.SelectedItem = cequipe.Pesquisa;
            txtFraseCla.Text = cequipe.FraseCla; 
            rbSim.Checked = cequipe.ParticipouDoJogo;
            cbGeneroJogo.SelectedItem = cequipe.GeneroJogo;
            mtbQuantidadeintegrantes.Text = Convert.ToString(cequipe.QuantidadeIntegrantes);
            txtFraseTaca.Text = cequipe.FraseTaca;
        }

        private void CadastroEquipe_Load(object sender, EventArgs e)
        {
          
         
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNomeDaEquipe_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNomeDaEquipe.Text.Length <= 4)
            {
                MessageBox.Show("Nome do clã deve conter no minimo 4 caracteres !!");
                txtNomeDaEquipe.Focus();
                return;
            }
            if (txtEstado.Text.Length < 2)
            {
                MessageBox.Show("Estado deve ter no minimo 2 caracter !!");
                txtEstado.Focus();
                return;
            }
            if (txtCidade.Text.Length < 4)
            {
                MessageBox.Show("Cidade deve conter no minimo 4 caracter !!");
                txtCidade.Focus();
                return;
            }
            if (txtNomeLider.Text.Length < 4)
            {
                MessageBox.Show("Nome do lider deve conter no minimo 4 caracter !!");
                txtNomeLider.Focus();
                return;
            }

            if (mtbCpf.Text.Length < 11)
            {
                MessageBox.Show("Deve-se colocar o cpf do lider !!");
                mtbCpf.Focus();
                return;
            }

            if (txtTelefone.Text.Length < 8)
            {
                MessageBox.Show("Deve-se colocar o telefone no minimo 8 digitos !!");
                txtTelefone.Focus();
                return;
            }

            
            if (cbPesquisa.SelectedIndex < 0)
            {
                MessageBox.Show("Responda a pesquisa !!");
                cbPesquisa.Focus();
                return;
            }
             
            

            if (txtFraseCla.Text.Length < 10)
            {
                MessageBox.Show("Frase deve conter no minimo 10 caracteres !!");
                return;
            }
            if ((rbSim.Checked == false) && (rbNao.Checked == false))
            {
                MessageBox.Show("Selecione se você já participou alguma deste evento !!");
                return;
                
            }
            if (cbGeneroJogo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o genero do jogo !!");
                cbGeneroJogo.Focus();
                return;

            }
            if (mtbQuantidadeintegrantes.Text.Length < 1)
            {
                MessageBox.Show("Coloque a quantidade de integrante do grupo !!");
                mtbQuantidadeintegrantes.Focus();
                return;
            }
            if (txtFraseTaca.Text.Length < 10)
            {
                MessageBox.Show("Digite a frase que será colocada na taça no minimo 10 caracteres");
                txtFraseTaca.Focus();
                return;
            }

            CEquipes cequipe = new CEquipes()
            {
                Imagem = textBox1.Text,
                NomeDaEquipe = txtNomeDaEquipe.Text,
                EstadoOrigem = txtEstado.Text,
                CidadeOrigem = txtCidade.Text,
                NomeLider = txtNomeLider.Text,
                CpfLider = mtbCpf.Text,
                TelefoneLider = txtTelefone.Text,
                Pesquisa = cbPesquisa.SelectedItem.ToString(),
                FraseCla = txtFraseCla.Text,
                ParticipouDoJogo = rbSim.Checked,
                GeneroJogo = cbGeneroJogo.SelectedItem.ToString(),
                QuantidadeIntegrantes = Convert.ToInt32(mtbQuantidadeintegrantes.Text),
                FraseTaca = txtFraseTaca.Text
            };

            if (posicao >= 0)
            {
                Program.cequipes[posicao] = cequipe;
                MessageBox.Show("Cadastro realizado com sucesso !!");
                LimparCampos();

            }
            else
            {
                Program.cequipes.Add(cequipe);
                MessageBox.Show("Cadastro realizado com sucesso !!");
                LimparCampos();
            }

        }

        public void LimparCampos()
        {
                textBox1.Text = "";
                txtNomeDaEquipe.Text = "";
                txtEstado.Text = "";
                txtCidade.Text = "";
                txtNomeLider.Text = "";
                mtbCpf.Text = "";
                txtTelefone.Text = "";
                cbPesquisa.SelectedIndex = -1;
                txtFraseCla.Text = "";
                rbSim.Checked = false;
                cbGeneroJogo.SelectedIndex = -1;
                mtbQuantidadeintegrantes.Text = "";
                txtFraseTaca.Text = "";
        }

        private void txtFraseCla_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ListaCadastroCla().ShowDialog(); 
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbCampeonato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();

            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openfiledialog.FileName;
                imgSalvar.ImageLocation = openfiledialog.FileName;
            }
           
        }
    }
}
