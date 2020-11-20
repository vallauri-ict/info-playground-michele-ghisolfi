using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/*
UTILIZZANDO UNA PILA realizzare la gestione dei Container alla banchina di un porto:
i Container sono dei grandi contenitori di merci. Una gru solleva i Container e li mette in pila uno
sull’altro. Poi dalla banchina li carica nelle stive delle navi. Dichiara una struttura Container coi
campi Codice, Peso e Tara; poi prepara un programma che carica in una pila i dati dei Container
prelevati da caselle di testo; un altro pulsante invece toglie dalla pila i Container e mostra a video i
dati
*/

namespace _014_StackContainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Container
        {
            public string Codice;
            public int Peso;
            public int Tara;
        }

        Stack<Container> StackContainer = new Stack<Container>();

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Container c;
            c.Codice = txtCodice.Text;
            bool val = int.TryParse(txtPeso.Text, out c.Peso);
            val = int.TryParse(txtTara.Text, out c.Tara);

            if (!val) { 
                MessageBox.Show("Inserie correttamente i dati"); 
            }
            else { 
                StackContainer.Push(c); 
                MessageBox.Show("Dati inseriti correttamente");
            }
        }

        private void btnEstrai_Click(object sender, EventArgs e)
        {
            if (StackContainer.Count > 0)
            {
                Container p;
                p = StackContainer.Pop();
                lblCodice.Text = "Codice: " + p.Codice;
                lblPeso.Text = "Peso" + p.Peso;
                lblTara.Text = "Tara: " + p.Tara;
            }
            else
            {
                MessageBox.Show("Stack vuoto");
                foreach (TextBox item in this.Controls.OfType<TextBox>())
                {
                    item.Text = "";
                }
            }
        }
    }
}
