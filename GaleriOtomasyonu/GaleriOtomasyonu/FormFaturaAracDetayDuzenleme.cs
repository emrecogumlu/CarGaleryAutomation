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

namespace GaleriOtomasyonu
{
    public partial class FormFaturaAracDetayDuzenleme : Form
    {
        public FormFaturaAracDetayDuzenleme()
        {
            InitializeComponent();
        }
        public string aracid;

        sqlbaglanti bgln = new sqlbaglanti();

        

        private void FormFaturaAracDetayDuzenleme_Load(object sender, EventArgs e)
        {
            textAracIdFT.Text = aracid;

            SqlCommand komut = new SqlCommand("select * from TBL_FATURADETAY where FATURAURUNID=@P1", bgln.baglanti());

            komut.Parameters.AddWithValue("@P1", aracid);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                textAracAdFT.Text = dr[1].ToString();
                textMiktarFT.Text = dr[2].ToString();
                textFiyatFT.Text = dr[3].ToString();
                textTutarFT.Text = dr[4].ToString();

                bgln.baglanti().Close();
            }
        }

        private void BttnGuncelleFT_Click(object sender, EventArgs e)
        {
            double miktar, tutar, fiyat;
            fiyat = Convert.ToDouble(textFiyatFT.Text);
            miktar = Convert.ToDouble(textMiktarFT.Text);
            tutar = fiyat * miktar;
            textTutarFT.Text = tutar.ToString();

            SqlCommand komutguncelle = new SqlCommand("update TBL_FATURADETAY set ARACAD=@P1, MIKTAR=@P2, FIYAT=@P3, TUTAR=@P4 where FATURAURUNID=@P5", bgln.baglanti());

            komutguncelle.Parameters.AddWithValue("@P1", textAracAdFT.Text);
            komutguncelle.Parameters.AddWithValue("@P2", textMiktarFT.Text);
            komutguncelle.Parameters.AddWithValue("@P3", decimal.Parse(textFiyatFT.Text));
            komutguncelle.Parameters.AddWithValue("@P4", decimal.Parse(textTutarFT.Text));
            komutguncelle.Parameters.AddWithValue("@P5", textAracIdFT.Text);

            komutguncelle.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Değişiklikler Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BttnSilFT_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from TBL_FATURADETAY where FATURAURUNID=@P1", bgln.baglanti());

            komutsil.Parameters.AddWithValue("@P1", textAracIdFT.Text);
            komutsil.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Araç Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
