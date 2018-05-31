namespace SistemaJogadores
{
    partial class ListaCadastroCampeonato
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
            this.ColumnTaxaEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumQuantidadeMaxEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNivelCampeonato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPremio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPremio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHorarioCampeonato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiaCampeonato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGeneroJogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoEquipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalaJogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeJogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeCampeonato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListaCampeonato = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaCampeonato = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCampeonato)).BeginInit();
            this.SuspendLayout();
            // 
            // ColumnTaxaEquipe
            // 
            this.ColumnTaxaEquipe.HeaderText = "Taxa por equipe";
            this.ColumnTaxaEquipe.Name = "ColumnTaxaEquipe";
            this.ColumnTaxaEquipe.ReadOnly = true;
            // 
            // ColumQuantidadeMaxEquipe
            // 
            this.ColumQuantidadeMaxEquipe.HeaderText = "Quantidade max de equipes";
            this.ColumQuantidadeMaxEquipe.Name = "ColumQuantidadeMaxEquipe";
            this.ColumQuantidadeMaxEquipe.ReadOnly = true;
            // 
            // ColumnNivelCampeonato
            // 
            this.ColumnNivelCampeonato.HeaderText = "Nivel do campeonato";
            this.ColumnNivelCampeonato.Name = "ColumnNivelCampeonato";
            this.ColumnNivelCampeonato.ReadOnly = true;
            // 
            // ColumnPremio3
            // 
            this.ColumnPremio3.HeaderText = "3° premio";
            this.ColumnPremio3.Name = "ColumnPremio3";
            this.ColumnPremio3.ReadOnly = true;
            // 
            // ColumnPremio2
            // 
            this.ColumnPremio2.HeaderText = "2° premio";
            this.ColumnPremio2.Name = "ColumnPremio2";
            this.ColumnPremio2.ReadOnly = true;
            // 
            // ColumnValor1
            // 
            this.ColumnValor1.HeaderText = "1° premio";
            this.ColumnValor1.Name = "ColumnValor1";
            this.ColumnValor1.ReadOnly = true;
            // 
            // ColumnHorarioCampeonato
            // 
            this.ColumnHorarioCampeonato.HeaderText = "Horario do campeonato";
            this.ColumnHorarioCampeonato.Name = "ColumnHorarioCampeonato";
            this.ColumnHorarioCampeonato.ReadOnly = true;
            // 
            // ColumnDiaCampeonato
            // 
            this.ColumnDiaCampeonato.HeaderText = "Dia do campeonato";
            this.ColumnDiaCampeonato.Name = "ColumnDiaCampeonato";
            this.ColumnDiaCampeonato.ReadOnly = true;
            // 
            // ColumnGeneroJogo
            // 
            this.ColumnGeneroJogo.HeaderText = "Genero do jogo";
            this.ColumnGeneroJogo.Name = "ColumnGeneroJogo";
            this.ColumnGeneroJogo.ReadOnly = true;
            // 
            // ColumnTipoEquipamento
            // 
            this.ColumnTipoEquipamento.HeaderText = "Tipo de equipamento";
            this.ColumnTipoEquipamento.Name = "ColumnTipoEquipamento";
            this.ColumnTipoEquipamento.ReadOnly = true;
            // 
            // ColumnSalaJogo
            // 
            this.ColumnSalaJogo.HeaderText = "Sala do jogo";
            this.ColumnSalaJogo.Name = "ColumnSalaJogo";
            this.ColumnSalaJogo.ReadOnly = true;
            // 
            // ColumnNomeJogo
            // 
            this.ColumnNomeJogo.HeaderText = "Nome do jogo";
            this.ColumnNomeJogo.Name = "ColumnNomeJogo";
            this.ColumnNomeJogo.ReadOnly = true;
            // 
            // ColumnNomeCampeonato
            // 
            this.ColumnNomeCampeonato.HeaderText = "Nome do campeonato";
            this.ColumnNomeCampeonato.Name = "ColumnNomeCampeonato";
            this.ColumnNomeCampeonato.ReadOnly = true;
            // 
            // dgvListaCampeonato
            // 
            this.dgvListaCampeonato.AllowUserToAddRows = false;
            this.dgvListaCampeonato.AllowUserToDeleteRows = false;
            this.dgvListaCampeonato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCampeonato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomeCampeonato,
            this.ColumnNomeJogo,
            this.ColumnSalaJogo,
            this.ColumnTipoEquipamento,
            this.ColumnGeneroJogo,
            this.ColumnDiaCampeonato,
            this.ColumnHorarioCampeonato,
            this.ColumnValor1,
            this.ColumnPremio2,
            this.ColumnPremio3,
            this.ColumnNivelCampeonato,
            this.ColumQuantidadeMaxEquipe,
            this.ColumnTaxaEquipe});
            this.dgvListaCampeonato.Location = new System.Drawing.Point(30, 49);
            this.dgvListaCampeonato.Name = "dgvListaCampeonato";
            this.dgvListaCampeonato.ReadOnly = true;
            this.dgvListaCampeonato.Size = new System.Drawing.Size(1356, 399);
            this.dgvListaCampeonato.TabIndex = 0;
            this.dgvListaCampeonato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCampeonato_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Buscar";
            // 
            // txtBuscaCampeonato
            // 
            this.txtBuscaCampeonato.Location = new System.Drawing.Point(87, 12);
            this.txtBuscaCampeonato.Name = "txtBuscaCampeonato";
            this.txtBuscaCampeonato.Size = new System.Drawing.Size(230, 20);
            this.txtBuscaCampeonato.TabIndex = 19;
            this.txtBuscaCampeonato.TextChanged += new System.EventHandler(this.txtBuscaCampeonato_TextChanged);
            this.txtBuscaCampeonato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscaCampeonato_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(369, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(491, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(603, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 35);
            this.button3.TabIndex = 22;
            this.button3.Text = "Voltar a pagina anterior";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(706, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 35);
            this.button4.TabIndex = 23;
            this.button4.Text = "Atualizar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ListaCadastroCampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 511);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscaCampeonato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaCampeonato);
            this.Name = "ListaCadastroCampeonato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaCadastroCampeonato";
            this.Load += new System.EventHandler(this.ListaCadastroCampeonato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCampeonato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaxaEquipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumQuantidadeMaxEquipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNivelCampeonato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPremio3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPremio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHorarioCampeonato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiaCampeonato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGeneroJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoEquipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalaJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeJogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeCampeonato;
        private System.Windows.Forms.DataGridView dgvListaCampeonato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaCampeonato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

    }
}