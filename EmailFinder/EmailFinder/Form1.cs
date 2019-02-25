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
using System.Text.RegularExpressions;

namespace EmailFinder
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
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string text = textBox1.Text;
                
                // regular expression for matching email addresses
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex re = new Regex(pattern);

            if (text != null)
            {
                // get all matches
                MatchCollection matches = re.Matches(text);
                if (matches.Count > 0)
                {
                    for (int i = 0; i < matches.Count; i++)
                    {
                        
                        textBox2.Text = textBox2.Text + matches[i] + System.Environment.NewLine;
                       
                    }
                }
            }
        }
    }
}
