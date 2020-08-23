namespace GaleriOtomasyonu
{
    partial class FormArac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArac));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboYilA = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboModelA = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboMarkaA = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboVasitaA = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BttnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.BttnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BttnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BttnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.richDetay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textSatis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textAlis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.numupAdet = new System.Windows.Forms.NumericUpDown();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboYilA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboModelA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboMarkaA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboVasitaA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSatis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAlis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1083, 749);
            this.gridControl1.TabIndex = 0;
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
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.comboYilA);
            this.groupControl1.Controls.Add(this.comboModelA);
            this.groupControl1.Controls.Add(this.comboMarkaA);
            this.groupControl1.Controls.Add(this.comboVasitaA);
            this.groupControl1.Controls.Add(this.BttnTemizle);
            this.groupControl1.Controls.Add(this.BttnGuncelle);
            this.groupControl1.Controls.Add(this.BttnSil);
            this.groupControl1.Controls.Add(this.BttnKaydet);
            this.groupControl1.Controls.Add(this.richDetay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.textSatis);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.textAlis);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.numupAdet);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1079, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(292, 749);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // comboYilA
            // 
            this.comboYilA.Location = new System.Drawing.Point(123, 147);
            this.comboYilA.Name = "comboYilA";
            this.comboYilA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboYilA.Properties.Appearance.Options.UseFont = true;
            this.comboYilA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboYilA.Size = new System.Drawing.Size(156, 22);
            this.comboYilA.TabIndex = 25;
            // 
            // comboModelA
            // 
            this.comboModelA.Location = new System.Drawing.Point(123, 113);
            this.comboModelA.Name = "comboModelA";
            this.comboModelA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboModelA.Properties.Appearance.Options.UseFont = true;
            this.comboModelA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboModelA.Size = new System.Drawing.Size(156, 22);
            this.comboModelA.TabIndex = 24;
            // 
            // comboMarkaA
            // 
            this.comboMarkaA.Location = new System.Drawing.Point(123, 82);
            this.comboMarkaA.Name = "comboMarkaA";
            this.comboMarkaA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboMarkaA.Properties.Appearance.Options.UseFont = true;
            this.comboMarkaA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboMarkaA.Size = new System.Drawing.Size(156, 22);
            this.comboMarkaA.TabIndex = 23;
            this.comboMarkaA.SelectedIndexChanged += new System.EventHandler(this.comboMarkaA_SelectedIndexChanged_1);
            // 
            // comboVasitaA
            // 
            this.comboVasitaA.Location = new System.Drawing.Point(123, 53);
            this.comboVasitaA.Name = "comboVasitaA";
            this.comboVasitaA.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboVasitaA.Properties.Appearance.Options.UseFont = true;
            this.comboVasitaA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboVasitaA.Size = new System.Drawing.Size(156, 22);
            this.comboVasitaA.TabIndex = 22;
            this.comboVasitaA.SelectedIndexChanged += new System.EventHandler(this.comboVasitaA_SelectedIndexChanged);
            // 
            // BttnTemizle
            // 
            this.BttnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnTemizle.Appearance.Options.UseFont = true;
            this.BttnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnTemizle.ImageOptions.Image")));
            this.BttnTemizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BttnTemizle.ImageOptions.SvgImage")));
            this.BttnTemizle.Location = new System.Drawing.Point(123, 512);
            this.BttnTemizle.Name = "BttnTemizle";
            this.BttnTemizle.Size = new System.Drawing.Size(156, 32);
            this.BttnTemizle.TabIndex = 21;
            this.BttnTemizle.Text = "TEMİZLE";
            this.BttnTemizle.Click += new System.EventHandler(this.BttnTemizle_Click);
            // 
            // BttnGuncelle
            // 
            this.BttnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnGuncelle.Appearance.Options.UseFont = true;
            this.BttnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnGuncelle.ImageOptions.Image")));
            this.BttnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BttnGuncelle.ImageOptions.SvgImage")));
            this.BttnGuncelle.Location = new System.Drawing.Point(123, 464);
            this.BttnGuncelle.Name = "BttnGuncelle";
            this.BttnGuncelle.Size = new System.Drawing.Size(156, 32);
            this.BttnGuncelle.TabIndex = 20;
            this.BttnGuncelle.Text = "GÜNCELLE";
            this.BttnGuncelle.Click += new System.EventHandler(this.BttnGuncelle_Click);
            // 
            // BttnSil
            // 
            this.BttnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnSil.Appearance.Options.UseFont = true;
            this.BttnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnSil.ImageOptions.Image")));
            this.BttnSil.Location = new System.Drawing.Point(123, 416);
            this.BttnSil.Name = "BttnSil";
            this.BttnSil.Size = new System.Drawing.Size(156, 32);
            this.BttnSil.TabIndex = 19;
            this.BttnSil.Text = "SİL";
            this.BttnSil.Click += new System.EventHandler(this.BttnSil_Click);
            // 
            // BttnKaydet
            // 
            this.BttnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnKaydet.Appearance.Options.UseFont = true;
            this.BttnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnKaydet.ImageOptions.Image")));
            this.BttnKaydet.Location = new System.Drawing.Point(123, 378);
            this.BttnKaydet.Name = "BttnKaydet";
            this.BttnKaydet.Size = new System.Drawing.Size(156, 32);
            this.BttnKaydet.TabIndex = 18;
            this.BttnKaydet.Text = "KAYDET";
            this.BttnKaydet.Click += new System.EventHandler(this.BttnKaydet_Click);
            // 
            // richDetay
            // 
            this.richDetay.Location = new System.Drawing.Point(123, 272);
            this.richDetay.Name = "richDetay";
            this.richDetay.Size = new System.Drawing.Size(156, 89);
            this.richDetay.TabIndex = 8;
            this.richDetay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(60, 270);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(57, 19);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "DETAY:";
            // 
            // textSatis
            // 
            this.textSatis.Location = new System.Drawing.Point(123, 240);
            this.textSatis.Name = "textSatis";
            this.textSatis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSatis.Properties.Appearance.Options.UseFont = true;
            this.textSatis.Size = new System.Drawing.Size(156, 24);
            this.textSatis.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(10, 245);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(107, 19);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "SATIŞ FİYATI:";
            // 
            // textAlis
            // 
            this.textAlis.Location = new System.Drawing.Point(123, 210);
            this.textAlis.Name = "textAlis";
            this.textAlis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAlis.Properties.Appearance.Options.UseFont = true;
            this.textAlis.Size = new System.Drawing.Size(156, 24);
            this.textAlis.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(21, 213);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(96, 19);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "ALIŞ FİYATI:";
            // 
            // numupAdet
            // 
            this.numupAdet.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numupAdet.Location = new System.Drawing.Point(123, 178);
            this.numupAdet.Name = "numupAdet";
            this.numupAdet.Size = new System.Drawing.Size(156, 26);
            this.numupAdet.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(70, 185);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 19);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "ADET:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(87, 150);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 19);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "YIL:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(59, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "MODEL:";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(58, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "MARKA:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "VASITA TİP:";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(123, 23);
            this.textId.Name = "textId";
            this.textId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textId.Properties.Appearance.Options.UseFont = true;
            this.textId.Size = new System.Drawing.Size(156, 24);
            this.textId.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(94, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // FormArac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormArac";
            this.Text = "Araçlar";
            this.Load += new System.EventHandler(this.FormArac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboYilA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboModelA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboMarkaA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboVasitaA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSatis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAlis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BttnKaydet;
        private System.Windows.Forms.RichTextBox richDetay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textSatis;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textAlis;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.NumericUpDown numupAdet;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton BttnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BttnSil;
        private DevExpress.XtraEditors.SimpleButton BttnTemizle;
        private DevExpress.XtraEditors.ComboBoxEdit comboYilA;
        private DevExpress.XtraEditors.ComboBoxEdit comboModelA;
        private DevExpress.XtraEditors.ComboBoxEdit comboMarkaA;
        private DevExpress.XtraEditors.ComboBoxEdit comboVasitaA;
    }
}