using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class Ahorcado : UserControl
    {
        [Category("Miguel")]
        [Description("Evento lanzado cuando cambia el num de errores")]
        public event EventHandler CambiaError;

        [Category("Miguel")]
        [Description("Errores en el ahorcado")]
        public event EventHandler Ahorcad0;

        [Category("Miguel")]
        [Description("Errores en el ahorcado")]
        private int errores;
        public int Errores
        {
            set
            {
                if (value >= 0)
                {
                    errores = value;
                    CambiaError?.Invoke(this, EventArgs.Empty);
                    this.Refresh();
                }

                if (value >= 7)
                {
                    Ahorcad0?.Invoke(this, EventArgs.Empty);
                }
            }

            get
            {
                return errores;
            }
        }

        public Ahorcado()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            switch (Errores)
            {
                case 1:
                    e.Graphics.DrawLine(new Pen(Color.Red), new Point(20, this.Height - 20), new Point(this.Width - 20, this.Height - 20));
                    e.Graphics.DrawLine(new Pen(Color.Red), new Point(50, 20), new Point(50, this.Height - 20));
                    e.Graphics.DrawLine(new Pen(Color.Red), new Point(50, 40), new Point(75, 20));
                    e.Graphics.DrawLine(new Pen(Color.Red), new Point(50, 20), new Point(this.Width - 60, 20));
                    break;
                case 2:
                    e.Graphics.DrawLine(new Pen(Color.Red), new Point(this.Width - 60, 20), new Point(this.Width - 60, 50));
                    goto case 1;
                case 3:
                    e.Graphics.DrawEllipse(new Pen(Color.Red), this.Width - 80, 50, 40, 40);
                    goto case 2;
                case 4:
                    e.Graphics.DrawLine(new Pen(Color.Red), new Point(this.Width - 60, 90), new Point(this.Width - 60, 120));
                    goto case 3;
                case 5:
                    e.Graphics.DrawLine(new Pen(Color.Red), new Point(this.Width - 80, 100), new Point(this.Width - 40, 100));
                    goto case 4;
                case 6:
                    e.Graphics.DrawLine(new Pen(Color.Red), new Point(this.Width - 60, 120), new Point(this.Width - 70, 140));
                    goto case 5;
                case 7:
                    e.Graphics.DrawLine(new Pen(Color.Red), new Point(this.Width - 60, 120), new Point(this.Width - 50, 140));
                    goto case 6;
            }
        }
    }
}
