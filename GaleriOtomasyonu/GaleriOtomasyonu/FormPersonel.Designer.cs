namespace GaleriOtomasyonu
{
    partial class FormPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonel));
            this.BttnTemizleP = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textMailP = new DevExpress.XtraEditors.TextEdit();
            this.comboilceP = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboilP = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.maskedTcP = new System.Windows.Forms.MaskedTextBox();
            this.maskedTelP = new System.Windows.Forms.MaskedTextBox();
            this.BttnGuncelleP = new DevExpress.XtraEditors.SimpleButton();
            this.BttnSilP = new DevExpress.XtraEditors.SimpleButton();
            this.BttnKaydetP = new DevExpress.XtraEditors.SimpleButton();
            this.richAcikadresP = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textStatuP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textSoyadP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textAdP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textIdP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMailP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboilceP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboilP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textStatuP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSoyadP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAdP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textIdP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BttnTemizleP
            // 
            this.BttnTemizleP.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnTemizleP.Appearance.Options.UseFont = true;
            this.BttnTemizleP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnTemizleP.ImageOptions.Image")));
            this.BttnTemizleP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BttnTemizleP.ImageOptions.SvgImage")));
            this.BttnTemizleP.Location = new System.Drawing.Point(121, 539);
            this.BttnTemizleP.Name = "BttnTemizleP";
            this.BttnTemizleP.Size = new System.Drawing.Size(156, 32);
            this.BttnTemizleP.TabIndex = 30;
            this.BttnTemizleP.Text = "TEMİZLE";
            this.BttnTemizleP.Click += new System.EventHandler(this.BttnTemizleP_Click);
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
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // textMailP
            // 
            this.textMailP.Location = new System.Drawing.Point(123, 244);
            this.textMailP.Name = "textMailP";
            this.textMailP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textMailP.Properties.Appearance.Options.UseFont = true;
            this.textMailP.Size = new System.Drawing.Size(156, 24);
            this.textMailP.TabIndex = 7;
            // 
            // comboilceP
            // 
            this.comboilceP.Location = new System.Drawing.Point(123, 214);
            this.comboilceP.Name = "comboilceP";
            this.comboilceP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboilceP.Properties.Appearance.Options.UseFont = true;
            this.comboilceP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboilceP.Size = new System.Drawing.Size(156, 24);
            this.comboilceP.TabIndex = 6;
            // 
            // comboilP
            // 
            this.comboilP.Location = new System.Drawing.Point(123, 183);
            this.comboilP.Name = "comboilP";
            this.comboilP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboilP.Properties.Appearance.Options.UseFont = true;
            this.comboilP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboilP.Size = new System.Drawing.Size(156, 24);
            this.comboilP.TabIndex = 5;
            this.comboilP.SelectedIndexChanged += new System.EventHandler(this.comboilP_SelectedIndexChanged);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(58, 279);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(57, 19);
            this.labelControl11.TabIndex = 22;
            this.labelControl11.Text = "STATÜ:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(74, 249);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(43, 19);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "MAİL:";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.BttnTemizleP);
            this.groupControl1.Controls.Add(this.textMailP);
            this.groupControl1.Controls.Add(this.comboilceP);
            this.groupControl1.Controls.Add(this.comboilP);
            this.groupControl1.Controls.Add(this.maskedTcP);
            this.groupControl1.Controls.Add(this.maskedTelP);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.BttnGuncelleP);
            this.groupControl1.Controls.Add(this.BttnSilP);
            this.groupControl1.Controls.Add(this.BttnKaydetP);
            this.groupControl1.Controls.Add(this.richAcikadresP);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.textStatuP);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textSoyadP);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textAdP);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textIdP);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1077, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(292, 751);
            this.groupControl1.TabIndex = 5;
            // 
            // maskedTcP
            // 
            this.maskedTcP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTcP.Location = new System.Drawing.Point(123, 151);
            this.maskedTcP.Mask = "00000000000";
            this.maskedTcP.Name = "maskedTcP";
            this.maskedTcP.Size = new System.Drawing.Size(156, 26);
            this.maskedTcP.TabIndex = 4;
            this.maskedTcP.ValidatingType = typeof(int);
            // 
            // maskedTelP
            // 
            this.maskedTelP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTelP.Location = new System.Drawing.Point(121, 115);
            this.maskedTelP.Mask = "(999) 000-0000";
            this.maskedTelP.Name = "maskedTelP";
            this.maskedTelP.Size = new System.Drawing.Size(158, 26);
            this.maskedTelP.TabIndex = 3;
            // 
            // BttnGuncelleP
            // 
            this.BttnGuncelleP.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnGuncelleP.Appearance.Options.UseFont = true;
            this.BttnGuncelleP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnGuncelleP.ImageOptions.Image")));
            this.BttnGuncelleP.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BttnGuncelleP.ImageOptions.SvgImage")));
            this.BttnGuncelleP.Location = new System.Drawing.Point(121, 501);
            this.BttnGuncelleP.Name = "BttnGuncelleP";
            this.BttnGuncelleP.Size = new System.Drawing.Size(156, 32);
            this.BttnGuncelleP.TabIndex = 20;
            this.BttnGuncelleP.Text = "GÜNCELLE";
            this.BttnGuncelleP.Click += new System.EventHandler(this.BttnGuncelleP_Click);
            // 
            // BttnSilP
            // 
            this.BttnSilP.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnSilP.Appearance.Options.UseFont = true;
            this.BttnSilP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnSilP.ImageOptions.Image")));
            this.BttnSilP.Location = new System.Drawing.Point(121, 463);
            this.BttnSilP.Name = "BttnSilP";
            this.BttnSilP.Size = new System.Drawing.Size(156, 32);
            this.BttnSilP.TabIndex = 19;
            this.BttnSilP.Text = "SİL";
            this.BttnSilP.Click += new System.EventHandler(this.BttnSilP_Click);
            // 
            // BttnKaydetP
            // 
            this.BttnKaydetP.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnKaydetP.Appearance.Options.UseFont = true;
            this.BttnKaydetP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnKaydetP.ImageOptions.Image")));
            this.BttnKaydetP.Location = new System.Drawing.Point(121, 425);
            this.BttnKaydetP.Name = "BttnKaydetP";
            this.BttnKaydetP.Size = new System.Drawing.Size(156, 32);
            this.BttnKaydetP.TabIndex = 18;
            this.BttnKaydetP.Text = "KAYDET";
            this.BttnKaydetP.Click += new System.EventHandler(this.BttnKaydetP_Click);
            // 
            // richAcikadresP
            // 
            this.richAcikadresP.Location = new System.Drawing.Point(123, 313);
            this.richAcikadresP.Name = "richAcikadresP";
            this.richAcikadresP.Size = new System.Drawing.Size(156, 89);
            this.richAcikadresP.TabIndex = 9;
            this.richAcikadresP.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(22, 313);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(97, 19);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "AÇIK ADRES:";
            // 
            // textStatuP
            // 
            this.textStatuP.Location = new System.Drawing.Point(123, 274);
            this.textStatuP.Name = "textStatuP";
            this.textStatuP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textStatuP.Properties.Appearance.Options.UseFont = true;
            this.textStatuP.Size = new System.Drawing.Size(156, 24);
            this.textStatuP.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(78, 216);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(39, 19);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "İLÇE:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(95, 188);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(20, 19);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "İL:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(89, 158);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(26, 19);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "TC:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(42, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "TELEFON:";
            // 
            // textSoyadP
            // 
            this.textSoyadP.Location = new System.Drawing.Point(123, 83);
            this.textSoyadP.Name = "textSoyadP";
            this.textSoyadP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSoyadP.Properties.Appearance.Options.UseFont = true;
            this.textSoyadP.Size = new System.Drawing.Size(156, 24);
            this.textSoyadP.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(58, 88);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "SOYAD:";
            // 
            // textAdP
            // 
            this.textAdP.Location = new System.Drawing.Point(123, 52);
            this.textAdP.Name = "textAdP";
            this.textAdP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAdP.Properties.Appearance.Options.UseFont = true;
            this.textAdP.Size = new System.Drawing.Size(156, 24);
            this.textAdP.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(87, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "AD:";
            // 
            // textIdP
            // 
            this.textIdP.Location = new System.Drawing.Point(123, 22);
            this.textIdP.Name = "textIdP";
            this.textIdP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textIdP.Properties.Appearance.Options.UseFont = true;
            this.textIdP.Size = new System.Drawing.Size(156, 24);
            this.textIdP.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(92, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormPersonel";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMailP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboilceP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboilP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textStatuP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSoyadP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAdP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textIdP.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BttnTemizleP;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textMailP;
        private DevExpress.XtraEditors.ComboBoxEdit comboilceP;
        private DevExpress.XtraEditors.ComboBoxEdit comboilP;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BttnGuncelleP;
        private DevExpress.XtraEditors.SimpleButton BttnSilP;
        private DevExpress.XtraEditors.SimpleButton BttnKaydetP;
        private System.Windows.Forms.RichTextBox richAcikadresP;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textStatuP;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textSoyadP;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textAdP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textIdP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox maskedTcP;
        private System.Windows.Forms.MaskedTextBox maskedTelP;
    }
}