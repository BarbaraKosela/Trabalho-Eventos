namespace TrabalhoEventos
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
            this.btnSalvarConvidado = new System.Windows.Forms.Button();
            this.btnCancelarConvidado = new System.Windows.Forms.Button();
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
            // btnSalvarConvidado
            // 
            this.btnSalvarConvidado.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalvarConvidado.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarConvidado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvarConvidado.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarConvidado.Image")));
            this.btnSalvarConvidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarConvidado.Location = new System.Drawing.Point(472, 227);
            this.btnSalvarConvidado.Name = "btnSalvarConvidado";
            this.btnSalvarConvidado.Size = new System.Drawing.Size(137, 56);
            this.btnSalvarConvidado.TabIndex = 35;
            this.btnSalvarConvidado.Text = "SALVAR";
            this.btnSalvarConvidado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvarConvidado.UseVisualStyleBackColor = false;
            // 
            // btnCancelarConvidado
            // 
            this.btnCancelarConvidado.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelarConvidado.Font = new System.Drawing.Font("Square721 BT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarConvidado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarConvidado.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarConvidado.Image")));
            this.btnCancelarConvidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarConvidado.Location = new System.Drawing.Point(300, 227);
            this.btnCancelarConvidado.Name = "btnCancelarConvidado";
            this.btnCancelarConvidado.Size = new System.Drawing.Size(145, 56);
            this.btnCancelarConvidado.TabIndex = 34;
            this.btnCancelarConvidado.Text = "CANCELAR";
            this.btnCancelarConvidado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelarConvidado.UseVisualStyleBackColor = false;
            // 
            // ListarConvidado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 511);
            this.Controls.Add(this.btnSalvarConvidado);
            this.Controls.Add(this.btnCancelarConvidado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Name = "ListarConvidado";
            this.Text = "ListarConvidado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarConvidado;
        private System.Windows.Forms.Button btnCancelarConvidado;
    }
}