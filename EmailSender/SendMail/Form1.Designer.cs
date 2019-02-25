namespace SendMail
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
            this.TxtTo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtFrom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSubject = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtSmtp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnSend = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTo
            // 
            this.TxtTo.Depth = 0;
            this.TxtTo.Hint = "";
            this.TxtTo.Location = new System.Drawing.Point(153, 99);
            this.TxtTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.PasswordChar = '\0';
            this.TxtTo.SelectedText = "";
            this.TxtTo.SelectionLength = 0;
            this.TxtTo.SelectionStart = 0;
            this.TxtTo.Size = new System.Drawing.Size(259, 23);
            this.TxtTo.TabIndex = 0;
            this.TxtTo.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 18);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "To : ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 151);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 18);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "From : ";
            // 
            // TxtFrom
            // 
            this.TxtFrom.Depth = 0;
            this.TxtFrom.Hint = "";
            this.TxtFrom.Location = new System.Drawing.Point(153, 147);
            this.TxtFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtFrom.Name = "TxtFrom";
            this.TxtFrom.PasswordChar = '\0';
            this.TxtFrom.SelectedText = "";
            this.TxtFrom.SelectionLength = 0;
            this.TxtFrom.SelectionStart = 0;
            this.TxtFrom.Size = new System.Drawing.Size(259, 23);
            this.TxtFrom.TabIndex = 2;
            this.TxtFrom.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 243);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 18);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Message : ";
            // 
            // TxtMessage
            // 
            this.TxtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.TxtMessage.Location = new System.Drawing.Point(153, 243);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(515, 75);
            this.TxtMessage.TabIndex = 6;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(25, 199);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 18);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Subject : ";
            // 
            // TxtSubject
            // 
            this.TxtSubject.Depth = 0;
            this.TxtSubject.Hint = "";
            this.TxtSubject.Location = new System.Drawing.Point(153, 195);
            this.TxtSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.PasswordChar = '\0';
            this.TxtSubject.SelectedText = "";
            this.TxtSubject.SelectionLength = 0;
            this.TxtSubject.SelectionStart = 0;
            this.TxtSubject.Size = new System.Drawing.Size(259, 23);
            this.TxtSubject.TabIndex = 7;
            this.TxtSubject.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(25, 344);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(89, 18);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Username : ";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Depth = 0;
            this.TxtUsername.Hint = "";
            this.TxtUsername.Location = new System.Drawing.Point(139, 340);
            this.TxtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PasswordChar = '\0';
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.SelectionLength = 0;
            this.TxtUsername.SelectionStart = 0;
            this.TxtUsername.Size = new System.Drawing.Size(179, 23);
            this.TxtUsername.TabIndex = 9;
            this.TxtUsername.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(364, 340);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(87, 18);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Password : ";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Hint = "";
            this.TxtPassword.Location = new System.Drawing.Point(478, 340);
            this.TxtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '\0';
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.Size = new System.Drawing.Size(190, 23);
            this.TxtPassword.TabIndex = 11;
            this.TxtPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(59, 387);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(55, 18);
            this.materialLabel8.TabIndex = 16;
            this.materialLabel8.Text = "Smtp : ";
            // 
            // TxtSmtp
            // 
            this.TxtSmtp.Depth = 0;
            this.TxtSmtp.Hint = "";
            this.TxtSmtp.Location = new System.Drawing.Point(139, 387);
            this.TxtSmtp.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSmtp.Name = "TxtSmtp";
            this.TxtSmtp.PasswordChar = '\0';
            this.TxtSmtp.SelectedText = "";
            this.TxtSmtp.SelectionLength = 0;
            this.TxtSmtp.SelectionStart = 0;
            this.TxtSmtp.Size = new System.Drawing.Size(179, 23);
            this.TxtSmtp.TabIndex = 15;
            this.TxtSmtp.Text = "smtp.gmail.com";
            this.TxtSmtp.UseSystemPasswordChar = false;
            // 
            // BtnSend
            // 
            this.BtnSend.Depth = 0;
            this.BtnSend.Location = new System.Drawing.Point(534, 442);
            this.BtnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Primary = true;
            this.BtnSend.Size = new System.Drawing.Size(134, 40);
            this.BtnSend.TabIndex = 18;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SendMail.Properties.Resources.imageedit_1_9751612447;
            this.pictureBox1.Location = new System.Drawing.Point(517, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 120);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.TxtSmtp);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.TxtSubject);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.TxtFrom);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TxtTo);
            this.MaximumSize = new System.Drawing.Size(695, 494);
            this.MinimumSize = new System.Drawing.Size(695, 494);
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Sender";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtFrom;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox TxtMessage;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSubject;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSmtp;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSend;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

