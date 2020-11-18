using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _012_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Value;
        Dictionary<int, string> articoli = new Dictionary<int, string>();

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Value = txtValue.Text;
            articoli.Add(Convert.ToInt32(txtKey.Text), Value);
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            lblNElementi.Text = "N° Elementi: " + articoli.Count;
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
           lblArticoloCercato.Text = "Articolo Cercato: " + articoli[Convert.ToInt32(txtKey.Text)];
        }
    }
}
