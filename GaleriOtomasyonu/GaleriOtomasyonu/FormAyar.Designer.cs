namespace GaleriOtomasyonu
{
    partial class FormAyar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAyar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textKullaniciA = new DevExpress.XtraEditors.TextEdit();
            this.textSifreA = new DevExpress.XtraEditors.TextEdit();
            this.BttnKaydet = new System.Windows.Forms.Button();
            this.BttnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKullaniciA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSifreA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(448, 152);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Silver;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(17, 180);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(25, 23);
            this.simpleButton1.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(17, 248);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(25, 23);
            this.simpleButton2.TabIndex = 4;
            // 
            // textKullaniciA
            // 
            this.textKullaniciA.Location = new System.Drawing.Point(17, 209);
            this.textKullaniciA.Name = "textKullaniciA";
            this.textKullaniciA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKullaniciA.Properties.Appearance.Options.UseFont = true;
            this.textKullaniciA.Size = new System.Drawing.Size(146, 24);
            this.textKullaniciA.TabIndex = 5;
            this.textKullaniciA.EditValueChanged += new System.EventHandler(this.textKullaniciA_EditValueChanged);
            // 
            // textSifreA
            // 
            this.textSifreA.Location = new System.Drawing.Point(17, 277);
            this.textSifreA.Name = "textSifreA";
            this.textSifreA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSifreA.Properties.Appearance.Options.UseFont = true;
            this.textSifreA.Size = new System.Drawing.Size(146, 24);
            this.textSifreA.TabIndex = 6;
            // 
            // BttnKaydet
            // 
            this.BttnKaydet.BackColor = System.Drawing.Color.Silver;
            this.BttnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BttnKaydet.Location = new System.Drawing.Point(17, 317);
            this.BttnKaydet.Name = "BttnKaydet";
            this.BttnKaydet.Size = new System.Drawing.Size(146, 36);
            this.BttnKaydet.TabIndex = 7;
            this.BttnKaydet.Text = "Kaydet";
            this.BttnKaydet.UseVisualStyleBackColor = false;
            this.BttnKaydet.Click += new System.EventHandler(this.BttnKaydet_Click);
            // 
            // BttnTemizle
            // 
            this.BttnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnTemizle.Appearance.Options.UseFont = true;
            this.BttnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnTemizle.ImageOptions.Image")));
            this.BttnTemizle.Location = new System.Drawing.Point(17, 359);
            this.BttnTemizle.Name = "BttnTemizle";
            this.BttnTemizle.Size = new System.Drawing.Size(146, 31);
            this.BttnTemizle.TabIndex = 8;
            this.BttnTemizle.Text = "Temizle";
            this.BttnTemizle.Click += new System.EventHandler(this.BttnTemizle_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(17, 396);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(146, 31);
            this.simpleButton3.TabIndex = 9;
            this.simpleButton3.Text = "Sil";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // FormAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 436);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.BttnTemizle);
            this.Controls.Add(this.BttnKaydet);
            this.Controls.Add(this.textSifreA);
            this.Controls.Add(this.textKullaniciA);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAyar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayar";
            this.Load += new System.EventHandler(this.FormAyar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKullaniciA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSifreA.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit textKullaniciA;
        private DevExpress.XtraEditors.TextEdit textSifreA;
        private System.Windows.Forms.Button BttnKaydet;
        private DevExpress.XtraEditors.SimpleButton BttnTemizle;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}