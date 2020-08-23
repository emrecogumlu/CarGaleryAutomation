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
    public partial class FormFatura : Form
    {
        public FormFatura()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        void faturalistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FATURABILGI", bgln.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

       
        

        void personellistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID, AD from TBL_PERSONEL", bgln.baglanti());
            da.Fill(dt);
            lookUpEditPersonel.Properties.ValueMember = "ID";
            lookUpEditPersonel.Properties.DisplayMember = "AD";
            lookUpEditPersonel.Properties.DataSource = dt;


        }

        private void FormFatura_Load(object sender, EventArgs e)
        {
            faturalistele();
            //firmalistele();
            personellistele();
            //musterilistele();
            
            temizle();
        }

        void temizle()
        {
            textIdFT.Text = "";
            textSeriFT.Text = "";
            textSiraFT.Text = "";
            maskedTarihFT.Text = "";
            maskedSaatFT.Text = "";
            textVergiFT.Text = "";
            textAliciFT.Text = "";
            textTedenFT.Text = "";
            textTalanFT.Text = "";
        }

        private void BttnKaydetFT_Click(object sender, EventArgs e)
        {
            

            if(textFaturaIdFT.Text != "" && comboCari.Text == "Firma")
            {

                
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(textFiyatFT.Text);
                miktar = Convert.ToDouble(textMiktarFT.Text);
                tutar = fiyat * miktar;
                textTutarFT.Text = tutar.ToString();

                SqlCommand komutkaydet2 = new SqlCommand("insert into TBL_FATURADETAY (ARACAD, MIKTAR, FIYAT, TUTAR, FATURAID) values (@P1,@P2,@P3,@P4,@P5)", bgln.baglanti());

                komutkaydet2.Parameters.AddWithValue("@P1", textAracAdFT.Text);
                komutkaydet2.Parameters.AddWithValue("@P2", textMiktarFT.Text);
                komutkaydet2.Parameters.AddWithValue("@P3", textFiyatFT.Text);
                komutkaydet2.Parameters.AddWithValue("@P4", textTutarFT.Text);
                komutkaydet2.Parameters.AddWithValue("@P5", textFaturaIdFT.Text);

                komutkaydet2.ExecuteNonQuery();
                bgln.baglanti().Close();

                //harekettablosunaaktarma
                
                
                    SqlCommand komutkaydet3 = new SqlCommand("insert into TBL_FIRMAHAREKET (URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID,TARIH) values (@d1, @d2, @d3, @d4, @d5, @d6, @d7, @d8)", bgln.baglanti());

                    komutkaydet3.Parameters.AddWithValue("@d1", textAracIdFT.Text);
                    komutkaydet3.Parameters.AddWithValue("@d2", textMiktarFT.Text);
                    komutkaydet3.Parameters.AddWithValue("@d3", lookUpEditPersonel.EditValue);
                    komutkaydet3.Parameters.AddWithValue("@d4", textCari.Text);
                    komutkaydet3.Parameters.AddWithValue("@d5", textFiyatFT.Text);
                    komutkaydet3.Parameters.AddWithValue("@d6", textTutarFT.Text);
                    komutkaydet3.Parameters.AddWithValue("@d7", textFaturaIdFT.Text);
                    komutkaydet3.Parameters.AddWithValue("@d8", maskedTarihFT.Text);
                    komutkaydet3.ExecuteNonQuery();
                    bgln.baglanti().Close();

                    //garajdaki vasitayi azaltma

                    SqlCommand komutgaraj = new SqlCommand("update TBL_URUN set ADET=ADET-@A1 where ID=@A2", bgln.baglanti());
                    komutgaraj.Parameters.AddWithValue("@A1", textMiktarFT.Text);
                    komutgaraj.Parameters.AddWithValue("@A2", textAracIdFT.Text);
                    komutgaraj.ExecuteNonQuery();
                    bgln.baglanti().Close();

                    MessageBox.Show("Fatura Detay Bilgisi Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    temizle();
                

                
                
            }

            if (textFaturaIdFT.Text != "" && comboCari.Text == "Müşteri")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(textFiyatFT.Text);
                miktar = Convert.ToDouble(textMiktarFT.Text);
                tutar = fiyat * miktar;
                textTutarFT.Text = tutar.ToString();

                SqlCommand komutkaydet2 = new SqlCommand("insert into TBL_FATURADETAY (ARACAD, MIKTAR, FIYAT, TUTAR, FATURAID) values (@P1,@P2,@P3,@P4,@P5)", bgln.baglanti());

                komutkaydet2.Parameters.AddWithValue("@P1", textAracAdFT.Text);
                komutkaydet2.Parameters.AddWithValue("@P2", textMiktarFT.Text);
                komutkaydet2.Parameters.AddWithValue("@P3", textFiyatFT.Text);
                komutkaydet2.Parameters.AddWithValue("@P4", textTutarFT.Text);
                komutkaydet2.Parameters.AddWithValue("@P5", textFaturaIdFT.Text);

                komutkaydet2.ExecuteNonQuery();
                bgln.baglanti().Close();

                //harekettablosunaaktarma
                SqlCommand komutkaydet11 = new SqlCommand("insert into TBL_MUSTERIHAREKET (URUNID,ADET,PERSONEL,MUSTERI,FIYAT,TOPLAM,FATURAID,TARIH) values (@d11, @d12, @d13, @d14, @d15, @d16, @d17, @d18)", bgln.baglanti());

                komutkaydet11.Parameters.AddWithValue("@d11", textAracIdFT.Text);
                komutkaydet11.Parameters.AddWithValue("@d12", textMiktarFT.Text);
                komutkaydet11.Parameters.AddWithValue("@d13", lookUpEditPersonel.EditValue);
                komutkaydet11.Parameters.AddWithValue("@d14", textCari.Text);
                komutkaydet11.Parameters.AddWithValue("@d15", textFiyatFT.Text);
                komutkaydet11.Parameters.AddWithValue("@d16", textTutarFT.Text);
                komutkaydet11.Parameters.AddWithValue("@d17", textFaturaIdFT.Text);
                komutkaydet11.Parameters.AddWithValue("@d18", maskedTarihFT.Text);
                komutkaydet11.ExecuteNonQuery();
                bgln.baglanti().Close();

                //garajdaki vasitayi azaltma

                SqlCommand komutgaraj = new SqlCommand("update TBL_URUN set ADET=ADET-@A1 where ID=@A2", bgln.baglanti());
                komutgaraj.Parameters.AddWithValue("@A1", textMiktarFT.Text);
                komutgaraj.Parameters.AddWithValue("@A2", textAracIdFT.Text);
                komutgaraj.ExecuteNonQuery();
                bgln.baglanti().Close();

                MessageBox.Show("Fatura Detay Bilgisi Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                temizle();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow drow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (drow != null)
            {
                textIdFT.Text = drow["FATURABILGIID"].ToString();
                textSeriFT.Text = drow["SERI"].ToString();
                textSiraFT.Text = drow["SIRANO"].ToString();
                maskedTarihFT.Text = drow["TARIH"].ToString();
                maskedSaatFT.Text = drow["SAAT"].ToString();
                textVergiFT.Text = drow["VERGIDAIRE"].ToString();
                textAliciFT.Text = drow["ALAN"].ToString();
                textTedenFT.Text = drow["TESLIMEDEN"].ToString();
                textTalanFT.Text = drow["TESLIMALAN"].ToString();
            }

        }

        private void BttnTemizleFT_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BttnSilFT_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("Fatura Bilgisi Silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("delete from TBL_FATURABILGI where FATURABILGIID=@P1", bgln.baglanti());

                komutsil.Parameters.AddWithValue("@P1", textIdFT.Text);
                komutsil.ExecuteNonQuery();
                bgln.baglanti().Close();
                
                MessageBox.Show("Fatura Bilgisi Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                faturalistele();
            }

        }

        private void BttnTemizleFT_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void BttnGuncelleFT_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update TBL_FATURABILGI set SERI=@P1, SIRANO=@P2, TARIH=@P3, SAAT=@P4, VERGIDAIRE=@P5, ALAN=@P6, TESLIMEDEN=@P7, TESLIMALAN=@P8 where FATURABILGIID=@P9", bgln.baglanti());

            komutguncelle.Parameters.AddWithValue("@P1", textSeriFT.Text);
            komutguncelle.Parameters.AddWithValue("@P2", textSiraFT.Text);
            komutguncelle.Parameters.AddWithValue("@P3", maskedTarihFT.Text);
            komutguncelle.Parameters.AddWithValue("@P4", maskedSaatFT.Text);
            komutguncelle.Parameters.AddWithValue("@P5", textVergiFT.Text);
            komutguncelle.Parameters.AddWithValue("@P6", textAliciFT.Text);
            komutguncelle.Parameters.AddWithValue("@P7", textTedenFT.Text);
            komutguncelle.Parameters.AddWithValue("@P8", textTalanFT.Text);
            komutguncelle.Parameters.AddWithValue("@P9", textIdFT.Text);

            komutguncelle.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            faturalistele();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormFaturaAracDetay fr = new FormFaturaAracDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr != null)
            {
                fr.id = dr["FATURABILGIID"].ToString();
            }
            fr.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select ARACAD, SATIS from TBL_URUN where ID=@P1", bgln.baglanti());
            komut.Parameters.AddWithValue("@P1", textAracIdFT.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textAracAdFT.Text = dr[0].ToString();
                textFiyatFT.Text = dr[1].ToString();
            }
            bgln.baglanti().Close();
        }
    }

}
