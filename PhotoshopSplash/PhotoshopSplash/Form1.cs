using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PhotoshopSplash
{
    public partial class Splash : Form
    {
        private int step;

        public Splash()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            try
            {
                Hide();
                var bitmap = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);
                var graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(Location.X, Location.Y, 0, 0, Size, CopyPixelOperation.SourceCopy);
                bitmap.Save("spls.bin", ImageFormat.Png);
                BackgroundImage = bitmap;
                base.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (step)
            {
                case 0:
                    timer1.Interval = 2000;
                    break;
                case 1:
                    lbl.Text = "Initializing Modules  ... 100%";
                    break;
                case 2:
                    lbl.Text = "Initializing UI  ... 100%";
                    break;
                case 3:
                    lbl.Text = "Initializing Plugins  ... 100%";
                    break;


                case 7:
                    Close();
                    break;
            }
            Enabled = false;
            step++;
        }
    }
}