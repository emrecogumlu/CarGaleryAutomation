namespace GaleriOtomasyonu
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textKadiG = new DevExpress.XtraEditors.TextEdit();
            this.textSifreG = new DevExpress.XtraEditors.TextEdit();
            this.BttnGirisG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textKadiG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSifreG.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifre:";
            // 
            // textKadiG
            // 
            this.textKadiG.Location = new System.Drawing.Point(285, 102);
            this.textKadiG.Name = "textKadiG";
            this.textKadiG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKadiG.Properties.Appearance.Options.UseFont = true;
            this.textKadiG.Size = new System.Drawing.Size(134, 24);
            this.textKadiG.TabIndex = 2;
            // 
            // textSifreG
            // 
            this.textSifreG.Location = new System.Drawing.Point(285, 133);
            this.textSifreG.Name = "textSifreG";
            this.textSifreG.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textSifreG.Properties.Appearance.Options.UseFont = true;
            this.textSifreG.Properties.UseSystemPasswordChar = true;
            this.textSifreG.Size = new System.Drawing.Size(134, 24);
            this.textSifreG.TabIndex = 3;
            // 
            // BttnGirisG
            // 
            this.BttnGirisG.BackColor = System.Drawing.Color.SteelBlue;
            this.BttnGirisG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnGirisG.Location = new System.Drawing.Point(285, 172);
            this.BttnGirisG.Name = "BttnGirisG";
            this.BttnGirisG.Size = new System.Drawing.Size(96, 31);
            this.BttnGirisG.TabIndex = 4;
            this.BttnGirisG.Text = "Giriş Yap";
            this.BttnGirisG.UseVisualStyleBackColor = false;
            this.BttnGirisG.Click += new System.EventHandler(this.BttnGirisG_Click);
            this.BttnGirisG.MouseLeave += new System.EventHandler(this.BttnGirisG_MouseLeave);
            this.BttnGirisG.MouseHover += new System.EventHandler(this.BttnGirisG_MouseHover);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(532, 372);
            this.Controls.Add(this.BttnGirisG);
            this.Controls.Add(this.textSifreG);
            this.Controls.Add(this.textKadiG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.textKadiG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSifreG.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textKadiG;
        private DevExpress.XtraEditors.TextEdit textSifreG;
        private System.Windows.Forms.Button BttnGirisG;
    }
}