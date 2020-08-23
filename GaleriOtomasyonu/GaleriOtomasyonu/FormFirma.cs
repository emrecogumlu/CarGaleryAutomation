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
    public partial class FormFirma : Form
    {
        public FormFirma()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        void firmalistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FIRMA", bgln.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }

        void illisteleF()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from TBL_IL", bgln.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboilF.Properties.Items.Add(dr[0]);
            }
            bgln.baglanti().Close();
        }

        void temizle()
        {
            textIdF.Text = "";
            textAdF.Text = "";
            textSektorF.Text = "";
            textYetkiliF.Text = "";
            textGorevF.Text = "";
            maskedTcF.Text = "";
            maskedTelF.Text = "";
            maskedTel2F.Text = "";
            maskedFaxF.Text = "";
            textMailF.Text = "";
            comboilF.Text = "";
            comboilceF.Text = "";
            textVergiF.Text = "";
            richAcikadresF.Text = "";
            
            



        }

        
        private void FormFirma_Load(object sender, EventArgs e)
        {
            firmalistele();
            illisteleF();
            
            temizle();
            
        }

       

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow drow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (drow != null)
            {
                textIdF.Text = drow["ID"].ToString();
                textAdF.Text = drow["AD"].ToString();
                maskedTelF.Text = drow["TELEFON1"].ToString();
                maskedTel2F.Text = drow["TELEFON2"].ToString();
                textYetkiliF.Text = drow["YETKILIADSOYAD"].ToString();
                maskedTcF.Text = drow["YETKILITC"].ToString();
                textSektorF.Text = drow["SEKTOR"].ToString();
                textGorevF.Text = drow["YETKILIGOREV"].ToString();
                textMailF.Text = drow["MAIL"].ToString();
                comboilF.Text = drow["IL"].ToString();
                comboilceF.Text = drow["ILCE"].ToString();
                maskedFaxF.Text = drow["FAX"].ToString();
                textVergiF.Text = drow["VERGIDAIRE"].ToString();
                richAcikadresF.Text = drow["ACIKADRES"].ToString();
                
            }
        }

        private void BttnKaydetF_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into TBL_FIRMA (AD,TELEFON1,TELEFON2,YETKILIADSOYAD,YETKILITC,SEKTOR,YETKILIGOREV,MAIL,IL,ILCE,FAX,VERGIDAIRE,ACIKADRES,OZEL1,OZEL2,OZEL3) values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16)", bgln.baglanti());


            komutkaydet.Parameters.AddWithValue("@P1", textAdF.Text);
            komutkaydet.Parameters.AddWithValue("@P2", maskedTelF.Text);
            komutkaydet.Parameters.AddWithValue("@P3", maskedTel2F.Text);
            komutkaydet.Parameters.AddWithValue("@P4", textYetkiliF.Text);
            komutkaydet.Parameters.AddWithValue("@P5", maskedTcF.Text);
            komutkaydet.Parameters.AddWithValue("@P6", textSektorF.Text);
            komutkaydet.Parameters.AddWithValue("@P7", textGorevF.Text);
            komutkaydet.Parameters.AddWithValue("@P8", textMailF.Text);
            komutkaydet.Parameters.AddWithValue("@P9", comboilF.Text);
            komutkaydet.Parameters.AddWithValue("@P10", comboilceF.Text);
            komutkaydet.Parameters.AddWithValue("@P11", maskedFaxF.Text);
            komutkaydet.Parameters.AddWithValue("@P12", textVergiF.Text);
            komutkaydet.Parameters.AddWithValue("@P13", richAcikadresF.Text);
            

            komutkaydet.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Firma Bilgisi Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistele();
            temizle();
            
        }

        private void comboilF_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboilceF.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("select ILCE from TBL_ILCE where SEHIR=@p1", bgln.baglanti());
            komut.Parameters.AddWithValue("@p1", comboilF.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboilceF.Properties.Items.Add(dr[0]);


            }

            bgln.baglanti().Close();
        }

        private void BttnSilF_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("Firma Bilgisi Silinecek. Ayrıca Varsa Firmaya Ait Banka Bilgisi Silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes) {
                SqlCommand komutsil = new SqlCommand("delete from TBL_FIRMA WHERE ID=@P1", bgln.baglanti());
                komutsil.Parameters.AddWithValue("@P1", textIdF.Text);
               
                    komutsil.ExecuteNonQuery();
                    bgln.baglanti().Close();
                    firmalistele();
                    temizle();
                    MessageBox.Show("Firma Bilgisi Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    firmalistele();
                    temizle();
                
            }

                

        }

        private void BttnGuncelleF_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update TBL_FIRMA set AD=@P1, TELEFON1=@P2, TELEFON2=@P3, YETKILIADSOYAD=@P4, YETKILITC=@P5, SEKTOR=@P6, YETKILIGOREV=@P7, MAIL=@P8,IL=@P9, ILCE=@P10, FAX=@P11, VERGIDAIRE=@P12, ACIKADRES=@P13, OZEL1=@P14, OZEL2=@P15, OZEL3=@P16 where ID=@P17 ", bgln.baglanti());

            komutguncelle.Parameters.AddWithValue("@P1", textAdF.Text);
            komutguncelle.Parameters.AddWithValue("@P2", maskedTelF.Text);
            komutguncelle.Parameters.AddWithValue("@P3", maskedTel2F.Text);
            komutguncelle.Parameters.AddWithValue("@P4", textYetkiliF.Text);
            komutguncelle.Parameters.AddWithValue("@P5", maskedTcF.Text);
            komutguncelle.Parameters.AddWithValue("@P6", textSektorF.Text);
            komutguncelle.Parameters.AddWithValue("@P7", textGorevF.Text);
            komutguncelle.Parameters.AddWithValue("@P8", textMailF.Text);
            komutguncelle.Parameters.AddWithValue("@P9", comboilF.Text);
            komutguncelle.Parameters.AddWithValue("@P10", comboilceF.Text);
            komutguncelle.Parameters.AddWithValue("@P11", maskedFaxF.Text);
            komutguncelle.Parameters.AddWithValue("@P12", textVergiF.Text);
            komutguncelle.Parameters.AddWithValue("@P13", richAcikadresF.Text);
            komutguncelle.Parameters.AddWithValue("@p17", textIdF.Text);

            komutguncelle.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Firma Bilgisi Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistele();
            temizle();
        }

        private void richTextKod1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BttnTemizleF_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
