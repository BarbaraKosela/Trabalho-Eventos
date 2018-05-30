namespace SistemaJogadores
{
    partial class ListarAtendimentoJogador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarAtendimentoJogador));
            this.dgvListarAtendimento = new System.Windows.Forms.DataGridView();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumeroPorVez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaEquipamentos = new System.Windows.Forms.TextBox();
            this.btnEditarAtendimento = new System.Windows.Forms.Button();
            this.btnAtualizarAtendimento = new System.Windows.Forms.Button();
            this.btnCadastrarAtentendimento = new System.Windows.Forms.Button();
            this.btnApagarAtendimento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarAtendimento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarAtendimento
            // 
            this.dgvListarAtendimento.AllowUserToAddRows = false;
            this.dgvListarAtendimento.AllowUserToDeleteRows = false;
            this.dgvListarAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarAtendimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEmail,
            this.ColumnResponsavel,
            this.ColumnNumeroPorVez,
            this.ColumnEquipe});
            this.dgvListarAtendimento.Location = new System.Drawing.Point(23, 153);
            this.dgvListarAtendimento.Name = "dgvListarAtendimento";
            this.dgvListarAtendimento.ReadOnly = true;
            this.dgvListarAtendimento.Size = new System.Drawing.Size(863, 347);
            this.dgvListarAtendimento.TabIndex = 55;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEmail.HeaderText = "E-mail";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // ColumnResponsavel
            // 
            this.ColumnResponsavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnResponsavel.HeaderText = "Responsabilidade";
            this.ColumnResponsavel.Name = "ColumnResponsavel";
            this.ColumnResponsavel.ReadOnly = true;
            // 
            // ColumnNumeroPorVez
            // 
            this.ColumnNumeroPorVez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNumeroPorVez.HeaderText = "Número de jogadores que poderá atender por vez";
            this.ColumnNumeroPorVez.Name = "ColumnNumeroPorVez";
            this.ColumnNumeroPorVez.ReadOnly = true;
            // 
            // ColumnEquipe
            // 
            this.ColumnEquipe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEquipe.HeaderText = "Equipe colaboradora";
            this.ColumnEquipe.Name = "ColumnEquipe";
            this.ColumnEquipe.ReadOnly = true;
            // 
            // txtBuscaEquipamentos
            // 
            this.txtBuscaEquipamentos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBuscaEquipamentos.Location = new System.Drawing.Point(23, 79);
            this.txtBuscaEquipamentos.Name = "txtBuscaEquipamentos";
            this.txtBuscaEquipamentos.Size = new System.Drawing.Size(360, 20);
            this.txtBuscaEquipamentos.TabIndex = 54;
            this.txtBuscaEquipamentos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscaEquipamentos_KeyDown);
            this.txtBuscaEquipamentos.Leave += new System.EventHandler(this.txtBuscaEquipamentos_Leave);
            // 
            // btnEditarAtendimento
            // 
            this.btnEditarAtendimento.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditarAtendimento.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAtendimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAtendimento.Image")));
            this.btnEditarAtendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAtendimento.Location = new System.Drawing.Point(694, 72);
            this.btnEditarAtendimento.Name = "btnEditarAtendimento";
            this.btnEditarAtendimento.Size = new System.Drawing.Size(160, 56);
            this.btnEditarAtendimento.TabIndex = 53;
            this.btnEditarAtendimento.Text = "EDITAR";
            this.btnEditarAtendimento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditarAtendimento.UseVisualStyleBackColor = false;
            this.btnEditarAtendimento.Click += new System.EventHandler(this.btnEditarAtendimento_Click);
            // 
            // btnAtualizarAtendimento
            // 
            this.btnAtualizarAtendimento.BackColor = System.Drawing.Color.DarkRed;
            this.btnAtualizarAtendimento.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarAtendimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizarAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarAtendimento.Image")));
            this.btnAtualizarAtendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarAtendimento.Location = new System.Drawing.Point(694, 10);
            this.btnAtualizarAtendimento.Name = "btnAtualizarAtendimento";
            this.btnAtualizarAtendimento.Size = new System.Drawing.Size(160, 56);
            this.btnAtualizarAtendimento.TabIndex = 52;
            this.btnAtualizarAtendimento.Text = "ATUALIZAR";
            this.btnAtualizarAtendimento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAtualizarAtendimento.UseVisualStyleBackColor = false;
            this.btnAtualizarAtendimento.Click += new System.EventHandler(this.btnAtualizarAtendimento_Click);
            // 
            // btnCadastrarAtentendimento
            // 
            this.btnCadastrarAtentendimento.BackColor = System.Drawing.Color.DarkRed;
            this.btnCadastrarAtentendimento.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAtentendimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarAtentendimento.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarAtentendimento.Image")));
            this.btnCadastrarAtentendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarAtentendimento.Location = new System.Drawing.Point(501, 72);
            this.btnCadastrarAtentendimento.Name = "btnCadastrarAtentendimento";
            this.btnCadastrarAtentendimento.Size = new System.Drawing.Size(160, 56);
            this.btnCadastrarAtentendimento.TabIndex = 51;
            this.btnCadastrarAtentendimento.Text = "CADASTRAR";
            this.btnCadastrarAtentendimento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrarAtentendimento.UseVisualStyleBackColor = false;
            this.btnCadastrarAtentendimento.Click += new System.EventHandler(this.btnCadastrarAtentendimento_Click);
            // 
            // btnApagarAtendimento
            // 
            this.btnApagarAtendimento.BackColor = System.Drawing.Color.DarkRed;
            this.btnApagarAtendimento.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarAtendimento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApagarAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("btnApagarAtendimento.Image")));
            this.btnApagarAtendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagarAtendimento.Location = new System.Drawing.Point(501, 10);
            this.btnApagarAtendimento.Name = "btnApagarAtendimento";
            this.btnApagarAtendimento.Size = new System.Drawing.Size(160, 56);
            this.btnApagarAtendimento.TabIndex = 50;
            this.btnApagarAtendimento.Text = "APAGAR";
            this.btnApagarAtendimento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnApagarAtendimento.UseVisualStyleBackColor = false;
            this.btnApagarAtendimento.Click += new System.EventHandler(this.btnApagarAtendimento_Click);
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
            this.label1.TabIndex = 49;
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
            this.label14.TabIndex = 48;
            this.label14.Text = "LISTAGEM DE ATENDIMENTO:";
            // 
            // ListarAtendimentoJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 511);
            this.Controls.Add(this.dgvListarAtendimento);
            this.Controls.Add(this.txtBuscaEquipamentos);
            this.Controls.Add(this.btnEditarAtendimento);
            this.Controls.Add(this.btnAtualizarAtendimento);
            this.Controls.Add(this.btnCadastrarAtentendimento);
            this.Controls.Add(this.btnApagarAtendimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Name = "ListarAtendimentoJogador";
            this.Text = "Listar Atendimento ao Jogador";
            this.Activated += new System.EventHandler(this.ListarAtendimentoJogador_Activated);
            this.Load += new System.EventHandler(this.ListarAtendimentoJogador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarAtendimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarAtendimento;
        private System.Windows.Forms.TextBox txtBuscaEquipamentos;
        private System.Windows.Forms.Button btnEditarAtendimento;
        private System.Windows.Forms.Button btnAtualizarAtendimento;
        private System.Windows.Forms.Button btnCadastrarAtentendimento;
        private System.Windows.Forms.Button btnApagarAtendimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumeroPorVez;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEquipe;
    }
}