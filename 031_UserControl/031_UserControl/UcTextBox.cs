using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _031_UserControl
{
    public partial class UcTextBox: UserControl
    {
        private bool numero = false;
        private string testo;
        private int cifreDecimali = 0;

        public UcTextBox()
        {
            InitializeComponent();
        }

        public bool Numero { get => numero; set => numero = value; }
        public string Testo { get => testo = txtTesto.Text; set => txtTesto.Text = testo = value; }
        public int CifreDecimali
        {
            get => cifreDecimali;
            set
            {
                cifreDecimali = value;
                reimpostaTesto();
            }
        }

        

        private void reimpostaTesto()
        {
            if (numero && Testo != "")
            {
                try
                {
                    // controllare che non ci siano + di una virgola
                    if (ContaVirgola(Testo) > 1)
                    {
                        throw new Exception("Ci sono troppa virgole");
                    }

                    // controllo dei decimali
                    double numero = Math.Round(Convert.ToDouble(Testo), CifreDecimali);
                    Testo = numero.ToString();

                    // Gestione degli 00 dopo la virgola in caso di numero intero

                }
                catch (Exception e)
                {
                    throw new Exception("Valore non valido");
                }
            }
        }

        private int ContaVirgola(string t)
        {
            int count = 0;

            for (int i = 0; i < t.Length; i++)
            {
                char c = Convert.ToChar(t.Substring(i, 1));
                if (c == ',')
                {
                    count++;
                }
            }

            return count;
        }

        public void Pulisci()
        {
            Testo = "";
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (Numero)
            {
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                    //throw new NotImplementedException();
                }
            }
        }

        private void OnLeave(object sender, EventArgs e)
        {
            reimpostaTesto();
        }
    }
}
