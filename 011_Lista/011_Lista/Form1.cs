using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_Lista
{
    public partial class Form1 : Form
    {
        public struct Libro
        {
            public int ID;
            public string Titolo;
            public string Autore;
        }

        List<Libro> miaLista = new List<Libro>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            Libro l;
            l.ID = Convert.ToInt32(txtId.Text);
            l.Titolo = txtTitolo.Text;
            l.Autore = txtAutore.Text;

            miaLista.Add(l);
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var elemento in miaLista)
            {
                s += elemento.Titolo + "\n";
            }
            MessageBox.Show(s);
        }

        private void btnAggiungiObj_Click(object sender, EventArgs e)
        {
            clsLibri.AggiungiLibro(txtAutore.Text, txtTitolo.Text, Convert.ToInt32(txtId.Text));
        }

        private void btnVisualizzaObj_Click_1(object sender, EventArgs e)
        {
            clsLibri.VisualizzaLibri();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string s = clsLibri.Find(txtDaCercare.Text);
            MessageBox.Show(s);
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            string s = clsLibri.FindAll(txtDaCercare.Text);
            MessageBox.Show(s);
        }

    }
}
