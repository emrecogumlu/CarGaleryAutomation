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
    public partial class FormGider : Form
    {
        public FormGider()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        void giderlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_GIDER order by ID asc", bgln.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            textIdG.Text = "";
            comboayG.Text = "";
            comboyilG.Text = "";
            textElektrikG.Text = "";
            textSuG.Text = "";
            textDogalG.Text = "";
            textInternetG.Text = "";
            textMaasG.Text = "";
            textEkstraG.Text = "";
            richNotG.Text = "";
            
        }
        

        private void FormGider_Load(object sender, EventArgs e)
        {
            giderlistele();
            temizle();
        }

        private void BttnKaydetG_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into TBL_GIDER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAAS,EKGIDER,NOTT) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)", bgln.baglanti());

            komutkaydet.Parameters.AddWithValue("@P1", comboayG.Text);
            komutkaydet.Parameters.AddWithValue("@P2", comboyilG.Text);
            komutkaydet.Parameters.AddWithValue("@P3", decimal.Parse(textElektrikG.Text));
            komutkaydet.Parameters.AddWithValue("@P4", decimal.Parse(textSuG.Text));
            komutkaydet.Parameters.AddWithValue("@P5", decimal.Parse(textDogalG.Text));
            komutkaydet.Parameters.AddWithValue("@P6", decimal.Parse(textInternetG.Text));
            komutkaydet.Parameters.AddWithValue("@P7", decimal.Parse(textMaasG.Text));
            komutkaydet.Parameters.AddWithValue("@P8", decimal.Parse(textEkstraG.Text));
            komutkaydet.Parameters.AddWithValue("@P9", richNotG.Text);

            komutkaydet.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Gider Bİlgisi Başarıyla Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderlistele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow drow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(drow != null)
            {
                textIdG.Text = drow["ID"].ToString();
                comboayG.Text = drow["AY"].ToString();
                comboyilG.Text = drow["YIL"].ToString();
                textElektrikG.Text = drow["ELEKTRIK"].ToString();
                textSuG.Text = drow["SU"].ToString();
                textDogalG.Text = drow["DOGALGAZ"].ToString();
                textInternetG.Text = drow["INTERNET"].ToString();
                textMaasG.Text = drow["MAAS"].ToString();
                textEkstraG.Text = drow["EKGIDER"].ToString();
                richNotG.Text = drow["NOTT"].ToString();
            }
        }

        private void BttnTemizleG_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BttnSilG_Click(object sender, EventArgs e)
        {
            DialogResult Secim = new DialogResult();

            Secim = MessageBox.Show("Gider Bilgisi Silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Secim == DialogResult.Yes)
            {

                SqlCommand komutsil = new SqlCommand("delete from TBL_GIDER where ID=@p1", bgln.baglanti());

                komutsil.Parameters.AddWithValue("@p1", textIdG.Text);
                komutsil.ExecuteNonQuery();
                bgln.baglanti().Close();
                MessageBox.Show("Müşteri Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                giderlistele();
            }
        }

        private void BttnGuncelleG_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update TBL_GIDER set AY=@P1, YIL=@P2, ELEKTRIK=@P3, SU=@P4, DOGALGAZ=@P5, INTERNET=@P6, MAAS=@P7, EKGIDER=@P8, NOTT=@P9 where ID=@P10", bgln.baglanti());

            komutguncelle.Parameters.AddWithValue("@P1", comboayG.Text);
            komutguncelle.Parameters.AddWithValue("@P2", comboyilG.Text);
            komutguncelle.Parameters.AddWithValue("@P3", Decimal.Parse(textElektrikG.Text));
            komutguncelle.Parameters.AddWithValue("@P4", Decimal.Parse(textSuG.Text));
            komutguncelle.Parameters.AddWithValue("@P5", Decimal.Parse(textDogalG.Text));
            komutguncelle.Parameters.AddWithValue("@P6", Decimal.Parse(textInternetG.Text));
            komutguncelle.Parameters.AddWithValue("@P7", Decimal.Parse(textMaasG.Text));
            komutguncelle.Parameters.AddWithValue("@P8", Decimal.Parse(textEkstraG.Text));
            komutguncelle.Parameters.AddWithValue("@P9", richNotG.Text);
            komutguncelle.Parameters.AddWithValue("@P10", textIdG.Text);

            komutguncelle.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Gider Bilgisi Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            giderlistele();
            temizle();
        }
    }
}
