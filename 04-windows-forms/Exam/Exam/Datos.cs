using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Datos
    {
        private double tMax;
        public double TMax
        {
            set { tMax = value; }
            get { return tMax; }
        }

        private double precip;
        public double Precip
        {
            set { precip = value; }
            get { return precip; }
        }

    }
}
