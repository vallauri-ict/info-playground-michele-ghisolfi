using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_MetodoFactory
{
    class Quadrato
    {
        private int lato;

        private Quadrato(int lato)
        {
            this.lato = lato;
        }

        public static Quadrato CreaQuadrato(int lato)
        {
            if (lato<=0)
            {
                throw new Exception("Il lato del quadrato deve essere maggiore di 0");
            }
            else
            {
                return new Quadrato(lato);
            }
        }
    }
}
