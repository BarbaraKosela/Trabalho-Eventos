namespace SistemaLivraria
{
    partial class CadastroFuncTerceirizado
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.nupIdade = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(292, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 23);
            this.txtEmail.TabIndex = 103;
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(15, 314);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(181, 23);
            this.txtRG.TabIndex = 102;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(15, 250);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(181, 23);
            this.txtSalario.TabIndex = 101;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtxtTelefone.Location = new System.Drawing.Point(292, 188);
            this.mtxtTelefone.Mask = "0000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(181, 23);
            this.mtxtTelefone.TabIndex = 100;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtxtCPF.Location = new System.Drawing.Point(292, 132);
            this.mtxtCPF.Mask = "000000000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(181, 23);
            this.mtxtCPF.TabIndex = 99;
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtxtCelular.Location = new System.Drawing.Point(15, 188);
            this.mtxtCelular.Mask = "(99) 00000-0000";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(181, 23);
            this.mtxtCelular.TabIndex = 97;
            this.mtxtCelular.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCelular_MaskInputRejected);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(15, 132);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(181, 23);
            this.txtEndereco.TabIndex = 96;
            // 
            // nupIdade
            // 
            this.nupIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupIdade.Location = new System.Drawing.Point(15, 78);
            this.nupIdade.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nupIdade.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.nupIdade.Name = "nupIdade";
            this.nupIdade.Size = new System.Drawing.Size(181, 22);
            this.nupIdade.TabIndex = 95;
            this.nupIdade.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(15, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(181, 23);
            this.txtNome.TabIndex = 92;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(289, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 90;
            this.label15.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(289, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 16);
            this.label16.TabIndex = 89;
            this.label16.Text = "CPF";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 292);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 16);
            this.label17.TabIndex = 88;
            this.label17.Text = "RG";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 231);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 16);
            this.label18.TabIndex = 87;
            this.label18.Text = "Salário";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(289, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 16);
            this.label19.TabIndex = 86;
            this.label19.Text = "Telefone";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 113);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 16);
            this.label21.TabIndex = 85;
            this.label21.Text = "Endereço";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(12, 169);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 16);
            this.label23.TabIndex = 83;
            this.label23.Text = "Celular";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(12, 59);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 16);
            this.label24.TabIndex = 82;
            this.label24.Text = "Idade";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(12, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 16);
            this.label26.TabIndex = 80;
            this.label26.Text = "Nome ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 46);
            this.button1.TabIndex = 106;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(396, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 46);
            this.btnCancelar.TabIndex = 105;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(297, 366);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 46);
            this.btnSalvar.TabIndex = 104;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.FormattingEnabled = true;
            this.txtCidade.Items.AddRange(new object[] {
            "Abdon Batista",
            "Abelardo Luz",
            "Agrolandia",
            "Agronomica",
            "Agua Doce",
            "Aguas Frias",
            "Aguas Mornas",
            "Aguas de Chapeco",
            "Alfredo Wagner",
            "Alto Bela Vista",
            "Anchieta",
            "Angelina",
            "Anita Garibaldi",
            "Anitapolis",
            "Antonio Carlos",
            "Apiuna",
            "Arabuta",
            "Araquari",
            "Ararangua",
            "Armazem",
            "Arroio Trinta",
            "Arvoredo",
            "Ascurra",
            "Atalanta",
            "Aurora",
            "Balneario Arroio do Silva",
            "Balneario Barra do Sul",
            "Balneario Camboriu",
            "Balneario Gaivota",
            "Bandeirante",
            "Barra Bonita",
            "Barra Velha",
            "Bela Vista do Toldo",
            "Belmonte",
            "Benedito Novo",
            "Biguacu",
            "Blumenau",
            "Bocaina do Sul",
            "Bom Jardim da Serra",
            "Bom Jesus do Oeste",
            "Bom Jesus",
            "Bom Retiro",
            "Bombinhas",
            "Botuvera",
            "Braco do Norte",
            "Braco do Trombudo",
            "Brunopolis",
            "Brusque",
            "Cacador",
            "Caibi",
            "Calmon",
            "Camboriu",
            "Campo Alegre",
            "Campo Belo do Sul",
            "Campo Ere",
            "Campos Novos",
            "Canelinha",
            "Canoinhas",
            "Capao Alto",
            "Capinzal",
            "Capivari de Baixo",
            "Catanduvas",
            "Caxambu do Sul",
            "Celso Ramos",
            "Cerro Negro",
            "Chapadao do Lageado",
            "Chapeco",
            "Cocal do Sul",
            "Concordia",
            "Cordilheira Alta",
            "Coronel Freitas",
            "Coronel Martins",
            "Correia Pinto",
            "Corupa",
            "Criciuma",
            "Cunha Pora",
            "Cunhatai",
            "Curitibanos",
            "Descanso",
            "Dionisio Cerqueira",
            "Dona Emma",
            "Doutor Pedrinho",
            "Entre Rios",
            "Ermo",
            "Erval Velho",
            "Faxinal dos Guedes",
            "Flor do Sertao",
            "Florianopolis",
            "Formosa do Sul",
            "Forquilhinha",
            "Fraiburgo",
            "Frei Rogerio",
            "Galvao",
            "Garopaba",
            "Garuva",
            "Gaspar",
            "Governador Celso Ramos",
            "Grao Para",
            "Gravatal",
            "Guabiruba",
            "Guaraciaba",
            "Guaramirim",
            "Guaruja do Sul",
            "Guatambu",
            "Herval d\'Oeste",
            "Ibiam",
            "Ibicare",
            "Ibirama",
            "Icara",
            "Ilhota",
            "Imarui",
            "Imbituba",
            "Imbuia",
            "Indaial",
            "Iomere",
            "Ipira",
            "Ipora do Oeste",
            "Ipuacu",
            "Ipumirim",
            "Iraceminha",
            "Irani",
            "Irati",
            "Irineopolis",
            "Ita",
            "Itaiopolis",
            "Itajai",
            "Itapema",
            "Itapiranga",
            "Itapoa",
            "Ituporanga",
            "Jabora",
            "Jacinto Machado",
            "Jaguaruna",
            "Jaragua do Sul",
            "Jardinopolis",
            "Joacaba",
            "Joinville",
            "Jose Boiteux",
            "Jupia",
            "Lacerdopolis",
            "Lages",
            "Laguna",
            "Lajeado Grande",
            "Laurentino",
            "Lauro Muller",
            "Lebon Regis",
            "Leoberto Leal",
            "Lindoia do Sul",
            "Lontras",
            "Luiz Alves",
            "Luzerna",
            "Macieira",
            "Mafra",
            "Major Gercino",
            "Major Vieira",
            "Maracaja",
            "Maravilha",
            "Marema",
            "Massaranduba",
            "Matos Costa",
            "Meleiro",
            "Mirim Doce",
            "Modelo",
            "Mondai",
            "Monte Carlo",
            "Monte Castelo",
            "Morro Grande",
            "Morro da Fumaca",
            "Navegantes",
            "Nova Erechim",
            "Nova Itaberaba",
            "Nova Trento",
            "Nova Veneza",
            "Novo Horizonte",
            "Orleans",
            "Otacilio Costa",
            "Ouro Verde",
            "Ouro",
            "Paial",
            "Painel",
            "Palhoca",
            "Palma Sola",
            "Palmeira",
            "Palmitos",
            "Papanduva",
            "Paraiso",
            "Passo de Torres",
            "Passos Maia",
            "Paulo Lopes",
            "Pedras Grandes",
            "Penha",
            "Peritiba",
            "Petrolandia",
            "Picarras",
            "Pinhalzinho",
            "Pinheiro Preto",
            "Piratuba",
            "Planalto Alegre",
            "Pomerode",
            "Ponte Alta do Norte",
            "Ponte Alta",
            "Ponte Serrada",
            "Porto Belo",
            "Porto Uniao",
            "Pouso Redondo",
            "Praia Grande",
            "Presidente Castelo Branco",
            "Presidente Getulio",
            "Presidente Nereu",
            "Princesa",
            "Quilombo",
            "Rancho Queimado",
            "Rio Fortuna",
            "Rio Negrinho",
            "Rio Rufino",
            "Rio d\'Oeste",
            "Rio das Antas",
            "Rio do Campo",
            "Rio do Sul",
            "Rio dos Cedros",
            "Riqueza",
            "Rodeio",
            "Romelandia",
            "Salete",
            "Saltinho",
            "Salto Veloso",
            "Sangao",
            "Santa Cecilia",
            "Santa Helena",
            "Santa Rosa de Lima",
            "Santa Rosa do Sul",
            "Santa Terezinha do Progresso",
            "Santa Terezinha",
            "Santiago do Sul",
            "Santo Amaro da Imperatriz",
            "Sao Bento do Sul",
            "Sao Bernardino",
            "Sao Bonifacio",
            "Sao Carlos",
            "Sao Cristovao do Sul",
            "Sao Domingos",
            "Sao Francisco do Sul",
            "Sao Joao Batista",
            "Sao Joao do Itaperiu",
            "Sao Joao do Oeste",
            "Sao Joao do Sul",
            "Sao Joaquim",
            "Sao Jose do Cedro",
            "Sao Jose do Cerrito",
            "Sao Jose",
            "Sao Lourenco d\'Oeste",
            "Sao Ludgero",
            "Sao Martinho",
            "Sao Miguel d\'Oeste",
            "Sao Miguel da Boa Vista",
            "Sao Pedro de Alcantara",
            "Saudades",
            "Schroeder",
            "Seara",
            "Serra Alta",
            "Sideropolis",
            "Sombrio",
            "Sul Brasil",
            "Taio",
            "Tangara",
            "Tigrinhos",
            "Tijucas",
            "Timbe do Sul",
            "Timbo Grande",
            "Timbo",
            "Tres Barras",
            "Treviso",
            "Treze Tilias",
            "Treze de Maio",
            "Trombudo Central",
            "Tubarao",
            "Tunapolis",
            "Turvo",
            "Uniao do Oeste",
            "Urubici",
            "Urupema",
            "Urussanga",
            "Vargeao",
            "Vargem Bonita",
            "Vargem",
            "Vidal Ramos",
            "Videira",
            "Vitor Meireles",
            "Witmarsum",
            "Xanxere",
            "Xavantina",
            "Xaxim",
            "Zortea"});
            this.txtCidade.Location = new System.Drawing.Point(292, 28);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(181, 24);
            this.txtCidade.TabIndex = 108;
            this.txtCidade.SelectedIndexChanged += new System.EventHandler(this.txtCidade_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(289, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 16);
            this.label13.TabIndex = 107;
            this.label13.Text = "Cidade aonde mora (SC) ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // CadastroFuncTerceirizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 424);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.mtxtCelular);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.nupIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label26);
            this.Name = "CadastroFuncTerceirizado";
            this.Text = "Cadastro de Funcionário Setor Terceirizado";
            this.Load += new System.EventHandler(this.CadastroFuncTerceirizado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.NumericUpDown nupIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox txtCidade;
        private System.Windows.Forms.Label label13;
    }
}