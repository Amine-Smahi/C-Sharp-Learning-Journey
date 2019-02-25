using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using ToDoList;

using MaterialSkin;
namespace ToDoList
{
    public partial class ToDoList : MaterialSkin.Controls.MaterialForm
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x39000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public ToDoList()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Purple400, Primary.Purple500, Primary.Purple500, Accent.Purple200, TextShade.WHITE);

        }

           private void addButton_Click(object sender, EventArgs e)
        {
            string newTodo = textBox.Text;

            if (newTodo == "")
            {
                errorProvider.SetError(label1, "Input some text!");
            }
            else
            {
                checkedListBox.Items.Add(newTodo);
                textBox.Text = "";
                newTodo = "";
                textBox.Select();
            }

        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            checkedListBox.Items.Clear();
            textBox.Select();
            label2.Text = "Cleared all items";
        }

        private void clearCheckedButton_Click(object sender, EventArgs e)
        {
            int totalItems = checkedListBox.Items.Count;
            int checkedItems = checkedListBox.CheckedIndices.Count;

            while (checkedListBox.CheckedItems.Count > 0)
            {
                checkedListBox.Items.Remove(checkedListBox.CheckedItems[0]);
            }

            textBox.Select();
            label2.Text = "Cleared " + checkedItems + " items of a total of " + totalItems + " items";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By JetLight Studio");
        }
    }
    }

