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

namespace FreeSmsSender
{
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
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
        public Form2()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Cyan500, Primary.Cyan700, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Visible = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try {
                Form1 f1 =  new Form1();
               
                SmtpClient smtp = new SmtpClient();
                MailMessage message = new MailMessage();
                smtp.Credentials = new NetworkCredential(f1.txtUser.Text, f1.txtPass.Text);
                smtp.Host = "ipipi.com";
                message.From = new MailAddress(string.Format("{0}@sms.ipipi.com"),f1.txtUser.Text);
                message.To.Add(string.Format("{0}@sms.ipipi",txtPhone.Text));
                message.Subject = "Free sms sender by amine smahi";
                message.Body = txtMess.Text;
                smtp.Send(message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
