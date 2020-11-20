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
        }

        struct Paziente
        {
            public string Nome;
            public int Eta;
            public string Colore;
        }

        Queue<Paziente> QueueRosso = new Queue<Paziente>();
        Queue<Paziente> QueueGiallo = new Queue<Paziente>();
        Queue<Paziente> QueueVerde = new Queue<Paziente>();
        Queue<Paziente> QueueBianco = new Queue<Paziente>();

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            Paziente p;
            p.Nome = txtNome.Text;
            bool aus = Int32.TryParse(txtEta.Text, out p.Eta);
            if (aus)
            {
                p.Colore = cmbColore.SelectedItem.ToString();
                switch (cmbColore.Text)
                {
                    case "Rosso":
                        QueueRosso.Enqueue(p);
                        break;
                    case "Giallo":
                        QueueGiallo.Enqueue(p);
                        break;
                    case "Verde":
                        QueueVerde.Enqueue(p);
                        break;
                    case "Bianco":
                        QueueBianco.Enqueue(p);
                        break;
                    default:
                        MessageBox.Show("Inserire un colore");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Età inserita NON correttamente");
            }
            
        }

        private void btnLiberaPaziente_Click(object sender, EventArgs e)
        {
            if (QueueRosso.Count > 0)
            {
                QueueRosso.Dequeue();
            }
            else
            {
                if (QueueGiallo.Count > 0)
                {
                    QueueGiallo.Dequeue();
                }
                else
                {
                    if (QueueVerde.Count > 0)
                    {
                        QueueVerde.Dequeue();
                    }
                    else
                    {
                        QueueBianco.Dequeue();
                    }
                }
            }
        }
    }
}
