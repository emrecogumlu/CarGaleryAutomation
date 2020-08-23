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
    public partial class FormAyar : Form
    {
        public FormAyar()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_ADMIN", bgln.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void temizle()
        {
            textKullaniciA.Text = "";
            textSifreA.Text = "";
        }

        private void FormAyar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BttnKaydet_Click(object sender, EventArgs e)
        {
            if (BttnKaydet.Text == "Kaydet")
            {

                SqlCommand komutkaydet = new SqlCommand("insert into TBL_ADMIN values (@p1, @p2)", bgln.baglanti());

                komutkaydet.Parameters.AddWithValue("@p1", textKullaniciA.Text);
                komutkaydet.Parameters.AddWithValue("@p2", textSifreA.Text);

                komutkaydet.ExecuteNonQuery();
                bgln.baglanti().Close();

                MessageBox.Show("Yeni Admin Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listele();
                temizle();
            }

            if(BttnKaydet.Text == "Güncelle")
            {
                SqlCommand komutguncelle = new SqlCommand("update TBL_ADMIN set SIFRE= @P2 where KULLANICIAD= @P1", bgln.baglanti());
                komutguncelle.Parameters.AddWithValue("@P1", textKullaniciA.Text);
                komutguncelle.Parameters.AddWithValue("@P2", textSifreA.Text);

                komutguncelle.ExecuteNonQuery();
                bgln.baglanti().Close();
                MessageBox.Show("Kullanıcı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow drow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(drow != null)
            {
                textKullaniciA.Text = drow["KULLANICIAD"].ToString();
                textSifreA.Text = drow["SIFRE"].ToString();
            }
        }

        private void textKullaniciA_EditValueChanged(object sender, EventArgs e)
        {
            if(textKullaniciA.Text != "")
            {
                BttnKaydet.Text = "Güncelle";
                BttnKaydet.BackColor = Color.Aqua;
            }
            else
            {
                BttnKaydet.Text = "Kaydet";
                BttnKaydet.BackColor = Color.Silver;
            }
        }

        private void BttnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("Kullanıcı Silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("delete from TBL_ADMIN where KULLANICIAD=@P1 and SIFRE=@P2", bgln.baglanti());
                komutsil.Parameters.AddWithValue("@P1", textKullaniciA.Text);
                komutsil.Parameters.AddWithValue("@P2", textSifreA.Text);

                komutsil.ExecuteNonQuery();
                bgln.baglanti().Close();
                temizle();
                MessageBox.Show("Kullanıcı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }

        }
    }
}
