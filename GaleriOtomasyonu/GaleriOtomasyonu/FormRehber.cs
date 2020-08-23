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
    public partial class FormRehber : Form
    {
        public FormRehber()
        {
            InitializeComponent();
        }
        sqlbaglanti bgln = new sqlbaglanti();

        private void FormRehber_Load(object sender, EventArgs e)
        {
            //musteri
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select AD, SOYAD, TELEFON, TELEFON2, MAIL from TBL_MUSTERI", bgln.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //firma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select AD, YETKILIADSOYAD, TELEFON1, TELEFON2, MAIL, FAX  from TBL_FIRMA", bgln.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormMail frm = new FormMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();
                frm.Show();
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FormMail frm = new FormMail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();
                frm.Show();
            }
        }
    }
}
