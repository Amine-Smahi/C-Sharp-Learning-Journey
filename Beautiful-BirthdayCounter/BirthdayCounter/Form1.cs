using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace BirthdayCounter
{
    public partial class Form1 : Form
    {
        private int cur_template;
        private DateTime endTime = new DateTime(2017, 08, 09, 0, 0, 0); //my bithday
        //store gradient themes
        private readonly List<Dictionary<string, Color>> templates = new List<Dictionary<string, Color>>();

        public Form1()
        {
            InitializeComponent();


            loader.Dock = DockStyle.Fill;

            //lets add asome templates
            var template = new Dictionary<string, Color>();

            template.Add("bottomleft", Color.FromArgb(255, 192, 128));
            template.Add("bottomright", Color.FromArgb(251, 97, 122));
            template.Add("topleft", Color.FromArgb(251, 97, 122));
            template.Add("topright", Color.FromArgb(251, 97, 122));

            templates.Add(template);


            template = new Dictionary<string, Color>();

            template.Add("bottomleft", Color.FromArgb(192, 0, 192));
            template.Add("bottomright", Color.Black);
            template.Add("topleft", Color.FromArgb(251, 97, 122));
            template.Add("topright", Color.FromArgb(251, 97, 122));

            templates.Add(template);

            template = new Dictionary<string, Color>();

            template.Add("bottomleft", Color.Black);
            template.Add("bottomright", Color.Black);
            template.Add("topleft", Color.FromArgb(251, 97, 122));
            template.Add("topright", Color.DarkTurquoise);

            templates.Add(template);

            //init fist theme
            load_theme(templates[cur_template]);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (cur_template < templates.Count() - 1)
                cur_template++;
            else
                cur_template = 0;

            load_theme(templates[cur_template]);
        }


        public void load_theme(Dictionary<string, Color> theme)
        {
            Opacity = 0.7;
            loader.Visible = true;
            bunifuGradientPanel1.GradientBottomLeft = theme["bottomleft"];
            bunifuGradientPanel1.GradientBottomRight = theme["bottomright"];
            bunifuGradientPanel1.GradientTopLeft = theme["topleft"];
            bunifuGradientPanel1.GradientTopRight = theme["topright"];

            hideloader.Start();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            var r = new Random();
            //lets add asome templates
            var template = new Dictionary<string, Color>();

            template.Add("bottomleft", Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
            template.Add("bottomright", Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
            template.Add("topleft", Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
            template.Add("topright", Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));

            bunifuThinButton21.BackColor = Color.Transparent;
            bunifuThinButton22.BackColor = Color.Transparent;

            load_theme(template);


            //safe theme
            templates.Add(template);
        }

        private void hideloader_Tick(object sender, EventArgs e)
        {
            hideloader.Stop();
            loader.Visible = false;
            Opacity = 0.9;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var ts = endTime.Subtract(DateTime.Now);

            d.Text = ts.Days.ToString();
            h.Text = ts.Hours.ToString();
            m.Text = ts.Minutes.ToString();
            s.Text = ts.Seconds.ToString();
        }

        private void openurl(string url)
        {
            cmd.EXECUTECMD("start explorer.exe \"" + url + "\"");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //my facebook
            openurl("https://web.facebook.com/amine.developer");
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            openurl("https://github.com/Amine-smahi");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}