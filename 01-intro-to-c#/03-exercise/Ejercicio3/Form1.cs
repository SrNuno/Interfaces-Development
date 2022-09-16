#define TWOIGUALS 
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

        private void btnPress_Click(object sender, EventArgs e)
        {
            if (cred > 0)
            {
                txtOne.Text = generador.Next(1, 8).ToString();
                txtTwo.Text = generador.Next(1, 8).ToString();
                txtThree.Text = generador.Next(1, 8).ToString();
                if (txtOne.Text == txtTwo.Text && txtTwo.Text == txtThree.Text)
                {
                    cred += 20;
                    lblCredit.Text = Convert.ToString("Credit: " + cred + "€");
                    lblReward.Text = "Reward";
                    lblReward.ForeColor = Color.Green;
                }
#if !TWOIGUALS

                else if (txtOne.Text == txtTwo.Text || txtOne.Text == txtThree.Text || txtTwo.Text == txtThree.Text)
                {
                    cred += 5;
                }
#else
                else if (txtOne.Text == txtTwo.Text || txtOne.Text == txtThree.Text || txtTwo.Text == txtThree.Text)
                {
                    cred -= 5;
                    lblCredit.Text = Convert.ToString("Credit: " + cred + "€");
                    lblReward.Text = "NO Reward";
                    lblReward.ForeColor = Color.Red;
                }
#endif
                else
                {
                    cred -= 2;
                    lblCredit.Text = Convert.ToString("Credit: " + cred + "€");
                    lblReward.Text = "NO Reward";
                    lblReward.ForeColor = Color.Red;
                }
            }
            else
            {
                
                btnPress.Enabled = false;
            }
                    }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            cred += 10;
            lblCredit.Text = Convert.ToString("Credit: " + cred + "€");
            btnCredit.Enabled = false;
        }

        Random generador = new Random();
        int cred = 50;
    }
}
