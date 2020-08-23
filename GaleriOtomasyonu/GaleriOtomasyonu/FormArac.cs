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
    public partial class FormArac : Form
    {
        public FormArac()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        void listele()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_URUN", bgln.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;



        }


        void vasitalistele()
        {
            SqlCommand komut = new SqlCommand("select distinct ARACAD from TBL_URUN", bgln.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboVasitaA.Properties.Items.Add(dr[0]);
            }
            bgln.baglanti().Close();
        }



        void temizle()
        {
            textId.Text = "";
            comboVasitaA.Text = "";
            comboMarkaA.Text = "";
            comboModelA.Text = "";
            comboYilA.Text = "";
            numupAdet.Text = "";
            textAlis.Text = "";
            textSatis.Text = "";
            richDetay.Text = "";

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormArac_Load(object sender, EventArgs e)
        {
            listele();
            vasitalistele();
            temizle();
        }

        private void BttnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_URUN (ARACAD,MARKAAD,MODEL,YIL,ADET,ALIS,SATIS,DETAY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgln.baglanti());


            komut.Parameters.AddWithValue("@p1", comboVasitaA.Text);
            komut.Parameters.AddWithValue("@p2", comboMarkaA.Text);
            komut.Parameters.AddWithValue("@p3", comboModelA.Text);
            komut.Parameters.AddWithValue("@p4", comboYilA.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((numupAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(textAlis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(textSatis.Text));
            komut.Parameters.AddWithValue("@p8", richDetay.Text);

            komut.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Araç başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BttnSil_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("Araç Bilgisi Silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {


                SqlCommand komutsil = new SqlCommand("delete from TBL_URUN where ID=@p1", bgln.baglanti());

                komutsil.Parameters.AddWithValue("@p1", textId.Text);
                komutsil.ExecuteNonQuery();
                bgln.baglanti().Close();
                MessageBox.Show("Araç Bilgisi Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listele();
                temizle();
            }
        }


        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow drow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(drow != null)
            {
                textId.Text = drow["ID"].ToString();
                comboVasitaA.Text = drow["ARACAD"].ToString();
                comboMarkaA.Text = drow["MARKAAD"].ToString();
                comboModelA.Text = drow["MODEL"].ToString();
                comboYilA.Text = drow["YIL"].ToString();
                numupAdet.Value = decimal.Parse(drow["ADET"].ToString());
                textAlis.Text = drow["ALIS"].ToString();
                textSatis.Text = drow["SATIS"].ToString();
                richDetay.Text = drow["DETAY"].ToString();
            }
            
        }

        private void BttnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update TBL_URUN set ARACAD=@p1, MARKAAD=@p2, MODEL= @p3, YIL=@p4, ADET=@p5, ALIS=@p6, SATIS=@p7, DETAY=@p8 where ID=@p9", bgln.baglanti());

            komutguncelle.Parameters.AddWithValue("@p1", comboVasitaA.Text);
            komutguncelle.Parameters.AddWithValue("@p2", comboMarkaA.Text);
            komutguncelle.Parameters.AddWithValue("@p3", comboModelA.Text);
            komutguncelle.Parameters.AddWithValue("@p4", comboYilA.Text);
            komutguncelle.Parameters.AddWithValue("@p5", int.Parse((numupAdet.Value).ToString()));
            komutguncelle.Parameters.AddWithValue("@p6", decimal.Parse(textAlis.Text));
            komutguncelle.Parameters.AddWithValue("@p7", decimal.Parse(textSatis.Text));
            komutguncelle.Parameters.AddWithValue("@p8", richDetay.Text);
            komutguncelle.Parameters.AddWithValue("@p9", textId.Text);
            komutguncelle.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Araç başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            temizle();

            }

        private void BttnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void comboMarkaA_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboMarkaA_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void comboVasitaA_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
