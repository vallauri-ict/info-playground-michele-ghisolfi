using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_OOP_PersoneStudenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Studente> lstStudenti = new List<Studente>();

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s.SetAttributs(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Text));
            lstStudenti.Add(s);
            listStudenti.Items.Add(s.GetCognome());
        }

        private void btnInserisciVoto_Click(object sender, EventArgs e)
        {
            string cognome = listStudenti.SelectedItems[0].Text;
            foreach (Studente item in lstStudenti)
            {
                if (item.GetCognome() == listStudenti.SelectedItems[0].Text)
                {
                    item.voti.Add(Convert.ToInt32(txtVoto.Text));
                }
            }
        }

        private void btnVissualizza_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s = lstStudenti.Find(stud => stud.GetCognome() == listStudenti.SelectedItems[0].Text);
            MessageBox.Show("lo studente " + s.GetCognome() + " " + s.GetNome() + " di " + s.Geteta() + " anni, ha la media del " + s.media());
        }
    }
}
