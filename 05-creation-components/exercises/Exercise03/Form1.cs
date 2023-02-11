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

namespace Exercise03
{
    public partial class Form1 : Form
    {
        public Timer timer = new Timer();
        private List<FileInfo> files;
        private List<Bitmap> images;
        private string[] extensions = new string[]
        {
            "*.jpg",
            "*.jpeg",
            "*.png"
        };

        private int index = 0;
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 21; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
            //timer = new Timer();
            timer.Tick += new EventHandler(timerEvent);
            files = new List<FileInfo>();
            images = new List<Bitmap>();
        }

        private void timerEvent(object sender, EventArgs e)
        {
            reproSimple.Seconds += 1;
            if (images.Count > 0)
            {
                index = index >= images.Count ? 0 : index;
                pictureBox1.Image = images[index];
                index++;
            }
        }

        private void reproSimple_PlayClick(object sender, EventArgs e)
        {
            if (reproSimple.IsPlay)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        private void reproSimple_DesbordaTiempo(object sender, EventArgs e)
        {
            reproSimple.Minutes += 1;
        }

        private void abrirDirectorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo di = new DirectoryInfo(fbd.SelectedPath);
                if (di.Exists)
                {
                    //TopDirectory: Especifica si se va a buscar, este caso, solo incluye el directorio actual en una operación de búsqueda
                    files = extensions.SelectMany(i => di.GetFiles(i, SearchOption.TopDirectoryOnly)).ToList();
                    if (files.Count > 0)
                    {
                        images.Clear();
                        files.ForEach(i => images.Add(new Bitmap(i.FullName)));
                        index = 0;
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer.Interval = int.Parse(comboBox1.SelectedItem.ToString()) * 1000;
        }
    }
}
