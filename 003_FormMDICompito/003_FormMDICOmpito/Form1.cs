using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_FormMDICOmpito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void apriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Size = new Size(210, 180);
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(0, 60);
            f2.Text = "Form 2 da Design";
            f2.Show();

            Form2 f2b = new Form2(10);
            f2b.MdiParent = this;
            f2b.Size = new Size(210, 180);
            f2b.StartPosition = FormStartPosition.Manual;
            f2b.Location = new Point(220, 60);
            f2b.Text = "Form 2 da Design con parametro";
            f2b.Show();

            toolStripStatusLbl.Text = "Premuto Apri Form 2";
        }

        private void btnPassaTxt_Click(object sender, EventArgs e)
        {
            Form2 f2b = new Form2(txtPassata);
            f2b.Text = "Form 2 passaggio di TextBox";
            f2b.Show();
        }

        private void apriFormModleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModale fm = new FormModale();
            fm.Text = "Form Modale";
            fm.MdiParent = this;
            fm.Size = new Size(210, 180);
            fm.StartPosition = FormStartPosition.Manual;
            fm.Location = new Point(320, 60);

            if (fm.ShowDialog() == DialogResult.OK)
            {
                txtNomeFM.Text = fm.nome;
                txtEtaFM.Text = fm.eta;
                MessageBox.Show("Premuto OK");
            }
            else
            {
                txtNomeFM.Text = "";
                txtEtaFM.Text = "";
                MessageBox.Show("Premuto Annulla");
            }

            toolStripStatusLbl.Text = "Premuto Apri Form Modale";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void apriForm2bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.MdiParent = this;
            f2b.Size = new Size(210, 180);
            f2b.StartPosition = FormStartPosition.Manual;
            f2b.Location = new Point(0, 320);
            f2b.Text = "Aperta form dinamica";
            f2b.Show();

            toolStripStatusLbl.Text = "Premuto Apri Form Dinamica";
        }

        private void txtPassata_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeFM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEtaFM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
