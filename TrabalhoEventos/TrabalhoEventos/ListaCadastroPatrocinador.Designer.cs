namespace SistemaJogadores
{
    partial class ListaCadastroPatrocinador
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
            this.dgvListaPatrocinador = new System.Windows.Forms.DataGridView();
            this.ColumnNomePatrocinador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEquipeSendoPatrocinada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoPatrocinio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPatrocinador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaPatrocinador
            // 
            this.dgvListaPatrocinador.AllowUserToAddRows = false;
            this.dgvListaPatrocinador.AllowUserToDeleteRows = false;
            this.dgvListaPatrocinador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPatrocinador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNomePatrocinador,
            this.ColumnTelefone,
            this.ColumnCpf,
            this.ColumnEquipeSendoPatrocinada,
            this.ColumnTipoPatrocinio,
            this.ColumnEstado,
            this.ColumnCidade});
            this.dgvListaPatrocinador.Location = new System.Drawing.Point(45, 96);
            this.dgvListaPatrocinador.Name = "dgvListaPatrocinador";
            this.dgvListaPatrocinador.ReadOnly = true;
            this.dgvListaPatrocinador.Size = new System.Drawing.Size(836, 331);
            this.dgvListaPatrocinador.TabIndex = 31;
            // 
            // ColumnNomePatrocinador
            // 
            this.ColumnNomePatrocinador.HeaderText = "Nome do patrocinador";
            this.ColumnNomePatrocinador.Name = "ColumnNomePatrocinador";
            this.ColumnNomePatrocinador.ReadOnly = true;
            // 
            // ColumnTelefone
            // 
            this.ColumnTelefone.HeaderText = "Telefone";
            this.ColumnTelefone.Name = "ColumnTelefone";
            this.ColumnTelefone.ReadOnly = true;
            // 
            // ColumnCpf
            // 
            this.ColumnCpf.HeaderText = "Cpf";
            this.ColumnCpf.Name = "ColumnCpf";
            this.ColumnCpf.ReadOnly = true;
            // 
            // ColumnEquipeSendoPatrocinada
            // 
            this.ColumnEquipeSendoPatrocinada.HeaderText = "Clã sendo patrocinado";
            this.ColumnEquipeSendoPatrocinada.Name = "ColumnEquipeSendoPatrocinada";
            this.ColumnEquipeSendoPatrocinada.ReadOnly = true;
            // 
            // ColumnTipoPatrocinio
            // 
            this.ColumnTipoPatrocinio.HeaderText = "Tipo de patrocinio";
            this.ColumnTipoPatrocinio.Name = "ColumnTipoPatrocinio";
            this.ColumnTipoPatrocinio.ReadOnly = true;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            // 
            // ColumnCidade
            // 
            this.ColumnCidade.HeaderText = "Cidade";
            this.ColumnCidade.Name = "ColumnCidade";
            this.ColumnCidade.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(402, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 34;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkRed;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(739, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 35);
            this.button4.TabIndex = 37;
            this.button4.Text = "Atualizar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Buscar";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(636, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 35);
            this.button3.TabIndex = 36;
            this.button3.Text = "Voltar a pagina anterior";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(120, 28);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(230, 20);
            this.txtBusca.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(524, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 35);
            this.button2.TabIndex = 35;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ListaCadastroPatrocinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvListaPatrocinador);
            this.Name = "ListaCadastroPatrocinador";
            this.Text = "ListaCadastroPatrocinador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListaCadastroPatrocinador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPatrocinador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaPatrocinador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomePatrocinador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEquipeSendoPatrocinada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoPatrocinio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button button2;
    }
}