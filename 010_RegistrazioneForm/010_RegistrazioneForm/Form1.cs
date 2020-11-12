using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _010_RegistrazioneForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            bool valido = true;

            // COGNOME
            Regex regCognome = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (!txtMatch(txtCognome, "Cognome", regCognome))
            {
                valido = false;
            }

            // Nome
            Regex regNome = new Regex(@"^[A-Z]{1}[a-z]+$");
            if (!txtMatch(txtNome, "Nome", regNome))
            {
                valido = false;
            }

            // Indirizzo
            Regex regIndirizzo = new Regex(@"^[A-Za-z\s]+\s\d+$");
            if (!txtMatch(txtIndirizzo, "Indirizzo", regIndirizzo))
            {
                valido = false;
            }

            // Città
            Regex regCitta = new Regex(@"[a-zA-Z]+(?:[\ ][a-zA-Z]+)*$");
            if (!txtMatch(txtCitta, "Città", regCitta))
            {
                valido = false;
            }

            // Cap
            Regex regCap = new Regex(@"^\d{3,5}$");
            if (!txtMatch(txtCap, "Cap", regCap))
            {
                valido = false;
            }

            // MAIL
            Regex regMail = new Regex(@"^[a-z]+.+[@][a-z]+.+[a-z]{2,5}$");
            if (!txtMatch(txtMail, "Mail", regMail))
            {
                valido = false;
            }

            // Cod. Fiscale
            Regex regCodFiscale = new Regex(@"^[A-Z]{6}\d{2}[A-Z]\d{2}[A-Z]\d{3}[A-Z]$");
            if (!txtMatch(txtCodFiscale, "Codice Fiscale", regCodFiscale))
            {
                valido = false;
            }

            // User
            Regex regUser = new Regex(@".+");
            if (!txtMatch(txtUser, "User", regUser))
            {
                valido = false;
            }

            // Pwd
            Regex regPwd = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}$");
            if (!txtMatch(txtPwd, "Password", regPwd))
            {
                valido = false;
            }


            if (valido)
            {
                Utenti u = Utenti.GetInstace(); 
                u.aggiungiUtente(txtNome.Text, txtCognome.Text, txtIndirizzo.Text, txtCitta.Text, 
                    txtCap.Text, txtMail.Text, txtCodFiscale.Text, txtUser.Text, txtPwd.Text);
            }
        }

        /// <summary>
        /// Controllo textBox non vuoto e match regex
        /// </summary>
        /// <param name="txt"> TextBox da validare </param>
        /// <param name="name"> Testo eventuali errori </param>
        /// <param name="reg"> Regex </param>
        /// <returns></returns>
        private bool txtMatch(TextBox txt, String name, Regex reg)
        {
            bool ok = true;
            if (txt.Text == "")
            {
                ok = false;
                MessageBox.Show(name + " non inserito");
                txt.BackColor = Color.Salmon;
            }
            else if (!reg.IsMatch(txt.Text))
            {
                MessageBox.Show(name + " inserito non valido");
                ok = false;
                txt.BackColor = Color.Salmon;
            }
            else
            {
                txt.BackColor = Color.LightGreen;
            }

            return ok;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
