using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;




namespace GaleriOtomasyonu
{
    public partial class FormMail : Form
    {
        public FormMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void FormMail_Load(object sender, EventArgs e)
        {
            textMailMail.Text = mail;
        }

        private void BttnGonderMail_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("gcogumlu@gmail.com", "Emre5490");
            istemci.Port = 587;
            istemci.Host = "smptp.gmail.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(TxtMailAdresi.Text);
            mesaj.From = new MailAddress("gcogumlu@gmail.com");
            mesaj.Subject = textKonuMail.Text;
            mesaj.Body = TxtMailAdresi.Text;
            istemci.Send(mesaj);
        }
    }
}
