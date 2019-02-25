namespace Whatsapp_Bunifu_UI
{
    partial class chatbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatbox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmessage = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buttonsend = new Bunifu.Framework.UI.BunifuImageButton();
            this.bubble1 = new Whatsapp_Bunifu_UI.bubble();
            this.bottom = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonsend);
            this.panel1.Controls.Add(this.txtmessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 88);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.bottom);
            this.panel2.Controls.Add(this.bubble1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 522);
            this.panel2.TabIndex = 1;
            // 
            // txtmessage
            // 
            this.txtmessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmessage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtmessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmessage.HintForeColor = System.Drawing.Color.Empty;
            this.txtmessage.HintText = "";
            this.txtmessage.isPassword = false;
            this.txtmessage.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(140)))), ((int)(((byte)(127)))));
            this.txtmessage.LineIdleColor = System.Drawing.Color.Gray;
            this.txtmessage.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(147)))));
            this.txtmessage.LineThickness = 3;
            this.txtmessage.Location = new System.Drawing.Point(14, 7);
            this.txtmessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(685, 68);
            this.txtmessage.TabIndex = 0;
            this.txtmessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buttonsend
            // 
            this.buttonsend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsend.BackColor = System.Drawing.Color.Transparent;
            this.buttonsend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsend.Image = ((System.Drawing.Image)(resources.GetObject("buttonsend.Image")));
            this.buttonsend.ImageActive = null;
            this.buttonsend.Location = new System.Drawing.Point(730, 29);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(29, 36);
            this.buttonsend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonsend.TabIndex = 1;
            this.buttonsend.TabStop = false;
            this.buttonsend.Zoom = 10;
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click);
            // 
            // bubble1
            // 
            this.bubble1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bubble1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(147)))));
            this.bubble1.Location = new System.Drawing.Point(14, 17);
            this.bubble1.Name = "bubble1";
            this.bubble1.Size = new System.Drawing.Size(715, 83);
            this.bubble1.TabIndex = 0;
            this.bubble1.Visible = false;
            // 
            // bottom
            // 
            this.bottom.Location = new System.Drawing.Point(31, 163);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(100, 50);
            this.bottom.TabIndex = 1;
            this.bottom.TabStop = false;
            // 
            // chatbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "chatbox";
            this.Size = new System.Drawing.Size(784, 610);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonsend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtmessage;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton buttonsend;
        private bubble bubble1;
        private System.Windows.Forms.PictureBox bottom;
    }
}
