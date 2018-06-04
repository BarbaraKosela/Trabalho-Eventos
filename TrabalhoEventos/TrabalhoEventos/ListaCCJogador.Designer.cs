namespace SistemaJogadores
{
    partial class ListaCCJogador
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
            this.ColumnNumeroCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ColumnDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListaJogadores = new System.Windows.Forms.DataGridView();
            this.ColumnNomeJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefoneEmegercia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFalarComEmergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJogadores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColumnNumeroCasa
            // 
            this.ColumnNumeroCasa.HeaderText = "N° da casa";
            this.ColumnNumeroCasa.Name = "ColumnNumeroCasa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
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
            this.button4.Location = new System.Drawing.Point(705, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 35);
            this.button4.TabIndex = 23;
            this.button4.Text = "Atualizar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(72, 15);
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
            this.button3.Location = new System.Drawing.Point(580, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 35);
            this.button3.TabIndex = 22;
            this.button3.Text = "Voltar a pagina anterior";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(330, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColumnDataNascimento
            // 
            this.ColumnDataNascimento.HeaderText = "Data de nascimento";
            this.ColumnDataNascimento.Name = "ColumnDataNascimento";
            // 
            // dgvListaJogadores
            // 
            this.dgvListaJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomeJogador,
            this.ColumnDataNascimento,
            this.ColumnCpf,
            this.ColumnRg,
            this.ColumnTelefone,
            this.ColumnTelefoneEmegercia,
            this.ColumnFalarComEmergencia,
            this.ColumnEmai,
            this.ColumnNomeEquipe,
            this.ColumnEstado,
            this.ColumnCidade,
            this.ColumnEndereço,
            this.ColumnNumeroCasa});
            this.dgvListaJogadores.Location = new System.Drawing.Point(12, 77);
            this.dgvListaJogadores.Name = "dgvListaJogadores";
            this.dgvListaJogadores.Size = new System.Drawing.Size(1476, 601);
            this.dgvListaJogadores.TabIndex = 29;
            this.dgvListaJogadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaJogadores_CellContentClick);
            // 
            // ColumnNomeJogador
            // 
            this.ColumnNomeJogador.HeaderText = "Nome do jogador";
            this.ColumnNomeJogador.Name = "ColumnNomeJogador";
            // 
            // ColumnCpf
            // 
            this.ColumnCpf.HeaderText = "Cpf";
            this.ColumnCpf.Name = "ColumnCpf";
            // 
            // ColumnRg
            // 
            this.ColumnRg.HeaderText = "Rg";
            this.ColumnRg.Name = "ColumnRg";
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            // 
            // ColumnTelefoneEmegercia
            // 
            this.ColumnTelefoneEmegercia.HeaderText = "Telefone de emegencia";
            this.ColumnTelefoneEmegercia.Name = "ColumnTelefoneEmegercia";
            // 
            // ColumnFalarComEmergencia
            // 
            this.ColumnFalarComEmergencia.HeaderText = "Nome telefone emergencia";
            this.ColumnFalarComEmergencia.Name = "ColumnFalarComEmergencia";
            // 
            // ColumnEmai
            // 
            this.ColumnEmai.HeaderText = "E-mail";
            this.ColumnEmai.Name = "ColumnEmai";
            // 
            // ColumnNomeEquipe
            // 
            this.ColumnNomeEquipe.HeaderText = "Nome da equipe";
            this.ColumnNomeEquipe.Name = "ColumnNomeEquipe";
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            // 
            // ColumnCidade
            // 
            this.ColumnCidade.HeaderText = "Cidade";
            this.ColumnCidade.Name = "ColumnCidade";
            // 
            // ColumnEndereço
            // 
            this.ColumnEndereço.HeaderText = "Endereço";
            this.ColumnEndereço.Name = "ColumnEndereço";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(455, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 65);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // ListaCCJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 576);
            this.Controls.Add(this.dgvListaJogadores);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListaCCJogador";
            this.Text = "Lista dos jogadores";
            this.Load += new System.EventHandler(this.ListaCCJogador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaJogadores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumeroCasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNascimento;
        private System.Windows.Forms.DataGridView dgvListaJogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefoneEmegercia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFalarComEmergencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeEquipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndereço;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}