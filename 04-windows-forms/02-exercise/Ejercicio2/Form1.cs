using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            try
            {
                int red = Int32.Parse(textRed.Text);
                int green = Int32.Parse(textGreen.Text);
                int blue = Int32.Parse(textBlue.Text);

                if ((red >= 0 && red <= 255) && (green >= 0 && green <= 255) && (blue >= 0 && blue <= 255))
                {
                    BackColor = Color.FromArgb(red, green, blue);
                }
                else
                {
                    MessageBox.Show("RGB error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textRed.SelectAll();
                    textGreen.SelectAll();
                    textBlue.SelectAll();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Characters invalids", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPath.Text.Equals(""))
                {
                    MessageBox.Show("Empty box", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pictureBox1.Image = new Bitmap(txtPath.Text);
                }

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Path invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPath.Focus();
                txtPath.SelectAll();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "My Aplication", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void buttons_ChangeColor(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.Red)
            {
                ((Button)sender).BackColor = Color.Red;
            }
            else
            {
                ((Button)sender).BackColor = SystemColors.ButtonFace;
            }
        }
        private void acceptButton(object sender, EventArgs e)
        {
            if (((TextBox)sender) == txtPath)
            {
                this.AcceptButton = btnImage;
            }
            else
            {
                this.AcceptButton = btnColor;
            }
        }
    }
}