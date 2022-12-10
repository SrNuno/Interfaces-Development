using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form2 : Form
    {
        int intentos = 3;
        Random ran = new Random();
        String pin = "1234";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == pin && textBox1.Text.Length == 4)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                intentos--;
                textBox1.Text = "";
                label2.Text = "Intentos: " + intentos;
                if (intentos == 0)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
