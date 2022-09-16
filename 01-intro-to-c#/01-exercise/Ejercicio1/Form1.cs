using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txtOne.Text);
                double n2 = Convert.ToDouble(txtTwo.Text);
                lblResult.Text = Convert.ToString(n1 + n2);
            }
            catch (FormatException)
            {
                string text = "You don't use characters or empty box";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1;

                DialogResult dialog = MessageBox.Show(text, title, buttons, icon, defaultButton);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOne.Text = "";
            txtTwo.Text = "";
            lblResult.Text = "=";
        }
    }
}
