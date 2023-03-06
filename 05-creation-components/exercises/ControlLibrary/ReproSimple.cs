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
    public partial class ReproSimple : UserControl
    {
        public ReproSimple()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (btn.Text.Equals(">"))
            {
                btn.Text = "||";
                IsPlay= true;
            }
            else
            {
                btn.Text = ">";
                IsPlay= false;
            }
            OnPlayClick(EventArgs.Empty);
        }

        [Category("Miguel")]
        [Description("Se lanza cuando el boton cambia su estado")]
        public event System.EventHandler PlayClick;
        protected virtual void OnPlayClick(EventArgs e)
        {
           // if (PlayClick != null)
            {
                PlayClick?.Invoke(this, e);
            }
        }

        private int seconds = 0;
        [Category("Miguel")]
        [Description("Texto asociado a los segundos en la Label")]
        public int Seconds
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else if (value >= 60)
                {
                    seconds = value % 60;
                    DesbordaTiempo?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    seconds = value;
                }

                updateTime();
            }

            get
            {
                return seconds;
            }

        }

        private int minutes = 0;
        [Category("Miguel")]
        [Description("Texto asociado a los minutos en la Label")]
        public int Minutes
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    if (minutes > 60)
                    {
                        minutes = 0;
                    }
                    else
                    {
                        minutes = value;
                    }
                }
                updateTime();
            }

            get
            {
                return minutes;
            }
        }

        [Category("Miguel")]
        [Description("Se lanza cuando los segundos supera a 59")]
        public event System.EventHandler DesbordaTiempo;


        [Category("Miguel")]
        [Description("Bandera si esta la repro. parada o en play")]
        private bool isPlay = false;
        public bool IsPlay
        {
            set { isPlay = value; }
            get { return isPlay; }
        }


        private void updateTime()
        {
            lbl.Text = $"{minutes,2:d2}:{seconds,2:d2}";
        }
    }

}
