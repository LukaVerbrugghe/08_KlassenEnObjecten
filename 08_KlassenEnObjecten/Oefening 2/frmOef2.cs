using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_KlassenEnObjecten.Oefening_2
{
    public partial class frmOef2 : Form
    {
        public frmOef2()
        {
            InitializeComponent();

            //cmb op "Kies een klas" zetten
            cmbKlas.SelectedIndex = 0;
        }

        private void btnBevestig_Click(object sender, EventArgs e) {
            Leerlingen leerling = new Leerlingen();

            //check voornaam op lege invoer
            if (txtVoornaam.Text.Trim() != string.Empty)
            {
                //voornaam van de leerling uit txt halen
                leerling.voornaam = txtVoornaam.Text;            
            }
            else
            {
                //Error weergeven
                MessageBox.Show("GADVERDAMME DAS LEEG DIE VOORNAAM\nVUL IETS IN TIE TA TAMZAK DAT JE BENT");
            }

            //check achternaam op lege invoer
            if (txtFamilienaam.Text.Trim() != string.Empty)
            {
                //achternaam van de leerling uit de txt halen
                leerling.achternaam = txtFamilienaam.Text;
            }
            else {
                //error weergeven
                MessageBox.Show("HEB JIJ GEEN ACHTERNAAM OF ZO JIJ VIES VIES VENTJE");
            }

            //datetime testen op foutieve invoer
            DateTime dteGeboortedatum;
            if (DateTime.TryParse(txtGeboortenaam.Text, out dteGeboortedatum))
            {
                //geboortedatum aan object geven
                leerling.geboortedatum = dteGeboortedatum;
            }
            else {
                //error weergeven
                MessageBox.Show("IS EEN DATUM INGEVEN OOK AL TE MOEILIJK OFZO");
            }

            //klasinvoer checken
            if (cmbKlas.SelectedIndex != 0)
            {
                //klas meegeven in leerling
                leerling.klas = cmbKlas.SelectedItem.ToString();
            }
            else {
                //error weergeven
                MessageBox.Show("MA PROTTEBALLETJE TOCH, KLAS INGEVEN");
            }

            //volledige naam en leeftijd bepalen
            leerling.volledigeNaam = leerling.voornaam + " " + leerling.achternaam;
            leerling.leeftijd = DateTime.Today.Year - leerling.geboortedatum.Year;

            //kijken of de persoon al verjaard is
            if (leerling.geboortedatum > DateTime.Today.AddYears(-leerling.leeftijd)) {
                leerling.leeftijd--;
            }

            //leerling aan correcte lsb toevoegen
            //checken welke de leerling aan toebehoort
            switch (cmbKlas.SelectedIndex) {
                case 1:
                    lsbtBI.Items.Add(leerling.volledigeNaam + " (" + Convert.ToString(leerling.leeftijd) + " jaar)");
                    break;
                case 2:
                    lsb5BW.Items.Add(leerling.volledigeNaam + " (" + Convert.ToString(leerling.leeftijd) + " jaar)");
                    break;
                case 3:
                    lsb5AI.Items.Add(leerling.volledigeNaam + " (" + Convert.ToString(leerling.leeftijd) + " jaar)");
                    break;
            }

            //txt en cmb resetten
            txtFamilienaam.Text = string.Empty;
            txtGeboortenaam.Text = string.Empty;
            txtVoornaam.Text = string.Empty;
            cmbKlas.SelectedIndex = 0;
        }
    }
}
