using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ControlLibrary
{
    public partial class LabelTextBox: UserControl
    {
        public LabelTextBox()
        {
            InitializeComponent();
        }

        public enum ePosicion
        {
            Izquierda, Derecha
        }

        private ePosicion posicion = ePosicion.Izquierda;
        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    recolocar();
                    OnPosicionChanged(EventArgs.Empty);
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        private int separacion = 0;
        [Category("Design")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                    OnSeparacionChanged(EventArgs.Empty);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("Design")]
        [Description("Valor para el campo PasswordChar")]
        public char PswChr
        {
            set
            {
                txt.PasswordChar = value;
            }

            get
            {
                return txt.PasswordChar;
            }
        }

        public void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.Izquierda:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    this.Width = lbl.Width + Separacion + txt.Width;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;

                case ePosicion.Derecha:
                    txt.Location = new Point(0, 0);
                    this.Width = lbl.Width + Separacion + txt.Width;
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }

        [Category("Miguel")]
        [Description("Se lanza cuando la propiedad Separacion cambia")]
        public event System.EventHandler PosicionChanged;
        protected virtual void OnPosicionChanged(EventArgs e)
        {
            if (PosicionChanged != null)
            {
                PosicionChanged?.Invoke(this, e);
            }
        }

        [Category("Miguel")]
        [Description("Se lanza cuando la propiedad Separacion cambia")]
        public event System.EventHandler SeparacionChanged;

        protected virtual void OnSeparacionChanged(EventArgs e)
        {
            if (SeparacionChanged != null)
            {
                SeparacionChanged?.Invoke(this, e);
            }
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        [Category("Miguel")]
        [Description("Se lanza cuando sucede el evento TextChanged del TextBox interno")]
        public event System.EventHandler TxtChanged;
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (TxtChanged != null)
            {
                TxtChanged?.Invoke(this, e);
            }
        }
    }
}
