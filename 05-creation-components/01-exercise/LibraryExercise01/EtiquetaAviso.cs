using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryExercise01
{
    public partial class EtiquetaAviso : Control
    {
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(0, 0), new Point(this.Width, this.Height), Color, ColorSecond);
            if (Gradient)
            {
                pe.Graphics.FillRectangle(lgb, new Rectangle(0, 0, this.Width, this.Height));
            }
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
            if (Gradient)
            {

            }
            // Altura de fuente, usada como referencia en varias partes
            int h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia 
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se 
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
            }
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        public enum eMarca
        {
            Nada,
            Cruz,
            Circulo
        }

        private eMarca marca = eMarca.Nada;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public eMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }

        private Color color;
        [Category("BackGround")]
        [Description("Indica el primer color para el fondo de la etiqueta")]
        public Color Color
        {
            set
            {
                color = value;
                this.Refresh();
            }

            get
            {
                return color;
            }
        }

        private Color colorSecond;
        [Category("BackGround")]
        [Description("Indica el segundo color para el fondo de la etiqueta")]
        public Color ColorSecond
        {
            set
            {
                colorSecond = value;
                this.Refresh();
            }

            get
            {
                return colorSecond;
            }
        }

        private bool gradient = true;
        [Category("BackGround")]
        [Description("Indica si hay gradient o no")]
        public bool Gradient
        {
            set
            {
                gradient = value;
                this.Refresh();
            }
            get
            {
                return gradient;
            }
        }
    }
}
