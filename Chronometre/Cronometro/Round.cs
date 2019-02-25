using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing; //Librería necesaria
using System.Drawing.Drawing2D; //Librería necesaria
using System.Windows.Forms; //Librería necesaria

namespace FrmCronometro
{
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new System.Drawing.Region(path);
            base.OnPaint(e);
        }
    }
}
