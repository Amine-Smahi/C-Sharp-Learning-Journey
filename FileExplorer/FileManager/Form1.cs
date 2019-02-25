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
using System.IO;

namespace FileManager
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        List<string> listFiles = new List<string>();
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
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            listView1.Items.Clear();
            using(FolderBrowserDialog fbd = new FolderBrowserDialog(){ Description="Select your path."})
            {
                if(fbd.ShowDialog()== DialogResult.OK){
                    txtPath.Text = fbd.SelectedPath;
                    foreach(string item in Directory.GetFiles(fbd.SelectedPath)){
                        imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        listFiles.Add(fi.FullName);
                        listView1.Items.Add(fi.Name,imageList.Images.Count - 1);
                    }
                }
            }
        }
    }
}
