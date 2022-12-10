using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        Button[,] tabla;
        Button boton, botonReset;
        int cont = 1, contSeconds = 0, contMinutos = 0;
        Color colorDefecto;

        public Form1()
        {
            InitializeComponent();
            Form2 form = new Form2();
            if (!(form.ShowDialog() == DialogResult.OK))
            {
                Environment.Exit(0);
            }

            CreaTabla(4, 3);
            PonerDatos(tabla);
            CrearReset();
            timer1.Enabled = true;
        }

        public void CreaTabla(int fila, int col)
        {
            int x = 12, y = 100;
            tabla = new Button[fila, col];
            for (int i = 0; i < tabla.GetLength(0); i++)
            {
                for (int j = 0; j < tabla.GetLength(1); j++)
                {
                    boton = new Button()
                    {
                        Size = new Size(70, 70),
                        Location = new Point(x, y),
                        Enabled = true,
                        Font = new Font("French Script MT", 22)
                    };
                    tabla[i, j] = boton;
                    colorDefecto = boton.BackColor;
                    this.boton.Click += new EventHandler(this.btn_Click);
                    this.boton.MouseEnter += new EventHandler(this.btn_MouseEnter);
                    this.boton.MouseLeave += new EventHandler(this.btn_MouseLeave);
                    this.Controls.Add(boton);
                    x += 80;
                    if ((j + 1) % 3 == 0)
                    {
                        y += 80;
                        x = 12;
                    }
                };
            }
        }

        public Button[,] PonerDatos(Button[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (i < 3 && j < 3)
                    {
                        table[i, j].Text = cont++.ToString();
                    }
                    else
                    {
                        if (i == 3 && j == 0)
                        {
                            table[i, j].Text = "*";
                        }
                        else if (i == 3 && j == 1)
                        {
                            table[i, j].Text = 0.ToString();
                        }
                        else
                        {
                            table[i, j].Text = "#";
                        }
                    }
                }
            }
            return table;
        }

        public void CrearReset()
        {
            botonReset = new Button()
            {
                Size = new Size(230, 50),
                Location = new Point(12, 420),
                Enabled = true,
                Text = "RESET"
            };
            this.botonReset.Click += new EventHandler(this.btnReset_Click);
            this.Controls.Add(botonReset);
        }

        public void btn_Click(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Beige;
            this.textBox1.Text += ((Button)sender).Text;
        }

        public void btn_MouseEnter(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.Beige)
            {
                ((Button)sender).BackColor = Color.DarkCyan;
            }
        }

        public void btn_MouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.Beige)
            {
                ((Button)sender).BackColor = colorDefecto;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contSeconds++;
            if (contSeconds == 60)
            {
                contMinutos++;
                contSeconds = 0;
            }
            this.Text = $"Teléfono: {contMinutos:D2}:{contSeconds:D2}";
        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    item.BackColor = colorDefecto;
                }
            }
        }

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter s;
            if (textBox1.Text != string.Empty)
            {
                saveFileDialog1.ShowDialog();
                try
                {
                    using (s = new StreamWriter(this.saveFileDialog1.FileName, true))
                    {
                        s.WriteLine(textBox1.Text);
                    }
                }
                catch (ArgumentException)
                {
                    Debug.WriteLine("Filename neve empty");
                }
            }
        }

        private void acercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Miguel Miguelez Cazapal", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}