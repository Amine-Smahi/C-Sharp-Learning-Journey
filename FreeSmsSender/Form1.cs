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

namespace FreeSmsSender
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
    // add shadow to corners
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
            skinManager.ColorScheme = new ColorScheme(Primary.Cyan500, Primary.Cyan700, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
            
      
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Pleas enter a valide username or password");
            }
            else
            {
                new Form2().Show();
                this.Visible = false;
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "" || txtPass.Text==""){
                MessageBox.Show("Pleas enter a valide username or password");
            }
            else{
                new Form2().Show();
                this.Visible = false;
            }
           
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
