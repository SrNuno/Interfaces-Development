﻿using ControlLibrary;
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

namespace Exercise01_02
{
    public partial class Form1 : Form
    {
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Welcome";
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Posicion.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == LabelTextBox.ePosicion.Izquierda)
            {
                labelTextBox1.Posicion = LabelTextBox.ePosicion.Derecha;
            }
            else
            {
                labelTextBox1.Posicion = LabelTextBox.ePosicion.Izquierda;
            }
        }
        private void labelTextBox1_SeparacionChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Separación: " + labelTextBox1.Separacion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelTextBox1.Separacion += 1;
        }

        private void labelTextBox1_TxtChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Se está escribiendo");
        }

        private void etiquetaAviso2_ClickEnMarca(object sender, EventArgs e)
        {
            Debug.Write("Hola");
        }
    }
}
