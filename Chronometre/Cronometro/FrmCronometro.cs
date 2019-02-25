using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; 
using FrmCronometro.Properties;

namespace FrmCronometro
{
    public partial class FrmCronometro : Form
    {
        public FrmCronometro()
        {
            InitializeComponent();
        }

        Stopwatch Stopwatch = new Stopwatch();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {
                btnTakeTime.Visible = false;
            }

            if (btnIniciar.Text == "Detener")
            {
                btnTakeTime.Visible = true;
            }
            

            if (Stopwatch.IsRunning)
            {
                TimeSpan ts = Stopwatch.Elapsed;
                this.lblTiempo.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", ts.Hours,
                    ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (Stopwatch.IsRunning)
            {
                Stopwatch.Stop();
                PicbPausa.Visible = false;
                btnReiniciar.Visible = true;
                btnTakeTime.Visible = false;
                btnInfo.Enabled = true;
            }


            else
            {
                Stopwatch.Start();
                PicbPausa.Visible = true;
                btnTakeTime.Visible = true;
                btnReiniciar.Visible = false;
                btnInfo.Enabled = false;
            }

            }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblTiempo.Text = "00:00:00:00";
            Stopwatch.Reset();
            btnReiniciar.Visible = false;
            listBox1.Items.Clear();
            PicbPausa.Visible = false;
        }

        private void btnTakeTime_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(this.lblTiempo.Text);
        }

        private void PicbPausa_Click(object sender, EventArgs e)
        {
            btnIniciar.PerformClick();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Amine Smahi");
            
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.listBox1.SelectedItems.Count > 0)
            {

                try
                {
                   
                    StringBuilder sb = new StringBuilder();

                    foreach (object row in listBox1.SelectedItems)
                    {
                        sb.Append(row.ToString());
                        sb.AppendLine();
                    }

                    sb.Remove(sb.Length - 1, 1);
                    Clipboard.SetData(System.Windows.Forms.DataFormats.Text,sb.ToString());

                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    MessageBox.Show("The Clipboard could not be accessed. Please try again.");
                }
            }
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                listBox1.SelectedItems.Clear();

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SetSelected(i, true);
                }
            }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            copiarToolStripMenuItem.Enabled = true;
        }

        private void FrmCronometro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                btnTakeTime.PerformClick();
            }

            if (e.KeyCode == Keys.R)
            {
                btnReiniciar.PerformClick();
            }
        }

        private void FrmCronometro_Shown(object sender, EventArgs e)
        {
            btnIniciar.Focus();
        }

        private void btnInfo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTakeTime.PerformClick();
            }

            if (e.KeyCode == Keys.R)
            {
                btnReiniciar.PerformClick();
            }

          
        }

        private void btnIniciar_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Purple")
            {
                this.BackColor = System.Drawing.Color.FromArgb(55, 43, 77);
                listBox1.BackColor = System.Drawing.Color.FromArgb(55, 43, 77);
             
                
            }

            if (comboBox1.SelectedItem == "Blue")
            {
                
                this.BackColor = System.Drawing.Color.FromArgb(2, 119, 189);
                listBox1.BackColor = System.Drawing.Color.FromArgb(2, 119, 189);
              

            }

            if (comboBox1.SelectedItem == "Black")
            {
             
                this.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
                listBox1.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
             

            }

            if (comboBox1.SelectedItem == "Pink")
            {
                
                this.BackColor = System.Drawing.Color.FromArgb(234, 30, 99);
                listBox1.BackColor = System.Drawing.Color.FromArgb(234, 30, 99);
               

            }

          


        }

        private void FrmCronometro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Fondo = this.BackColor;
            Properties.Settings.Default.Save();
        }

        private void FrmCronometro_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(2, 119, 189);
            listBox1.BackColor = System.Drawing.Color.FromArgb(2, 119, 189);
               
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btnTakeTime_Enter(object sender, EventArgs e)
        {
            btnIniciar.Focus();
        }
        }
    }

