namespace GaleriOtomasyonu
{
    partial class FormMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMail));
            this.label1 = new System.Windows.Forms.Label();
            this.tbL_ILCETableAdapter1 = new GaleriOtomasyonu.DboTicariDataSetTableAdapters.TBL_ILCETableAdapter();
            this.textMailMail = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textKonuMail = new DevExpress.XtraEditors.TextEdit();
            this.TxtMailAdresi = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BttnGonderMail = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textMailMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKonuMail.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi:";
            // 
            // tbL_ILCETableAdapter1
            // 
            this.tbL_ILCETableAdapter1.ClearBeforeFill = true;
            // 
            // textMailMail
            // 
            this.textMailMail.Location = new System.Drawing.Point(125, 157);
            this.textMailMail.Name = "textMailMail";
            this.textMailMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textMailMail.Properties.Appearance.Options.UseFont = true;
            this.textMailMail.Size = new System.Drawing.Size(199, 24);
            this.textMailMail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu:";
            // 
            // textKonuMail
            // 
            this.textKonuMail.Location = new System.Drawing.Point(125, 194);
            this.textKonuMail.Name = "textKonuMail";
            this.textKonuMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKonuMail.Properties.Appearance.Options.UseFont = true;
            this.textKonuMail.Size = new System.Drawing.Size(199, 24);
            this.textKonuMail.TabIndex = 3;
            // 
            // TxtMailAdresi
            // 
            this.TxtMailAdresi.Location = new System.Drawing.Point(125, 237);
            this.TxtMailAdresi.Name = "TxtMailAdresi";
            this.TxtMailAdresi.Size = new System.Drawing.Size(199, 100);
            this.TxtMailAdresi.TabIndex = 4;
            this.TxtMailAdresi.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesaj:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 100);
            this.panel1.TabIndex = 6;
            // 
            // BttnGonderMail
            // 
            this.BttnGonderMail.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.BttnGonderMail.Location = new System.Drawing.Point(125, 344);
            this.BttnGonderMail.Name = "BttnGonderMail";
            this.BttnGonderMail.Size = new System.Drawing.Size(103, 39);
            this.BttnGonderMail.TabIndex = 0;
            this.BttnGonderMail.Text = "Gönder";
            this.BttnGonderMail.Click += new System.EventHandler(this.BttnGonderMail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(86, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "MAİL PANELİ";
            // 
            // FormMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 395);
            this.Controls.Add(this.BttnGonderMail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMailAdresi);
            this.Controls.Add(this.textKonuMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMailMail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönder";
            this.Load += new System.EventHandler(this.FormMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textMailMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKonuMail.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DboTicariDataSetTableAdapters.TBL_ILCETableAdapter tbL_ILCETableAdapter1;
        private DevExpress.XtraEditors.TextEdit textMailMail;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textKonuMail;
        private System.Windows.Forms.RichTextBox TxtMailAdresi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton BttnGonderMail;
    }
}