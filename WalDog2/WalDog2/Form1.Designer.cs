namespace WalDog2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtt_Sair = new System.Windows.Forms.ToolStripButton();
            this.txt_Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btt_cadastrar = new WalDog2.Botao();
            this.btt_entrar = new WalDog2.Botao();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logarTA = new WalDog2.WalDogDataSetTableAdapters.LogarTA();
            this.dogDadosTA = new WalDog2.WalDogDataSetTableAdapters.DogDadosTA();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 31);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtt_Sair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(353, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtt_Sair
            // 
            this.tsBtt_Sair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtt_Sair.AutoSize = false;
            this.tsBtt_Sair.BackgroundImage = global::WalDog2.Properties.Resources.saai;
            this.tsBtt_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsBtt_Sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtt_Sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtt_Sair.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.tsBtt_Sair.Name = "tsBtt_Sair";
            this.tsBtt_Sair.Size = new System.Drawing.Size(25, 30);
            this.tsBtt_Sair.Text = "Sair";
            this.tsBtt_Sair.Click += new System.EventHandler(this.tsBtt_Sair_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Depth = 0;
            this.txt_Password.Hint = "Password";
            this.txt_Password.Location = new System.Drawing.Point(65, 154);
            this.txt_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.SelectedText = "";
            this.txt_Password.SelectionLength = 0;
            this.txt_Password.SelectionStart = 0;
            this.txt_Password.Size = new System.Drawing.Size(217, 23);
            this.txt_Password.TabIndex = 6;
            this.txt_Password.UseSystemPasswordChar = false;
            this.txt_Password.Visible = false;
            // 
            // txt_Username
            // 
            this.txt_Username.Depth = 0;
            this.txt_Username.Hint = "Username";
            this.txt_Username.Location = new System.Drawing.Point(65, 83);
            this.txt_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.SelectedText = "";
            this.txt_Username.SelectionLength = 0;
            this.txt_Username.SelectionStart = 0;
            this.txt_Username.Size = new System.Drawing.Size(217, 23);
            this.txt_Username.TabIndex = 5;
            this.txt_Username.UseSystemPasswordChar = false;
            this.txt_Username.Visible = false;
            // 
            // btt_cadastrar
            // 
            this.btt_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_cadastrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_cadastrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btt_cadastrar.BorderRadius = 20;
            this.btt_cadastrar.BorderSize = 0;
            this.btt_cadastrar.FlatAppearance.BorderSize = 0;
            this.btt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btt_cadastrar.Location = new System.Drawing.Point(30, 237);
            this.btt_cadastrar.Name = "btt_cadastrar";
            this.btt_cadastrar.Size = new System.Drawing.Size(107, 41);
            this.btt_cadastrar.TabIndex = 7;
            this.btt_cadastrar.Text = "Cadastrar";
            this.btt_cadastrar.TextColor = System.Drawing.Color.White;
            this.btt_cadastrar.UseVisualStyleBackColor = false;
            this.btt_cadastrar.Click += new System.EventHandler(this.btt_cadastrar_Click);
            // 
            // btt_entrar
            // 
            this.btt_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_entrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_entrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btt_entrar.BorderRadius = 20;
            this.btt_entrar.BorderSize = 0;
            this.btt_entrar.FlatAppearance.BorderSize = 0;
            this.btt_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_entrar.ForeColor = System.Drawing.Color.White;
            this.btt_entrar.Location = new System.Drawing.Point(204, 237);
            this.btt_entrar.Name = "btt_entrar";
            this.btt_entrar.Size = new System.Drawing.Size(107, 41);
            this.btt_entrar.TabIndex = 8;
            this.btt_entrar.Text = "Entrar";
            this.btt_entrar.TextColor = System.Drawing.Color.White;
            this.btt_entrar.UseVisualStyleBackColor = false;
            this.btt_entrar.Click += new System.EventHandler(this.btt_entrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WalDog2.Properties.Resources.WallDog;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 362);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logarTA
            // 
            this.logarTA.ClearBeforeFill = true;
            // 
            // dogDadosTA
            // 
            this.dogDadosTA.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btt_entrar);
            this.Controls.Add(this.btt_cadastrar);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtt_Sair;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Password;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Username;
        private Botao btt_cadastrar;
        private Botao btt_entrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private WalDogDataSetTableAdapters.LogarTA logarTA;
        private WalDogDataSetTableAdapters.DogDadosTA dogDadosTA;
    }
}

