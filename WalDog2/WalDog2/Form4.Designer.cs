namespace WalDog2.Resources
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtt_Sair = new System.Windows.Forms.ToolStripButton();
            this.cBox_procurarDog = new System.Windows.Forms.ComboBox();
            this.dogDadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.walDogDataSet = new WalDog2.WalDogDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtt_Simalergia = new MetroFramework.Controls.MetroRadioButton();
            this.rbtt_Naoalergia = new MetroFramework.Controls.MetroRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_racaCao = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dogDadosTA = new WalDog2.WalDogDataSetTableAdapters.DogDadosTA();
            this.btt_trocarConta = new WalDog2.Botao();
            this.btt_verPasseios = new WalDog2.Botao();
            this.btt_doPasseio = new WalDog2.Botao();
            this.btt_adCartao = new WalDog2.Botao();
            this.btt_adAumigo = new WalDog2.Botao();
            this.btt_mais = new WalDog2.Botao();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogDadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walDogDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 31);
            this.panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtt_Sair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(459, 33);
            this.toolStrip1.TabIndex = 0;
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
            // cBox_procurarDog
            // 
            this.cBox_procurarDog.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBox_procurarDog.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBox_procurarDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_procurarDog.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dogDadosBindingSource, "nameDog", true));
            this.cBox_procurarDog.DataSource = this.dogDadosBindingSource;
            this.cBox_procurarDog.DisplayMember = "nameDog";
            this.cBox_procurarDog.Enabled = false;
            this.cBox_procurarDog.FormattingEnabled = true;
            this.cBox_procurarDog.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cBox_procurarDog.IntegralHeight = false;
            this.cBox_procurarDog.Location = new System.Drawing.Point(52, 53);
            this.cBox_procurarDog.Name = "cBox_procurarDog";
            this.cBox_procurarDog.Size = new System.Drawing.Size(124, 21);
            this.cBox_procurarDog.TabIndex = 12;
            this.cBox_procurarDog.SelectedIndexChanged += new System.EventHandler(this.cBox_procurarDog_SelectedIndexChanged);
            // 
            // dogDadosBindingSource
            // 
            this.dogDadosBindingSource.DataMember = "DogDados";
            this.dogDadosBindingSource.DataSource = this.walDogDataSet;
            // 
            // walDogDataSet
            // 
            this.walDogDataSet.DataSetName = "WalDogDataSet";
            this.walDogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_descricao);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_racaCao);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 212);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Enabled = false;
            this.txt_descricao.Location = new System.Drawing.Point(117, 126);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(229, 58);
            this.txt_descricao.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Descrição";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtt_Simalergia);
            this.groupBox4.Controls.Add(this.rbtt_Naoalergia);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox4.Enabled = false;
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(117, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(116, 40);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Alergia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Raça do Dog";
            // 
            // lbl_racaCao
            // 
            this.lbl_racaCao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_racaCao.Enabled = false;
            this.lbl_racaCao.Location = new System.Drawing.Point(117, 36);
            this.lbl_racaCao.Name = "lbl_racaCao";
            this.lbl_racaCao.Size = new System.Drawing.Size(116, 20);
            this.lbl_racaCao.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WalDog2.Properties.Resources.lupa;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(26, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // dogDadosTA
            // 
            this.dogDadosTA.ClearBeforeFill = true;
            // 
            // btt_trocarConta
            // 
            this.btt_trocarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_trocarConta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_trocarConta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.btt_trocarConta.BorderRadius = 27;
            this.btt_trocarConta.BorderSize = 1;
            this.btt_trocarConta.FlatAppearance.BorderSize = 0;
            this.btt_trocarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_trocarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_trocarConta.ForeColor = System.Drawing.Color.White;
            this.btt_trocarConta.Location = new System.Drawing.Point(281, 381);
            this.btt_trocarConta.Name = "btt_trocarConta";
            this.btt_trocarConta.Size = new System.Drawing.Size(90, 53);
            this.btt_trocarConta.TabIndex = 18;
            this.btt_trocarConta.Text = "Sair";
            this.btt_trocarConta.TextColor = System.Drawing.Color.White;
            this.btt_trocarConta.UseVisualStyleBackColor = false;
            this.btt_trocarConta.Click += new System.EventHandler(this.btt_trocarConta_Click);
            // 
            // btt_verPasseios
            // 
            this.btt_verPasseios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_verPasseios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_verPasseios.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.btt_verPasseios.BorderRadius = 27;
            this.btt_verPasseios.BorderSize = 1;
            this.btt_verPasseios.FlatAppearance.BorderSize = 0;
            this.btt_verPasseios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_verPasseios.ForeColor = System.Drawing.Color.White;
            this.btt_verPasseios.Location = new System.Drawing.Point(89, 381);
            this.btt_verPasseios.Name = "btt_verPasseios";
            this.btt_verPasseios.Size = new System.Drawing.Size(90, 53);
            this.btt_verPasseios.TabIndex = 17;
            this.btt_verPasseios.Text = "Ver Passeios";
            this.btt_verPasseios.TextColor = System.Drawing.Color.White;
            this.btt_verPasseios.UseVisualStyleBackColor = false;
            this.btt_verPasseios.Click += new System.EventHandler(this.btt_verPasseios_Click);
            // 
            // btt_doPasseio
            // 
            this.btt_doPasseio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_doPasseio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_doPasseio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.btt_doPasseio.BorderRadius = 27;
            this.btt_doPasseio.BorderSize = 1;
            this.btt_doPasseio.FlatAppearance.BorderSize = 0;
            this.btt_doPasseio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_doPasseio.ForeColor = System.Drawing.Color.White;
            this.btt_doPasseio.Location = new System.Drawing.Point(281, 317);
            this.btt_doPasseio.Name = "btt_doPasseio";
            this.btt_doPasseio.Size = new System.Drawing.Size(90, 53);
            this.btt_doPasseio.TabIndex = 16;
            this.btt_doPasseio.Text = "Realizar Passeio";
            this.btt_doPasseio.TextColor = System.Drawing.Color.White;
            this.btt_doPasseio.UseVisualStyleBackColor = false;
            this.btt_doPasseio.Click += new System.EventHandler(this.btt_doPasseio_Click);
            // 
            // btt_adCartao
            // 
            this.btt_adCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_adCartao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_adCartao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.btt_adCartao.BorderRadius = 27;
            this.btt_adCartao.BorderSize = 1;
            this.btt_adCartao.FlatAppearance.BorderSize = 0;
            this.btt_adCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_adCartao.ForeColor = System.Drawing.Color.White;
            this.btt_adCartao.Location = new System.Drawing.Point(185, 381);
            this.btt_adCartao.Name = "btt_adCartao";
            this.btt_adCartao.Size = new System.Drawing.Size(90, 53);
            this.btt_adCartao.TabIndex = 15;
            this.btt_adCartao.Text = "Adicionar Cartão";
            this.btt_adCartao.TextColor = System.Drawing.Color.White;
            this.btt_adCartao.UseVisualStyleBackColor = false;
            this.btt_adCartao.Click += new System.EventHandler(this.btt_adCartao_Click);
            // 
            // btt_adAumigo
            // 
            this.btt_adAumigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_adAumigo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_adAumigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.btt_adAumigo.BorderRadius = 27;
            this.btt_adAumigo.BorderSize = 1;
            this.btt_adAumigo.FlatAppearance.BorderSize = 0;
            this.btt_adAumigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_adAumigo.ForeColor = System.Drawing.Color.White;
            this.btt_adAumigo.Location = new System.Drawing.Point(89, 317);
            this.btt_adAumigo.Name = "btt_adAumigo";
            this.btt_adAumigo.Size = new System.Drawing.Size(90, 53);
            this.btt_adAumigo.TabIndex = 14;
            this.btt_adAumigo.Text = "Adicionar um AUmigo";
            this.btt_adAumigo.TextColor = System.Drawing.Color.White;
            this.btt_adAumigo.UseVisualStyleBackColor = false;
            this.btt_adAumigo.Click += new System.EventHandler(this.btt_adAumigo_Click);
            // 
            // btt_mais
            // 
            this.btt_mais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_mais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_mais.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(111)))), ((int)(((byte)(71)))));
            this.btt_mais.BorderRadius = 10;
            this.btt_mais.BorderSize = 2;
            this.btt_mais.FlatAppearance.BorderSize = 0;
            this.btt_mais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_mais.ForeColor = System.Drawing.Color.White;
            this.btt_mais.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btt_mais.Location = new System.Drawing.Point(203, 317);
            this.btt_mais.Name = "btt_mais";
            this.btt_mais.Size = new System.Drawing.Size(53, 50);
            this.btt_mais.TabIndex = 13;
            this.btt_mais.Text = "+";
            this.btt_mais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btt_mais.TextColor = System.Drawing.Color.White;
            this.btt_mais.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 445);
            this.Controls.Add(this.btt_trocarConta);
            this.Controls.Add(this.btt_verPasseios);
            this.Controls.Add(this.btt_doPasseio);
            this.Controls.Add(this.btt_adCartao);
            this.Controls.Add(this.btt_adAumigo);
            this.Controls.Add(this.btt_mais);
            this.Controls.Add(this.cBox_procurarDog);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogDadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walDogDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtt_Sair;
        private System.Windows.Forms.ComboBox cBox_procurarDog;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroRadioButton rbtt_Simalergia;
        private MetroFramework.Controls.MetroRadioButton rbtt_Naoalergia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_racaCao;
        private Botao btt_mais;
        private Botao btt_adAumigo;
        private Botao btt_adCartao;
        private Botao btt_doPasseio;
        private Botao btt_verPasseios;
        private Botao btt_trocarConta;
        private System.Windows.Forms.ToolTip toolTip1;
        private WalDogDataSetTableAdapters.DogDadosTA dogDadosTA;
        private WalDogDataSet walDogDataSet;
        private System.Windows.Forms.BindingSource dogDadosBindingSource;
    }
}