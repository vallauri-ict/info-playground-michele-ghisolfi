using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_MetodoFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaQuadrato_Click(object sender, EventArgs e)
        {
            Quadrato q;

            if (txtInserisciLAtoQuadrato.Text != "")
            {
                try
                {
                    q = Quadrato.CreaQuadrato(Convert.ToInt32(txtInserisciLAtoQuadrato.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Compilare il campo");
            }
        }
    }
}
