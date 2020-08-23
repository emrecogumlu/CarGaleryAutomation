namespace GaleriOtomasyonu
{
    partial class FormNot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNot));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.BttnTemizleN = new DevExpress.XtraEditors.SimpleButton();
            this.textKonuN = new DevExpress.XtraEditors.TextEdit();
            this.maskedSaatN = new System.Windows.Forms.MaskedTextBox();
            this.maskedTarihN = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BttnGuncelleN = new DevExpress.XtraEditors.SimpleButton();
            this.BttnSilN = new DevExpress.XtraEditors.SimpleButton();
            this.BttnKaydetN = new DevExpress.XtraEditors.SimpleButton();
            this.richDetayN = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textKimdenN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textKimeN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textIdN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKonuN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textKimdenN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKimeN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textIdN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, -1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1083, 751);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // BttnTemizleN
            // 
            this.BttnTemizleN.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnTemizleN.Appearance.Options.UseFont = true;
            this.BttnTemizleN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnTemizleN.ImageOptions.Image")));
            this.BttnTemizleN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BttnTemizleN.ImageOptions.SvgImage")));
            this.BttnTemizleN.Location = new System.Drawing.Point(98, 455);
            this.BttnTemizleN.Name = "BttnTemizleN";
            this.BttnTemizleN.Size = new System.Drawing.Size(156, 32);
            this.BttnTemizleN.TabIndex = 30;
            this.BttnTemizleN.Text = "TEMİZLE";
            this.BttnTemizleN.Click += new System.EventHandler(this.BttnTemizleN_Click);
            // 
            // textKonuN
            // 
            this.textKonuN.Location = new System.Drawing.Point(98, 148);
            this.textKonuN.Name = "textKonuN";
            this.textKonuN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKonuN.Properties.Appearance.Options.UseFont = true;
            this.textKonuN.Size = new System.Drawing.Size(156, 24);
            this.textKonuN.TabIndex = 3;
            // 
            // maskedSaatN
            // 
            this.maskedSaatN.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedSaatN.Location = new System.Drawing.Point(100, 116);
            this.maskedSaatN.Mask = "00:00";
            this.maskedSaatN.Name = "maskedSaatN";
            this.maskedSaatN.Size = new System.Drawing.Size(154, 26);
            this.maskedSaatN.TabIndex = 2;
            this.maskedSaatN.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTarihN
            // 
            this.maskedTarihN.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTarihN.Location = new System.Drawing.Point(98, 83);
            this.maskedTarihN.Mask = "00/00/0000";
            this.maskedTarihN.Name = "maskedTarihN";
            this.maskedTarihN.Size = new System.Drawing.Size(156, 26);
            this.maskedTarihN.TabIndex = 1;
            this.maskedTarihN.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(26, 189);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(64, 19);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "KİMDEN:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(41, 153);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 19);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "KONU:";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.BttnTemizleN);
            this.groupControl1.Controls.Add(this.textKonuN);
            this.groupControl1.Controls.Add(this.maskedSaatN);
            this.groupControl1.Controls.Add(this.maskedTarihN);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.BttnGuncelleN);
            this.groupControl1.Controls.Add(this.BttnSilN);
            this.groupControl1.Controls.Add(this.BttnKaydetN);
            this.groupControl1.Controls.Add(this.richDetayN);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.textKimdenN);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textKimeN);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textIdN);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1077, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(292, 751);
            this.groupControl1.TabIndex = 5;
            // 
            // BttnGuncelleN
            // 
            this.BttnGuncelleN.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnGuncelleN.Appearance.Options.UseFont = true;
            this.BttnGuncelleN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnGuncelleN.ImageOptions.Image")));
            this.BttnGuncelleN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BttnGuncelleN.ImageOptions.SvgImage")));
            this.BttnGuncelleN.Location = new System.Drawing.Point(98, 417);
            this.BttnGuncelleN.Name = "BttnGuncelleN";
            this.BttnGuncelleN.Size = new System.Drawing.Size(156, 32);
            this.BttnGuncelleN.TabIndex = 20;
            this.BttnGuncelleN.Text = "GÜNCELLE";
            this.BttnGuncelleN.Click += new System.EventHandler(this.BttnGuncelleN_Click);
            // 
            // BttnSilN
            // 
            this.BttnSilN.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnSilN.Appearance.Options.UseFont = true;
            this.BttnSilN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnSilN.ImageOptions.Image")));
            this.BttnSilN.Location = new System.Drawing.Point(98, 379);
            this.BttnSilN.Name = "BttnSilN";
            this.BttnSilN.Size = new System.Drawing.Size(156, 32);
            this.BttnSilN.TabIndex = 19;
            this.BttnSilN.Text = "SİL";
            this.BttnSilN.Click += new System.EventHandler(this.BttnSilN_Click);
            // 
            // BttnKaydetN
            // 
            this.BttnKaydetN.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnKaydetN.Appearance.Options.UseFont = true;
            this.BttnKaydetN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnKaydetN.ImageOptions.Image")));
            this.BttnKaydetN.Location = new System.Drawing.Point(98, 341);
            this.BttnKaydetN.Name = "BttnKaydetN";
            this.BttnKaydetN.Size = new System.Drawing.Size(156, 32);
            this.BttnKaydetN.TabIndex = 18;
            this.BttnKaydetN.Text = "KAYDET";
            this.BttnKaydetN.Click += new System.EventHandler(this.BttnKaydetN_Click);
            // 
            // richDetayN
            // 
            this.richDetayN.Location = new System.Drawing.Point(98, 254);
            this.richDetayN.Name = "richDetayN";
            this.richDetayN.Size = new System.Drawing.Size(156, 68);
            this.richDetayN.TabIndex = 6;
            this.richDetayN.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(33, 254);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(57, 19);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "DETAY:";
            // 
            // textKimdenN
            // 
            this.textKimdenN.Location = new System.Drawing.Point(98, 184);
            this.textKimdenN.Name = "textKimdenN";
            this.textKimdenN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKimdenN.Properties.Appearance.Options.UseFont = true;
            this.textKimdenN.Size = new System.Drawing.Size(156, 24);
            this.textKimdenN.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(43, 123);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 19);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "SAAT:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(36, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "TARİH:";
            // 
            // textKimeN
            // 
            this.textKimeN.Location = new System.Drawing.Point(98, 214);
            this.textKimeN.Name = "textKimeN";
            this.textKimeN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKimeN.Properties.Appearance.Options.UseFont = true;
            this.textKimeN.Size = new System.Drawing.Size(156, 24);
            this.textKimeN.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(48, 219);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "KİME:";
            // 
            // textIdN
            // 
            this.textIdN.Location = new System.Drawing.Point(98, 54);
            this.textIdN.Name = "textIdN";
            this.textIdN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textIdN.Properties.Appearance.Options.UseFont = true;
            this.textIdN.Size = new System.Drawing.Size(156, 24);
            this.textIdN.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(67, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // FormNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormNot";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.FormNot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKonuN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textKimdenN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKimeN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textIdN.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton BttnTemizleN;
        private DevExpress.XtraEditors.TextEdit textKonuN;
        private System.Windows.Forms.MaskedTextBox maskedSaatN;
        private System.Windows.Forms.MaskedTextBox maskedTarihN;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BttnGuncelleN;
        private DevExpress.XtraEditors.SimpleButton BttnSilN;
        private DevExpress.XtraEditors.SimpleButton BttnKaydetN;
        private System.Windows.Forms.RichTextBox richDetayN;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textKimdenN;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textKimeN;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textIdN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}