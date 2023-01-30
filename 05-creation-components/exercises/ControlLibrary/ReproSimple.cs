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
            }
            else
            {
                btn.Text = ">";
            }
        }
    }
}
