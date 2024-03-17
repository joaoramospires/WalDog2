namespace WalDog2
{
    partial class Form6
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtt_sair = new System.Windows.Forms.ToolStripButton();
            this.tsbtt_voltar = new System.Windows.Forms.ToolStripButton();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dayContanier = new System.Windows.Forms.FlowLayoutPanel();
            this.btt_previous = new WalDog2.Botao();
            this.btt_next = new WalDog2.Botao();
            this.passeiosTA = new WalDog2.WalDogDataSetTableAdapters.PasseiosTA();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 31);
            this.panel1.TabIndex = 4;
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
            this.toolStrip2.Size = new System.Drawing.Size(935, 33);
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
            // lbl_ano
            // 
            this.lbl_ano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ano.Location = new System.Drawing.Point(302, 45);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(334, 35);
            this.lbl_ano.TabIndex = 75;
            this.lbl_ano.Text = "Ano";
            this.lbl_ano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Domingo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(827, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "Sábado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(694, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 80;
            this.label5.Text = "Sexta-Feira";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(556, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Quinta-Feira";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 83;
            this.label3.Text = "Quarta-Feira";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 82;
            this.label2.Text = "Terça-Feira";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Segunda-Feira";
            // 
            // dayContanier
            // 
            this.dayContanier.Location = new System.Drawing.Point(12, 134);
            this.dayContanier.Name = "dayContanier";
            this.dayContanier.Size = new System.Drawing.Size(912, 626);
            this.dayContanier.TabIndex = 76;
            // 
            // btt_previous
            // 
            this.btt_previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_previous.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_previous.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btt_previous.BorderRadius = 10;
            this.btt_previous.BorderSize = 0;
            this.btt_previous.FlatAppearance.BorderSize = 0;
            this.btt_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btt_previous.ForeColor = System.Drawing.Color.White;
            this.btt_previous.Location = new System.Drawing.Point(29, 45);
            this.btt_previous.Name = "btt_previous";
            this.btt_previous.Size = new System.Drawing.Size(41, 35);
            this.btt_previous.TabIndex = 84;
            this.btt_previous.Text = "<";
            this.btt_previous.TextColor = System.Drawing.Color.White;
            this.btt_previous.UseVisualStyleBackColor = false;
            this.btt_previous.Click += new System.EventHandler(this.btt_previous_Click);
            // 
            // btt_next
            // 
            this.btt_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_next.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(135)))), ((int)(((byte)(50)))));
            this.btt_next.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btt_next.BorderRadius = 10;
            this.btt_next.BorderSize = 0;
            this.btt_next.FlatAppearance.BorderSize = 0;
            this.btt_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btt_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btt_next.ForeColor = System.Drawing.Color.White;
            this.btt_next.Location = new System.Drawing.Point(842, 45);
            this.btt_next.Name = "btt_next";
            this.btt_next.Size = new System.Drawing.Size(41, 35);
            this.btt_next.TabIndex = 85;
            this.btt_next.Text = " >";
            this.btt_next.TextColor = System.Drawing.Color.White;
            this.btt_next.UseVisualStyleBackColor = false;
            this.btt_next.Click += new System.EventHandler(this.btt_next_Click);
            // 
            // passeiosTA
            // 
            this.passeiosTA.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 777);
            this.Controls.Add(this.btt_next);
            this.Controls.Add(this.btt_previous);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayContanier);
            this.Controls.Add(this.lbl_ano);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtt_sair;
        private System.Windows.Forms.ToolStripButton tsbtt_voltar;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel dayContanier;
        private Botao btt_previous;
        private Botao btt_next;
        private WalDogDataSetTableAdapters.PasseiosTA passeiosTA;
    }
}