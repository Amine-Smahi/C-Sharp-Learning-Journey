namespace CalculateAge
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LblDay = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.LblMonth = new MaterialSkin.Controls.MaterialLabel();
            this.LblYear = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(67, 90);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(127, 36);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "Calculate Age";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(46, 43);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(202, 162);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(34, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Day";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // LblDay
            // 
            this.LblDay.AutoSize = true;
            this.LblDay.Depth = 0;
            this.LblDay.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDay.Location = new System.Drawing.Point(202, 200);
            this.LblDay.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(17, 19);
            this.LblDay.TabIndex = 4;
            this.LblDay.Text = "--";
            this.LblDay.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(116, 162);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(52, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Month";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(29, 162);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(47, 19);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "Years";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // LblMonth
            // 
            this.LblMonth.AutoSize = true;
            this.LblMonth.Depth = 0;
            this.LblMonth.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblMonth.Location = new System.Drawing.Point(128, 200);
            this.LblMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblMonth.Name = "LblMonth";
            this.LblMonth.Size = new System.Drawing.Size(17, 19);
            this.LblMonth.TabIndex = 8;
            this.LblMonth.Text = "--";
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Depth = 0;
            this.LblYear.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblYear.Location = new System.Drawing.Point(42, 200);
            this.LblYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(17, 19);
            this.LblYear.TabIndex = 9;
            this.LblYear.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.LblMonth);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.LblDay);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.materialRaisedButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Calculate Age";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel LblDay;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel LblMonth;
        private MaterialSkin.Controls.MaterialLabel LblYear;
    }
}

