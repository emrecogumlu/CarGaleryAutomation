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
using System.Xml;


namespace GaleriOtomasyonu
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        sqlbaglanti bgln = new sqlbaglanti();

        void azalanvasita()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ARACAD AS 'VASITA ADI', SUM(ADET) AS 'ADET' FROM TBL_URUN GROUP BY ARACAD HAVING SUM(ADET) <=10 ORDER BY SUM(ADET)", bgln.baglanti());
            da.Fill(dt);
            gridControlAzalan.DataSource = dt;

        }

        void ajandanot()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select TOP 3 NOTTARIH AS 'TARİH', NOTSAAT AS 'SAAT', NOTKONU AS 'BAŞLIK' FROM TBL_NOT ORDER BY NOTID DESC", bgln.baglanti());
            da2.Fill(dt2);
            gridControlAjanda.DataSource = dt2;
        }
        void hareketana()
        {
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Exec firmahareket2", bgln.baglanti());
            da3.Fill(dt3);
            gridControlIslem.DataSource = dt3;
        }
        void fihrist()
        {
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select AD AS 'FİRMA ADI', YETKILIADSOYAD AS 'YETKİLİ', TELEFON1 AS 'TELEFON 1', TELEFON2 AS 'TELEFON 2' FROM TBL_FIRMA", bgln.baglanti());
            da4.Fill(dt4);
            gridControlFihrist.DataSource = dt4;
        }

        void haber()
        {
            XmlTextReader xmlokut = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");

            while (xmlokut.Read())
            {
                if(xmlokut.Name == "title")
                {
                    listBox1.Items.Add(xmlokut.ReadString());
                }
            }
            
        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
            azalanvasita();
            ajandanot();
            hareketana();
            fihrist();
            //webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            //haber();
        }
    }
}
