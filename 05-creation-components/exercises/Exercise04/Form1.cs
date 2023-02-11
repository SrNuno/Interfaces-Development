using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Ahorcado";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ahorcado1.Errores++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ahorcado1.Errores--;
        }

        private void ahorcado1_CambiaError(object sender, EventArgs e)
        {
            label1.Text = "Errores: " + ahorcado1.Errores.ToString();
        }

        private void ahorcado1_Ahorcad0(object sender, EventArgs e)
        {
            MessageBox.Show(this, "You lose", "Lose", MessageBoxButtons.OK, MessageBoxIcon.Error);
            button1.Enabled= false;
            button2.Enabled = false;
        }
    }
}
