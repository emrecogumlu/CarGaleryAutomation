namespace GaleriOtomasyonu
{
    partial class FormAna
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAna));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BttnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.BttnPersonel = new DevExpress.XtraBars.BarButtonItem();
            this.BttnMusteri = new DevExpress.XtraBars.BarButtonItem();
            this.BttnArac = new DevExpress.XtraBars.BarButtonItem();
            this.BttnGaraj = new DevExpress.XtraBars.BarButtonItem();
            this.BttnFirma = new DevExpress.XtraBars.BarButtonItem();
            this.BttnBanka = new DevExpress.XtraBars.BarButtonItem();
            this.BttnGider = new DevExpress.XtraBars.BarButtonItem();
            this.BttnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.BttnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.BttnNot = new DevExpress.XtraBars.BarButtonItem();
            this.BttnFatura = new DevExpress.XtraBars.BarButtonItem();
            this.BttnAyar = new DevExpress.XtraBars.BarButtonItem();
            this.BttnHareket = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BttnAnasayfa,
            this.BttnPersonel,
            this.BttnMusteri,
            this.BttnArac,
            this.BttnGaraj,
            this.BttnFirma,
            this.BttnBanka,
            this.BttnGider,
            this.BttnKasa,
            this.BttnRehber,
            this.BttnNot,
            this.BttnFatura,
            this.BttnAyar,
            this.BttnHareket});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1370, 141);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // BttnAnasayfa
            // 
            this.BttnAnasayfa.Caption = "ANA SAYFA";
            this.BttnAnasayfa.Id = 1;
            this.BttnAnasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnAnasayfa.ImageOptions.Image")));
            this.BttnAnasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BttnAnasayfa.ImageOptions.LargeImage")));
            this.BttnAnasayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnAnasayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnAnasayfa.Name = "BttnAnasayfa";
            this.BttnAnasayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnAnasayfa_ItemClick);
            // 
            // BttnPersonel
            // 
            this.BttnPersonel.Caption = "PERSONELLER";
            this.BttnPersonel.Id = 2;
            this.BttnPersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnPersonel.ImageOptions.Image")));
            this.BttnPersonel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BttnPersonel.ImageOptions.LargeImage")));
            this.BttnPersonel.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnPersonel.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnPersonel.Name = "BttnPersonel";
            this.BttnPersonel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnPersonel_ItemClick);
            // 
            // BttnMusteri
            // 
            this.BttnMusteri.Caption = "MÜŞTERİLER";
            this.BttnMusteri.Id = 3;
            this.BttnMusteri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnMusteri.ImageOptions.Image")));
            this.BttnMusteri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BttnMusteri.ImageOptions.LargeImage")));
            this.BttnMusteri.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnMusteri.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnMusteri.Name = "BttnMusteri";
            this.BttnMusteri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnMusteri_ItemClick);
            // 
            // BttnArac
            // 
            this.BttnArac.Caption = "ARAÇLAR";
            this.BttnArac.Id = 4;
            this.BttnArac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnArac.ImageOptions.Image")));
            this.BttnArac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BttnArac.ImageOptions.LargeImage")));
            this.BttnArac.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnArac.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnArac.Name = "BttnArac";
            this.BttnArac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnArac_ItemClick);
            // 
            // BttnGaraj
            // 
            this.BttnGaraj.Caption = "GARAJ";
            this.BttnGaraj.Id = 5;
            this.BttnGaraj.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnGaraj.ImageOptions.Image")));
            this.BttnGaraj.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BttnGaraj.ImageOptions.LargeImage")));
            this.BttnGaraj.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnGaraj.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnGaraj.Name = "BttnGaraj";
            this.BttnGaraj.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnGaraj_ItemClick);
            // 
            // BttnFirma
            // 
            this.BttnFirma.Caption = "FİRMALAR";
            this.BttnFirma.Id = 6;
            this.BttnFirma.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BttnFirma.ImageOptions.SvgImage")));
            this.BttnFirma.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnFirma.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnFirma.Name = "BttnFirma";
            this.BttnFirma.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnFirma_ItemClick);
            // 
            // BttnBanka
            // 
            this.BttnBanka.Caption = "BANKALAR";
            this.BttnBanka.Id = 7;
            this.BttnBanka.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BttnBanka.ImageOptions.SvgImage")));
            this.BttnBanka.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnBanka.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnBanka.Name = "BttnBanka";
            this.BttnBanka.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnBanka_ItemClick);
            // 
            // BttnGider
            // 
            this.BttnGider.Caption = "GİDERLER";
            this.BttnGider.Id = 8;
            this.BttnGider.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnGider.ImageOptions.Image")));
            this.BttnGider.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BttnGider.ImageOptions.LargeImage")));
            this.BttnGider.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnGider.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnGider.Name = "BttnGider";
            this.BttnGider.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnGider_ItemClick);
            // 
            // BttnKasa
            // 
            this.BttnKasa.Caption = "KASA";
            this.BttnKasa.Id = 9;
            this.BttnKasa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BttnKasa.ImageOptions.SvgImage")));
            this.BttnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnKasa.Name = "BttnKasa";
            this.BttnKasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnKasa_ItemClick);
            // 
            // BttnRehber
            // 
            this.BttnRehber.Caption = "REHBER";
            this.BttnRehber.Id = 10;
            this.BttnRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnRehber.ImageOptions.Image")));
            this.BttnRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BttnRehber.ImageOptions.LargeImage")));
            this.BttnRehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnRehber.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnRehber.Name = "BttnRehber";
            this.BttnRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnRehber_ItemClick);
            // 
            // BttnNot
            // 
            this.BttnNot.Caption = "NOTLAR";
            this.BttnNot.Id = 11;
            this.BttnNot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnNot.ImageOptions.Image")));
            this.BttnNot.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BttnNot.ImageOptions.LargeImage")));
            this.BttnNot.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnNot.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnNot.Name = "BttnNot";
            this.BttnNot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnNot_ItemClick);
            // 
            // BttnFatura
            // 
            this.BttnFatura.Caption = "FATURALAR";
            this.BttnFatura.Id = 12;
            this.BttnFatura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BttnFatura.ImageOptions.Image")));
            this.BttnFatura.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BttnFatura.ImageOptions.LargeImage")));
            this.BttnFatura.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BttnFatura.ImageOptions.SvgImage")));
            this.BttnFatura.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnFatura.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnFatura.Name = "BttnFatura";
            this.BttnFatura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnFatura_ItemClick);
            // 
            // BttnAyar
            // 
            this.BttnAyar.Caption = "AYARLAR";
            this.BttnAyar.Id = 13;
            this.BttnAyar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BttnAyar.ImageOptions.SvgImage")));
            this.BttnAyar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnAyar.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnAyar.Name = "BttnAyar";
            this.BttnAyar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnAyar_ItemClick);
            // 
            // BttnHareket
            // 
            this.BttnHareket.Caption = "HAREKETLER";
            this.BttnHareket.Id = 14;
            this.BttnHareket.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BttnHareket.ImageOptions.SvgImage")));
            this.BttnHareket.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BttnHareket.ItemAppearance.Normal.Options.UseFont = true;
            this.BttnHareket.Name = "BttnHareket";
            this.BttnHareket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BttnHareket_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Galeri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnAnasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnPersonel);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnMusteri);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnArac);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnGaraj);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnFirma);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnBanka);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnGider);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnNot);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnFatura);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnHareket);
            this.ribbonPageGroup1.ItemLinks.Add(this.BttnAyar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emre Galeri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BttnAnasayfa;
        private DevExpress.XtraBars.BarButtonItem BttnPersonel;
        private DevExpress.XtraBars.BarButtonItem BttnMusteri;
        private DevExpress.XtraBars.BarButtonItem BttnArac;
        private DevExpress.XtraBars.BarButtonItem BttnGaraj;
        private DevExpress.XtraBars.BarButtonItem BttnFirma;
        private DevExpress.XtraBars.BarButtonItem BttnBanka;
        private DevExpress.XtraBars.BarButtonItem BttnGider;
        private DevExpress.XtraBars.BarButtonItem BttnKasa;
        private DevExpress.XtraBars.BarButtonItem BttnRehber;
        private DevExpress.XtraBars.BarButtonItem BttnNot;
        private DevExpress.XtraBars.BarButtonItem BttnFatura;
        private DevExpress.XtraBars.BarButtonItem BttnAyar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem BttnHareket;
    }
}

