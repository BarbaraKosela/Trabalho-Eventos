namespace SistemaJogadores
{
    partial class ListaCadastroCla
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
            this.dgvListaCadastroCla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ColumnNomeEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstadoOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidadeOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpfLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefoneLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPesquisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFraseCla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJaParticipou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGeneroJogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeJogadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrasaTaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCadastroCla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaCadastroCla
            // 
            this.dgvListaCadastroCla.AllowUserToAddRows = false;
            this.dgvListaCadastroCla.AllowUserToDeleteRows = false;
            this.dgvListaCadastroCla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvListaCadastroCla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCadastroCla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomeEquipe,
            this.ColumnEstadoOrigem,
            this.ColumnCidadeOrigem,
            this.ColumnNomeLider,
            this.ColumnCpfLider,
            this.ColumnTelefoneLider,
            this.ColumnPesquisa,
            this.ColumnFraseCla,
            this.ColumnJaParticipou,
            this.ColumnGeneroJogo,
            this.ColumnQuantidadeJogadores,
            this.ColumnFrasaTaca});
            this.dgvListaCadastroCla.Location = new System.Drawing.Point(12, 74);
            this.dgvListaCadastroCla.Name = "dgvListaCadastroCla";
            this.dgvListaCadastroCla.ReadOnly = true;
            this.dgvListaCadastroCla.Size = new System.Drawing.Size(1244, 726);
            this.dgvListaCadastroCla.TabIndex = 29;
            this.dgvListaCadastroCla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCadastroCla_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Buscar";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(730, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 35);
            this.button4.TabIndex = 34;
            this.button4.Text = "Atualizar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusca.Location = new System.Drawing.Point(97, 24);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(230, 20);
            this.txtBusca.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(605, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 35);
            this.button3.TabIndex = 33;
            this.button3.Text = "Voltar a pagina anterior";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(480, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 35);
            this.button2.TabIndex = 32;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(355, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 35;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ColumnNomeEquipe
            // 
            this.ColumnNomeEquipe.HeaderText = "Nome da equipe";
            this.ColumnNomeEquipe.Name = "ColumnNomeEquipe";
            this.ColumnNomeEquipe.ReadOnly = true;
            // 
            // ColumnEstadoOrigem
            // 
            this.ColumnEstadoOrigem.HeaderText = "Estado de origem";
            this.ColumnEstadoOrigem.Name = "ColumnEstadoOrigem";
            this.ColumnEstadoOrigem.ReadOnly = true;
            // 
            // ColumnCidadeOrigem
            // 
            this.ColumnCidadeOrigem.HeaderText = "Cidade de origem";
            this.ColumnCidadeOrigem.Name = "ColumnCidadeOrigem";
            this.ColumnCidadeOrigem.ReadOnly = true;
            // 
            // ColumnNomeLider
            // 
            this.ColumnNomeLider.HeaderText = "Nome do lider";
            this.ColumnNomeLider.Name = "ColumnNomeLider";
            this.ColumnNomeLider.ReadOnly = true;
            // 
            // ColumnCpfLider
            // 
            this.ColumnCpfLider.HeaderText = "Cpf do Lider";
            this.ColumnCpfLider.Name = "ColumnCpfLider";
            this.ColumnCpfLider.ReadOnly = true;
            // 
            // ColumnTelefoneLider
            // 
            this.ColumnTelefoneLider.HeaderText = "Telefone do lider";
            this.ColumnTelefoneLider.Name = "ColumnTelefoneLider";
            this.ColumnTelefoneLider.ReadOnly = true;
            // 
            // ColumnPesquisa
            // 
            this.ColumnPesquisa.HeaderText = "Pesquisa";
            this.ColumnPesquisa.Name = "ColumnPesquisa";
            this.ColumnPesquisa.ReadOnly = true;
            // 
            // ColumnFraseCla
            // 
            this.ColumnFraseCla.HeaderText = "Grito de guerra clã";
            this.ColumnFraseCla.Name = "ColumnFraseCla";
            this.ColumnFraseCla.ReadOnly = true;
            // 
            // ColumnJaParticipou
            // 
            this.ColumnJaParticipou.HeaderText = "Participou anteriormente do evento ??";
            this.ColumnJaParticipou.Name = "ColumnJaParticipou";
            this.ColumnJaParticipou.ReadOnly = true;
            // 
            // ColumnGeneroJogo
            // 
            this.ColumnGeneroJogo.HeaderText = "Genero do jogo";
            this.ColumnGeneroJogo.Name = "ColumnGeneroJogo";
            this.ColumnGeneroJogo.ReadOnly = true;
            // 
            // ColumnQuantidadeJogadores
            // 
            this.ColumnQuantidadeJogadores.HeaderText = "Quantidade de integrantes";
            this.ColumnQuantidadeJogadores.Name = "ColumnQuantidadeJogadores";
            this.ColumnQuantidadeJogadores.ReadOnly = true;
            // 
            // ColumnFrasaTaca
            // 
            this.ColumnFrasaTaca.HeaderText = "Frase na taça";
            this.ColumnFrasaTaca.Name = "ColumnFrasaTaca";
            this.ColumnFrasaTaca.ReadOnly = true;
            // 
            // ListaCadastroCla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvListaCadastroCla);
            this.Name = "ListaCadastroCla";
            this.Text = "ListaCadastroCla";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCadastroCla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCadastroCla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeEquipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstadoOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCidadeOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeLider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCpfLider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefoneLider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFraseCla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJaParticipou;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGeneroJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidadeJogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrasaTaca;
    }
}