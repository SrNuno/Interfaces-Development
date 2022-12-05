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

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        string path = Environment.ExpandEnvironmentVariables("%userprofile%") + "\\nombres.txt";
        public string students;
        public string[] subjects;
        Aula classroom;
        Label label;

        public Form1()
        {
            InitializeComponent();
            createDocument();
            createTable();
            if (classroom.calcMedia() < 5)
            {
                label3.ForeColor = Color.DarkRed;
            }
            else
            {
                label3.ForeColor = Color.DarkGreen;
            }

            label3.Text = "Average table: " + classroom.calcMedia();
        }

        public void createDocument()
        {
            try
            {
                students = File.ReadAllText(path);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Create a file \"nombres.txt\" with names students in user directory", "File not exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            classroom = new Aula(students);
            subjects = Enum.GetNames(typeof(Aula.Asig));
            comboBox1.Items.AddRange(classroom.guardaNombres);
            comboBox2.Items.AddRange(subjects);
        }

        public void createTable()
        {
            int x = 95;
            int y = 65;

            for (int i = 0; i < subjects.Length; i++)
            {
                label = new Label();
                label.Text = subjects[i];
                label.Font = new Font("French Script MT", 9);
                //label.BorderStyle = BorderStyle.FixedSingle;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Location = new Point(x, y);
                label.Size = new Size(100, 25);
                this.Controls.Add(label);
                x += 105;
            }

            x = 13;
            y = 95;

            for (int i = 0; i < classroom.guardaNombres.Length; i++)
            {
                label = new Label();
                label.Text = classroom.guardaNombres[i];
                label.Location = new Point(x, y);
                label.Font = new Font("French Script MT", 9);
                //label.BorderStyle = BorderStyle.FixedSingle;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Size = new Size(80, 20);
                this.Controls.Add(label);
                if ((i + 1) % 1 == 0)
                {
                    x = 13;
                    y += 25;
                }
            }

            x = 120;
            y = 95;

            for (int j = 0; j < classroom.guardaNombres.Length; j++)
            {
                for (int i = 0; i < subjects.Length; i++)
                {
                    label = new Label();
                    label.Text = classroom.notas[i, j].ToString();
                    label.Location = new Point(x, y);
                    //label.BorderStyle = BorderStyle.FixedSingle;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Size = new Size(50, 20);
                    this.label.MouseEnter += new System.EventHandler(this.ChangeBackColor);
                    this.label.MouseLeave += new System.EventHandler(this.ChangeDefaultColor);
                    toolTip1.SetToolTip(label, classroom.guardaNombres[j].ToString() + "\n" + subjects[i]);
                    this.Controls.Add(label);
                    x += 103;
                    if ((i + 1) % 4 == 0)
                    {
                        x = 120;
                        y += 25;
                    }
                }
            }
        }

        public void ChangeBackColor(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Yellow;
        }

        public void ChangeDefaultColor(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = DefaultBackColor;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (classroom.mediaAlumno(comboBox1.SelectedIndex) < 5)
            {
                label4.ForeColor = Color.DarkRed;
            }
            else
            {
                label4.ForeColor = Color.DarkGreen;
            }

            label4.Text = $"Average {comboBox1.SelectedItem}: {classroom.mediaAlumno(comboBox1.SelectedIndex).ToString()}";
            classroom.minMaxAlumno(comboBox1.SelectedIndex, out int min, out int max);
            label6.Text = $"Minimum note about {comboBox1.SelectedItem} has Min: {min}";
            label7.Text = $"Maximum note about {comboBox1.SelectedItem} has Max: {max}";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classroom.mediaAsignatura(comboBox2.SelectedIndex) < 5)
            {
                label5.ForeColor = Color.DarkRed;
            }
            else
            {
                label5.ForeColor = Color.DarkGreen;
            }

            label5.Text = $"Average {comboBox2.SelectedItem}: {classroom.mediaAsignatura(comboBox2.SelectedIndex).ToString()}";
        }
    }
}
