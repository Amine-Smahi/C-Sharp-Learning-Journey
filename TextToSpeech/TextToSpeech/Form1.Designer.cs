namespace TextToSpeech
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
            this.txtContant = new System.Windows.Forms.TextBox();
            this.btnResume = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPause = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSpeak = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtContant
            // 
            this.txtContant.Location = new System.Drawing.Point(26, 94);
            this.txtContant.Multiline = true;
            this.txtContant.Name = "txtContant";
            this.txtContant.Size = new System.Drawing.Size(310, 280);
            this.txtContant.TabIndex = 2;
            // 
            // btnResume
            // 
            this.btnResume.Depth = 0;
            this.btnResume.Location = new System.Drawing.Point(359, 255);
            this.btnResume.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnResume.Name = "btnResume";
            this.btnResume.Primary = true;
            this.btnResume.Size = new System.Drawing.Size(75, 38);
            this.btnResume.TabIndex = 3;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.Depth = 0;
            this.btnPause.Location = new System.Drawing.Point(359, 175);
            this.btnPause.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPause.Name = "btnPause";
            this.btnPause.Primary = true;
            this.btnPause.Size = new System.Drawing.Size(75, 37);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(359, 338);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Depth = 0;
            this.btnSpeak.Location = new System.Drawing.Point(359, 94);
            this.btnSpeak.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Primary = true;
            this.btnSpeak.Size = new System.Drawing.Size(75, 38);
            this.btnSpeak.TabIndex = 6;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 395);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.txtContant);
            this.Name = "Form1";
            this.Text = "Text To Speech";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContant;
        private MaterialSkin.Controls.MaterialRaisedButton btnResume;
        private MaterialSkin.Controls.MaterialRaisedButton btnPause;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnSpeak;
    }
}

