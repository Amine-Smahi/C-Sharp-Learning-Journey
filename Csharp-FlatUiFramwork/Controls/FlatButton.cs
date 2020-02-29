using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class FlatButton : Control
{

    #region  Variables

    Timer AnimationTimer = new Timer { Interval = 1 };

    FontManager font = new FontManager();
    StringFormat SF = new StringFormat();
    Rectangle R;

    bool Focus = false;

    int xx;
    int yy;

    float SizeAnimation = 0;
    float SizeIncNum;

    string fontcolor = "#ffffff";
    string Backcolor = "#508ef5";

    Color EnabledBGColor;
    Color StringColor;

    Color DisabledBGColor = ColorTranslator.FromHtml("#b0b2b5");

    #endregion
    #region  Properties

    [Category("Appearance")]
    public string BGColor
    {
        get { return Backcolor; }
        set
        {
            Backcolor = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public string FontColor
    {
        get { return fontcolor; }
        set
        {
            fontcolor = value;
            Invalidate();
        }
    }
    
    [Browsable(false)]
    public Font Font
    {
        get { return base.Font; }
        set { base.Font = value; }
    }

    [Browsable(false)]
    public Color ForeColor
    {
        get { return base.ForeColor; }
        set { base.ForeColor = value; }
    }
    
    #endregion
    #region  Events

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        xx = e.X;
        yy = e.Y;
        Focus = true;
        AnimationTimer.Start();
        Invalidate();
    }
    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        Focus = false;
        AnimationTimer.Start();
        Invalidate();
    }

    protected override void OnTextChanged(System.EventArgs e)
    {       
        base.OnTextChanged(e);
        Invalidate();
    }
    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        R = new Rectangle(0, 0, Width, Height);
    }

    #endregion

    public FlatButton()
    {
        SetStyle((ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint), true);
        DoubleBuffered = true;

        Size = new Size(143, 41);
        BackColor = Color.Transparent;

        SF.Alignment = StringAlignment.Center;
        SF.LineAlignment = StringAlignment.Center;
        
        AnimationTimer.Tick += new EventHandler(AnimationTick);
    }

    protected override void OnResize(System.EventArgs e)
    {
        base.OnResize(e);
        SizeIncNum = Width / 34;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        var G = e.Graphics;
        G.SmoothingMode = SmoothingMode.HighQuality;
        G.Clear(Parent.BackColor);

        StringColor = ColorTranslator.FromHtml(fontcolor);
        EnabledBGColor = ColorTranslator.FromHtml(Backcolor);

        var BG = DrawHelper.CreateRoundRect(1, 1, Width - 3, Height - 3, 1);
        Region region = new Region(BG);

        G.FillPath(new SolidBrush(Enabled? EnabledBGColor:DisabledBGColor), BG);
        G.DrawPath(new Pen(Enabled ? EnabledBGColor : DisabledBGColor), BG);

        G.SetClip(region, CombineMode.Replace);
        
        //The Ripple Effect
        G.FillEllipse(new SolidBrush(Color.FromArgb(25,Color.Black)), xx - (SizeAnimation / 2), yy - (SizeAnimation / 2), SizeAnimation, SizeAnimation);

        G.DrawString(Text, font.Roboto_Medium9, new SolidBrush(StringColor), R, SF);       
    }

    protected void AnimationTick(object sender, EventArgs e)
    {
        if (Focus)
        {
            if (SizeAnimation < Width + 250)
            {
                SizeAnimation += SizeIncNum;
                this.Invalidate();
            }          
        }
        else
        {
            if (SizeAnimation > 0)
            {
                SizeAnimation = 0;
                this.Invalidate();
            }
        }
    }
}
