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
    public partial class FormGarajDetay : Form
    {
        public FormGarajDetay()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        public string ad;

        private void FormGarajDetay_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_URUN where ARACAD='" + ad + "'", bgln.baglanti());

            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
