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
using System.Security.Cryptography;

namespace BruteForcePasswordFinder
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
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.LightGreen800, Primary.LightGreen900,
                Primary.LightGreen500, Accent.LightGreen200, TextShade.WHITE);

        }

        void Check(string pch, string charset)
        {
            charset.Split(new[] {','}).ToList<string>();
            foreach (char ch in charset)
            {
                string sch = Convert.ToString(ch);
                if (sch == pch)
                {

                    txtResult.Text =   txtResult.Text + " \n Trying.. [ " + ch + " ]" +System.Environment.NewLine;

                    txtResult.Text =   txtResult.Text + " \n ###### Matched [ " + ch + " ] ######" + System.Environment.NewLine;
                    break;
                }
                else
                {
                    txtResult.Text =   txtResult.Text + " \n Trying.. [ " + ch + " ]" + System.Environment.NewLine;
                }
            }
        }



        string BruteForce()
        {
            string pasw = txtPassword.Text;
            string charset = "abcdefghijklmnopqrstuvwxyz";
            string charset1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string charset2 = "0123456789";
            string charset3 = "!@#$%^&*(~[-+:=;'{<>_?/,.|¿¡}'])";
            string result = "";
            txtResult.Text ="[+][+] Starting BruteForce...";
            pasw.Split(new[] { ',' }).ToList<string>();
            for (int x = 0; x <= pasw.Length - 1; x++)
            {
                string pch = Convert.ToString(pasw[x]);
                if (charset.Contains(pch))
                {
                    Check(pch, charset);
                    result += pch;
                }
                else if (charset1.Contains(pch))
                {
                    Check(pch, charset1);
                    result += pch;
                }
                else if (charset2.Contains(pch))
                {
                    Check(pch, charset2);
                    result += pch;
                }
                else
                {
                    Check(pch, charset3);
                    result += pch;
                }
            }
            return result;
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " All Matched - Password Found: " + BruteForce();
        }
    }
}
