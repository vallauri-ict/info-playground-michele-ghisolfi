using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
UTILIZZANDO UNA CODA realizzare la gestione di un pronto soccorso:
al Pronto Soccorso i pazienti sono classificati con un colore: rosso (urgentissimo), giallo (grave),
verde (moderato), bianco (lieve). Funziona così: quando una persona arriva al pronto soccorso
l’infermiere lo registra (nome e età) e decide anche il colore di priorità; appena un medico è libero
deve gestire prima quelli con codice rosso, poi giallo, poi verde e poi bianco. Dichiara una struttura
Paziente con i campi Nome, Età, Colore; il programma deve gestire 4 code diverse e inserire il
paziente nella lista corretta; quando un medico è libero preme il pulsante e il programma fornisce
subito il paziente da servire (quindi sceglie il primo dei pazienti codice verde solo se non ci sono
codici rosso e giallo). Le informazioni vanno visualizzate in una etichetta; i dati prelevati da caselle
di testo Un altro pulsante determina i valori massimo e minimo giornalieri delle temperature
rilevate.
*/

namespace _013_GestioneProntoSoccorso
{
    public partial class Form1 : Form
    {
        string[] coloriUrgenza = { "Rosso", "Giallo", "Verde", "Bianco" };

        public Form1()
        {
            InitializeComponent();
            cmbColore.SelectedIndex = 0;
            setQueue();
        }

        struct Paziente
        {
            public string Nome;
            public int Eta;
            public string Colore;
            public int Temperatura;
        }

        /*
         * Priorità gestita in base all' indice. 
         * 0 = priorità massima
         * vetQueue.Lenght = priorità minima
         */
        Queue<Paziente>[] vetQueue = new Queue<Paziente>[4];

        private void setQueue()
        {
            for(int i=0; i<vetQueue.Length; i++)
            {
                vetQueue[i] = new Queue<Paziente>();
            }    
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != " ")
            {
                if (Int32.TryParse(txtEta.Text, out int eta))
                {
                    Paziente p;
                    p.Colore = cmbColore.SelectedItem.ToString();
                    p.Eta = eta;
                    Random rnd = new Random();
                    p.Temperatura = rnd.Next(35, 41);
                    p.Nome = txtNome.Text;
                    vetQueue[cmbColore.SelectedIndex].Enqueue(p);
                }
                else
                {
                    MessageBox.Show("Età inserita NON correttamente");
                }
            }
            else
            {
                MessageBox.Show("Inserire un nome");
            }
            
        }

        private void btnInfermiere_Click(object sender, EventArgs e)
        {
            foreach (var item in vetQueue)
            {
                if (item.Count>0)
                {
                    Paziente p;
                    p = item.Dequeue();
                    lblUltimoPazienteVisitato.Text = p.Nome + " - " + p.Eta + " Anni - " + p.Temperatura + "C° - Codice" + p.Colore;
                    break;
                }
            }
        }
    }
}
