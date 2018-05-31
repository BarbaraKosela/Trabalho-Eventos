﻿namespace SistemaJogadores
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ColumnNomeEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstadoOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidadeOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpfLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefoneLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFraseCla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJaParticipou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGeneroJogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeJogadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFrasaTaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCadastroCla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaCadastroCla
            // 
            this.dgvListaCadastroCla.AllowUserToAddRows = false;
            this.dgvListaCadastroCla.AllowUserToDeleteRows = false;
            this.dgvListaCadastroCla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCadastroCla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomeEquipe,
            this.ColumnEstadoOrigem,
            this.ColumnCidadeOrigem,
            this.ColumnNomeLider,
            this.ColumnCpfLider,
            this.ColumnTelefoneLider,
            this.ColumnFraseCla,
            this.ColumnJaParticipou,
            this.ColumnGeneroJogo,
            this.ColumnQuantidadeJogadores,
            this.ColumnFrasaTaca});
            this.dgvListaCadastroCla.Location = new System.Drawing.Point(12, 84);
            this.dgvListaCadastroCla.Name = "dgvListaCadastroCla";
            this.dgvListaCadastroCla.ReadOnly = true;
            this.dgvListaCadastroCla.Size = new System.Drawing.Size(1244, 601);
            this.dgvListaCadastroCla.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(326, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txtBusca);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1244, 65);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
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
            this.button4.Location = new System.Drawing.Point(701, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 35);
            this.button4.TabIndex = 23;
            this.button4.Text = "Atualizar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(68, 15);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(230, 20);
            this.txtBusca.TabIndex = 19;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            this.txtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(576, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 35);
            this.button3.TabIndex = 22;
            this.button3.Text = "Voltar a pagina anterior";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(451, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.ClientSize = new System.Drawing.Size(1262, 513);
            this.Controls.Add(this.dgvListaCadastroCla);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListaCadastroCla";
            this.Text = "ListaCadastroCla";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCadastroCla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaCadastroCla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeEquipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstadoOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCidadeOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeLider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCpfLider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefoneLider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFraseCla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJaParticipou;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGeneroJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidadeJogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrasaTaca;
    }
}