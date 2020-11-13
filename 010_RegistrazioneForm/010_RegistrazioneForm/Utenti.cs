using System;
using System.IO;

namespace _010_RegistrazioneForm
{
    class Utenti
    {
        private static Utenti instace = null;
        private const char separatore = '|';
        private const string nomeFile = "Utenti.txt";

        private Utenti()
        {

        }

        public static Utenti GetInstace()
        {
            if (instace == null)
            {
                instace = new Utenti();
            }
            return instace;
        }
   
        internal void aggiungiUtente(string nome, string cognome, string indirizzo, string citta, 
            string cap, string mail, string codFiscale, string user, string pwd)
        {
            StreamReader sr = new StreamReader(nomeFile);
            if (!presente(sr, separatore, user))
            {
                sr.Close();
                StreamWriter sw = new StreamWriter(nomeFile, true);
                sw.WriteLine(nome + separatore + cognome + separatore + indirizzo + separatore +
                    citta + separatore + cap + separatore + mail + separatore + codFiscale +
                    separatore + user + separatore + pwd);
                sw.Close();
                System.Windows.Forms.MessageBox.Show("Utente Aggiunto");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Utente già presente nel file");
            }
            sr.Close();
        }

        private bool presente(StreamReader sr, char separatore, string user)
        {
            bool presente = false;
            while (sr.Peek() != -1 && !presente)
            {
                if (sr.ReadLine().Split(separatore)[7] == user)
                {
                    presente = true;
                }
            }

            return presente;
        }
    }
}
