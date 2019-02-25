using System;
using System.Diagnostics;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace YoutubeDownloader
{
    public partial class about : MaterialForm
    {
        public about()
        {
            InitializeComponent();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red800,
                Primary.Red500, Accent.Blue200, TextShade.WHITE);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x39000;
                var cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://facebook.com/amine.developer");
        }
    }
}