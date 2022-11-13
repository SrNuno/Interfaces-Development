using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (dialogNewImage.ShowDialog() == DialogResult.OK)
                {
                    Form2 form = new Form2();
                    form.Text = dialogNewImage.SafeFileName;
                    form.pictBox.Image = Image.FromFile(dialogNewImage.FileName);

                    if (chkModal.Checked)
                    {
                        form.ShowDialog();
                    }
                    else
                    {
                        form.Show();
                    }
                }
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Format invalid", "My Aplication", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void chkModal_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                ((CheckBox)sender).ForeColor = Color.Red;
            }
            else
            {
                ((CheckBox)sender).ForeColor = Color.Black;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Are you want exit?", "My Aplication", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
