using System;

namespace _024_EsStagisti
{
    abstract class clsPersona
    {
        #region attributi
        private string nome;
        private string cognome;
        private string città;
        #endregion
        public string Città
        {
            get => città;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    città = value;
                }
                else
                {
                    throw new Exception("Città non valida");
                }
            }

        }
        public string Nome
        {
            get => nome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Nome non valido");
                }
            }
        }
        public string Cognome
        {
            get => cognome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    cognome = value;
                }
                else
                {
                    throw new Exception("Cognome non valido");
                }
            }
        }

        protected clsPersona(string città, string nome, string cognome)
        {
            Città = città;
            Nome = nome;
            Cognome = cognome;
        }

        public abstract string visualizza();
    }
}
