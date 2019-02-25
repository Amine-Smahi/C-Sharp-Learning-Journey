using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            DateTime CurrenteDate = DateTime.Now;
            DateTime BirthDay = Convert.ToDateTime(dateTimePicker.Text);
            int year = BirthDay.Year;
            int month = BirthDay.Month;
            int day = BirthDay.Day;

            int j = 0;
            for (int i = year; i < BirthDay.Year; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    j++;
                }
            }
            TimeSpan time = CurrenteDate.Subtract(BirthDay);
            day = time.Days - j;
            int r = 0;
            year = Math.DivRem(day,356,out r);
            month = Math.DivRem(r, 30, out r);
            day = r;
            LblYear.Text = year.ToString();
            LblMonth.Text = month.ToString();
            LblDay.Text = day.ToString();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
