namespace ToDoList
{
    partial class ToDoList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.clearAllButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.clearCheckedButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter here your to-do\'s:";
            // 
            // textBox
            // 
            this.textBox.Depth = 0;
            this.textBox.Hint = "";
            this.textBox.Location = new System.Drawing.Point(16, 113);
            this.textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.SelectedText = "";
            this.textBox.SelectionLength = 0;
            this.textBox.SelectionStart = 0;
            this.textBox.Size = new System.Drawing.Size(202, 23);
            this.textBox.TabIndex = 1;
            this.textBox.UseSystemPasswordChar = false;
            // 
            // addButton
            // 
            this.addButton.Depth = 0;
            this.addButton.Location = new System.Drawing.Point(247, 107);
            this.addButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.Primary = true;
            this.addButton.Size = new System.Drawing.Size(75, 29);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(16, 181);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(296, 184);
            this.checkedListBox.TabIndex = 4;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Depth = 0;
            this.clearAllButton.Location = new System.Drawing.Point(234, 414);
            this.clearAllButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Primary = true;
            this.clearAllButton.Size = new System.Drawing.Size(88, 30);
            this.clearAllButton.TabIndex = 5;
            this.clearAllButton.Text = "Clear all";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // clearCheckedButton
            // 
            this.clearCheckedButton.Depth = 0;
            this.clearCheckedButton.Location = new System.Drawing.Point(88, 414);
            this.clearCheckedButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearCheckedButton.Name = "clearCheckedButton";
            this.clearCheckedButton.Primary = true;
            this.clearCheckedButton.Size = new System.Drawing.Size(130, 30);
            this.clearCheckedButton.TabIndex = 6;
            this.clearCheckedButton.Text = "Clear checked";
            this.clearCheckedButton.UseVisualStyleBackColor = true;
            this.clearCheckedButton.Click += new System.EventHandler(this.clearCheckedButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cleared 0 items";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(12, 418);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(34, 23);
            this.materialRaisedButton1.TabIndex = 9;
            this.materialRaisedButton1.Text = "+";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 455);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearCheckedButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(334, 455);
            this.MinimumSize = new System.Drawing.Size(334, 455);
            this.Name = "ToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoList";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox;
        private MaterialSkin.Controls.MaterialRaisedButton addButton;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private MaterialSkin.Controls.MaterialRaisedButton clearAllButton;
        private MaterialSkin.Controls.MaterialRaisedButton clearCheckedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;

    }
}

