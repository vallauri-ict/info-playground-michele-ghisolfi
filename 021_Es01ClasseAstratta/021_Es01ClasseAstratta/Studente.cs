﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Es01ClasseAstratta
{
    class Studente
    {
        public string Nome { get; set; }
        private string Cognome { get; set; }

        private DateTime dataNascita;

        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public string nomeCompleto()
        {
            return Nome + " " + Cognome;
        }
    }
}
