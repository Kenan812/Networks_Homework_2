using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesApplication
{
    public partial class SendMailForm : Form
    {
        private string _msg;

        public SendMailForm(string msg)
        {
            InitializeComponent();

            _msg = msg;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (toTextBox.Text != String.Empty)
            {
                SendMail();
            }
        }
        
        private void SendMail()
        {
            NetworkCredential credential = new NetworkCredential("testoving.test@gmail.com", "1a2b3c4d5e))");

            MailMessage mail = new MailMessage();

            MailAddress from = new MailAddress("testoving.test@gmail.com");
            MailAddress to = new MailAddress(toTextBox.Text);

            mail.From = from;
            mail.To.Add(to);

            mail.Subject = headerTextBox.Text;
            mail.IsBodyHtml = true;
            mail.Body = textTextBox.Text;

            SmtpClient client= new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = credential;
            client.EnableSsl = true;
            client.Send(mail);
        }
    }
}
