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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTitleText_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            string text = "Do you want to change the form title text to ";
            string caption = "Change title";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            if (txtInfo.Text == "Enter text" || txtInfo.Text == "")
            {
                MessageBox.Show("Sorry, text invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dialog = MessageBox.Show($"\"{text}{txtInfo.Text}\"?", caption, btns, icon);
                if (dialog == DialogResult.Yes)
                {
                    this.Text = txtInfo.Text;
                    txtInfo.Text = "";
                }
            }

        }
    }
}
