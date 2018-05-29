namespace SistemaJogadores
{
    partial class ListarEquipamentoConvidado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarEquipamentoConvidado));
            this.dgvListarEquipamento = new System.Windows.Forms.DataGridView();
            this.txtBuscaEquipamentos = new System.Windows.Forms.TextBox();
            this.btnEditarConvidado2 = new System.Windows.Forms.Button();
            this.btnAtualizarConvidado2 = new System.Windows.Forms.Button();
            this.btnCadastrarConvidado2 = new System.Windows.Forms.Button();
            this.btnApagarConvidado2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ColumnEquipamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAcompanhamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumeroCracha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEquipamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarEquipamento
            // 
            this.dgvListarEquipamento.AllowUserToAddRows = false;
            this.dgvListarEquipamento.AllowUserToDeleteRows = false;
            this.dgvListarEquipamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarEquipamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEquipamento,
            this.ColumnEmail,
            this.ColumnAcompanhamento,
            this.ColumnNumeroCracha});
            this.dgvListarEquipamento.Location = new System.Drawing.Point(23, 153);
            this.dgvListarEquipamento.Name = "dgvListarEquipamento";
            this.dgvListarEquipamento.ReadOnly = true;
            this.dgvListarEquipamento.Size = new System.Drawing.Size(863, 347);
            this.dgvListarEquipamento.TabIndex = 47;
            // 
            // txtBuscaEquipamentos
            // 
            this.txtBuscaEquipamentos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBuscaEquipamentos.Location = new System.Drawing.Point(23, 79);
            this.txtBuscaEquipamentos.Name = "txtBuscaEquipamentos";
            this.txtBuscaEquipamentos.Size = new System.Drawing.Size(360, 20);
            this.txtBuscaEquipamentos.TabIndex = 46;
            this.txtBuscaEquipamentos.TextChanged += new System.EventHandler(this.txtBuscaEquipamentos_TextChanged);
            this.txtBuscaEquipamentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscaEquipamentos_KeyDown);
            this.txtBuscaEquipamentos.Leave += new System.EventHandler(this.txtBuscaEquipamentos_Leave);
            // 
            // btnEditarConvidado2
            // 
            this.btnEditarConvidado2.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditarConvidado2.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarConvidado2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarConvidado2.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarConvidado2.Image")));
            this.btnEditarConvidado2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarConvidado2.Location = new System.Drawing.Point(694, 72);
            this.btnEditarConvidado2.Name = "btnEditarConvidado2";
            this.btnEditarConvidado2.Size = new System.Drawing.Size(160, 56);
            this.btnEditarConvidado2.TabIndex = 45;
            this.btnEditarConvidado2.Text = "EDITAR";
            this.btnEditarConvidado2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditarConvidado2.UseVisualStyleBackColor = false;
            this.btnEditarConvidado2.Click += new System.EventHandler(this.btnEditarConvidado2_Click);
            // 
            // btnAtualizarConvidado2
            // 
            this.btnAtualizarConvidado2.BackColor = System.Drawing.Color.DarkRed;
            this.btnAtualizarConvidado2.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarConvidado2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizarConvidado2.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarConvidado2.Image")));
            this.btnAtualizarConvidado2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarConvidado2.Location = new System.Drawing.Point(694, 10);
            this.btnAtualizarConvidado2.Name = "btnAtualizarConvidado2";
            this.btnAtualizarConvidado2.Size = new System.Drawing.Size(160, 56);
            this.btnAtualizarConvidado2.TabIndex = 44;
            this.btnAtualizarConvidado2.Text = "ATUALIZAR";
            this.btnAtualizarConvidado2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAtualizarConvidado2.UseVisualStyleBackColor = false;
            this.btnAtualizarConvidado2.Click += new System.EventHandler(this.btnAtualizarConvidado2_Click);
            // 
            // btnCadastrarConvidado2
            // 
            this.btnCadastrarConvidado2.BackColor = System.Drawing.Color.DarkRed;
            this.btnCadastrarConvidado2.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarConvidado2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarConvidado2.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarConvidado2.Image")));
            this.btnCadastrarConvidado2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarConvidado2.Location = new System.Drawing.Point(501, 72);
            this.btnCadastrarConvidado2.Name = "btnCadastrarConvidado2";
            this.btnCadastrarConvidado2.Size = new System.Drawing.Size(160, 56);
            this.btnCadastrarConvidado2.TabIndex = 43;
            this.btnCadastrarConvidado2.Text = "CADASTRAR";
            this.btnCadastrarConvidado2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrarConvidado2.UseVisualStyleBackColor = false;
            this.btnCadastrarConvidado2.Click += new System.EventHandler(this.btnCadastrarConvidado2_Click);
            // 
            // btnApagarConvidado2
            // 
            this.btnApagarConvidado2.BackColor = System.Drawing.Color.DarkRed;
            this.btnApagarConvidado2.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarConvidado2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApagarConvidado2.Image = ((System.Drawing.Image)(resources.GetObject("btnApagarConvidado2.Image")));
            this.btnApagarConvidado2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagarConvidado2.Location = new System.Drawing.Point(501, 10);
            this.btnApagarConvidado2.Name = "btnApagarConvidado2";
            this.btnApagarConvidado2.Size = new System.Drawing.Size(160, 56);
            this.btnApagarConvidado2.TabIndex = 42;
            this.btnApagarConvidado2.Text = "APAGAR";
            this.btnApagarConvidado2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnApagarConvidado2.UseVisualStyleBackColor = false;
            this.btnApagarConvidado2.Click += new System.EventHandler(this.btnApagarConvidado2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "BUSCA:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkRed;
            this.label14.Font = new System.Drawing.Font("Square721 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(23, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(394, 29);
            this.label14.TabIndex = 40;
            this.label14.Text = "LISTAGEM DE EQUIPAMENTO:";
            // 
            // ColumnEquipamento
            // 
            this.ColumnEquipamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEquipamento.HeaderText = "Equipamento solicitado";
            this.ColumnEquipamento.Name = "ColumnEquipamento";
            this.ColumnEquipamento.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEmail.HeaderText = "E-mail";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // ColumnAcompanhamento
            // 
            this.ColumnAcompanhamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAcompanhamento.HeaderText = "Acompanhamento";
            this.ColumnAcompanhamento.Name = "ColumnAcompanhamento";
            this.ColumnAcompanhamento.ReadOnly = true;
            // 
            // ColumnNumeroCracha
            // 
            this.ColumnNumeroCracha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNumeroCracha.HeaderText = "Número do crachá";
            this.ColumnNumeroCracha.Name = "ColumnNumeroCracha";
            this.ColumnNumeroCracha.ReadOnly = true;
            // 
            // ListarEquipamentoConvidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 511);
            this.Controls.Add(this.dgvListarEquipamento);
            this.Controls.Add(this.txtBuscaEquipamentos);
            this.Controls.Add(this.btnEditarConvidado2);
            this.Controls.Add(this.btnAtualizarConvidado2);
            this.Controls.Add(this.btnCadastrarConvidado2);
            this.Controls.Add(this.btnApagarConvidado2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Name = "ListarEquipamentoConvidado";
            this.Text = "Listar Equipamento Convidado";
            this.Activated += new System.EventHandler(this.ListarEquipamentoConvidado_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEquipamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarEquipamento;
        private System.Windows.Forms.TextBox txtBuscaEquipamentos;
        private System.Windows.Forms.Button btnEditarConvidado2;
        private System.Windows.Forms.Button btnAtualizarConvidado2;
        private System.Windows.Forms.Button btnCadastrarConvidado2;
        private System.Windows.Forms.Button btnApagarConvidado2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEquipamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAcompanhamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumeroCracha;
    }
}