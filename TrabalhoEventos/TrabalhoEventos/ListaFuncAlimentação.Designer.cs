namespace SistemaJogadores
{
    partial class ListaFuncAlimentação
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaFuncAlimentação));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crestaurante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cposicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cendereço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(778, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista de Funcionários Alimentação:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkRed;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(732, 34);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 36);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Retornar";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.DarkRed;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(614, 34);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(113, 36);
            this.btnAtualizar.TabIndex = 25;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.DarkRed;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(495, 34);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 36);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(376, 34);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 36);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cnome,
            this.Crestaurante,
            this.Cposicao,
            this.Cidade,
            this.Cendereço,
            this.Ccelular,
            this.Ccidade,
            this.Ccpf,
            this.Ctelefone,
            this.Csalario,
            this.Crg});
            this.dataGridView1.Location = new System.Drawing.Point(14, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(831, 379);
            this.dataGridView1.TabIndex = 27;
            // 
            // Cnome
            // 
            this.Cnome.HeaderText = "Nome";
            this.Cnome.Name = "Cnome";
            this.Cnome.ReadOnly = true;
            // 
            // Crestaurante
            // 
            this.Crestaurante.HeaderText = "Restaurante";
            this.Crestaurante.Name = "Crestaurante";
            this.Crestaurante.ReadOnly = true;
            // 
            // Cposicao
            // 
            this.Cposicao.HeaderText = "Posição do Funcionário";
            this.Cposicao.Name = "Cposicao";
            this.Cposicao.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Idade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Cendereço
            // 
            this.Cendereço.HeaderText = "Endereço";
            this.Cendereço.Name = "Cendereço";
            this.Cendereço.ReadOnly = true;
            // 
            // Ccelular
            // 
            this.Ccelular.HeaderText = "Celular";
            this.Ccelular.Name = "Ccelular";
            this.Ccelular.ReadOnly = true;
            // 
            // Ccidade
            // 
            this.Ccidade.HeaderText = "Cidade";
            this.Ccidade.Name = "Ccidade";
            this.Ccidade.ReadOnly = true;
            // 
            // Ccpf
            // 
            this.Ccpf.HeaderText = "CPF";
            this.Ccpf.Name = "Ccpf";
            this.Ccpf.ReadOnly = true;
            // 
            // Ctelefone
            // 
            this.Ctelefone.HeaderText = "Telefone";
            this.Ctelefone.Name = "Ctelefone";
            this.Ctelefone.ReadOnly = true;
            // 
            // Csalario
            // 
            this.Csalario.HeaderText = "Salário";
            this.Csalario.Name = "Csalario";
            this.Csalario.ReadOnly = true;
            // 
            // Crg
            // 
            this.Crg.HeaderText = "RG";
            this.Crg.Name = "Crg";
            this.Crg.ReadOnly = true;
            // 
            // ListaFuncAlimentação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListaFuncAlimentação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaFuncAlimentação";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crestaurante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cendereço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Csalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Crg;
    }
}