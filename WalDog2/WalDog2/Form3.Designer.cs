namespace WalDog2.Resources
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.cbox_racaDog = new MetroFramework.Controls.MetroComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbox_Brinquedo = new System.Windows.Forms.GroupBox();
            this.rbtt_SimBrinquedo = new MetroFramework.Controls.MetroRadioButton();
            this.rbtt_NaoBrinquedo = new MetroFramework.Controls.MetroRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbox_Raiva = new System.Windows.Forms.GroupBox();
            this.rbtt_Raiva5 = new MetroFramework.Controls.MetroRadioButton();
            this.rbtt_Raiva4 = new MetroFramework.Controls.MetroRadioButton();
            this.rbtt_Raiva3 = new MetroFramework.Controls.MetroRadioButton();
            this.rbtt_Raiva1 = new MetroFramework.Controls.MetroRadioButton();
            this.rbtt_Raiva2 = new MetroFramework.Controls.MetroRadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.gbox_Alergia = new System.Windows.Forms.GroupBox();
            this.rbtt_Simalergia = new MetroFramework.Controls.MetroRadioButton();
            this.rbtt_Naoalergia = new MetroFramework.Controls.MetroRadioButton();
            this.gbox_Carinho = new System.Windows.Forms.GroupBox();
            this.rbtt_Simcarinho = new MetroFramework.Controls.MetroRadioButton();
            this.rbtt_Naocarinho = new MetroFramework.Controls.MetroRadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_Tamanho = new MetroFramework.Controls.MetroComboBox();
            this.txt_nomeDog = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtt_sair = new System.Windows.Forms.ToolStripButton();
            this.tsbtt_voltar = new System.Windows.Forms.ToolStripButton();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btt_submeter = new WalDog2.Botao();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbox_Brinquedo.SuspendLayout();
            this.gbox_Raiva.SuspendLayout();
            this.gbox_Alergia.SuspendLayout();
            this.gbox_Carinho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erros)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox_racaDog
            // 
            this.cbox_racaDog.DisplayMember = "racaCachorro";
            this.cbox_racaDog.FormattingEnabled = true;
            this.cbox_racaDog.ItemHeight = 23;
            this.cbox_racaDog.Location = new System.Drawing.Point(165, 90);
            this.cbox_racaDog.Name = "cbox_racaDog";
            this.cbox_racaDog.Size = new System.Drawing.Size(132, 29);
            this.cbox_racaDog.TabIndex = 97;
            this.cbox_racaDog.UseSelectable = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(633, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 96;
            this.label11.Text = "Bravo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(477, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 95;
            this.label8.Text = "Calmo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "Meio-termo";
            // 
            // gbox_Brinquedo
            // 
            this.gbox_Brinquedo.Controls.Add(this.rbtt_SimBrinquedo);
            this.gbox_Brinquedo.Controls.Add(this.rbtt_NaoBrinquedo);
            this.gbox_Brinquedo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbox_Brinquedo.ForeColor = System.Drawing.Color.White;
            this.gbox_Brinquedo.Location = new System.Drawing.Point(166, 314);
            this.gbox_Brinquedo.Name = "gbox_Brinquedo";
            this.gbox_Brinquedo.Size = new System.Drawing.Size(116, 40);
            this.gbox_Brinquedo.TabIndex = 93;
            this.gbox_Brinquedo.TabStop = false;
            // 
            // rbtt_SimBrinquedo
            // 
            this.rbtt_SimBrinquedo.AutoSize = true;
            this.rbtt_SimBrinquedo.ForeColor = System.Drawing.Color.IndianRed;
            this.rbtt_SimBrinquedo.Location = new System.Drawing.Point(10, 16);
            this.rbtt_SimBrinquedo.Name = "rbtt_SimBrinquedo";
            this.rbtt_SimBrinquedo.Size = new System.Drawing.Size(43, 15);
            this.rbtt_SimBrinquedo.TabIndex = 16;
            this.rbtt_SimBrinquedo.Text = "Sim";
            this.rbtt_SimBrinquedo.UseSelectable = true;
            // 
            // rbtt_NaoBrinquedo
            // 
            this.rbtt_NaoBrinquedo.AutoSize = true;
            this.rbtt_NaoBrinquedo.Location = new System.Drawing.Point(62, 16);
            this.rbtt_NaoBrinquedo.Name = "rbtt_NaoBrinquedo";
            this.rbtt_NaoBrinquedo.Size = new System.Drawing.Size(45, 15);
            this.rbtt_NaoBrinquedo.TabIndex = 20;
            this.rbtt_NaoBrinquedo.Text = "Não";
            this.rbtt_NaoBrinquedo.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 92;
            this.label4.Text = "Quer brinquedo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "Nível de Hostilidade";
            // 
            // gbox_Raiva
            // 
            this.gbox_Raiva.Controls.Add(this.rbtt_Raiva5);
            this.gbox_Raiva.Controls.Add(this.rbtt_Raiva4);
            this.gbox_Raiva.Controls.Add(this.rbtt_Raiva3);
            this.gbox_Raiva.Controls.Add(this.rbtt_Raiva1);
            this.gbox_Raiva.Controls.Add(this.rbtt_Raiva2);
            this.gbox_Raiva.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbox_Raiva.ForeColor = System.Drawing.Color.White;
            this.gbox_Raiva.Location = new System.Drawing.Point(479, 88);
            this.gbox_Raiva.Name = "gbox_Raiva";
            this.gbox_Raiva.Size = new System.Drawing.Size(187, 40);
            this.gbox_Raiva.TabIndex = 90;
            this.gbox_Raiva.TabStop = false;
            // 
            // rbtt_Raiva5
            // 
            this.rbtt_Raiva5.AutoSize = true;
            this.rbtt_Raiva5.Location = new System.Drawing.Point(150, 16);
            this.rbtt_Raiva5.Name = "rbtt_Raiva5";
            this.rbtt_Raiva5.Size = new System.Drawing.Size(29, 15);
            this.rbtt_Raiva5.TabIndex = 23;
            this.rbtt_Raiva5.Text = "5";
            this.rbtt_Raiva5.UseSelectable = true;
            // 
            // rbtt_Raiva4
            // 
            this.rbtt_Raiva4.AutoSize = true;
            this.rbtt_Raiva4.Location = new System.Drawing.Point(115, 16);
            this.rbtt_Raiva4.Name = "rbtt_Raiva4";
            this.rbtt_Raiva4.Size = new System.Drawing.Size(29, 15);
            this.rbtt_Raiva4.TabIndex = 22;
            this.rbtt_Raiva4.Text = "4";
            this.rbtt_Raiva4.UseSelectable = true;
            // 
            // rbtt_Raiva3
            // 
            this.rbtt_Raiva3.AutoSize = true;
            this.rbtt_Raiva3.Location = new System.Drawing.Point(80, 16);
            this.rbtt_Raiva3.Name = "rbtt_Raiva3";
            this.rbtt_Raiva3.Size = new System.Drawing.Size(29, 15);
            this.rbtt_Raiva3.TabIndex = 21;
            this.rbtt_Raiva3.Text = "3";
            this.rbtt_Raiva3.UseSelectable = true;
            // 
            // rbtt_Raiva1
            // 
            this.rbtt_Raiva1.AutoSize = true;
            this.rbtt_Raiva1.Location = new System.Drawing.Point(10, 16);
            this.rbtt_Raiva1.Name = "rbtt_Raiva1";
            this.rbtt_Raiva1.Size = new System.Drawing.Size(29, 15);
            this.rbtt_Raiva1.TabIndex = 16;
            this.rbtt_Raiva1.Text = "1";
            this.rbtt_Raiva1.UseSelectable = true;
            // 
            // rbtt_Raiva2
            // 
            this.rbtt_Raiva2.AutoSize = true;
            this.rbtt_Raiva2.Location = new System.Drawing.Point(45, 16);
            this.rbtt_Raiva2.Name = "rbtt_Raiva2";
            this.rbtt_Raiva2.Size = new System.Drawing.Size(29, 15);
            this.rbtt_Raiva2.TabIndex = 20;
            this.rbtt_Raiva2.Text = "2";
            this.rbtt_Raiva2.UseSelectable = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 89;
            this.label10.Text = "Raça do cachorro";
            // 
            // gbox_Alergia
            // 
            this.gbox_Alergia.Controls.Add(this.rbtt_Simalergia);
            this.gbox_Alergia.Controls.Add(this.rbtt_Naoalergia);
            this.gbox_Alergia.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbox_Alergia.ForeColor = System.Drawing.Color.White;
            this.gbox_Alergia.Location = new System.Drawing.Point(479, 156);
            this.gbox_Alergia.Name = "gbox_Alergia";
            this.gbox_Alergia.Size = new System.Drawing.Size(116, 40);
            this.gbox_Alergia.TabIndex = 88;
            this.gbox_Alergia.TabStop = false;
            // 
            // rbtt_Simalergia
            // 
            this.rbtt_Simalergia.AutoSize = true;
            this.rbtt_Simalergia.Location = new System.Drawing.Point(10, 16);
            this.rbtt_Simalergia.Name = "rbtt_Simalergia";
            this.rbtt_Simalergia.Size = new System.Drawing.Size(43, 15);
            this.rbtt_Simalergia.TabIndex = 16;
            this.rbtt_Simalergia.Text = "Sim";
            this.rbtt_Simalergia.UseSelectable = true;
            // 
            // rbtt_Naoalergia
            // 
            this.rbtt_Naoalergia.AutoSize = true;
            this.rbtt_Naoalergia.Location = new System.Drawing.Point(62, 16);
            this.rbtt_Naoalergia.Name = "rbtt_Naoalergia";
            this.rbtt_Naoalergia.Size = new System.Drawing.Size(45, 15);
            this.rbtt_Naoalergia.TabIndex = 20;
            this.rbtt_Naoalergia.Text = "Não";
            this.rbtt_Naoalergia.UseSelectable = true;
            // 
            // gbox_Carinho
            // 
            this.gbox_Carinho.Controls.Add(this.rbtt_Simcarinho);
            this.gbox_Carinho.Controls.Add(this.rbtt_Naocarinho);
            this.gbox_Carinho.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbox_Carinho.ForeColor = System.Drawing.Color.White;
            this.gbox_Carinho.Location = new System.Drawing.Point(166, 253);
            this.gbox_Carinho.Name = "gbox_Carinho";
            this.gbox_Carinho.Size = new System.Drawing.Size(116, 40);
            this.gbox_Carinho.TabIndex = 87;
            this.gbox_Carinho.TabStop = false;
            // 
            // rbtt_Simcarinho
            // 
            this.rbtt_Simcarinho.AutoSize = true;
            this.rbtt_Simcarinho.ForeColor = System.Drawing.Color.IndianRed;
            this.rbtt_Simcarinho.Location = new System.Drawing.Point(10, 16);
            this.rbtt_Simcarinho.Name = "rbtt_Simcarinho";
            this.rbtt_Simcarinho.Size = new System.Drawing.Size(43, 15);
            this.rbtt_Simcarinho.TabIndex = 16;
            this.rbtt_Simcarinho.Text = "Sim";
            this.rbtt_Simcarinho.UseSelectable = true;
            // 
            // rbtt_Naocarinho
            // 
            this.rbtt_Naocarinho.AutoSize = true;
            this.rbtt_Naocarinho.Location = new System.Drawing.Point(62, 16);
            this.rbtt_Naocarinho.Name = "rbtt_Naocarinho";
            this.rbtt_Naocarinho.Size = new System.Drawing.Size(45, 15);
            this.rbtt_Naocarinho.TabIndex = 20;
            this.rbtt_Naocarinho.Text = "Não";
            this.rbtt_Naocarinho.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 86;
            this.label6.Text = "Alergia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 85;
            this.label3.Text = "Gosta de carinho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 84;
            this.label2.Text = "Tamanho do cachorro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Nome do cachorro";
            // 
            // cbox_Tamanho
            // 
            this.cbox_Tamanho.FormattingEnabled = true;
            this.cbox_Tamanho.ItemHeight = 23;
            this.cbox_Tamanho.Items.AddRange(new object[] {
            "Pequeno",
            "Médio",
            "Grande"});
            this.cbox_Tamanho.Location = new System.Drawing.Point(166, 201);
            this.cbox_Tamanho.Name = "cbox_Tamanho";
            this.cbox_Tamanho.Size = new System.Drawing.Size(132, 29);
            this.cbox_Tamanho.TabIndex = 82;
            this.cbox_Tamanho.UseSelectable = true;
            // 
            // txt_nomeDog
            // 
            this.txt_nomeDog.Depth = 0;
            this.txt_nomeDog.Hint = "";
            this.txt_nomeDog.Location = new System.Drawing.Point(166, 142);
            this.txt_nomeDog.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nomeDog.Name = "txt_nomeDog";
            this.txt_nomeDog.PasswordChar = '\0';
            this.txt_nomeDog.SelectedText = "";
            this.txt_nomeDog.SelectionLength = 0;
            this.txt_nomeDog.SelectionStart = 0;
            this.txt_nomeDog.Size = new System.Drawing.Size(132, 23);
            this.txt_nomeDog.TabIndex = 81;
            this.txt_nomeDog.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 31);
            this.panel1.TabIndex = 98;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtt_sair,
            this.tsbtt_voltar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(720, 33);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtt_sair
            // 
            this.tsbtt_sair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtt_sair.AutoSize = false;
            this.tsbtt_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbtt_sair.BackgroundImage")));
            this.tsbtt_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtt_sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtt_sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtt_sair.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.tsbtt_sair.Name = "tsbtt_sair";
            this.tsbtt_sair.Size = new System.Drawing.Size(25, 30);
            this.tsbtt_sair.Text = "Sair";
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
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(378, 244);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(280, 110);
            this.txt_descricao.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(481, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 99;
            this.label9.Text = "Descrição";
            // 
            // btt_submeter
            // 
            this.btt_submeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_submeter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_submeter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btt_submeter.BorderRadius = 28;
            this.btt_submeter.BorderSize = 0;
            this.btt_submeter.FlatAppearance.BorderSize = 0;
            this.btt_submeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_submeter.ForeColor = System.Drawing.Color.White;
            this.btt_submeter.Location = new System.Drawing.Point(244, 416);
            this.btt_submeter.Name = "btt_submeter";
            this.btt_submeter.Size = new System.Drawing.Size(229, 53);
            this.btt_submeter.TabIndex = 101;
            this.btt_submeter.Text = "Submeter";
            this.btt_submeter.TextColor = System.Drawing.Color.White;
            this.btt_submeter.UseVisualStyleBackColor = false;
            this.btt_submeter.Click += new System.EventHandler(this.btt_submeter_Click);
            // 
            // Erros
            // 
            this.Erros.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 510);
            this.Controls.Add(this.btt_submeter);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbox_racaDog);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbox_Brinquedo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbox_Raiva);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gbox_Alergia);
            this.Controls.Add(this.gbox_Carinho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_Tamanho);
            this.Controls.Add(this.txt_nomeDog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.gbox_Brinquedo.ResumeLayout(false);
            this.gbox_Brinquedo.PerformLayout();
            this.gbox_Raiva.ResumeLayout(false);
            this.gbox_Raiva.PerformLayout();
            this.gbox_Alergia.ResumeLayout(false);
            this.gbox_Alergia.PerformLayout();
            this.gbox_Carinho.ResumeLayout(false);
            this.gbox_Carinho.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbox_racaDog;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbox_Brinquedo;
        private MetroFramework.Controls.MetroRadioButton rbtt_SimBrinquedo;
        private MetroFramework.Controls.MetroRadioButton rbtt_NaoBrinquedo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbox_Raiva;
        private MetroFramework.Controls.MetroRadioButton rbtt_Raiva5;
        private MetroFramework.Controls.MetroRadioButton rbtt_Raiva4;
        private MetroFramework.Controls.MetroRadioButton rbtt_Raiva3;
        private MetroFramework.Controls.MetroRadioButton rbtt_Raiva1;
        private MetroFramework.Controls.MetroRadioButton rbtt_Raiva2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbox_Alergia;
        private MetroFramework.Controls.MetroRadioButton rbtt_Simalergia;
        private MetroFramework.Controls.MetroRadioButton rbtt_Naoalergia;
        private System.Windows.Forms.GroupBox gbox_Carinho;
        private MetroFramework.Controls.MetroRadioButton rbtt_Simcarinho;
        private MetroFramework.Controls.MetroRadioButton rbtt_Naocarinho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cbox_Tamanho;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nomeDog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtt_sair;
        private System.Windows.Forms.ToolStripButton tsbtt_voltar;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label9;
        private Botao btt_submeter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider Erros;
    }
}