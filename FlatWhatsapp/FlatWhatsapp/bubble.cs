using System;
using System.Drawing;
using System.Windows.Forms;

namespace Whatsapp_Bunifu_UI
{
    public partial class bubble : UserControl
    {
        public bubble()
        {
            InitializeComponent();
        }

        public bubble(string message, string time, msgtype messagetype)
        {
            InitializeComponent();
            lblmessgae.Text = message;
            lbltime.Text = time;

            if (messagetype.ToString() == "In")
                BackColor = Color.FromArgb(0, 164, 147);
            else
                BackColor = Color.Gray;

            Setheight();
        }


        //lets add the function which adjusts the bubble height


        private void Setheight()
        {
            var maxSize = new Size(495, int.MaxValue);
            var g = CreateGraphics();
            var size = g.MeasureString(lblmessgae.Text, lblmessgae.Font, lblmessgae.Width);


            lblmessgae.Height = int.Parse(Math.Round(size.Height + 2, 0).ToString());
            lbltime.Top = lblmessgae.Bottom + 10;
            Height = lbltime.Bottom + 10;
        }

        private void bubble_Resize(object sender, EventArgs e)
        {
            Setheight();
        }
    }

    public enum msgtype
    {
        In,
        Out
    }
}