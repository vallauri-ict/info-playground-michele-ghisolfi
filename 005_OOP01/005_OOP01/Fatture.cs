using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _005_OOP01
{
    class Fatture
    {
        private static int cntFatture = 0;
        public readonly int nFattura;

        public Fatture()
        {
            cntFatture++;
            nFattura = cntFatture;
        }

        public static void visualizza()
        {
            System.Windows.Forms.MessageBox.Show("Numero fatture create: " + cntFatture);
            //System.Windows.Forms.MessageBox.Show("Numero fattura corrente: " + nFattura);
        }
    }
}
