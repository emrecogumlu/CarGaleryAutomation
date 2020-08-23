using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriOtomasyonu
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        FormAnaSayfa fr15;

        private void BttnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15 == null || fr15.IsDisposed)
            {
                fr15 = new FormAnaSayfa();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }
        FormArac fr;
        private void BttnArac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr == null || fr.IsDisposed)
            {
                fr = new FormArac();
                fr.MdiParent = this;
                fr.Show();
            }
            
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr15 == null)
            {
                fr15 = new FormAnaSayfa();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }
        FormMusteri fr2;

        private void BttnMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new FormMusteri();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        FormFirma fr3;
        private void BttnFirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new FormFirma();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        FormPersonel fr4;
        private void BttnPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new FormPersonel();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }

        FormRehber fr5;
        private void BttnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new FormRehber();
                fr5.MdiParent = this;
                fr5.Show();

            }
        }
        FormGider fr6;
        private void BttnGider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         if(fr6 == null || fr6.IsDisposed)
            {
                fr6 = new FormGider();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }
        FormBanka fr7;
        private void BttnBanka_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        if(fr7 == null || fr7.IsDisposed)
            {
                fr7 = new FormBanka();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }

        FormFatura fr8;

        private void BttnFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        if(fr8 == null || fr8.IsDisposed)
            {
                fr8 = new FormFatura();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }

        FormNot fr9;

        private void BttnNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        if(fr9 == null || fr9.IsDisposed)
            {
                fr9 = new FormNot();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }

        FormHareket fr10;

        private void BttnHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        if(fr10 == null || fr10.IsDisposed)
            {
                fr10 = new FormHareket();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }

        FormGaraj fr12;
        private void BttnGaraj_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr12 == null || fr12.IsDisposed)
            {
                fr12 = new FormGaraj();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }

        FormAyar fr13;
        private void BttnAyar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)
            {
                fr13 = new FormAyar();
                
                fr13.Show();
            }
        }

        FormKasa fr14;

        private void BttnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr14 == null || fr14.IsDisposed)
            {
                fr14 = new FormKasa();
                fr14.MdiParent = this;
                fr14.Show();
            }
        }

        
    }
}
