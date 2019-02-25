using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace SendMail
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x39000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public Form1()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue800,Primary.LightBlue900,Primary.LightBlue500,Accent.LightBlue200,TextShade.WHITE);
            TxtPassword.PasswordChar = '*';
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(TxtFrom.Text,TxtTo.Text,TxtSubject.Text,TxtMessage.Text);
            SmtpClient client = new SmtpClient(TxtSmtp.Text);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(TxtUsername.Text,TxtPassword.Text);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Mail Sent !","Success",MessageBoxButtons.OK);
        }
       
    }
}
