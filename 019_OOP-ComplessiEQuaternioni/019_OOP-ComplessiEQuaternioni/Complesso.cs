using System;

namespace _019_OOP_ComplessiEQuaternioni
{
    class Complesso
    {
        private double reale = 0;
        private double immaginario = 0;

        public Complesso() : this(1)
        {
        }

        public Complesso(double immaginario) : this(0, immaginario)
        {

        }

        public Complesso(double reale, double immaginario)
        {
            Reale = reale;
            Immaginario = immaginario;
        }

        public double Reale { get => reale; set => reale = value; }
        public double Immaginario { get => immaginario; set => immaginario = value; }


        public double Modulo()
        {
            double somma = Math.Pow(Reale, 2) + Math.Pow(Immaginario, 2);
            return Math.Sqrt(somma);
        }

        public void Coniugato()
        {
            Immaginario = -Immaginario;
        }
    }
}
