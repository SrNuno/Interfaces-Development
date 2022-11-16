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
        int i;
        string title;
        Icon icon = Properties.Resources.icon;
        Icon icon2 = Properties.Resources.icon2;

        public Form1()
        {
            InitializeComponent();
            i = this.Text.Length;
            title = this.Text;
            this.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(string.Empty))
            {
                if (!addOptions())
                {
                    listBox1.Items.Add(textBox1.Text);
                    labelCantLB1.Text = "Count: " + listBox1.Items.Count.ToString();
                    textBox1.Text = "";
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            removeOptions();
            labelCantLB1.Text = "Count: " + listBox1.Items.Count;
        }

        private void buttonTraspLeftRight_Click(object sender, EventArgs e)
        {
            traspLeftRight();
            labelCantLB1.Text = "Count: " + listBox1.Items.Count;
        }

        private void buttonTraspRightLeft_Click(object sender, EventArgs e)
        {
            traspRightLeft();
            labelCantLB1.Text = "Count: " + listBox1.Items.Count;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count != 0)
            {
                labelCantLB2.Text = "Index: ";
                for (int i = 0; i < listBox1.SelectedIndices.Count; i++)
                {
                    labelCantLB2.Text += listBox1.SelectedIndices[i].ToString() + " ";
                }
            }
            else
            {
                labelCantLB2.Text = "Index: None";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = title[i - 1].ToString() + this.Text;
            i--;
            if (i == 0)
            {
                i = this.Text.Length;
                this.Text = "";
            }

            if (i % 2 == 0)
            {
                this.Icon = icon;
            }
            else
            {
                this.Icon = icon2;
            }

        }

        private void listBox1_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(listBox1, "Items: " + listBox1.Items.Count.ToString());
        }

        private void listBox2_Enter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(listBox2, "Items: " + listBox2.Items.Count.ToString());
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
        private void removeOptions()
        {
            if (listBox1.SelectedIndices.Count != 0)
            {
                while (listBox1.SelectedIndices.Count > 0)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);

                }
            }
        }
        private void traspLeftRight()
        {
            if (listBox1.SelectedIndices.Count != 0)
            {
                while (listBox1.SelectedIndices.Count > 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
        }
        private void traspRightLeft()
        {
            if (listBox2.SelectedIndices.Count != 0)
            {
                while (listBox2.SelectedIndices.Count > 0)
                {
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
        }


    }
}
