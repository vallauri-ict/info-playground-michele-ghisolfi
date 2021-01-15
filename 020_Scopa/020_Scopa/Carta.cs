using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Scopa
{
    class Carta
    {
        private int valore;
        private string seme;

        public Carta(int valore, string seme)
        {
            this.valore = valore;
            this.seme = seme;
        }

        public void Lettura (string seme, int valore)
        {
            seme = this.seme;
            valore = this.valore;
        }
    }
}
