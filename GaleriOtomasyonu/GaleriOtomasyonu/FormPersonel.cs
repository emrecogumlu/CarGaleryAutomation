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
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        void personellistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_PERSONEL", bgln.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            textIdP.Text = "";
            textAdP.Text = "";
            textSoyadP.Text = "";
            maskedTelP.Text = "";
            maskedTcP.Text = "";
            textMailP.Text = "";
            comboilP.Text = "";
            comboilceP.Text = "";
            richAcikadresP.Text = "";
            textStatuP.Text = "";

        }

        void illistele()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from TBL_IL", bgln.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboilP.Properties.Items.Add(dr[0]);
            }
            bgln.baglanti().Close();
        }
        private void FormPersonel_Load(object sender, EventArgs e)
        {
            personellistele();
            illistele();
            temizle();
        }

        private void BttnKaydetP_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONEL (AD,SOYAD,TELEFON,TC, MAIL,IL,ILCE,ACIKADRES,STATU) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgln.baglanti());

            komut.Parameters.AddWithValue("@P1", textAdP.Text);
            komut.Parameters.AddWithValue("@P2", textSoyadP.Text);
            komut.Parameters.AddWithValue("@P3", maskedTelP.Text);
            komut.Parameters.AddWithValue("@P4", maskedTcP.Text);
            komut.Parameters.AddWithValue("@P5", textMailP.Text);
            komut.Parameters.AddWithValue("@P6", comboilP.Text);
            komut.Parameters.AddWithValue("@P7", comboilceP.Text);
            komut.Parameters.AddWithValue("@P8", richAcikadresP.Text);
            komut.Parameters.AddWithValue("@P9", textStatuP.Text);

            komut.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Personel Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personellistele();
            temizle();
        }

        private void comboilP_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboilceP.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_ILCE where SEHIR=@p1", bgln.baglanti());
            komut.Parameters.AddWithValue("@p1", comboilP.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboilceP.Properties.Items.Add(dr[0]);


            }

            bgln.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow drow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(drow != null)
            {
                textIdP.Text = drow["ID"].ToString();
                textAdP.Text = drow["AD"].ToString();
                textSoyadP.Text = drow["SOYAD"].ToString();
                maskedTelP.Text = drow["TELEFON"].ToString();
                maskedTcP.Text = drow["TC"].ToString();
                textMailP.Text = drow["MAIL"].ToString();
                comboilP.Text = drow["IL"].ToString();
                comboilceP.Text = drow["ILCE"].ToString();
                richAcikadresP.Text = drow["ACIKADRES"].ToString();
                textStatuP.Text = drow["STATU"].ToString();


            }
        }

        private void BttnTemizleP_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BttnSilP_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("Müşteri Bilgisi Silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("delete from TBL_PERSONEL where ID=@P1", bgln.baglanti());

                komutsil.Parameters.AddWithValue("@P1", textIdP.Text);
                komutsil.ExecuteNonQuery();
                bgln.baglanti().Close();
                MessageBox.Show("Personel Başarıyla Sİlindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                personellistele();
            }
        }

        private void BttnGuncelleP_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update TBL_PERSONEL set AD=@P1, SOYAD=@P2, TELEFON=@P3, TC=@P4, MAIL=@P5, IL=@P6, ILCE=@P7, ACIKADRES=@P8, STATU=@P9 where ID=@P10", bgln.baglanti());

            komutguncelle.Parameters.AddWithValue("@P1", textAdP.Text);
            komutguncelle.Parameters.AddWithValue("@P2", textSoyadP.Text);
            komutguncelle.Parameters.AddWithValue("@P3", maskedTelP.Text);
            komutguncelle.Parameters.AddWithValue("@P4", maskedTcP.Text);
            komutguncelle.Parameters.AddWithValue("@P5", textMailP.Text);
            komutguncelle.Parameters.AddWithValue("@P6", comboilP.Text);
            komutguncelle.Parameters.AddWithValue("@P7", comboilceP.Text);
            komutguncelle.Parameters.AddWithValue("@P8", richAcikadresP.Text);
            komutguncelle.Parameters.AddWithValue("@P9", textStatuP.Text);
            komutguncelle.Parameters.AddWithValue("@P10", textIdP.Text);

            komutguncelle.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Personel Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personellistele();
            temizle();

        }
    }
}
