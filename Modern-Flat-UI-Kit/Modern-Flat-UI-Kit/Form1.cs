using System;
using System.Windows.Forms;

namespace ModernFlatUIKit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(this,10);
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

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}