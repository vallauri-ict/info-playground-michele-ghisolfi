using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Lista
{
    class clsLibri
    {
        public string autore;
        public string titolo;
        public int id;

        static List<clsLibri> listaLibri = new List<clsLibri>();

        public clsLibri()
        {

        }

        public clsLibri(string autore, string titolo, int id)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.id = id;
        }

        public static void AggiungiLibro(string autore, string titolo, int id)
        {
            clsLibri libro = new clsLibri(autore, titolo, id);
            listaLibri.Add(libro);
        }

        public static void VisualizzaLibri()
        {
            string s = "";
            foreach (clsLibri item in listaLibri)
            {
                s += item.autore.ToString() + "  " + item.titolo.ToString() + "\n";
            }
            System.Windows.Forms.MessageBox.Show(s);
        }

        public static string Find(string titoloDaCercare)
        {
            clsLibri ris = listaLibri.Find(l => l.titolo == titoloDaCercare);
            string s = ris.autore + " " + ris.titolo;

            return s;
        }

        public static string FindAll(string titoloDaCercare)
        {
            List<clsLibri> ListaLibriAppoggio = new List<clsLibri>();
            ListaLibriAppoggio = listaLibri.FindAll(l => l.titolo == titoloDaCercare);
            string s = "";
            foreach (clsLibri item in ListaLibriAppoggio)
            {
                s += item.autore + " " + item.titolo + "\n";
            }

            return s;
        }
    }
}
