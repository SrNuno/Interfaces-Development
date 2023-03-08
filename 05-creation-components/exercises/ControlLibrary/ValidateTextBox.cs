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
    [Category("Miguel")]
    [Description("Enumerado de la clase Tipo")]
    public enum eTipo
    {
        Numerico,
        Textual
    }
    public partial class ValidateTextBox : UserControl
    {
        private bool isValid;
        public ValidateTextBox()
        {
            InitializeComponent();
            this.Height = txt.Height + 20;
            txt.Width = this.Width - 20;
        }

        [Category("Miguel")]
        [Description("Contenido del TextBox interno")]
        public string Texto
        {
            set
            {
                txt.Text = value;
                comprobar();
                Refresh();
            }
            get { return txt.Text; }
        }

        [Category("Miguel")]
        [Description("Multilínea del TextBox interno")]
        public bool Multilinea
        {
            set { txt.Multiline = value; }
            get { return txt.Multiline; }
        }

        [Category("Miguel")]
        [Description("Indica de que tipo es")]
        private eTipo tipo;
        public eTipo Tipo
        {
            set
            {
                tipo = value;
                comprobar();
                Refresh();
            }
            get { return tipo; }
        }

        private void comprobar()
        {
            switch (Tipo)
            {
                case eTipo.Numerico:
                    isValid = txt.Text.Trim().All(c => Char.IsNumber(c));
                    break;

                case eTipo.Textual:
                    isValid = txt.Text.All(c => Char.IsLetter(c) || c == ' ');
                    break;
            }
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color color = isValid ? Color.Green : Color.Red;
            e.Graphics.DrawRectangle(new Pen(color), new Rectangle(new Point(5, 5), new Size(Width - 10, Height - 10)));
        }

        [Category("Miguel")]
        [Description("Evento cambio de texto")]
        public event System.EventHandler CambioTexto;
        protected virtual void OnCambioText(EventArgs e)
        {
            CambioTexto?.Invoke(this, EventArgs.Empty);
            Refresh();
        }

        private void txt_TextChanged_1(object sender, EventArgs e)
        {
            this.Refresh();
            comprobar();
            OnCambioText(EventArgs.Empty);
        }
    }
}
