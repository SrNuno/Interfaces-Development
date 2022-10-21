using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        const string text = "Form1";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                this.Text = $"X: {e.X + ((Button)sender).Location.X}, Y: {e.Y + ((Button)sender).Location.Y}";
            }
            else
            {
                this.Text = $"X: {e.X}, Y: {e.Y}";
            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = text;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Yellow;
            }
        }
    }
}
