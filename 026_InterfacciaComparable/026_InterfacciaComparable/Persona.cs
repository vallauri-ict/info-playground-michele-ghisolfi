using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _026_InterfacciaComparable
{
    class Persona : IComparable
    {
        private string nome;
        private string cognome;
        private string citta;

        public Persona(string nome, string cognome, string citta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.citta = citta;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Citta { get => citta; set => citta = value; }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1; // un oggetto null è più piccolo di tutti
            }
            Persona p = obj as Persona;
            return String.Compare(Cognome, p.Cognome, true); // case unsensitive
        }

        public override string ToString()
        {
            return $"{cognome} {nome} {citta}";
        }
    }
}
