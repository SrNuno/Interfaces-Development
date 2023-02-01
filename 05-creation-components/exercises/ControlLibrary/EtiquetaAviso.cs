using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class EtiquetaAviso : Control
    {
        int offsetX = 0;
        int offsetY = 0;
        int grosor = 0;

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

            int h = this.Font.Height;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            switch (Marca)
            {
                case eMarca.Nada:
                    offsetX = 0;
                    offsetY = 0;
                    grosor = 0;
                    break;

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
                    lapiz.Dispose();
                    break;

                case eMarca.Imagen:
                    if (Image != null)
                    {
                        offsetX = h;
                        offsetY = h;
                        g.DrawImage(Image, 0, offsetY, h, h);
                    }
                    else
                    {
                        offsetX = 0;
                        offsetY = 0;
                        grosor = 0;
                    }
                    break;
            }
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
            Circulo,
            Imagen
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

        private Image image;
        [Category("Appearance")]
        [Description("Indica la imagen que se utilizará")]
        public Image Image
        {
            set
            {
                image = value;
                this.Refresh();
            }
            get { return image; }
        }

        [Category("Miguel")]
        [Description("Se lanza cuando se hace click en la marca")]
        public event System.EventHandler ClickEnMarca;
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (ClickEnMarca != null)
            {
                if (e.Location.X < offsetX + grosor)
                {
                    ClickEnMarca?.Invoke(this, e);
                }
            }
        }
    }
}
