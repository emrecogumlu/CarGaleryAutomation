using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.Charts;


namespace GaleriOtomasyonu
{
    public partial class FormKasa : Form
    {
        public FormKasa()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        private void groupControl6_Paint(object sender, PaintEventArgs e)
        {

        }

        void musterihareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute musterihareket", bgln.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void firmahareket()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute firmahareket", bgln.baglanti());
            da2.Fill(dt2);
            gridControl3.DataSource = dt2;
        }

        void faturalistele()
        {
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select * from TBL_GIDER", bgln.baglanti());
            da3.Fill(dt3);
            gridControl2.DataSource = dt3;
        }

        private void FormKasa_Load(object sender, EventArgs e)
        {
            



            musterihareket();
            firmahareket();
            faturalistele();

            //toplamtutar

            SqlCommand komut1 = new SqlCommand("select SUM(TUTAR) FROM TBL_FATURADETAY", bgln.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                labelToplamTutar.Text = dr1[0].ToString() + " ₺";
            }

            bgln.baglanti().Close();

            //sonayfatura

            SqlCommand komut2 = new SqlCommand("SELECT (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKGIDER) AS 'FATURA TOPLAM' from TBL_GIDER ORDER BY ID ASC", bgln.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                labelOdemeler.Text = dr2[0].ToString() + " ₺";
                
            }
            bgln.baglanti().Close();

            //sonaymaas

            SqlCommand komut3 = new SqlCommand("select MAAS AS 'MAAŞLAR' FROM TBL_GIDER ORDER BY ID ASC", bgln.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                labelPersonelMaas.Text = dr3[0].ToString() + " ₺";
            }
            bgln.baglanti().Close();

            //musterisayisi

            SqlCommand komut4 = new SqlCommand("select COUNT(*) FROM TBL_MUSTERI", bgln.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                labelMusteriSayisi.Text = dr4[0].ToString();
            }
            bgln.baglanti().Close();

            //firmasayisi
            SqlCommand komut5 = new SqlCommand("select COUNT(*) FROM TBL_FIRMA", bgln.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();

            while (dr5.Read())
            {
                labelFirmaSayisi.Text = dr5[0].ToString();
            }
            bgln.baglanti().Close();

            //firmasehirsayisi
            SqlCommand komut6 = new SqlCommand("select COUNT(DISTINCT(IL)) FROM TBL_FIRMA", bgln.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();

            while (dr6.Read())
            {
                labelFirmaSehirSayisi.Text = dr6[0].ToString();
            }
            bgln.baglanti().Close();

            //müsterisehirsayisi
            SqlCommand komut7 = new SqlCommand("select COUNT(DISTINCT(IL)) FROM TBL_MUSTERI", bgln.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();

            while (dr7.Read())
            {
                labelMüsteriSehirSayisi.Text = dr7[0].ToString();
            }
            bgln.baglanti().Close();

            //personelsayisi

            SqlCommand komut8 = new SqlCommand("select COUNT(*) FROM TBL_PERSONEL", bgln.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();

            while (dr8.Read())
            {
                labelPersonelSayisi.Text = dr8[0].ToString();
            }
            bgln.baglanti().Close();

            //toplamvasita
            SqlCommand komut9 = new SqlCommand("select COUNT(ADET) FROM TBL_URUN", bgln.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();

            while (dr9.Read())
            {
                labelVasitaSayisi.Text = dr9[0].ToString();
            }
            bgln.baglanti().Close();


            
        }

        

    private void label2_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        public int sayac=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

                if(sayac>0 && sayac <= 5)
            {
                //elektrik
                groupControl9.Text = "Elektrik";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("Select TOP 6 AY, ELEKTRIK FROM TBL_GIDER ORDER BY ID ASC", bgln.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();

                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgln.baglanti().Close();

                
            }
                if(sayac>5 && sayac<= 10)
            {
                //su
                groupControl9.Text = "Su";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 6 AY, SU FROM TBL_GIDER ORDER BY ID ASC", bgln.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();

                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgln.baglanti().Close();
            }
                if(sayac>10 && sayac <= 15)
            {    
                //doğalgaz
                groupControl9.Text = "Doğalgaz";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut12 = new SqlCommand("select top 6 AY, DOGALGAZ FROM TBL_GIDER ORDER BY ID ASC", bgln.baglanti());
                SqlDataReader dr12 = komut12.ExecuteReader();

                while (dr12.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr12[0], dr12[1]));
                }
                bgln.baglanti().Close();
            }
                if(sayac>15 && sayac<=20)
            {
                //internet
                groupControl9.Text = "İnternet";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut13 = new SqlCommand("select top 6 AY, INTERNET FROM TBL_GIDER ORDER BY ID ASC", bgln.baglanti());
                SqlDataReader dr13 = komut13.ExecuteReader();

                while (dr13.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr13[0], dr13[1]));
                }
                bgln.baglanti().Close();
            }

            if (sayac > 20 && sayac <= 25)
            {
                //ekstra
                groupControl9.Text = "Ekstra";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut14 = new SqlCommand("select top 6 AY, EKGIDER FROM TBL_GIDER ORDER BY ID ASC", bgln.baglanti());
                SqlDataReader dr14 = komut14.ExecuteReader();

                while (dr14.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr14[0], dr14[1]));
                }
                bgln.baglanti().Close();
            }

            if(sayac == 26)
            {
                sayac = 0;
            }
        }
        int sayac2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;

            if (sayac2 > 0 && sayac2 <= 5)
            {
                //elektrik
                groupControl10.Text = "Elektrik";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut15 = new SqlCommand("Select TOP 6 AY, ELEKTRIK FROM TBL_GIDER ORDER BY ID DESC", bgln.baglanti());
                SqlDataReader dr15 = komut15.ExecuteReader();

                while (dr15.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr15[0], dr15[1]));
                }
                bgln.baglanti().Close();


            }
            if (sayac2 > 5 && sayac2 <= 10)
            {
                //su
                groupControl10.Text = "Su";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut16 = new SqlCommand("select top 6 AY, SU FROM TBL_GIDER ORDER BY ID DESC", bgln.baglanti());
                SqlDataReader dr16 = komut16.ExecuteReader();

                while (dr16.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr16[0], dr16[1]));
                }
                bgln.baglanti().Close();
            }
            if (sayac2 > 10 && sayac2 <= 15)
            {
                //doğalgaz
                groupControl10.Text = "Doğalgaz";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut17 = new SqlCommand("select top 6 AY, DOGALGAZ FROM TBL_GIDER ORDER BY ID DESC", bgln.baglanti());
                SqlDataReader dr17 = komut17.ExecuteReader();

                while (dr17.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr17[0], dr17[1]));
                }
                bgln.baglanti().Close();
            }
            if (sayac2 > 15 && sayac2 <= 20)
            {
                //internet
                groupControl10.Text = "İnternet";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut18 = new SqlCommand("select top 6 AY, INTERNET FROM TBL_GIDER ORDER BY ID DESC", bgln.baglanti());
                SqlDataReader dr18 = komut18.ExecuteReader();

                while (dr18.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr18[0], dr18[1]));
                }
                bgln.baglanti().Close();
            }

            if (sayac2 > 20 && sayac2 <= 25)
            {
                //ekstra
                groupControl10.Text = "Ekstra";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut19 = new SqlCommand("select top 6 AY, EKGIDER FROM TBL_GIDER ORDER BY ID DESC", bgln.baglanti());
                SqlDataReader dr19 = komut19.ExecuteReader();

                while (dr19.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr19[0], dr19[1]));
                }
                bgln.baglanti().Close();
            }

            if (sayac2 == 26)
            {
                sayac2 = 0;
            }
        }
    }
}
