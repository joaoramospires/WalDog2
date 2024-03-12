namespace WalDog2
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtt_Sair = new System.Windows.Forms.ToolStripButton();
            this.tsbtt_voltar = new System.Windows.Forms.ToolStripButton();
            this.mtxt_numCartao = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_validadeCartao = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxt_cvc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxt_nif = new System.Windows.Forms.MaskedTextBox();
            this.txt_valorConta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_nome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_confirmPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.btt_cadastrar = new WalDog2.Botao();
            this.logarTA = new WalDog2.WalDogDataSetTableAdapters.LogarTA();
            this.pagamentosTA = new WalDog2.WalDogDataSetTableAdapters.PagamentosTA();
            this.bancoDinheiroTA = new WalDog2.WalDogDataSetTableAdapters.BancoDinheiroTA();
            this.walDogDataSet = new WalDog2.WalDogDataSet();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walDogDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 31);
            this.panel1.TabIndex = 44;
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
            this.toolStrip1.Size = new System.Drawing.Size(394, 33);
            this.toolStrip1.TabIndex = 1;
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
            // tsbtt_voltar
            // 
            this.tsbtt_voltar.BackgroundImage = global::WalDog2.Properties.Resources.voltar2;
            this.tsbtt_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtt_voltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtt_voltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtt_voltar.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tsbtt_voltar.Name = "tsbtt_voltar";
            this.tsbtt_voltar.Size = new System.Drawing.Size(23, 30);
            this.tsbtt_voltar.Text = "Voltar";
            this.tsbtt_voltar.Click += new System.EventHandler(this.tsbtt_voltar_Click);
            // 
            // mtxt_numCartao
            // 
            this.mtxt_numCartao.Location = new System.Drawing.Point(156, 362);
            this.mtxt_numCartao.Mask = "0000-0000-0000-0000";
            this.mtxt_numCartao.Name = "mtxt_numCartao";
            this.mtxt_numCartao.Size = new System.Drawing.Size(117, 20);
            this.mtxt_numCartao.TabIndex = 64;
            // 
            // mtxt_validadeCartao
            // 
            this.mtxt_validadeCartao.Location = new System.Drawing.Point(156, 424);
            this.mtxt_validadeCartao.Mask = "00/0000";
            this.mtxt_validadeCartao.Name = "mtxt_validadeCartao";
            this.mtxt_validadeCartao.Size = new System.Drawing.Size(60, 20);
            this.mtxt_validadeCartao.TabIndex = 63;
            this.mtxt_validadeCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_validadeCartao.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Valor da Conta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 32);
            this.label7.TabIndex = 60;
            this.label7.Text = "Confirmar \r\npassword";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 32);
            this.label4.TabIndex = 57;
            this.label4.Text = "Validade  \r\n  Cartão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 32);
            this.label3.TabIndex = 56;
            this.label3.Text = "Número\r\n Cartão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "CVV/CVC";
            // 
            // mtxt_cvc
            // 
            this.mtxt_cvc.Location = new System.Drawing.Point(156, 470);
            this.mtxt_cvc.Mask = "0000";
            this.mtxt_cvc.Name = "mtxt_cvc";
            this.mtxt_cvc.Size = new System.Drawing.Size(46, 20);
            this.mtxt_cvc.TabIndex = 54;
            this.mtxt_cvc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "NIF";
            // 
            // mtxt_nif
            // 
            this.mtxt_nif.Location = new System.Drawing.Point(156, 292);
            this.mtxt_nif.Mask = "000000000";
            this.mtxt_nif.Name = "mtxt_nif";
            this.mtxt_nif.Size = new System.Drawing.Size(61, 20);
            this.mtxt_nif.TabIndex = 52;
            this.mtxt_nif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_valorConta
            // 
            this.txt_valorConta.Depth = 0;
            this.txt_valorConta.Hint = "";
            this.txt_valorConta.Location = new System.Drawing.Point(156, 517);
            this.txt_valorConta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_valorConta.Name = "txt_valorConta";
            this.txt_valorConta.PasswordChar = '\0';
            this.txt_valorConta.SelectedText = "";
            this.txt_valorConta.SelectionLength = 0;
            this.txt_valorConta.SelectionStart = 0;
            this.txt_valorConta.Size = new System.Drawing.Size(144, 23);
            this.txt_valorConta.TabIndex = 51;
            this.txt_valorConta.UseSystemPasswordChar = false;
            // 
            // txt_nome
            // 
            this.txt_nome.Depth = 0;
            this.txt_nome.Hint = "";
            this.txt_nome.Location = new System.Drawing.Point(156, 236);
            this.txt_nome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.SelectedText = "";
            this.txt_nome.SelectionLength = 0;
            this.txt_nome.SelectionStart = 0;
            this.txt_nome.Size = new System.Drawing.Size(144, 23);
            this.txt_nome.TabIndex = 50;
            this.txt_nome.UseSystemPasswordChar = false;
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.Depth = 0;
            this.txt_confirmPassword.Hint = "";
            this.txt_confirmPassword.Location = new System.Drawing.Point(156, 182);
            this.txt_confirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.PasswordChar = '\0';
            this.txt_confirmPassword.SelectedText = "";
            this.txt_confirmPassword.SelectionLength = 0;
            this.txt_confirmPassword.SelectionStart = 0;
            this.txt_confirmPassword.Size = new System.Drawing.Size(144, 23);
            this.txt_confirmPassword.TabIndex = 49;
            this.txt_confirmPassword.UseSystemPasswordChar = false;
            // 
            // txt_password
            // 
            this.txt_password.Depth = 0;
            this.txt_password.Hint = "";
            this.txt_password.Location = new System.Drawing.Point(156, 131);
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(144, 23);
            this.txt_password.TabIndex = 48;
            this.txt_password.UseSystemPasswordChar = false;
            // 
            // txt_username
            // 
            this.txt_username.Depth = 0;
            this.txt_username.Hint = "";
            this.txt_username.Location = new System.Drawing.Point(156, 85);
            this.txt_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.Size = new System.Drawing.Size(144, 23);
            this.txt_username.TabIndex = 47;
            this.txt_username.UseSystemPasswordChar = false;
            // 
            // Erros
            // 
            this.Erros.ContainerControl = this;
            // 
            // btt_cadastrar
            // 
            this.btt_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_cadastrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_cadastrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btt_cadastrar.BorderRadius = 27;
            this.btt_cadastrar.BorderSize = 0;
            this.btt_cadastrar.FlatAppearance.BorderSize = 0;
            this.btt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btt_cadastrar.Location = new System.Drawing.Point(57, 576);
            this.btt_cadastrar.Name = "btt_cadastrar";
            this.btt_cadastrar.Size = new System.Drawing.Size(243, 53);
            this.btt_cadastrar.TabIndex = 65;
            this.btt_cadastrar.Text = "Cadastrar";
            this.btt_cadastrar.TextColor = System.Drawing.Color.White;
            this.btt_cadastrar.UseVisualStyleBackColor = false;
            this.btt_cadastrar.Click += new System.EventHandler(this.btt_cadastrar_Click);
            // 
            // logarTA
            // 
            this.logarTA.ClearBeforeFill = true;
            // 
            // pagamentosTA
            // 
            this.pagamentosTA.ClearBeforeFill = true;
            // 
            // bancoDinheiroTA
            // 
            this.bancoDinheiroTA.ClearBeforeFill = true;
            // 
            // walDogDataSet
            // 
            this.walDogDataSet.DataSetName = "WalDogDataSet";
            this.walDogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 658);
            this.Controls.Add(this.btt_cadastrar);
            this.Controls.Add(this.mtxt_numCartao);
            this.Controls.Add(this.mtxt_validadeCartao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxt_cvc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxt_nif);
            this.Controls.Add(this.txt_valorConta);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walDogDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtt_Sair;
        private System.Windows.Forms.ToolStripButton tsbtt_voltar;
        private System.Windows.Forms.MaskedTextBox mtxt_numCartao;
        private System.Windows.Forms.MaskedTextBox mtxt_validadeCartao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxt_cvc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxt_nif;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_valorConta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_confirmPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_username;
        private Botao btt_cadastrar;
        private System.Windows.Forms.ErrorProvider Erros;
        private WalDogDataSetTableAdapters.LogarTA logarTA;
        private WalDogDataSetTableAdapters.PagamentosTA pagamentosTA;
        private WalDogDataSetTableAdapters.BancoDinheiroTA bancoDinheiroTA;
        private WalDogDataSet walDogDataSet;
    }
}