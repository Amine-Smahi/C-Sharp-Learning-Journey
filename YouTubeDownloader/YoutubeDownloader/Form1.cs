using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using YoutubeExtractor;

namespace YoutubeDownloader
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
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
            try
            {
                var videos = DownloadUrlResolver.GetDownloadUrls(txtURL.Text);
                var video =
                    videos.First(
                        p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(cboResolution.Text));
                if (video.RequiresDecryption)
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                var Downloader = new VideoDownloader(video,
                    Path.Combine(textBox1.Text + "\\", video.Title + video.VideoExtension));
                Downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;
                var thread = new Thread(() => { Downloader.Execute(); }) {IsBackground = true};
                thread.Start();
            }
            catch (Exception e2)
            {
                MessageBox.Show("Your Link Or Your Folder Path Was Invalid");
                Console.WriteLine(e2.Message);
            }
        }

        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate
            {
                progressBar1.Value = (int) e.ProgressPercentage;
                lblProgresss.Text = string.Format("{0:0.##}", e.ProgressPercentage) + " %";
                progressBar1.Update();
            }));
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var a = new about();
            a.Show();
        }
    }
}