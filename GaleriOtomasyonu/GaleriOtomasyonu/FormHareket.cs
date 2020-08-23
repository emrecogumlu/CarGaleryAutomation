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
    public partial class FormHareket : Form
    {
        public FormHareket()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        void firmahareketlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec firmahareket", bgln.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        void musterihareketlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec musterihareket", bgln.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FormHareket_Load(object sender, EventArgs e)
        {
            firmahareketlistele();
            musterihareketlistele();
        }
    }
}
