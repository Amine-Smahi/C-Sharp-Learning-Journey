namespace YoutubeDownloader
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Panel();
            this.lblProgresss = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtURL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProgress.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "YoutubeDownloader";
            // 
            // lblProgress
            // 
            this.lblProgress.BackColor = System.Drawing.Color.White;
            this.lblProgress.Controls.Add(this.label5);
            this.lblProgress.Controls.Add(this.lblProgresss);
            this.lblProgress.Controls.Add(this.label6);
            this.lblProgress.Controls.Add(this.label4);
            this.lblProgress.Controls.Add(this.label3);
            this.lblProgress.Controls.Add(this.progressBar1);
            this.lblProgress.Controls.Add(this.cboResolution);
            this.lblProgress.Controls.Add(this.label2);
            this.lblProgress.Controls.Add(this.textBox1);
            this.lblProgress.Controls.Add(this.txtURL);
            this.lblProgress.Controls.Add(this.materialRaisedButton1);
            this.lblProgress.Location = new System.Drawing.Point(58, 122);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(492, 306);
            this.lblProgress.TabIndex = 3;
            // 
            // lblProgresss
            // 
            this.lblProgresss.AutoSize = true;
            this.lblProgresss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgresss.Location = new System.Drawing.Point(442, 158);
            this.lblProgresss.Name = "lblProgresss";
            this.lblProgresss.Size = new System.Drawing.Size(27, 16);
            this.lblProgresss.TabIndex = 10;
            this.lblProgresss.Text = "0%";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Folder Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Video Url:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 151);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(395, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // cboResolution
            // 
            this.cboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResolution.FormattingEnabled = true;
            this.cboResolution.Items.AddRange(new object[] {
            "360",
            "480",
            "720"});
            this.cboResolution.Location = new System.Drawing.Point(126, 97);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(85, 21);
            this.cboResolution.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resolution:";
            // 
            // textBox1
            // 
            this.textBox1.Depth = 0;
            this.textBox1.Hint = "";
            this.textBox1.Location = new System.Drawing.Point(126, 207);
            this.textBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.Size = new System.Drawing.Size(310, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseSystemPasswordChar = false;
            // 
            // txtURL
            // 
            this.txtURL.Depth = 0;
            this.txtURL.Hint = "";
            this.txtURL.Location = new System.Drawing.Point(126, 37);
            this.txtURL.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.SelectedText = "";
            this.txtURL.SelectionLength = 0;
            this.txtURL.SelectionStart = 0;
            this.txtURL.Size = new System.Drawing.Size(310, 23);
            this.txtURL.TabIndex = 1;
            this.txtURL.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(177, 259);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(133, 36);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Download";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 136);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Image = global::YoutubeDownloader.Properties.Resources.bb2;
            this.label5.Location = new System.Drawing.Point(442, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 50);
            this.label5.TabIndex = 12;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 452);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(610, 452);
            this.MinimumSize = new System.Drawing.Size(610, 452);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.lblProgress.ResumeLayout(false);
            this.lblProgress.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel lblProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox cboResolution;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtURL;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProgresss;
        private System.Windows.Forms.Label label5;







    }
}

