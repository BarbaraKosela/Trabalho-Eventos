namespace SistemaJogadores
{
    partial class ListarConvidado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarConvidado));
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarConvidado = new System.Windows.Forms.Button();
            this.btnApagarConvidado = new System.Windows.Forms.Button();
            this.btnEditarConvidado = new System.Windows.Forms.Button();
            this.btnAtualizarConvidado = new System.Windows.Forms.Button();
            this.txtBuscaConvidado = new System.Windows.Forms.TextBox();
            this.dgvListarConvidados = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumeroCracha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarConvidados)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkRed;
            this.label14.Font = new System.Drawing.Font("Square721 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(360, 29);
            this.label14.TabIndex = 32;
            this.label14.Text = "LISTAGEM DE CONVIDADO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "BUSCA:";
            // 
            // btnCadastrarConvidado
            // 
            this.btnCadastrarConvidado.BackColor = System.Drawing.Color.DarkRed;
            this.btnCadastrarConvidado.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarConvidado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarConvidado.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarConvidado.Image")));
            this.btnCadastrarConvidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarConvidado.Location = new System.Drawing.Point(490, 71);
            this.btnCadastrarConvidado.Name = "btnCadastrarConvidado";
            this.btnCadastrarConvidado.Size = new System.Drawing.Size(160, 56);
            this.btnCadastrarConvidado.TabIndex = 35;
            this.btnCadastrarConvidado.Text = "CADASTRAR";
            this.btnCadastrarConvidado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrarConvidado.UseVisualStyleBackColor = false;
            this.btnCadastrarConvidado.Click += new System.EventHandler(this.btnCadastrarConvidado_Click);
            // 
            // btnApagarConvidado
            // 
            this.btnApagarConvidado.BackColor = System.Drawing.Color.DarkRed;
            this.btnApagarConvidado.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarConvidado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApagarConvidado.Image = ((System.Drawing.Image)(resources.GetObject("btnApagarConvidado.Image")));
            this.btnApagarConvidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagarConvidado.Location = new System.Drawing.Point(490, 9);
            this.btnApagarConvidado.Name = "btnApagarConvidado";
            this.btnApagarConvidado.Size = new System.Drawing.Size(160, 56);
            this.btnApagarConvidado.TabIndex = 34;
            this.btnApagarConvidado.Text = "APAGAR";
            this.btnApagarConvidado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnApagarConvidado.UseVisualStyleBackColor = false;
            this.btnApagarConvidado.Click += new System.EventHandler(this.btnApagarConvidado_Click);
            // 
            // btnEditarConvidado
            // 
            this.btnEditarConvidado.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditarConvidado.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarConvidado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarConvidado.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarConvidado.Image")));
            this.btnEditarConvidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarConvidado.Location = new System.Drawing.Point(683, 71);
            this.btnEditarConvidado.Name = "btnEditarConvidado";
            this.btnEditarConvidado.Size = new System.Drawing.Size(160, 56);
            this.btnEditarConvidado.TabIndex = 37;
            this.btnEditarConvidado.Text = "EDITAR";
            this.btnEditarConvidado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditarConvidado.UseVisualStyleBackColor = false;
            this.btnEditarConvidado.Click += new System.EventHandler(this.btnEditarConvidado_Click);
            // 
            // btnAtualizarConvidado
            // 
            this.btnAtualizarConvidado.BackColor = System.Drawing.Color.DarkRed;
            this.btnAtualizarConvidado.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarConvidado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizarConvidado.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarConvidado.Image")));
            this.btnAtualizarConvidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarConvidado.Location = new System.Drawing.Point(683, 9);
            this.btnAtualizarConvidado.Name = "btnAtualizarConvidado";
            this.btnAtualizarConvidado.Size = new System.Drawing.Size(160, 56);
            this.btnAtualizarConvidado.TabIndex = 36;
            this.btnAtualizarConvidado.Text = "ATUALIZAR";
            this.btnAtualizarConvidado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAtualizarConvidado.UseVisualStyleBackColor = false;
            this.btnAtualizarConvidado.Click += new System.EventHandler(this.btnAtualizarConvidado_Click);
            // 
            // txtBuscaConvidado
            // 
            this.txtBuscaConvidado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBuscaConvidado.Location = new System.Drawing.Point(12, 78);
            this.txtBuscaConvidado.Name = "txtBuscaConvidado";
            this.txtBuscaConvidado.Size = new System.Drawing.Size(360, 20);
            this.txtBuscaConvidado.TabIndex = 38;
            this.txtBuscaConvidado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscaConvidado_KeyDown);
            this.txtBuscaConvidado.Leave += new System.EventHandler(this.txtBuscaConvidado_Leave);
            // 
            // dgvListarConvidados
            // 
            this.dgvListarConvidados.AllowUserToAddRows = false;
            this.dgvListarConvidados.AllowUserToDeleteRows = false;
            this.dgvListarConvidados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarConvidados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnIdade,
            this.ColumnEquipe,
            this.ColumnNumeroCracha});
            this.dgvListarConvidados.Location = new System.Drawing.Point(12, 152);
            this.dgvListarConvidados.Name = "dgvListarConvidados";
            this.dgvListarConvidados.ReadOnly = true;
            this.dgvListarConvidados.Size = new System.Drawing.Size(863, 347);
            this.dgvListarConvidados.TabIndex = 39;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNome.HeaderText = "Nome do campeão";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnIdade
            // 
            this.ColumnIdade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIdade.HeaderText = "Idade";
            this.ColumnIdade.Name = "ColumnIdade";
            this.ColumnIdade.ReadOnly = true;
            // 
            // ColumnEquipe
            // 
            this.ColumnEquipe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEquipe.HeaderText = "Equipe que o patrocina";
            this.ColumnEquipe.Name = "ColumnEquipe";
            this.ColumnEquipe.ReadOnly = true;
            // 
            // ColumnNumeroCracha
            // 
            this.ColumnNumeroCracha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNumeroCracha.HeaderText = "Número do crachá";
            this.ColumnNumeroCracha.Name = "ColumnNumeroCracha";
            this.ColumnNumeroCracha.ReadOnly = true;
            // 
            // ListarConvidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(909, 511);
            this.Controls.Add(this.dgvListarConvidados);
            this.Controls.Add(this.txtBuscaConvidado);
            this.Controls.Add(this.btnEditarConvidado);
            this.Controls.Add(this.btnAtualizarConvidado);
            this.Controls.Add(this.btnCadastrarConvidado);
            this.Controls.Add(this.btnApagarConvidado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Name = "ListarConvidado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarConvidado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarConvidados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarConvidado;
        private System.Windows.Forms.Button btnApagarConvidado;
        private System.Windows.Forms.Button btnEditarConvidado;
        private System.Windows.Forms.Button btnAtualizarConvidado;
        private System.Windows.Forms.TextBox txtBuscaConvidado;
        private System.Windows.Forms.DataGridView dgvListarConvidados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEquipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumeroCracha;
    }
}