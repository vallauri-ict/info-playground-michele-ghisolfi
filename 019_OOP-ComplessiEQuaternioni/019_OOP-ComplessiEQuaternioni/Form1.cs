using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_OOP_ComplessiEQuaternioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComplesso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReale.Text != "" && txtImmaginario.Text != "")
                {
                    Complesso complesso = new Complesso(Convert.ToDouble(txtImmaginario.Text));
                    MessageBox.Show(complesso.Modulo().ToString());
                }
                else if (txtReale.Text != "" && txtImmaginario.Text != "")
                {
                    Complesso complesso = new Complesso(Convert.ToDouble(txtReale.Text), Convert.ToDouble(txtImmaginario.Text));
                    MessageBox.Show(complesso.Modulo().ToString());
                }
                else if (txtReale.Text == "" && txtImmaginario.Text == "")
                {
                    Complesso complesso = new Complesso();
                    MessageBox.Show(complesso.Modulo().ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mancanti Immaginario");
            }
        }

        private void btnQuaternione_Click(object sender, EventArgs e)
        {
            Quaternione quaternione = new Quaternione();
            MessageBox.Show(quaternione.Modulo().ToString());
        }
    }
}
