using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaJogadores;

namespace SistemaJogadores
{
    public partial class CadastroCampeonato : Form
    {
        public CCampeonato ccampeonato;
        public int posicao = -1;

        public CadastroCampeonato()
        {
            InitializeComponent();
        }

        public CadastroCampeonato(CCampeonato ccampeonato, int posicao)
        {
            InitializeComponent();
            this.posicao = posicao;
            txtNomeCampeonato.Text = ccampeonato.nomeDocampeonato; 
            txtNomeDoJogo.Text = ccampeonato.nomeDoJogo;
            cbSalaJogo.SelectedItem = ccampeonato.salaDoJogo;
            cbTipoEquipamento.SelectedItem = ccampeonato.tipoDeEquipamento;
            cbGeneroJogo.SelectedItem = ccampeonato.generoDoJogo;
            cbDiaCampeonato.SelectedItem = ccampeonato.dataCampeonato;
            cbHoraCampeonato.SelectedItem = ccampeonato.horaCampeonato;
            mtbPremio1.Text = ccampeonato.premio1;
            mtbPremio2.Text = ccampeonato.premio2;
            mtbPremio3.Text = ccampeonato.premio3;
            cbNivelCampeonato.SelectedItem = ccampeonato.nivel;
            txtQuantidadeEquipesParticipar.Text = Convert.ToString(ccampeonato.quantidadeEquipes);
            mtbTaxaEquipe.Text = Convert.ToString(ccampeonato.taxaEquipe);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaCadastroCampeonato listacadastrocampeonato = new ListaCadastroCampeonato();
            listacadastrocampeonato.Show();
        }

        private void CadastroCampeonato_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                int QuantidadeEquipe = Convert.ToInt32(txtQuantidadeEquipesParticipar.Text);
                txtQuantidadeEquipesParticipar.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor valido para a quantidade ");
                return;
            }
            if (txtNomeCampeonato.Text.Length <= 0)
            {
                MessageBox.Show("Digite um nome para o campeonato !!");
                txtNomeCampeonato.Focus();
                return;
            }
            if (txtNomeDoJogo.Text.Length < 4)
            {
                MessageBox.Show("Nome deve conter mais que 4 carcteres !!");
                txtNomeDoJogo.Focus();
                return;
            }
            if (cbSalaJogo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione ao menos uma sala para o jogo !!");
                cbSalaJogo.Focus();
                return;
            }
            if (cbTipoEquipamento.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione ao menos um tipo de equipamento que sera usado nesse campeonato !!");
                cbTipoEquipamento.Focus();
                return;
            }
            if (cbGeneroJogo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione ao menos um genero para o jogo !!");
                cbGeneroJogo.Focus();
                return;
            }
            if (cbDiaCampeonato.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione ao menos um dia para o campeonato !!");
                cbDiaCampeonato.Focus();
                return;
            }
            if (cbHoraCampeonato.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione ao menos uma hora que o campeonato iniciará !!");
                cbHoraCampeonato.Focus();
                return;
            }
            if (mtbPremio1.Text.Length < 5)
            {
                MessageBox.Show("Digite ao menos um valor para o 1° premio !!");
                mtbPremio1.Focus();
                return;
            }
            if (mtbPremio2.Text.Length < 5)
            {
                MessageBox.Show("Digite ao menos um valor para o 1° premio !!");
                mtbPremio2.Focus();
                return;
            }
            if (mtbPremio3.Text.Length < 5)
            {
                MessageBox.Show("Digite ao menos um valor para o 1° premio !!");
                mtbPremio3.Focus();
                return;
            }
            if (cbNivelCampeonato.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione ao menos um nivel para o campeonato !!");
                cbNivelCampeonato.Focus();
                return;
            }
            if (txtQuantidadeEquipesParticipar.Text.Length <  0)
            {
                MessageBox.Show("Digite um valor valido para a quantidade maxima de equipes que podem participar desse campeonato !!");
                txtQuantidadeEquipesParticipar.Focus();
                return;
            }
            if (mtbTaxaEquipe.Text.Length < 5)
            {
                MessageBox.Show("Digite um valor valido para a taxa a ser paga por equipe para participar do campeonato !!");
                mtbTaxaEquipe.Focus();
                return;
            }

            CCampeonato ccampeonato = new CCampeonato()
            {
               nomeDocampeonato = txtNomeCampeonato.Text, 
               nomeDoJogo = txtNomeDoJogo.Text,
               salaDoJogo = cbSalaJogo.SelectedItem.ToString(),
               tipoDeEquipamento = cbTipoEquipamento.SelectedItem.ToString(),
               generoDoJogo =  cbGeneroJogo.SelectedItem.ToString(),
               dataCampeonato =  cbDiaCampeonato.SelectedItem.ToString(),
               horaCampeonato = cbHoraCampeonato.SelectedItem.ToString(),
               premio1 = mtbPremio1.Text,
               premio2 = mtbPremio2.Text,
               premio3 = mtbPremio3.Text,
               nivel = cbNivelCampeonato.SelectedItem.ToString(),        
               quantidadeEquipes = Convert.ToInt32(txtQuantidadeEquipesParticipar.Text),
               taxaEquipe = Convert.ToDouble(mtbTaxaEquipe.Text)
              

            };

            if (posicao >= 0)
            {
                Program.ccampeonatos[posicao] = ccampeonato;
                MessageBox.Show("Cadastro realizado com sucesso !!");
                LimparCampos();

            }
            else
            {
                Program.ccampeonatos.Add(ccampeonato);
                MessageBox.Show("Cadastro realizado com sucesso !!");
                LimparCampos(); 
            }
        }

        public void LimparCampos()
        {
               txtNomeCampeonato.Text = ""; 
               txtNomeDoJogo.Text = "";
               cbSalaJogo.SelectedIndex = -1;
               cbTipoEquipamento.SelectedIndex = -1;
               cbGeneroJogo.SelectedIndex = -1;
               cbDiaCampeonato.SelectedIndex = -1;
               cbHoraCampeonato.SelectedIndex = -1;
               mtbPremio1.Text = "";
               mtbPremio2.Text = "";
               mtbPremio3.Text = "";
               cbNivelCampeonato.SelectedIndex = -1;    
               txtQuantidadeEquipesParticipar.Text = "";
               mtbTaxaEquipe.Text = "";

        }

        private void mtbTaxaEquipe_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbPremio1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
