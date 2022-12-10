using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        string[] ciudades = { "Coruña", "Pontevedra", "Ourense", "Lugo" };
        Datos[] arrayDatos = new Datos[28];
        //Datos dato;
        bool guardar = false;
        TextBox valores;
        TextBox[] guardaValores = new TextBox[28];
        Label labelNombres;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("TMax (ºC)");
            comboBox1.Items.Add("Precip. (ml/m²)");
            comboBox1.SelectedIndex = 0;
            toolTip1.SetToolTip(button1, "Guardar arrayDatos de " + comboBox1.SelectedItem.ToString());
            for (int i = 0; i < arrayDatos.Length; i++)
            {
                arrayDatos[i] = new Datos();
            }
        }

        public void creacionTabla()
        {
            int x = 34;
            int y = 60;

            for (int i = 0; i < ciudades.Length; i++)
            {
                labelNombres = new Label();
                labelNombres.Text = ciudades[i];
                labelNombres.Location = new Point(x, y);
                labelNombres.Size = new Size(75, 20);
                if ((i + 1) % 1 == 0)
                {
                    y += labelNombres.Height + 15;
                }
                this.panel2.Controls.Add(labelNombres);
            }

            x = 135;
            y = 55;

            for (int i = 0; i < 28; i++)
            {
                valores = new TextBox();
                valores.Text = 0.ToString();
                valores.Location = new Point(x, y);
                valores.Size = new Size(60, 20);
                //valores.Enter += new System.EventHandler(this.textEnter);
                //valores.Leave += new System.EventHandler(this.textLeave);
                guardaValores[i] = valores;
                x += valores.Width + 20;
                if ((i + 1) % 7 == 0)
                {
                    x = 135;
                    y += valores.Height + 15;
                }
                this.panel2.Controls.Add(valores);
            }
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creacionTabla();
            panel1.Enabled = true;
            poblacionesToolStripMenuItem.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nuevaToolStripMenuItem.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guardar != true)
            {
                closeForm(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = 0;
            for (int i = 0; i < guardaValores.Length; i++)
            {
                bool flag = double.TryParse(valores.Text, out n);
                if (!flag)
                {
                    n = 0;
                }

                if (comboBox1.SelectedIndex == 0)
                {
                    arrayDatos[i].TMax = n;
                }
                else
                {
                    arrayDatos[i].Precip = n;
                }
            }
            guardar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeForm(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Do you want exit without saving changes?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

    }
}
