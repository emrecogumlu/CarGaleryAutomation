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
    public partial class FormGaraj : Form
    {
        public FormGaraj()
        {
            InitializeComponent();
        }
        sqlbaglanti bgln = new sqlbaglanti();

        private void FormGaraj_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ARACAD AS 'VASITA ADI' , SUM(ADET) AS 'SAYI' FROM TBL_URUN GROUP BY ARACAD", bgln.baglanti());

            da.Fill(dt);
            gridControl1.DataSource = dt;


            //aracmiktar
            SqlCommand komut = new SqlCommand("SELECT ARACAD AS 'VASITA TİPİ' , SUM(ADET) AS 'SAYI' FROM TBL_URUN GROUP BY ARACAD", bgln.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {

                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
                
            }
            bgln.baglanti().Close();

            //firmail

            SqlCommand komut2 = new SqlCommand("SELECT IL AS 'ŞEHİR', COUNT(*) FROM TBL_FIRMA GROUP BY IL", bgln.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }

            bgln.baglanti().Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FormGarajDetay fr = new FormGarajDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.ad = dr["VASITA ADI"].ToString();
            }
            fr.Show();
        }
    }
}
