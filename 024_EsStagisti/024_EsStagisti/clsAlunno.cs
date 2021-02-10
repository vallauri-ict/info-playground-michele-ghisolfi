using System;

namespace _024_EsStagisti
{
    class clsAlunno : clsPersona
    {
        #region attributi
        private static int progressivo = 0;
        private readonly string matricola;
        private char classe;
        private char sezione;
        private string specializzazione;
        #endregion

        public static int Progressivo { get => progressivo; set => progressivo = value; }
        public string Matricola => matricola;
        public char Classe { get => classe; set => classe = Convert.ToChar(value); }
        public char Sezione { get => sezione; set => sezione = Convert.ToChar(value); }
        public string Specializzazione { get => specializzazione; set => specializzazione = value; }

        public clsAlunno( string nome, string cognome, string città, string classe, string sezione, string spec) 
            : base(città, nome, cognome)
        {
            Classe = Convert.ToChar(classe);
            Specializzazione = spec;
            Sezione = Convert.ToChar(sezione);

            progressivo++;
            matricola = "A" + progressivo.ToString().PadLeft(5, '0');
        }

        public override string visualizza()
        {
            return Matricola + " " + Nome + " " + Cognome + " " + Città + " " + Classe + " " + Sezione + " " + Specializzazione;
        }
    }
}
