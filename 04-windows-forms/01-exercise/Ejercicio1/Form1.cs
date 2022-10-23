#define DIR

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
        Color colorDefault = Button.DefaultBackColor;
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
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Yellow;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Blue;
            }
            else
            {
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Red;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = colorDefault;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = colorDefault;
            }
            else
            {
                button1.BackColor = colorDefault;
                button2.BackColor = colorDefault;
            }
        }

#if !DIR
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = text;
            }
            else
            {
                this.Text = e.KeyCode.ToString();
            }
        }
#else
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = text;
            }
            else
            {
                this.Text = e.KeyValue.ToString();
            }
        }
#endif
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
