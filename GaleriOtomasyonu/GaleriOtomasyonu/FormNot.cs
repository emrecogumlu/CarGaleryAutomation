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
    public partial class FormNot : Form
    {
        public FormNot()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        void notlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_NOT", bgln.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void temizle()
        {
            textIdN.Text = "";
            maskedTarihN.Text = "";
            maskedSaatN.Text = "";
            textKonuN.Text = "";
            textKimdenN.Text = "";
            textKimeN.Text = "";
            richDetayN.Text = "";
        }

        private void FormNot_Load(object sender, EventArgs e)
        {
            notlistele();
            temizle();
        }

        private void BttnKaydetN_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into TBL_NOT (NOTTARIH, NOTSAAT, NOTKONU, NOTUNSAHIBI, NOTHITAP, NOTDETAY) values (@P1, @P2, @P3, @P4, @P5, @P6)", bgln.baglanti());

            komutkaydet.Parameters.AddWithValue("@P1", maskedTarihN.Text);
            komutkaydet.Parameters.AddWithValue("@P2", maskedSaatN.Text);
            komutkaydet.Parameters.AddWithValue("@P3", textKonuN.Text);
            komutkaydet.Parameters.AddWithValue("@P4", textKimdenN.Text);
            komutkaydet.Parameters.AddWithValue("@P5", textKimeN.Text);
            komutkaydet.Parameters.AddWithValue("@P6", richDetayN.Text);

            komutkaydet.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Not Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            notlistele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow drow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(drow != null)
            {
                textIdN.Text = drow["NOTID"].ToString();
                maskedTarihN.Text = drow["NOTTARIH"].ToString();
                maskedSaatN.Text = drow["NOTSAAT"].ToString();
                textKonuN.Text = drow["NOTKONU"].ToString();
                textKimdenN.Text = drow["NOTUNSAHIBI"].ToString();
                textKimeN.Text = drow["NOTHITAP"].ToString();
                richDetayN.Text = drow["NOTDETAY"].ToString();
            }
        }

        private void BttnTemizleN_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BttnSilN_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("Not Bilgisi Silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {

                SqlCommand komutsil = new SqlCommand("delete from TBL_NOT where NOTID=@P1", bgln.baglanti());
                komutsil.Parameters.AddWithValue("@P1", textIdN.Text);
                komutsil.ExecuteNonQuery();
                bgln.baglanti().Close();
                MessageBox.Show("Not Bilgisi Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                notlistele();
                temizle();
            }
        }

        private void BttnGuncelleN_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update TBL_NOT set NOTTARIH=@P1, NOTSAAT=@P2, NOTKONU=@P3, NOTUNSAHIBI=@P4, NOTHITAP=@P5, NOTDETAY=@P6 where NOTID=@P7", bgln.baglanti());

            komutguncelle.Parameters.AddWithValue("@P1", maskedTarihN.Text);
            komutguncelle.Parameters.AddWithValue("@P2", maskedSaatN.Text);
            komutguncelle.Parameters.AddWithValue("@P3", textKonuN.Text);
            komutguncelle.Parameters.AddWithValue("@P4", textKimdenN.Text);
            komutguncelle.Parameters.AddWithValue("@P5", textKimeN.Text);
            komutguncelle.Parameters.AddWithValue("@P6", richDetayN.Text);
            komutguncelle.Parameters.AddWithValue("@P7", textIdN.Text);

            komutguncelle.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Not Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            notlistele();
            temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormNotDetay fr = new FormNotDetay();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr != null)
            {
                fr.metin = dr["NOTDETAY"].ToString();
            }
            fr.Show();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
