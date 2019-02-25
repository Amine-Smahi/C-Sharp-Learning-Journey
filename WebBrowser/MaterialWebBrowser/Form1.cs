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

namespace MaterialWebBrowser
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
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
        public Form1()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
           
            skinManager.ColorScheme = new ColorScheme(Primary.Cyan700, Primary.Cyan800, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            button2.Enabled = webBrowser1.CanGoForward;
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by Amine Smahi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                button1_Click(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigatetoPage();
        }

        private void NavigatetoPage()
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
            webBrowser1.Navigate(textBox1.Text);
            toolStripStatusLabel1.Text = "Loading Webpage";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            toolStripStatusLabel1.Text = "Loading Complete";
        }
    }
}
