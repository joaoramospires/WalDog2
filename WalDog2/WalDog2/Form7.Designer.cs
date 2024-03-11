namespace WalDog2
{
    partial class Form7
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtt_sair = new System.Windows.Forms.ToolStripButton();
            this.tsbtt_voltar = new System.Windows.Forms.ToolStripButton();
            this.mtxt_validadeCartao = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxt_numCartao = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxt_cvc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxt_nif = new System.Windows.Forms.MaskedTextBox();
            this.txt_valorConta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_nome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btt_adCartao = new WalDog2.Botao();
            this.Erros = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 31);
            this.panel1.TabIndex = 8;
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
            this.toolStrip2.Size = new System.Drawing.Size(318, 33);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtt_sair
            // 
            this.tsbtt_sair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtt_sair.AutoSize = false;
            this.tsbtt_sair.BackgroundImage = global::WalDog2.Properties.Resources.saai;
            this.tsbtt_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbtt_sair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtt_sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtt_sair.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.tsbtt_sair.Name = "tsbtt_sair";
            this.tsbtt_sair.Size = new System.Drawing.Size(25, 30);
            this.tsbtt_sair.Text = "Sair";
            this.tsbtt_sair.Click += new System.EventHandler(this.tsbtt_sair_Click);
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
            // mtxt_validadeCartao
            // 
            this.mtxt_validadeCartao.Location = new System.Drawing.Point(125, 231);
            this.mtxt_validadeCartao.Mask = "00/0000";
            this.mtxt_validadeCartao.Name = "mtxt_validadeCartao";
            this.mtxt_validadeCartao.Size = new System.Drawing.Size(60, 20);
            this.mtxt_validadeCartao.TabIndex = 65;
            this.mtxt_validadeCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_validadeCartao.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 64;
            this.label9.Text = "Valor da Conta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 63;
            this.label8.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 62;
            this.label4.Text = "Validade\r\n  Cartão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 32);
            this.label3.TabIndex = 61;
            this.label3.Text = "Número\r\n Cartão";
            // 
            // mtxt_numCartao
            // 
            this.mtxt_numCartao.Location = new System.Drawing.Point(125, 171);
            this.mtxt_numCartao.Mask = "0000-0000-0000-0000";
            this.mtxt_numCartao.Name = "mtxt_numCartao";
            this.mtxt_numCartao.Size = new System.Drawing.Size(119, 20);
            this.mtxt_numCartao.TabIndex = 60;
            this.mtxt_numCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "CVV/CVC";
            // 
            // mtxt_cvc
            // 
            this.mtxt_cvc.Location = new System.Drawing.Point(125, 284);
            this.mtxt_cvc.Mask = "0000";
            this.mtxt_cvc.Name = "mtxt_cvc";
            this.mtxt_cvc.Size = new System.Drawing.Size(46, 20);
            this.mtxt_cvc.TabIndex = 58;
            this.mtxt_cvc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "NIF";
            // 
            // mtxt_nif
            // 
            this.mtxt_nif.Location = new System.Drawing.Point(125, 114);
            this.mtxt_nif.Mask = "000000000";
            this.mtxt_nif.Name = "mtxt_nif";
            this.mtxt_nif.Size = new System.Drawing.Size(61, 20);
            this.mtxt_nif.TabIndex = 56;
            this.mtxt_nif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_valorConta
            // 
            this.txt_valorConta.Depth = 0;
            this.txt_valorConta.Hint = "";
            this.txt_valorConta.Location = new System.Drawing.Point(125, 330);
            this.txt_valorConta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_valorConta.Name = "txt_valorConta";
            this.txt_valorConta.PasswordChar = '\0';
            this.txt_valorConta.SelectedText = "";
            this.txt_valorConta.SelectionLength = 0;
            this.txt_valorConta.SelectionStart = 0;
            this.txt_valorConta.Size = new System.Drawing.Size(144, 23);
            this.txt_valorConta.TabIndex = 55;
            this.txt_valorConta.UseSystemPasswordChar = false;
            // 
            // txt_nome
            // 
            this.txt_nome.Depth = 0;
            this.txt_nome.Hint = "";
            this.txt_nome.Location = new System.Drawing.Point(125, 58);
            this.txt_nome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.PasswordChar = '\0';
            this.txt_nome.SelectedText = "";
            this.txt_nome.SelectionLength = 0;
            this.txt_nome.SelectionStart = 0;
            this.txt_nome.Size = new System.Drawing.Size(144, 23);
            this.txt_nome.TabIndex = 54;
            this.txt_nome.UseSystemPasswordChar = false;
            // 
            // btt_adCartao
            // 
            this.btt_adCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_adCartao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_adCartao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btt_adCartao.BorderRadius = 27;
            this.btt_adCartao.BorderSize = 0;
            this.btt_adCartao.FlatAppearance.BorderSize = 0;
            this.btt_adCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_adCartao.ForeColor = System.Drawing.Color.White;
            this.btt_adCartao.Location = new System.Drawing.Point(26, 384);
            this.btt_adCartao.Name = "btt_adCartao";
            this.btt_adCartao.Size = new System.Drawing.Size(243, 53);
            this.btt_adCartao.TabIndex = 66;
            this.btt_adCartao.Text = "Adicionar cartão";
            this.btt_adCartao.TextColor = System.Drawing.Color.White;
            this.btt_adCartao.UseVisualStyleBackColor = false;
            this.btt_adCartao.Click += new System.EventHandler(this.btt_adCartao_Click);
            // 
            // Erros
            // 
            this.Erros.ContainerControl = this;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 460);
            this.Controls.Add(this.btt_adCartao);
            this.Controls.Add(this.mtxt_validadeCartao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtxt_numCartao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxt_cvc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxt_nif);
            this.Controls.Add(this.txt_valorConta);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtt_sair;
        private System.Windows.Forms.ToolStripButton tsbtt_voltar;
        private System.Windows.Forms.MaskedTextBox mtxt_validadeCartao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxt_numCartao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxt_cvc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxt_nif;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_valorConta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nome;
        private Botao btt_adCartao;
        private System.Windows.Forms.ErrorProvider Erros;
    }
}