using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        int contSeconds = 0, contMins = 0;
        double num1 = 0.0, num2 = 0.0;


        Hashtable hashtable = new Hashtable();
        delegate double Operations(double num1, double num2);
        Operations operations;

        public Form1()
        {
            InitializeComponent();
            hashtable.Add("+", (Operations)((num1, num2) => num1 + num2));
            hashtable.Add("-", (Operations)((num1, num2) => num1 - num2));
            hashtable.Add("*", (Operations)((num1, num2) => num1 * num2));
            hashtable.Add("/", (Operations)((num1, num2) => num1 / num2));
            operations = (Operations)(hashtable["+"]);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            contSeconds++;
            if (contSeconds == 60)
            {
                contMins++;
                contSeconds = 0;
            }
            this.Text = $"{contMins:D2}:{contSeconds:D2}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            bool num1Comp = Double.TryParse(textBoxNum1.Text, out num1);
            bool num2Comp = Double.TryParse(textBoxNum2.Text, out num2);
            if (num1Comp && num2Comp)
            {
                textBoxResult.Text = operations(num1, num2).ToString();
            } else
            {
                MessageBox.Show("Operation invalid", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Enabled = false;
        }

        private void selectOperation(object sender, EventArgs e)
        {
            string textRadioButton = ((RadioButton)sender).Text;
            labelOperation.Text = textRadioButton;
            operations = (Operations)(hashtable[labelOperation.Text]);

        }

        private void changeTextBackColor(object sender, EventArgs e)
        {
            double num;
            bool compNum = Double.TryParse(((TextBox)sender).Text, out num);
            if (!compNum)
            {
                ((TextBox)sender).BackColor = Color.Red;
            }
            else
            {
                ((TextBox)sender).BackColor = DefaultBackColor;
            }
        }
    }
}
