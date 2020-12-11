using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_OOP_PersoneStudenti
{
    class Persona
    {
        private string nome, cognome, sesso;
        private int eta;

        public void SetAttributs(string nome, string cognome, string sesso, int eta)
        {
            if (true)
            {
                // controllo tutti valori ok
            }
            this.nome = nome;
            this.cognome = cognome;
            this.sesso = sesso;
            this.eta = eta;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetCognome()
        {
            return this.cognome;
        }

        public string GetSesso()
        {
            return this.sesso;
        }

        public int Geteta()
        {
            return this.eta;
        }
    }
}
