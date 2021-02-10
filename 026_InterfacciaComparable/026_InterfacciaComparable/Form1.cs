using System;
using System.Windows.Forms;

namespace _026_InterfacciaComparable
{
    public partial class Form1 : Form
    {
        Persona[] vect = { new Persona("Luca", "Bonelli", "Fossano"),
                           new Persona("Antonio", "Ariaudo", "Alba"),
                           new Persona("Samuele","Stefirca", "Savigliano") };

        public Form1()
        {
            InitializeComponent();
            ShowPersona();
        }

        public void ShowPersona()
        {
            InitializeComponent();
            string s = "";
            foreach (var item in vect)
            {
                s += item.ToString() + "\n";
            }
            MessageBox.Show(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            Array.Sort(vect);
            ShowPersona();
        }
    }
}
