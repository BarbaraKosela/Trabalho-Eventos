namespace SistemaJogadores
{
    partial class CadastroFuncAdministração
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncAdministração));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtSalário = new System.Windows.Forms.TextBox();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCel = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.nupIdade = new System.Windows.Forms.NumericUpDown();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(17, 367);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(335, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // txtRG
            // 
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRG.Location = new System.Drawing.Point(17, 425);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(335, 22);
            this.txtRG.TabIndex = 7;
            // 
            // txtSalário
            // 
            this.txtSalário.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalário.Location = new System.Drawing.Point(514, 304);
            this.txtSalário.Name = "txtSalário";
            this.txtSalário.Size = new System.Drawing.Size(339, 22);
            this.txtSalário.TabIndex = 12;
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtxTelefone.Location = new System.Drawing.Point(514, 232);
            this.mtxTelefone.Mask = "0000-0000";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(339, 22);
            this.mtxTelefone.TabIndex = 11;
            // 
            // mtxCPF
            // 
            this.mtxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtxCPF.Location = new System.Drawing.Point(514, 166);
            this.mtxCPF.Mask = "000000000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(339, 22);
            this.mtxCPF.TabIndex = 10;
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtxtCEP.Location = new System.Drawing.Point(514, 100);
            this.mtxtCEP.Mask = "00000-000";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(339, 22);
            this.mtxtCEP.TabIndex = 9;
            // 
            // mtxtCel
            // 
            this.mtxtCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.mtxtCel.Location = new System.Drawing.Point(15, 304);
            this.mtxtCel.Mask = "(99) 00000-0000";
            this.mtxtCel.Name = "mtxtCel";
            this.mtxtCel.Size = new System.Drawing.Size(337, 22);
            this.mtxtCel.TabIndex = 5;
            this.mtxtCel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCel_MaskInputRejected);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(16, 232);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(336, 22);
            this.txtEndereco.TabIndex = 4;
            // 
            // nupIdade
            // 
            this.nupIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupIdade.Location = new System.Drawing.Point(16, 163);
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
            this.nupIdade.Size = new System.Drawing.Size(336, 22);
            this.nupIdade.TabIndex = 3;
            this.nupIdade.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // cbArea
            // 
            this.cbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Items.AddRange(new object[] {
            "Estacionamento",
            "Administração dos Jogos",
            "Administração Praça de Alimentação"});
            this.cbArea.Location = new System.Drawing.Point(16, 96);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(336, 24);
            this.cbArea.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(15, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(337, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DarkRed;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(511, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Cidade aonde mora (SC) ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.DarkRed;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(14, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DarkRed;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(511, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "CPF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkRed;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(14, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "RG";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkRed;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(511, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Salário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkRed;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(511, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Telefone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(511, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "CEP ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(13, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Celular";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Area de aministração:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome ";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtCidade.Location = new System.Drawing.Point(514, 31);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(339, 24);
            this.txtCidade.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(432, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 53);
            this.button1.TabIndex = 92;
            this.button1.Text = "LISTAR";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(716, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(137, 53);
            this.btnCancelar.TabIndex = 91;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkRed;
            this.btnSalvar.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(573, 425);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(137, 53);
            this.btnSalvar.TabIndex = 90;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // CadastroFuncAdministração
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(909, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtSalário);
            this.Controls.Add(this.mtxTelefone);
            this.Controls.Add(this.mtxCPF);
            this.Controls.Add(this.mtxtCEP);
            this.Controls.Add(this.mtxtCel);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.nupIdade);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroFuncAdministração";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário Setor de  Administração";
            this.Load += new System.EventHandler(this.CadastroFuncAdministração_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtSalário;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.MaskedTextBox mtxtCel;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.NumericUpDown nupIdade;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtCidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}