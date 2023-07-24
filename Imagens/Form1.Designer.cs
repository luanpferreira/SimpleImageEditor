namespace Imagens
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCaminho = new System.Windows.Forms.TextBox();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbcImagem = new System.Windows.Forms.TabControl();
            this.tbCarregar = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbGrau = new System.Windows.Forms.ComboBox();
            this.cbLocalizacao = new System.Windows.Forms.ComboBox();
            this.tbEditar = new System.Windows.Forms.TabPage();
            this.btMediana = new System.Windows.Forms.Button();
            this.btStd = new System.Windows.Forms.Button();
            this.btMedia = new System.Windows.Forms.Button();
            this.lvValores = new System.Windows.Forms.ListView();
            this.btExportar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGrau = new System.Windows.Forms.Label();
            this.lbLocalizacao = new System.Windows.Forms.Label();
            this.lbLargura = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.lbResolucao = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCinza = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.tbGravar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.tbExibir = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.pbImagemModificada = new System.Windows.Forms.PictureBox();
            this.pbImagemOriginal = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.tbcImagem.SuspendLayout();
            this.tbCarregar.SuspendLayout();
            this.tbEditar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemModificada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(72, 74);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(352, 26);
            this.tbNome.TabIndex = 0;
            // 
            // tbCaminho
            // 
            this.tbCaminho.Location = new System.Drawing.Point(72, 111);
            this.tbCaminho.Name = "tbCaminho";
            this.tbCaminho.Size = new System.Drawing.Size(352, 26);
            this.tbCaminho.TabIndex = 1;
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Location = new System.Drawing.Point(17, 360);
            this.dGV.Name = "dGV";
            this.dGV.Size = new System.Drawing.Size(711, 203);
            this.dGV.TabIndex = 5;
            this.dGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbcImagem
            // 
            this.tbcImagem.Controls.Add(this.tbCarregar);
            this.tbcImagem.Controls.Add(this.tbEditar);
            this.tbcImagem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcImagem.Location = new System.Drawing.Point(12, 12);
            this.tbcImagem.Name = "tbcImagem";
            this.tbcImagem.SelectedIndex = 0;
            this.tbcImagem.Size = new System.Drawing.Size(753, 600);
            this.tbcImagem.TabIndex = 11;
            this.tbcImagem.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcImagem_Selecting);
            // 
            // tbCarregar
            // 
            this.tbCarregar.Controls.Add(this.label12);
            this.tbCarregar.Controls.Add(this.label11);
            this.tbCarregar.Controls.Add(this.label10);
            this.tbCarregar.Controls.Add(this.label9);
            this.tbCarregar.Controls.Add(this.btEditar);
            this.tbCarregar.Controls.Add(this.cbGrau);
            this.tbCarregar.Controls.Add(this.cbLocalizacao);
            this.tbCarregar.Controls.Add(this.tbNome);
            this.tbCarregar.Controls.Add(this.pbImagem);
            this.tbCarregar.Controls.Add(this.btBuscar);
            this.tbCarregar.Controls.Add(this.tbCaminho);
            this.tbCarregar.Controls.Add(this.dGV);
            this.tbCarregar.Controls.Add(this.btAtualizar);
            this.tbCarregar.Controls.Add(this.tbGravar);
            this.tbCarregar.Controls.Add(this.btExcluir);
            this.tbCarregar.Controls.Add(this.tbExibir);
            this.tbCarregar.Location = new System.Drawing.Point(4, 27);
            this.tbCarregar.Name = "tbCarregar";
            this.tbCarregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbCarregar.Size = new System.Drawing.Size(745, 569);
            this.tbCarregar.TabIndex = 0;
            this.tbCarregar.Text = "Carregar";
            this.tbCarregar.UseVisualStyleBackColor = true;
            this.tbCarregar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbCarregar_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Localização:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Grau:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Local:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nome:";
            // 
            // cbGrau
            // 
            this.cbGrau.FormattingEnabled = true;
            this.cbGrau.Items.AddRange(new object[] {
            "",
            "Grau I",
            "Grau II",
            "Grau III",
            "Controle"});
            this.cbGrau.Location = new System.Drawing.Point(72, 150);
            this.cbGrau.Name = "cbGrau";
            this.cbGrau.Size = new System.Drawing.Size(121, 26);
            this.cbGrau.TabIndex = 14;
            // 
            // cbLocalizacao
            // 
            this.cbLocalizacao.FormattingEnabled = true;
            this.cbLocalizacao.Items.AddRange(new object[] {
            "",
            "Centro",
            "Periferia"});
            this.cbLocalizacao.Location = new System.Drawing.Point(303, 150);
            this.cbLocalizacao.Name = "cbLocalizacao";
            this.cbLocalizacao.Size = new System.Drawing.Size(121, 26);
            this.cbLocalizacao.TabIndex = 13;
            // 
            // tbEditar
            // 
            this.tbEditar.Controls.Add(this.button2);
            this.tbEditar.Controls.Add(this.button1);
            this.tbEditar.Controls.Add(this.btVoltar);
            this.tbEditar.Controls.Add(this.btMediana);
            this.tbEditar.Controls.Add(this.btStd);
            this.tbEditar.Controls.Add(this.btMedia);
            this.tbEditar.Controls.Add(this.lvValores);
            this.tbEditar.Controls.Add(this.btExportar);
            this.tbEditar.Controls.Add(this.groupBox1);
            this.tbEditar.Controls.Add(this.btCinza);
            this.tbEditar.Controls.Add(this.pbImagemModificada);
            this.tbEditar.Controls.Add(this.pbImagemOriginal);
            this.tbEditar.Location = new System.Drawing.Point(4, 27);
            this.tbEditar.Name = "tbEditar";
            this.tbEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tbEditar.Size = new System.Drawing.Size(745, 569);
            this.tbEditar.TabIndex = 2;
            this.tbEditar.Text = "Editar";
            this.tbEditar.UseVisualStyleBackColor = true;
            this.tbEditar.Click += new System.EventHandler(this.tbRGB_Click);
            this.tbEditar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbEditar_MouseDoubleClick);
            // 
            // btMediana
            // 
            this.btMediana.Location = new System.Drawing.Point(383, 10);
            this.btMediana.Name = "btMediana";
            this.btMediana.Size = new System.Drawing.Size(58, 25);
            this.btMediana.TabIndex = 22;
            this.btMediana.Text = "Med";
            this.btMediana.UseVisualStyleBackColor = true;
            this.btMediana.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btMediana_MouseClick);
            // 
            // btStd
            // 
            this.btStd.Location = new System.Drawing.Point(319, 10);
            this.btStd.Name = "btStd";
            this.btStd.Size = new System.Drawing.Size(58, 25);
            this.btStd.TabIndex = 17;
            this.btStd.Text = "Std";
            this.btStd.UseVisualStyleBackColor = true;
            this.btStd.Click += new System.EventHandler(this.btStd_Click);
            // 
            // btMedia
            // 
            this.btMedia.Location = new System.Drawing.Point(255, 10);
            this.btMedia.Name = "btMedia";
            this.btMedia.Size = new System.Drawing.Size(58, 25);
            this.btMedia.TabIndex = 16;
            this.btMedia.Text = "Mean";
            this.btMedia.UseVisualStyleBackColor = true;
            this.btMedia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btMedia_MouseClick);
            // 
            // lvValores
            // 
            this.lvValores.HideSelection = false;
            this.lvValores.Location = new System.Drawing.Point(383, 412);
            this.lvValores.Name = "lvValores";
            this.lvValores.Size = new System.Drawing.Size(356, 151);
            this.lvValores.TabIndex = 15;
            this.lvValores.UseCompatibleStateImageBehavior = false;
            this.lvValores.SelectedIndexChanged += new System.EventHandler(this.lvValores_SelectedIndexChanged);
            // 
            // btExportar
            // 
            this.btExportar.BackgroundImage = global::Imagens.Properties.Resources.save;
            this.btExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btExportar.Location = new System.Drawing.Point(700, 3);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(39, 34);
            this.btExportar.TabIndex = 14;
            this.btExportar.UseVisualStyleBackColor = true;
            this.btExportar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btExportar_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbGrau);
            this.groupBox1.Controls.Add(this.lbLocalizacao);
            this.groupBox1.Controls.Add(this.lbLargura);
            this.groupBox1.Controls.Add(this.lbAltura);
            this.groupBox1.Controls.Add(this.lbResolucao);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbEnd);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 151);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros";
            // 
            // lbGrau
            // 
            this.lbGrau.AutoSize = true;
            this.lbGrau.Location = new System.Drawing.Point(68, 130);
            this.lbGrau.Name = "lbGrau";
            this.lbGrau.Size = new System.Drawing.Size(24, 13);
            this.lbGrau.TabIndex = 29;
            this.lbGrau.Text = "Null";
            // 
            // lbLocalizacao
            // 
            this.lbLocalizacao.AutoSize = true;
            this.lbLocalizacao.Location = new System.Drawing.Point(68, 111);
            this.lbLocalizacao.Name = "lbLocalizacao";
            this.lbLocalizacao.Size = new System.Drawing.Size(24, 13);
            this.lbLocalizacao.TabIndex = 28;
            this.lbLocalizacao.Text = "Null";
            // 
            // lbLargura
            // 
            this.lbLargura.AutoSize = true;
            this.lbLargura.Location = new System.Drawing.Point(68, 91);
            this.lbLargura.Name = "lbLargura";
            this.lbLargura.Size = new System.Drawing.Size(24, 13);
            this.lbLargura.TabIndex = 27;
            this.lbLargura.Text = "Null";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(68, 73);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(24, 13);
            this.lbAltura.TabIndex = 26;
            this.lbAltura.Text = "Null";
            // 
            // lbResolucao
            // 
            this.lbResolucao.AutoSize = true;
            this.lbResolucao.Location = new System.Drawing.Point(68, 55);
            this.lbResolucao.Name = "lbResolucao";
            this.lbResolucao.Size = new System.Drawing.Size(24, 13);
            this.lbResolucao.TabIndex = 25;
            this.lbResolucao.Text = "Null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Grau:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Localização:";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(68, 35);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(24, 13);
            this.lbEnd.TabIndex = 22;
            this.lbEnd.Text = "Null";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(68, 16);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(24, 13);
            this.lbNome.TabIndex = 20;
            this.lbNome.Text = "Null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Largura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Altura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Resolução:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome:";
            // 
            // btCinza
            // 
            this.btCinza.Location = new System.Drawing.Point(191, 10);
            this.btCinza.Name = "btCinza";
            this.btCinza.Size = new System.Drawing.Size(58, 25);
            this.btCinza.TabIndex = 12;
            this.btCinza.Text = "Gray";
            this.btCinza.UseVisualStyleBackColor = true;
            this.btCinza.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btCinza_MouseClick);
            // 
            // btEditar
            // 
            this.btEditar.BackgroundImage = global::Imagens.Properties.Resources.edit;
            this.btEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEditar.Location = new System.Drawing.Point(587, 253);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(47, 37);
            this.btEditar.TabIndex = 15;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btEditar_MouseClick);
            // 
            // pbImagem
            // 
            this.pbImagem.Image = ((System.Drawing.Image)(resources.GetObject("pbImagem.Image")));
            this.pbImagem.Location = new System.Drawing.Point(489, 37);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(239, 210);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagem.TabIndex = 9;
            this.pbImagem.TabStop = false;
            // 
            // btBuscar
            // 
            this.btBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscar.BackgroundImage")));
            this.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            this.btBuscar.Location = new System.Drawing.Point(430, 111);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(34, 31);
            this.btBuscar.TabIndex = 10;
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btSelecionar_MouseClick);
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackgroundImage = global::Imagens.Properties.Resources.refresh1;
            this.btAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAtualizar.Location = new System.Drawing.Point(74, 204);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(45, 33);
            this.btAtualizar.TabIndex = 6;
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btAtualizar_MouseClick);
            // 
            // tbGravar
            // 
            this.tbGravar.BackgroundImage = global::Imagens.Properties.Resources.save;
            this.tbGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tbGravar.Location = new System.Drawing.Point(380, 202);
            this.tbGravar.Name = "tbGravar";
            this.tbGravar.Size = new System.Drawing.Size(44, 35);
            this.tbGravar.TabIndex = 2;
            this.tbGravar.UseVisualStyleBackColor = true;
            this.tbGravar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbGravar_MouseClick);
            // 
            // btExcluir
            // 
            this.btExcluir.BackgroundImage = global::Imagens.Properties.Resources.delete;
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btExcluir.Location = new System.Drawing.Point(230, 204);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(44, 33);
            this.btExcluir.TabIndex = 7;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btExcluir_MouseClick);
            // 
            // tbExibir
            // 
            this.tbExibir.BackgroundImage = global::Imagens.Properties.Resources.show;
            this.tbExibir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tbExibir.Location = new System.Drawing.Point(18, 324);
            this.tbExibir.Name = "tbExibir";
            this.tbExibir.Size = new System.Drawing.Size(41, 30);
            this.tbExibir.TabIndex = 4;
            this.tbExibir.UseVisualStyleBackColor = true;
            this.tbExibir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbExibir_MouseClick);
            // 
            // btVoltar
            // 
            this.btVoltar.BackgroundImage = global::Imagens.Properties.Resources._return;
            this.btVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btVoltar.Location = new System.Drawing.Point(6, 5);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(39, 34);
            this.btVoltar.TabIndex = 23;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // pbImagemModificada
            // 
            this.pbImagemModificada.Location = new System.Drawing.Point(383, 43);
            this.pbImagemModificada.Name = "pbImagemModificada";
            this.pbImagemModificada.Size = new System.Drawing.Size(356, 351);
            this.pbImagemModificada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagemModificada.TabIndex = 11;
            this.pbImagemModificada.TabStop = false;
            // 
            // pbImagemOriginal
            // 
            this.pbImagemOriginal.Location = new System.Drawing.Point(6, 43);
            this.pbImagemOriginal.Name = "pbImagemOriginal";
            this.pbImagemOriginal.Size = new System.Drawing.Size(371, 351);
            this.pbImagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagemOriginal.TabIndex = 10;
            this.pbImagemOriginal.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 25);
            this.button1.TabIndex = 24;
            this.button1.Text = "+ B";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 25);
            this.button2.TabIndex = 25;
            this.button2.Text = "- B";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 616);
            this.Controls.Add(this.tbcImagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carregamento de Imagens";
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.tbcImagem.ResumeLayout(false);
            this.tbCarregar.ResumeLayout(false);
            this.tbCarregar.PerformLayout();
            this.tbEditar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemModificada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCaminho;
        private System.Windows.Forms.Button tbGravar;
        private System.Windows.Forms.Button tbExibir;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TabControl tbcImagem;
        private System.Windows.Forms.TabPage tbCarregar;
        private System.Windows.Forms.TabPage tbEditar;
        private System.Windows.Forms.ComboBox cbGrau;
        private System.Windows.Forms.ComboBox cbLocalizacao;
        private System.Windows.Forms.PictureBox pbImagemOriginal;
        private System.Windows.Forms.Button btCinza;
        private System.Windows.Forms.PictureBox pbImagemModificada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbGrau;
        private System.Windows.Forms.Label lbLocalizacao;
        private System.Windows.Forms.Label lbLargura;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbResolucao;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.ListView lvValores;
        private System.Windows.Forms.Button btStd;
        private System.Windows.Forms.Button btMedia;
        private System.Windows.Forms.Button btMediana;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

