﻿namespace WalDog2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label7 = new System.Windows.Forms.Label();
            this.lst_mostrar = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chek_cuidadoEspe = new System.Windows.Forms.CheckBox();
            this.chek_alimentacao = new System.Windows.Forms.CheckBox();
            this.chek_treinamento = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nif = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_valorConta = new System.Windows.Forms.Label();
            this.lbl_numCartao = new System.Windows.Forms.Label();
            this.lbl_cvc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mdata_passeio = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_precoPasseio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxt_tempoPasseio = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtt_Sair = new System.Windows.Forms.ToolStripButton();
            this.tsbtt_voltar = new System.Windows.Forms.ToolStripButton();
            this.btt_escolherCaes = new WalDog2.Botao();
            this.btt_marcarPasseio = new WalDog2.Botao();
            this.btt_gerarPreco = new WalDog2.Botao();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 18);
            this.label7.TabIndex = 104;
            this.label7.Text = "Selecione os seus Cães";
            // 
            // lst_mostrar
            // 
            this.lst_mostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_mostrar.FormattingEnabled = true;
            this.lst_mostrar.Location = new System.Drawing.Point(30, 72);
            this.lst_mostrar.Name = "lst_mostrar";
            this.lst_mostrar.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_mostrar.Size = new System.Drawing.Size(251, 134);
            this.lst_mostrar.TabIndex = 103;
            this.lst_mostrar.SelectedIndexChanged += new System.EventHandler(this.lst_mostrar_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chek_cuidadoEspe);
            this.groupBox4.Controls.Add(this.chek_alimentacao);
            this.groupBox4.Controls.Add(this.chek_treinamento);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(30, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 116);
            this.groupBox4.TabIndex = 102;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Serviços Extras";
            // 
            // chek_cuidadoEspe
            // 
            this.chek_cuidadoEspe.AutoSize = true;
            this.chek_cuidadoEspe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chek_cuidadoEspe.Location = new System.Drawing.Point(15, 79);
            this.chek_cuidadoEspe.Name = "chek_cuidadoEspe";
            this.chek_cuidadoEspe.Size = new System.Drawing.Size(144, 20);
            this.chek_cuidadoEspe.TabIndex = 24;
            this.chek_cuidadoEspe.Text = "Cuidados Especias";
            this.chek_cuidadoEspe.UseVisualStyleBackColor = true;
            // 
            // chek_alimentacao
            // 
            this.chek_alimentacao.AutoSize = true;
            this.chek_alimentacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chek_alimentacao.Location = new System.Drawing.Point(15, 53);
            this.chek_alimentacao.Name = "chek_alimentacao";
            this.chek_alimentacao.Size = new System.Drawing.Size(101, 20);
            this.chek_alimentacao.TabIndex = 22;
            this.chek_alimentacao.Text = "Alimentação";
            this.chek_alimentacao.UseVisualStyleBackColor = true;
            // 
            // chek_treinamento
            // 
            this.chek_treinamento.AutoSize = true;
            this.chek_treinamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chek_treinamento.Location = new System.Drawing.Point(15, 27);
            this.chek_treinamento.Name = "chek_treinamento";
            this.chek_treinamento.Size = new System.Drawing.Size(102, 20);
            this.chek_treinamento.TabIndex = 21;
            this.chek_treinamento.Text = "Treinamento";
            this.chek_treinamento.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_nif);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbl_valorConta);
            this.groupBox1.Controls.Add(this.lbl_numCartao);
            this.groupBox1.Controls.Add(this.lbl_cvc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(389, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 221);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cartão";
            // 
            // lbl_nif
            // 
            this.lbl_nif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_nif.Enabled = false;
            this.lbl_nif.Location = new System.Drawing.Point(116, 60);
            this.lbl_nif.Name = "lbl_nif";
            this.lbl_nif.Size = new System.Drawing.Size(81, 20);
            this.lbl_nif.TabIndex = 68;
            this.lbl_nif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(82, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 67;
            this.label11.Text = "NIF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 66;
            this.label10.Text = "Valor na conta";
            // 
            // lbl_valorConta
            // 
            this.lbl_valorConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_valorConta.Enabled = false;
            this.lbl_valorConta.Location = new System.Drawing.Point(116, 164);
            this.lbl_valorConta.Name = "lbl_valorConta";
            this.lbl_valorConta.Size = new System.Drawing.Size(172, 20);
            this.lbl_valorConta.TabIndex = 65;
            this.lbl_valorConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_numCartao
            // 
            this.lbl_numCartao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_numCartao.Enabled = false;
            this.lbl_numCartao.Location = new System.Drawing.Point(116, 95);
            this.lbl_numCartao.Name = "lbl_numCartao";
            this.lbl_numCartao.Size = new System.Drawing.Size(143, 20);
            this.lbl_numCartao.TabIndex = 64;
            this.lbl_numCartao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cvc
            // 
            this.lbl_cvc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_cvc.Enabled = false;
            this.lbl_cvc.Location = new System.Drawing.Point(116, 129);
            this.lbl_cvc.Name = "lbl_cvc";
            this.lbl_cvc.Size = new System.Drawing.Size(44, 20);
            this.lbl_cvc.TabIndex = 63;
            this.lbl_cvc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "CVV/CVC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Número Cartão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Nome";
            // 
            // lbl_nome
            // 
            this.lbl_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_nome.Enabled = false;
            this.lbl_nome.Location = new System.Drawing.Point(116, 22);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(161, 20);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DisplayMember = "nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(415, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 100;
            this.comboBox1.ValueMember = "nif";
            // 
            // mdata_passeio
            // 
            this.mdata_passeio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdata_passeio.Location = new System.Drawing.Point(155, 268);
            this.mdata_passeio.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdata_passeio.Name = "mdata_passeio";
            this.mdata_passeio.Size = new System.Drawing.Size(109, 29);
            this.mdata_passeio.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 97;
            this.label3.Text = "Preço de passeio";
            // 
            // lbl_precoPasseio
            // 
            this.lbl_precoPasseio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_precoPasseio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_precoPasseio.Location = new System.Drawing.Point(138, 496);
            this.lbl_precoPasseio.Name = "lbl_precoPasseio";
            this.lbl_precoPasseio.Size = new System.Drawing.Size(97, 21);
            this.lbl_precoPasseio.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Tempo de passeio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 94;
            this.label1.Text = "Data do passeio";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(385, 325);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(316, 116);
            this.txt_descricao.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(310, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 92;
            this.label9.Text = "Descrição";
            // 
            // mtxt_tempoPasseio
            // 
            this.mtxt_tempoPasseio.Location = new System.Drawing.Point(155, 230);
            this.mtxt_tempoPasseio.Mask = "00:00";
            this.mtxt_tempoPasseio.Name = "mtxt_tempoPasseio";
            this.mtxt_tempoPasseio.Size = new System.Drawing.Size(40, 20);
            this.mtxt_tempoPasseio.TabIndex = 91;
            this.mtxt_tempoPasseio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_tempoPasseio.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(389, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 31);
            this.panel1.TabIndex = 105;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtt_Sair,
            this.tsbtt_voltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(719, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtt_Sair
            // 
            this.tsBtt_Sair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtt_Sair.AutoSize = false;
            this.tsBtt_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsBtt_Sair.BackgroundImage")));
            this.tsBtt_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsBtt_Sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtt_Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtt_Sair.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.tsBtt_Sair.Name = "tsBtt_Sair";
            this.tsBtt_Sair.Size = new System.Drawing.Size(25, 30);
            this.tsBtt_Sair.Text = "Sair";
            this.tsBtt_Sair.Click += new System.EventHandler(this.tsBtt_Sair_Click);
            // 
            // tsbtt_voltar
            // 
            this.tsbtt_voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbtt_voltar.BackgroundImage")));
            this.tsbtt_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtt_voltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtt_voltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtt_voltar.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tsbtt_voltar.Name = "tsbtt_voltar";
            this.tsbtt_voltar.Size = new System.Drawing.Size(23, 30);
            this.tsbtt_voltar.Text = "Voltar";
            this.tsbtt_voltar.Click += new System.EventHandler(this.tsbtt_voltar_Click);
            // 
            // btt_escolherCaes
            // 
            this.btt_escolherCaes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_escolherCaes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_escolherCaes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btt_escolherCaes.BorderRadius = 10;
            this.btt_escolherCaes.BorderSize = 0;
            this.btt_escolherCaes.FlatAppearance.BorderSize = 0;
            this.btt_escolherCaes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_escolherCaes.ForeColor = System.Drawing.Color.White;
            this.btt_escolherCaes.Location = new System.Drawing.Point(243, 172);
            this.btt_escolherCaes.Name = "btt_escolherCaes";
            this.btt_escolherCaes.Size = new System.Drawing.Size(92, 34);
            this.btt_escolherCaes.TabIndex = 106;
            this.btt_escolherCaes.Text = "Escolher os selecionados";
            this.btt_escolherCaes.TextColor = System.Drawing.Color.White;
            this.btt_escolherCaes.UseVisualStyleBackColor = false;
            // 
            // btt_marcarPasseio
            // 
            this.btt_marcarPasseio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_marcarPasseio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_marcarPasseio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btt_marcarPasseio.BorderRadius = 10;
            this.btt_marcarPasseio.BorderSize = 0;
            this.btt_marcarPasseio.FlatAppearance.BorderSize = 0;
            this.btt_marcarPasseio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_marcarPasseio.ForeColor = System.Drawing.Color.White;
            this.btt_marcarPasseio.Location = new System.Drawing.Point(512, 495);
            this.btt_marcarPasseio.Name = "btt_marcarPasseio";
            this.btt_marcarPasseio.Size = new System.Drawing.Size(160, 46);
            this.btt_marcarPasseio.TabIndex = 107;
            this.btt_marcarPasseio.Text = "Marcar Passeio";
            this.btt_marcarPasseio.TextColor = System.Drawing.Color.White;
            this.btt_marcarPasseio.UseVisualStyleBackColor = false;
            // 
            // btt_gerarPreco
            // 
            this.btt_gerarPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_gerarPreco.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_gerarPreco.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btt_gerarPreco.BorderRadius = 10;
            this.btt_gerarPreco.BorderSize = 0;
            this.btt_gerarPreco.FlatAppearance.BorderSize = 0;
            this.btt_gerarPreco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_gerarPreco.ForeColor = System.Drawing.Color.White;
            this.btt_gerarPreco.Location = new System.Drawing.Point(45, 475);
            this.btt_gerarPreco.Name = "btt_gerarPreco";
            this.btt_gerarPreco.Size = new System.Drawing.Size(78, 56);
            this.btt_gerarPreco.TabIndex = 108;
            this.btt_gerarPreco.Text = " Gerar preço \r\n de passeio\r\n";
            this.btt_gerarPreco.TextColor = System.Drawing.Color.White;
            this.btt_gerarPreco.UseVisualStyleBackColor = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 572);
            this.Controls.Add(this.btt_gerarPreco);
            this.Controls.Add(this.btt_marcarPasseio);
            this.Controls.Add(this.btt_escolherCaes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lst_mostrar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mdata_passeio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_precoPasseio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mtxt_tempoPasseio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lst_mostrar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chek_cuidadoEspe;
        private System.Windows.Forms.CheckBox chek_alimentacao;
        private System.Windows.Forms.CheckBox chek_treinamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nif;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_valorConta;
        private System.Windows.Forms.Label lbl_numCartao;
        private System.Windows.Forms.Label lbl_cvc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroDateTime mdata_passeio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_precoPasseio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxt_tempoPasseio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtt_Sair;
        private System.Windows.Forms.ToolStripButton tsbtt_voltar;
        private Botao btt_escolherCaes;
        private Botao btt_marcarPasseio;
        private Botao btt_gerarPreco;
    }
}