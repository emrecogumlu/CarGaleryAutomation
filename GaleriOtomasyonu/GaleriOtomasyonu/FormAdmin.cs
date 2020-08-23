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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        private void BttnGirisG_Click(object sender, EventArgs e)
        {
            SqlCommand giris = new SqlCommand("select * from TBL_ADMIN where KULLANICIAD=@P1 and SIFRE=@P2 ", bgln.baglanti());

            giris.Parameters.AddWithValue("@P1", textKadiG.Text);
            giris.Parameters.AddWithValue("@P2", textSifreG.Text);
            SqlDataReader dr = giris.ExecuteReader();

            if (dr.Read())
            {
                FormAna fr = new FormAna();
                
                fr.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgln.baglanti().Close();
        }

        private void BttnGirisG_MouseHover(object sender, EventArgs e)
        {
            BttnGirisG.BackColor = Color.Yellow;
        }

        private void BttnGirisG_MouseLeave(object sender, EventArgs e)
        {
            BttnGirisG.BackColor = Color.SteelBlue;
        }
    }
}
