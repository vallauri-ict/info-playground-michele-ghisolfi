using System;

namespace _022_EreditarietàCarte2
{
    class Carte
    {
        public string Valore { get; set; }
        public string Seme { get; set; }

        public string[] listaSemi = { "Cuore", "Picche", "Fiore", "Quadri" };
        public string[] listaVal = { "Asso", "2", "3", "4", "5", "6", "7", "Fante", "Regina", "Re" };

        public Carte(string valore, string seme)
        {
            Valore = valore;
            Seme = seme;
        }
    }
}
