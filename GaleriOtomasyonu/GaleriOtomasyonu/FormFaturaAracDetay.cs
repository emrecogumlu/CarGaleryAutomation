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
    public partial class FormFaturaAracDetay : Form
    {
        public FormFaturaAracDetay()
        {
            InitializeComponent();
        }

        public string id;
        sqlbaglanti bgln = new sqlbaglanti();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FATURADETAY where FATURAID='" + id + "'", bgln.baglanti());

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }


        private void FormFaturaAracDetay_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormFaturaAracDetayDuzenleme fr = new FormFaturaAracDetayDuzenleme();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr != null)
            {
                fr.aracid = dr["FATURAURUNID"].ToString();
            }
            fr.Show();
        }
    }
}
