using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_FormMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brnApri1_Click(object sender, EventArgs e)
        {
            Figlia1 f = new Figlia1();
            f.Text = "Filgia 1";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(0, 40);
            f.Show();
        }

        private void btnApri2_Click(object sender, EventArgs e)
        {
            Figlia2 f = new Figlia2();
            f.Text = "Filgia 2";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(215, 40);
            f.Show();
        }

        private void btnFAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte " + this.MdiChildren.Length + " Finestre");
            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra " + f.Text + " Aperta");
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalEsci f = new ModalEsci();
            f.Text = "Uscire";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Close();
            }
        }

        
        private void apri2ToolStripItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto Apri 2";
        }

        private void apri1ToolStripItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLbl.Text = "Premuto Apri 1";
        }
    }
}
