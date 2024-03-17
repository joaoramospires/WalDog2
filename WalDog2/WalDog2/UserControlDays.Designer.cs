namespace WalDog2
{
    partial class UserControlDays
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.pbox_marcacao = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.walDogDataSet = new WalDog2.WalDogDataSet();
            this.passeiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passeiosTA = new WalDog2.WalDogDataSetTableAdapters.PasseiosTA();
            this.tableAdapterManager = new WalDog2.WalDogDataSetTableAdapters.TableAdapterManager();
            this.passeiosTA1 = new WalDog2.WalDogDataSetTableAdapters.PasseiosTA();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_marcacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walDogDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passeiosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dia.Location = new System.Drawing.Point(12, 10);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(27, 20);
            this.lbl_dia.TabIndex = 22;
            this.lbl_dia.Text = "00";
            // 
            // pbox_marcacao
            // 
            this.pbox_marcacao.BackgroundImage = global::WalDog2.Properties.Resources.marcado2;
            this.pbox_marcacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbox_marcacao.Location = new System.Drawing.Point(66, 48);
            this.pbox_marcacao.Name = "pbox_marcacao";
            this.pbox_marcacao.Size = new System.Drawing.Size(46, 38);
            this.pbox_marcacao.TabIndex = 23;
            this.pbox_marcacao.TabStop = false;
            this.pbox_marcacao.Visible = false;
            this.pbox_marcacao.Click += new System.EventHandler(this.pbox_marcacao_Click);
            // 
            // walDogDataSet
            // 
            this.walDogDataSet.DataSetName = "WalDogDataSet";
            this.walDogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passeiosBindingSource
            // 
            this.passeiosBindingSource.DataMember = "Passeios";
            this.passeiosBindingSource.DataSource = this.walDogDataSet;
            // 
            // passeiosTA
            // 
            this.passeiosTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BancoDinheiroTA = null;
            this.tableAdapterManager.DogDadosTA = null;
            this.tableAdapterManager.LogarTA = null;
            this.tableAdapterManager.PagamentosTA = null;
            this.tableAdapterManager.PasseiosTA = this.passeiosTA;
            this.tableAdapterManager.TypeCaoTA = null;
            this.tableAdapterManager.UpdateOrder = WalDog2.WalDogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // passeiosTA1
            // 
            this.passeiosTA1.ClearBeforeFill = true;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pbox_marcacao);
            this.Controls.Add(this.lbl_dia);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(124, 97);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_marcacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walDogDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passeiosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.ToolTip toolTip1;
        private WalDogDataSet walDogDataSet;
        private System.Windows.Forms.BindingSource passeiosBindingSource;
        private WalDogDataSetTableAdapters.PasseiosTA passeiosTA;
        private WalDogDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private WalDogDataSetTableAdapters.PasseiosTA passeiosTA1;
        public System.Windows.Forms.PictureBox pbox_marcacao;
    }
}
