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
using System.Speech;
using System.Speech.Synthesis;
using System.IO;


namespace TextToSpeech
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        SpeechSynthesizer voice = new SpeechSynthesizer();
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
            skinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
       

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            if (txtContant.Text != "")
            {
                voice.SpeakAsync(txtContant.Text);
            }
            else
            {
                MessageBox.Show("What do you want to say ?", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            } 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
              try{
                  using(SaveFileDialog sfd = new SaveFileDialog()){
                      sfd.Filter = "wav files|*.wav";
                      sfd.Title = "Save to a wave file";
                      if(sfd.ShowDialog() == DialogResult.OK){
                          FileStream fs = new FileStream(sfd.FileName,FileMode.Create,FileAccess.Write);
                          voice.SetOutputToWaveStream(fs);
                          voice.Speak(txtContant.Text);
                      }

                  }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
              try{
                  voice.Pause();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
              try{
               voice.Resume();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

       
    }
}
