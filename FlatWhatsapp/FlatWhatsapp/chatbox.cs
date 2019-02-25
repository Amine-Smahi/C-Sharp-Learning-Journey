using System;
using System.Windows.Forms;

namespace Whatsapp_Bunifu_UI
{
    public partial class chatbox : UserControl
    {
        private bubble bbl_old = new bubble();


        private int curtop = 10;

        private int lst = 0;

        public chatbox()
        {
            if (!DesignMode)
                InitializeComponent();


            bbl_old.Top = 0 - bbl_old.Height + 10;
        }

        public void addInMessage(string message, string time)
        {
            var bbl = new bubble(message, time, msgtype.In);
            bbl.Location = bubble1.Location;
            bbl.Size = bubble1.Size;
            bbl.Anchor = bubble1.Anchor;
            bbl.Top = bbl_old.Bottom + 10;
            panel2.Controls.Add(bbl);


            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum;

            bbl_old = bbl; //safe the last added object
        }

        public void addOutMessage(string message, string time)
        {
            var bbl = new bubble(message, time, msgtype.Out);
            bbl.Location = bubble1.Location;
            bbl.Left += 20; //add intent
            bbl.Size = bubble1.Size;
            bbl.Anchor = bubble1.Anchor;
            bbl.Top = bbl_old.Bottom + 10;
            panel2.Controls.Add(bbl);

            bottom.Top = bbl.Bottom + 50;

            bbl_old = bbl; //safe the last added object
        }

        private void buttonsend_Click(object sender, EventArgs e)
        {
            addInMessage("Hello world", "00:00");
            addOutMessage("Hello world to you too", "00:00");

            panel2.VerticalScroll.Value = panel2.VerticalScroll.Maximum; //scroll the chatbox down 
        }
    }
}