namespace Whatsapp_Bunifu_UI
{
    partial class bubble
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblmessgae = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // lblmessgae
            // 
            this.lblmessgae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmessgae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessgae.ForeColor = System.Drawing.Color.White;
            this.lblmessgae.Location = new System.Drawing.Point(13, 10);
            this.lblmessgae.Name = "lblmessgae";
            this.lblmessgae.Size = new System.Drawing.Size(528, 101);
            this.lblmessgae.TabIndex = 0;
            this.lblmessgae.Text = "this is just a place holder";
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltime.AutoSize = true;
            this.lbltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbltime.Location = new System.Drawing.Point(14, 114);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(77, 13);
            this.lbltime.TabIndex = 1;
            this.lbltime.Text = "Wed 12:37 pm";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblmessgae);
            this.Name = "bubble";
            this.Size = new System.Drawing.Size(555, 139);
            this.Resize += new System.EventHandler(this.bubble_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmessgae;
        private System.Windows.Forms.Label lbltime;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
