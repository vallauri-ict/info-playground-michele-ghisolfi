using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_OOP_ComplessiEQuaternioni
{
    class Quaternione : Complesso
    {
        private double c;
        private double d;

        public double D { get => d; set => d = value; }
        public double C { get => c; set => c = value; }

        public Quaternione() : base()
        {
        }

        public Quaternione(double immaginario)
            : base(immaginario)
        {

        }

        public Quaternione(double reale, double immaginario)
            : this(reale, immaginario, 0, 0)
        {

        }


        public Quaternione(double reale, double immaginario, double immaginarioC)
            : this(reale, immaginario, immaginarioC, 0)
        {

        }

        public Quaternione(double reale, double immaginario, double immaginarioC, double immaginarioD)
            : base(reale, immaginario)
        {
            C = immaginarioC;
            D = immaginarioD;
        }

        public double Modulo()
        {
            double somma = Math.Pow(Reale, 2) + Math.Pow(Immaginario, 2) + Math.Pow(C, 2) + Math.Pow(D, 2);
            return Math.Sqrt(somma);
        }
    }
}
