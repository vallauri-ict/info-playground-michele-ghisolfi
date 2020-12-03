using System;
using System.Windows.Forms;

namespace _017_ParametriDiTipoOggetto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mannaro x = new Mannaro();
            Mostro y;
            y = Clona_V(x);
            x.Rivela();
            y.Rivela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mostro x = new Mannaro();
            Mostro y;
            y = Clona_R(ref x);
            x.Rivela();
            y.Rivela();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mostro x = new Mostro();
            Mostro y;
            y = Clona_O(out x);
            x.Rivela();
            y.Rivela();
        }

        public Mostro Clona_V(Mostro p)
        {
            p = new Mostro("Valuex");
            p.nome = "Cambia";
            return p;
        }

        public Mostro Clona_R(ref Mostro p)
        {
            p = new Mostro("Referex");
            p.nome = "Cambia";
            return p;
        }

        public Mostro Clona_O(out Mostro p)
        {
            p = new Mostro("Resulx");
            p.nome = "Cambia";
            return p;
        }
    }
}
