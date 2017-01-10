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
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
