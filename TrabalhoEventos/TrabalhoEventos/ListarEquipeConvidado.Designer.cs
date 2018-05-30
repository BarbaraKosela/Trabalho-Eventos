namespace SistemaJogadores
{
    partial class ListarEquipeConvidado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarEquipeConvidado));
            this.dgvListarEquipe = new System.Windows.Forms.DataGridView();
            this.txtBuscaEquipe = new System.Windows.Forms.TextBox();
            this.btnEditarEquipe = new System.Windows.Forms.Button();
            this.btnAtualizarEquipe = new System.Windows.Forms.Button();
            this.btnCadastrarEquipe = new System.Windows.Forms.Button();
            this.btnApagarEquipe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ColumnSeuNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeCampeao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomeLider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEquipe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarEquipe
            // 
            this.dgvListarEquipe.AllowUserToAddRows = false;
            this.dgvListarEquipe.AllowUserToDeleteRows = false;
            this.dgvListarEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarEquipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSeuNome,
            this.ColumnIdade,
            this.ColumnNomeCampeao,
            this.ColumnNomeLider});
            this.dgvListarEquipe.Location = new System.Drawing.Point(23, 153);
            this.dgvListarEquipe.Name = "dgvListarEquipe";
            this.dgvListarEquipe.ReadOnly = true;
            this.dgvListarEquipe.Size = new System.Drawing.Size(863, 347);
            this.dgvListarEquipe.TabIndex = 47;
            // 
            // txtBuscaEquipe
            // 
            this.txtBuscaEquipe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBuscaEquipe.Location = new System.Drawing.Point(23, 79);
            this.txtBuscaEquipe.Name = "txtBuscaEquipe";
            this.txtBuscaEquipe.Size = new System.Drawing.Size(360, 20);
            this.txtBuscaEquipe.TabIndex = 46;
            this.txtBuscaEquipe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscaEquipe_KeyDown);
            this.txtBuscaEquipe.Leave += new System.EventHandler(this.txtBuscaEquipe_Leave);
            // 
            // btnEditarEquipe
            // 
            this.btnEditarEquipe.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditarEquipe.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEquipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarEquipe.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarEquipe.Image")));
            this.btnEditarEquipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarEquipe.Location = new System.Drawing.Point(694, 72);
            this.btnEditarEquipe.Name = "btnEditarEquipe";
            this.btnEditarEquipe.Size = new System.Drawing.Size(160, 56);
            this.btnEditarEquipe.TabIndex = 45;
            this.btnEditarEquipe.Text = "EDITAR";
            this.btnEditarEquipe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditarEquipe.UseVisualStyleBackColor = false;
            this.btnEditarEquipe.Click += new System.EventHandler(this.btnEditarEquipe_Click);
            // 
            // btnAtualizarEquipe
            // 
            this.btnAtualizarEquipe.BackColor = System.Drawing.Color.DarkRed;
            this.btnAtualizarEquipe.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarEquipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizarEquipe.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarEquipe.Image")));
            this.btnAtualizarEquipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarEquipe.Location = new System.Drawing.Point(694, 10);
            this.btnAtualizarEquipe.Name = "btnAtualizarEquipe";
            this.btnAtualizarEquipe.Size = new System.Drawing.Size(160, 56);
            this.btnAtualizarEquipe.TabIndex = 44;
            this.btnAtualizarEquipe.Text = "ATUALIZAR";
            this.btnAtualizarEquipe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAtualizarEquipe.UseVisualStyleBackColor = false;
            this.btnAtualizarEquipe.Click += new System.EventHandler(this.btnAtualizarEquipe_Click);
            // 
            // btnCadastrarEquipe
            // 
            this.btnCadastrarEquipe.BackColor = System.Drawing.Color.DarkRed;
            this.btnCadastrarEquipe.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEquipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarEquipe.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarEquipe.Image")));
            this.btnCadastrarEquipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarEquipe.Location = new System.Drawing.Point(501, 72);
            this.btnCadastrarEquipe.Name = "btnCadastrarEquipe";
            this.btnCadastrarEquipe.Size = new System.Drawing.Size(160, 56);
            this.btnCadastrarEquipe.TabIndex = 43;
            this.btnCadastrarEquipe.Text = "CADASTRAR";
            this.btnCadastrarEquipe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrarEquipe.UseVisualStyleBackColor = false;
            this.btnCadastrarEquipe.Click += new System.EventHandler(this.btnCadastrarEquipe_Click);
            // 
            // btnApagarEquipe
            // 
            this.btnApagarEquipe.BackColor = System.Drawing.Color.DarkRed;
            this.btnApagarEquipe.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarEquipe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApagarEquipe.Image = ((System.Drawing.Image)(resources.GetObject("btnApagarEquipe.Image")));
            this.btnApagarEquipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagarEquipe.Location = new System.Drawing.Point(501, 10);
            this.btnApagarEquipe.Name = "btnApagarEquipe";
            this.btnApagarEquipe.Size = new System.Drawing.Size(160, 56);
            this.btnApagarEquipe.TabIndex = 42;
            this.btnApagarEquipe.Text = "APAGAR";
            this.btnApagarEquipe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnApagarEquipe.UseVisualStyleBackColor = false;
            this.btnApagarEquipe.Click += new System.EventHandler(this.btnApagarEquipe_Click);
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
            this.label14.Size = new System.Drawing.Size(299, 29);
            this.label14.TabIndex = 40;
            this.label14.Text = "LISTAGEM DE EQUIPE:";
            // 
            // ColumnSeuNome
            // 
            this.ColumnSeuNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSeuNome.HeaderText = "Seu nome";
            this.ColumnSeuNome.Name = "ColumnSeuNome";
            this.ColumnSeuNome.ReadOnly = true;
            // 
            // ColumnIdade
            // 
            this.ColumnIdade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIdade.HeaderText = "Sua Idade";
            this.ColumnIdade.Name = "ColumnIdade";
            this.ColumnIdade.ReadOnly = true;
            // 
            // ColumnNomeCampeao
            // 
            this.ColumnNomeCampeao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomeCampeao.HeaderText = "Nome do campeão que patrocina";
            this.ColumnNomeCampeao.Name = "ColumnNomeCampeao";
            this.ColumnNomeCampeao.ReadOnly = true;
            // 
            // ColumnNomeLider
            // 
            this.ColumnNomeLider.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNomeLider.HeaderText = "Nome do seu líder";
            this.ColumnNomeLider.Name = "ColumnNomeLider";
            this.ColumnNomeLider.ReadOnly = true;
            // 
            // ListarEquipeConvidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 511);
            this.Controls.Add(this.dgvListarEquipe);
            this.Controls.Add(this.txtBuscaEquipe);
            this.Controls.Add(this.btnEditarEquipe);
            this.Controls.Add(this.btnAtualizarEquipe);
            this.Controls.Add(this.btnCadastrarEquipe);
            this.Controls.Add(this.btnApagarEquipe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Name = "ListarEquipeConvidado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Equipe do Convidado";
            this.Activated += new System.EventHandler(this.ListarEquipeConvidado_Activated);
            this.Load += new System.EventHandler(this.ListarEquipeConvidado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEquipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarEquipe;
        private System.Windows.Forms.TextBox txtBuscaEquipe;
        private System.Windows.Forms.Button btnEditarEquipe;
        private System.Windows.Forms.Button btnAtualizarEquipe;
        private System.Windows.Forms.Button btnCadastrarEquipe;
        private System.Windows.Forms.Button btnApagarEquipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeuNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeCampeao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomeLider;
    }
}