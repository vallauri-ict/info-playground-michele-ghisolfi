using System;
using System.Windows.Forms;

namespace _024_EsStagisti
{
    public partial class Form1 : Form
    {
        clsElenco elencoStudenti;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elencoStudenti = new clsElenco();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            clsAlunno stu;
            if (txtOre.Text.Trim() == "")
            {
                stu = new clsAlunno(txtNome.Text, txtCognome.Text, txtCitta.Text, cmbClasse.SelectedItem.ToString(), cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedIndex.ToString());
            }
            else
            {
                stu = new clsStagista(txtNome.Text, txtCognome.Text, txtCitta.Text, cmbClasse.SelectedItem.ToString(), cmbSezione.SelectedItem.ToString(), cmbSpec.SelectedIndex.ToString(), cmbAzienda.SelectedItem.ToString(), txtOre.Text);
                btnRicerca.Enabled = true;
            }
            elencoStudenti.inserisci(stu);
            elencoStudenti.VisualizzaDGV(dgvStudenti);
            pulisciCampi();
        }

        private void pulisciCampi()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 1;
                }

            }
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            string azienda = cmbAzienda.SelectedItem.ToString();
            int ore = elencoStudenti.OreAzienda(azienda);

            if (ore != 0)
            {
                MessageBox.Show($"Gli stagisti hanno effettuato {ore} in {azienda}", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Non è stata effettutata alcuna ora in" + azienda);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPosizione.Text == "")
                {
                    elencoStudenti.cancella();
                }
                else
                {
                    elencoStudenti.cancella(Convert.ToInt32(txtPosizione.Text));
                }
                MessageBox.Show("Cancellazione Effettuata!");
                elencoStudenti.VisualizzaDGV(dgvStudenti);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
