namespace TrabalhoEventos
{
    partial class ListaCadastroEquipes
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
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ColumnJaParticipou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidadeOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstadoOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrasaTaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeJogadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGeneroJogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeJogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefoneLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpfLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListarCadastroCampeonato = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCadastroCampeonato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Buscar";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(947, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 44);
            this.button4.TabIndex = 23;
            this.button4.Text = "Atualizar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(68, 15);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(235, 20);
            this.txtBusca.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(1115, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 44);
            this.button3.TabIndex = 22;
            this.button3.Text = "Voltar a pagina anterior";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(817, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txtBusca);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(15, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1249, 65);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(687, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ColumnJaParticipou
            // 
            this.ColumnJaParticipou.HeaderText = "Participou anteriormente do evento ??";
            this.ColumnJaParticipou.Name = "ColumnJaParticipou";
            this.ColumnJaParticipou.ReadOnly = true;
            // 
            // ColumnCidadeOrigem
            // 
            this.ColumnCidadeOrigem.HeaderText = "Cidade de origem";
            this.ColumnCidadeOrigem.Name = "ColumnCidadeOrigem";
            this.ColumnCidadeOrigem.ReadOnly = true;
            // 
            // ColumnEstadoOrigem
            // 
            this.ColumnEstadoOrigem.HeaderText = "Estado de origem";
            this.ColumnEstadoOrigem.Name = "ColumnEstadoOrigem";
            this.ColumnEstadoOrigem.ReadOnly = true;
            // 
            // ColumnFrasaTaca
            // 
            this.ColumnFrasaTaca.HeaderText = "Frase na taça";
            this.ColumnFrasaTaca.Name = "ColumnFrasaTaca";
            this.ColumnFrasaTaca.ReadOnly = true;
            // 
            // ColumnQuantidadeJogadores
            // 
            this.ColumnQuantidadeJogadores.HeaderText = "Quantidade de integrantes";
            this.ColumnQuantidadeJogadores.Name = "ColumnQuantidadeJogadores";
            this.ColumnQuantidadeJogadores.ReadOnly = true;
            // 
            // ColumnGeneroJogo
            // 
            this.ColumnGeneroJogo.HeaderText = "Genero do jogo";
            this.ColumnGeneroJogo.Name = "ColumnGeneroJogo";
            this.ColumnGeneroJogo.ReadOnly = true;
            // 
            // ColumnNomeJogo
            // 
            this.ColumnNomeJogo.HeaderText = "Nome do jogo";
            this.ColumnNomeJogo.Name = "ColumnNomeJogo";
            this.ColumnNomeJogo.ReadOnly = true;
            // 
            // ColumnTelefoneLider
            // 
            this.ColumnTelefoneLider.HeaderText = "Telefone do lider";
            this.ColumnTelefoneLider.Name = "ColumnTelefoneLider";
            this.ColumnTelefoneLider.ReadOnly = true;
            // 
            // ColumnCpfLider
            // 
            this.ColumnCpfLider.HeaderText = "Cpf do Lider";
            this.ColumnCpfLider.Name = "ColumnCpfLider";
            this.ColumnCpfLider.ReadOnly = true;
            // 
            // ColumnNomeLider
            // 
            this.ColumnNomeLider.HeaderText = "Column1";
            this.ColumnNomeLider.Name = "ColumnNomeLider";
            this.ColumnNomeLider.ReadOnly = true;
            // 
            // ColumnCla
            // 
            this.ColumnCla.HeaderText = "Clã";
            this.ColumnCla.Name = "ColumnCla";
            this.ColumnCla.ReadOnly = true;
            // 
            // ColumnNomeEquipe
            // 
            this.ColumnNomeEquipe.HeaderText = "Nome da equipe";
            this.ColumnNomeEquipe.Name = "ColumnNomeEquipe";
            this.ColumnNomeEquipe.ReadOnly = true;
            // 
            // dgvListarCadastroCampeonato
            // 
            this.dgvListarCadastroCampeonato.AllowUserToAddRows = false;
            this.dgvListarCadastroCampeonato.AllowUserToDeleteRows = false;
            this.dgvListarCadastroCampeonato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarCadastroCampeonato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomeEquipe,
            this.ColumnCla,
            this.ColumnNomeLider,
            this.ColumnCpfLider,
            this.ColumnTelefoneLider,
            this.ColumnNomeJogo,
            this.ColumnGeneroJogo,
            this.ColumnQuantidadeJogadores,
            this.ColumnFrasaTaca,
            this.ColumnEstadoOrigem,
            this.ColumnCidadeOrigem,
            this.ColumnJaParticipou});
            this.dgvListarCadastroCampeonato.Location = new System.Drawing.Point(15, 104);
            this.dgvListarCadastroCampeonato.Name = "dgvListarCadastroCampeonato";
            this.dgvListarCadastroCampeonato.ReadOnly = true;
            this.dgvListarCadastroCampeonato.Size = new System.Drawing.Size(1249, 601);
            this.dgvListarCadastroCampeonato.TabIndex = 27;
            // 
            // ListaCadastroEquipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 739);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListarCadastroCampeonato);
            this.Name = "ListaCadastroEquipes";
            this.Text = "ListaCadastroEquipes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCadastroCampeonato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJaParticipou;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCidadeOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstadoOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrasaTaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidadeJogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGeneroJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefoneLider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCpfLider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeLider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeEquipe;
        private System.Windows.Forms.DataGridView dgvListarCadastroCampeonato;
    }
}