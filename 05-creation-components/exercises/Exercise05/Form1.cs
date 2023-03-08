using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            validateTextBox1.Multilinea = ((CheckBox)sender).Checked;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Textual")
            {
                ((Button)sender).Text = "Numérico";
                validateTextBox1.Tipo = ControlLibrary.eTipo.Numerico;
            }
            else
            {
                ((Button)sender).Text = "Textual";
                validateTextBox1.Tipo = ControlLibrary.eTipo.Textual;
            }

        }
    }
}
