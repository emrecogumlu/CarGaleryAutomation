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
    public partial class FormBanka : Form
    {
        public FormBanka()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        void bankalistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute bankabilgi", bgln.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void illisteleB()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from TBL_IL", bgln.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboilB.Properties.Items.Add(dr[0]);
            }
            bgln.baglanti().Close();
        }

        void firmalistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID, AD from TBL_FIRMA", bgln.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;


        }

        void temizle()
        {
            textIdB.Text = "";
            textAdB.Text = "";
            comboilB.Text = "";
            comboilceB.Text = "";
            textSubeB.Text = "";
            maskedIbanB.Text = "";
            maskedHesapnoB.Text = "";
            textYetkiliB.Text = "";
            maskedTelB.Text = "";
            maskedTarihB.Text = "";
            textHesapcesidiB.Text = "";
            lookUpEdit1.Text = "";
        }

        private void FormBanka_Load(object sender, EventArgs e)
        {
            bankalistele();
            illisteleB();
            firmalistele();
            temizle();
        }

        private void BttnKaydetB_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into TBL_BANKA (BANKAADI, IL ,ILCE, SUBE, IBANNO, HESAPNO, BANKAYETKILISI, TELEFON, TARIH, HESAPCESIDI, FIRMAID) values (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11)", bgln.baglanti());

            komutkaydet.Parameters.AddWithValue("@P1", textAdB.Text);
            komutkaydet.Parameters.AddWithValue("@P2", comboilB.Text);
            komutkaydet.Parameters.AddWithValue("@P3", comboilceB.Text);
            komutkaydet.Parameters.AddWithValue("@P4", textSubeB.Text);
            komutkaydet.Parameters.AddWithValue("@P5", maskedIbanB.Text);
            komutkaydet.Parameters.AddWithValue("@P6", maskedHesapnoB.Text);
            komutkaydet.Parameters.AddWithValue("@P7", textYetkiliB.Text);
            komutkaydet.Parameters.AddWithValue("@P8", maskedTelB.Text);
            komutkaydet.Parameters.AddWithValue("@P9", maskedTarihB.Text);
            komutkaydet.Parameters.AddWithValue("@P10", textHesapcesidiB.Text);
            komutkaydet.Parameters.AddWithValue("@P11", lookUpEdit1.EditValue);

            if(lookUpEdit1.EditValue == null)
            {
                MessageBox.Show("Lütfen Firma Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bankalistele();
                temizle();
            }
            else {
                komutkaydet.ExecuteNonQuery();
                bgln.baglanti().Close();

                MessageBox.Show("Banka Bilgisi Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bankalistele();
                temizle();
            }
        }

        private void comboilB_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboilceB.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_ILCE where SEHIR=@p1", bgln.baglanti());
            komut.Parameters.AddWithValue("@p1", comboilB.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboilceB.Properties.Items.Add(dr[0]);


            }

            bgln.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow drow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (drow != null)
            {
                textIdB.Text = drow["ID"].ToString();
                textAdB.Text = drow["BANKAADI"].ToString();
                comboilB.Text = drow["IL"].ToString();
                comboilceB.Text = drow["ILCE"].ToString();
                textSubeB.Text = drow["SUBE"].ToString();
                maskedIbanB.Text = drow["IBANNO"].ToString();
                maskedHesapnoB.Text = drow["HESAPNO"].ToString();
                textYetkiliB.Text = drow["BANKAYETKILISI"].ToString();
                maskedTelB.Text = drow["TELEFON"].ToString();
                maskedTarihB.Text = drow["TARIH"].ToString();
                textHesapcesidiB.Text = drow["HESAPCESIDI"].ToString();
                
                
            }
        }

        private void BttnTemizleB_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BttnSilB_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("Araç Bilgisi Silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("delete from TBL_BANKA WHERE ID=@P1", bgln.baglanti());
                komutsil.Parameters.AddWithValue("@P1", textIdB.Text);
                komutsil.ExecuteNonQuery();
                bgln.baglanti().Close();
                temizle();
                MessageBox.Show("Banka Bilgisi Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bankalistele();
            }
        }

        private void BttnGuncelleB_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update TBL_BANKA set BANKAADI=@P1, IL=@P2, ILCE=@P3, SUBE=@P4, IBANNO=@P5, HESAPNO=@P6, BANKAYETKILISI=@P7, TELEFON =@P8, TARIH=@P9, HESAPCESIDI=@P10, FIRMAID=@P11 where ID=@P12", bgln.baglanti());

            komutguncelle.Parameters.AddWithValue("@P1", textAdB.Text);
            komutguncelle.Parameters.AddWithValue("@P2", comboilB.Text);
            komutguncelle.Parameters.AddWithValue("@P3", comboilceB.Text);
            komutguncelle.Parameters.AddWithValue("@P4", textSubeB.Text);
            komutguncelle.Parameters.AddWithValue("@P5", maskedIbanB.Text);
            komutguncelle.Parameters.AddWithValue("@P6", maskedHesapnoB.Text);
            komutguncelle.Parameters.AddWithValue("@P7", textYetkiliB.Text);
            komutguncelle.Parameters.AddWithValue("@P8", maskedTelB.Text);
            komutguncelle.Parameters.AddWithValue("@P9", maskedTarihB.Text);
            komutguncelle.Parameters.AddWithValue("@P10", textHesapcesidiB.Text);
            komutguncelle.Parameters.AddWithValue("@P11", lookUpEdit1.EditValue);
            komutguncelle.Parameters.AddWithValue("@P12", textIdB.EditValue);

            komutguncelle.ExecuteNonQuery();
            bgln.baglanti().Close();

            MessageBox.Show("Banka Bilgisi Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bankalistele();
            temizle();

        }
    }
}
