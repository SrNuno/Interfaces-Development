using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public int cont = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(string.Empty))
            {
                if (!addOptions())
                {
                    listBox1.Items.Add(textBox1.Text);
                    labelCantLB1.Text = "Count: " + cont++.ToString();
                    textBox1.Text = "";
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (!removeOptions())
            {
                listBox1.Items.Remove(listBox1.SelectedItems);
            }
        }

        private bool addOptions()
        {
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.Items[i].ToString().Equals(textBox1.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool removeOptions()
        {
            ListBox.SelectedObjectCollection selected = listBox1.SelectedItems;
            for (int i = 0; i < selected.Count; i++)
            {
                return true;
            }
            return false;
        }
    }
}
