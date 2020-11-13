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
        List<Books> listaLibri = new List<Books>();

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
            Books b = new Books();
            b.autore = txtAutore.Text;
            b.id = Convert.ToInt32(txtId.Text);
            b.titolo = txtTitolo.Text;

            listaLibri.Add(b);
        }

        private void btnVisualizzaObj_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (Books item in listaLibri)
            {
                s += item.titolo + "\n";
            }
            MessageBox.Show(s);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
