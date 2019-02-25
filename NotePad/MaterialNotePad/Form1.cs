using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialNotePad
{
    public partial class Form1 : Form
    {
        RichTextBox rtb;
        public Form1()
        {
            InitializeComponent();
            
        }

      

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
           Close();
        }
       

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
