﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librieria1
{
    public class MisMates
    {
        private double a;
        private double b;
        private double r;

        public MisMates(double pA, double pB)
        {
            a = pA;
            b = pB;
            r = 0;
        }

        public double R { get { return r; } }

        public double suma()
        {
            r = a + b;
            return r;
        }

        public double multi()
        {
            r = a * b;
            return r;
        }

        public double resta()
        {
            r = a - b;
            return r;
        }

        public double div()
        {
            r = a / b;
            return r;
        }
    }
}
