namespace SistemaJogadores
{
    partial class CadastroEquipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.txtFraseTaca = new System.Windows.Forms.TextBox();
            this.cbGeneroJogo = new System.Windows.Forms.ComboBox();
            this.txtNomeJogo = new System.Windows.Forms.TextBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeLider = new System.Windows.Forms.TextBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mtbQuantidadeintegrantes = new System.Windows.Forms.MaskedTextBox();
            this.cbCla = new System.Windows.Forms.ComboBox();
            this.txtNomeDaEquipe = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(236, 213);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(203, 20);
            this.txtTelefone.TabIndex = 6;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.Location = new System.Drawing.Point(277, 393);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(63, 28);
            this.rbNao.TabIndex = 10;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.Location = new System.Drawing.Point(141, 393);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(60, 28);
            this.rbSim.TabIndex = 9;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // txtFraseTaca
            // 
            this.txtFraseTaca.Location = new System.Drawing.Point(554, 206);
            this.txtFraseTaca.Multiline = true;
            this.txtFraseTaca.Name = "txtFraseTaca";
            this.txtFraseTaca.Size = new System.Drawing.Size(276, 96);
            this.txtFraseTaca.TabIndex = 13;
            // 
            // cbGeneroJogo
            // 
            this.cbGeneroJogo.FormattingEnabled = true;
            this.cbGeneroJogo.Items.AddRange(new object[] {
            "Sex",
            "Sab",
            "Dom"});
            this.cbGeneroJogo.Location = new System.Drawing.Point(641, 10);
            this.cbGeneroJogo.Name = "cbGeneroJogo";
            this.cbGeneroJogo.Size = new System.Drawing.Size(203, 21);
            this.cbGeneroJogo.TabIndex = 11;
            // 
            // txtNomeJogo
            // 
            this.txtNomeJogo.Location = new System.Drawing.Point(236, 253);
            this.txtNomeJogo.Name = "txtNomeJogo";
            this.txtNomeJogo.Size = new System.Drawing.Size(203, 20);
            this.txtNomeJogo.TabIndex = 7;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(236, 174);
            this.mtbCpf.Mask = "999.999.999-99";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(203, 20);
            this.mtbCpf.TabIndex = 5;
            // 
            // txtNomeLider
            // 
            this.txtNomeLider.Location = new System.Drawing.Point(236, 138);
            this.txtNomeLider.Name = "txtNomeLider";
            this.txtNomeLider.Size = new System.Drawing.Size(203, 20);
            this.txtNomeLider.TabIndex = 4;
            // 
            // cbCidade
            // 
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(236, 100);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(203, 21);
            this.cbCidade.TabIndex = 3;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbEstado.Location = new System.Drawing.Point(236, 61);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(203, 21);
            this.cbEstado.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(52, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(392, 16);
            this.label13.TabIndex = 100;
            this.label13.Text = "Primeira vez que  essa euipe participa desse evento ??";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(47, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 16);
            this.label12.TabIndex = 99;
            this.label12.Text = "Cidade de origem";
            // 
            // mtbQuantidadeintegrantes
            // 
            this.mtbQuantidadeintegrantes.Location = new System.Drawing.Point(667, 83);
            this.mtbQuantidadeintegrantes.Mask = "99";
            this.mtbQuantidadeintegrantes.Name = "mtbQuantidadeintegrantes";
            this.mtbQuantidadeintegrantes.Size = new System.Drawing.Size(41, 20);
            this.mtbQuantidadeintegrantes.TabIndex = 12;
            // 
            // cbCla
            // 
            this.cbCla.FormattingEnabled = true;
            this.cbCla.Items.AddRange(new object[] {
            "08 : 00",
            "10 : 00",
            "13: 00",
            "15: 00",
            "17: 00",
            "19: 30",
            "21: 00",
            "22: 00"});
            this.cbCla.Location = new System.Drawing.Point(236, 292);
            this.cbCla.Name = "cbCla";
            this.cbCla.Size = new System.Drawing.Size(203, 21);
            this.cbCla.TabIndex = 8;
            // 
            // txtNomeDaEquipe
            // 
            this.txtNomeDaEquipe.Location = new System.Drawing.Point(236, 24);
            this.txtNomeDaEquipe.Name = "txtNomeDaEquipe";
            this.txtNomeDaEquipe.Size = new System.Drawing.Size(203, 20);
            this.txtNomeDaEquipe.TabIndex = 1;
            this.txtNomeDaEquipe.TextChanged += new System.EventHandler(this.txtNomeDaEquipe_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(728, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 55);
            this.button3.TabIndex = 95;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(580, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 55);
            this.button2.TabIndex = 94;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(165, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 55);
            this.button1.TabIndex = 93;
            this.button1.Text = "Listar Equipes";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 16);
            this.label11.TabIndex = 92;
            this.label11.Text = "Estado de origem";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(577, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 48);
            this.label10.TabIndex = 91;
            this.label10.Text = "    * Digite a frase que será \r\n            colocada na taça\r\ncaso a  equipe seja" +
    " a vencedora\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(577, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 16);
            this.label8.TabIndex = 90;
            this.label8.Text = "Quantidades  de integrantes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(508, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 16);
            this.label9.TabIndex = 89;
            this.label9.Text = "Generodo Jogo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 88;
            this.label6.Text = "Nome do jogo escolhido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 87;
            this.label5.Text = "Telefone do lider";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 86;
            this.label4.Text = "Cpf do lider";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 85;
            this.label3.Text = "Nome do lider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Clã";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Nome da equipe";
            // 
            // CadastroEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 511);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.txtFraseTaca);
            this.Controls.Add(this.cbGeneroJogo);
            this.Controls.Add(this.txtNomeJogo);
            this.Controls.Add(this.mtbCpf);
            this.Controls.Add(this.txtNomeLider);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mtbQuantidadeintegrantes);
            this.Controls.Add(this.cbCla);
            this.Controls.Add(this.txtNomeDaEquipe);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroEquipe";
            this.Text = "CadastroEquipe";
            this.Load += new System.EventHandler(this.CadastroEquipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.TextBox txtFraseTaca;
        private System.Windows.Forms.ComboBox cbGeneroJogo;
        private System.Windows.Forms.TextBox txtNomeJogo;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox txtNomeLider;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtbQuantidadeintegrantes;
        private System.Windows.Forms.ComboBox cbCla;
        private System.Windows.Forms.TextBox txtNomeDaEquipe;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}