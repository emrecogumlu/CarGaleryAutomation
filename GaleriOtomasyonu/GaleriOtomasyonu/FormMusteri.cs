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
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_MUSTERI", bgln.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt; 
        }

        void illistele()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from TBL_IL", bgln.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboilM.Properties.Items.Add(dr[0]);
            }
            bgln.baglanti().Close();
        }

        void temizle()
        {
            textIdM.Text = "";
            textAdM.Text = "";
            textSoyadM.Text = "";
            maskedTelM.Text = "";
            maskedTel2M.Text = "";
            maskedTcM.Text = "";
            comboilM.Text = "";
            comboilceM.Text = "";
            textMailM.Text = "";
            textVergiM.Text = "";
            richAcikadresM.Text = "";
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            listele();
            illistele();
            temizle();
            
        }

        private void comboilceM_SelectedIndexChanged(object sender, EventArgs e)
        {


            
        }

        private void comboilM_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboilceM.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_ILCE where SEHIR=@p1", bgln.baglanti());
            komut.Parameters.AddWithValue("@p1", comboilM.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboilceM.Properties.Items.Add(dr[0]);
                

            }
            
            bgln.baglanti().Close();
        }

        private void BttnKaydetM_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERI (AD,SOYAD,TELEFON,TELEFON2,TC,IL,ILCE,ACIKADRES,MAIL,VERGIDAIRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgln.baglanti());

            komut.Parameters.AddWithValue("@p1", textAdM.Text);
            komut.Parameters.AddWithValue("@p2", textSoyadM.Text);
            komut.Parameters.AddWithValue("@p3", maskedTelM.Text);
            komut.Parameters.AddWithValue("@p4", maskedTel2M.Text);
            komut.Parameters.AddWithValue("@p5", maskedTcM.Text);
            komut.Parameters.AddWithValue("@p6", comboilM.Text);
            komut.Parameters.AddWithValue("@p7", comboilceM.Text);
            komut.Parameters.AddWithValue("@p8", richAcikadresM.Text);
            komut.Parameters.AddWithValue("@p9", textMailM.Text);
            komut.Parameters.AddWithValue("@p10", textVergiM.Text);

            komut.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Müşteri Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BttnSilM_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("Müşteri Bilgisi Silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {

                SqlCommand komutsil = new SqlCommand("delete from TBL_MUSTERI where ID=@p1", bgln.baglanti());

                komutsil.Parameters.AddWithValue("@p1", textIdM.Text);
                komutsil.ExecuteNonQuery();
                bgln.baglanti().Close();
                MessageBox.Show("Müşteri Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
                temizle();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow drow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(drow != null)
            {
                textIdM.Text = drow["ID"].ToString();
                textAdM.Text = drow["AD"].ToString();
                textSoyadM.Text = drow["SOYAD"].ToString();
                maskedTelM.Text = drow["TELEFON"].ToString();
                maskedTel2M.Text = drow["TELEFON2"].ToString();
                maskedTcM.Text = drow["TC"].ToString();
                comboilM.Text = drow["IL"].ToString();
                comboilceM.Text = drow["ILCE"].ToString();
                textMailM.Text = drow["MAIL"].ToString();
                textVergiM.Text = drow["VERGIDAIRE"].ToString();
                richAcikadresM.Text = drow["ACIKADRES"].ToString();

            }
        }

        private void BttnGuncelleM_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update TBL_MUSTERI set AD=@p1, SOYAD=@p2, TELEFON=@p3, TELEFON2=@p4, TC=@p5, IL=@p6, ILCE=@p7, MAIL=@p8, VERGIDAIRE=@p9, ACIKADRES=@p10 where ID=@p11", bgln.baglanti());

            komutguncelle.Parameters.AddWithValue("@p1", textAdM.Text);
            komutguncelle.Parameters.AddWithValue("@p2", textSoyadM.Text);
            komutguncelle.Parameters.AddWithValue("@p3", maskedTelM.Text);
            komutguncelle.Parameters.AddWithValue("@p4", maskedTel2M.Text);
            komutguncelle.Parameters.AddWithValue("@p5", maskedTcM.Text);
            komutguncelle.Parameters.AddWithValue("@p6", comboilM.Text);
            komutguncelle.Parameters.AddWithValue("@p7", comboilceM.Text);
            komutguncelle.Parameters.AddWithValue("@p8", textMailM.Text);
            komutguncelle.Parameters.AddWithValue("@p9", textVergiM.Text);
            komutguncelle.Parameters.AddWithValue("@p10", richAcikadresM.Text);
            komutguncelle.Parameters.AddWithValue("@p11", textIdM.Text);

            komutguncelle.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Müşteri Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richAcikadresM_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void textVergiM_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void textSoyadM_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textAdM_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textIdM_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textMailM_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTcM_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTel2M_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTelM_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
