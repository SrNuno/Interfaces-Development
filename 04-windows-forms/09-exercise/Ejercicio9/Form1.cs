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

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        string filters = "Normal text file (*.txt)|*.txt|Ini source file (*.ini)|*.ini|Java source file (*.java)|*.java|C# source file (*.cs)|*.cs|Python source file (*.py)|*.py|Html source file (*.html)|*.html|Css source file (*.css)|*.css|Xml source file (*.xml)|*.xml|All Files (*.*)|*.*\"";
        FileInfo fileInfo;
        public Form1()
        {
            InitializeComponent();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = filters;
            openFile.ShowDialog();

            try
            {
                StreamReader sr = new StreamReader(openFile.FileName);
                fileInfo = new FileInfo(openFile.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (ArgumentException)
            {
                Trace.WriteLine("Enter a filename, never empty");
            }
            this.Text = openFile.SafeFileName;
            textBox1.Modified = true;
        }

        private void saveFile()
        {
            if (textBox1.Text.Length != 0)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = filters;
                saveFile.ShowDialog();

                try
                {
                    StreamWriter sw = new StreamWriter(saveFile.FileName);
                    fileInfo = new FileInfo(saveFile.FileName);
                    sw.Write(textBox1.Text);
                    sw.Close();
                }
                catch (ArgumentException)
                {
                    Trace.WriteLine("Enter a filename, never empty");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Modified)
            {
                //this.Text = $"*{fileInfo.Name}: NotePad";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified)
            {
                if (MessageBox.Show($"¿Do you want save the changes {fileInfo.Name}?", "NotePad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None) != DialogResult.Cancel)
                {
                    //e.Cancel = true;
                    saveFile();
                }
            }
        }
    }
}
