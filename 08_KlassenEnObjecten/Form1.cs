using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _08_KlassenEnObjecten {
    public partial class Form1 : Form {
        Voertuig auto3 = new Voertuig(merk: "Volkswagen", kleur: "knalrood", wielen: 4);
        


        public Form1() {
            InitializeComponent();
        }

        private void btnAuto1_Click(object sender, EventArgs e) {
            Voertuig auto1 = new Voertuig();
            if (txtKleur.Text.Trim() != "")
            {
                auto1.merk = txtMerk.Text;
            }
            if (txtMerk.Text.Trim() != "")
            {
                auto1.kleur = txtKleur.Text;
            }
            if (txtWielen.Text.Trim() != "")
            {
                auto1.aantalWielen = Convert.ToInt32(txtWielen.Text);
            }

            lblAuto1.Text = auto1.Details();
        }

        private void btnAuto2_Click(object sender, EventArgs e) {
            Voertuig auto2 = new Voertuig();
            
            string merk = Interaction.InputBox("Welk merk?");
            string kleur = Interaction.InputBox("Welke kleur?");
            string wielen = Interaction.InputBox("Hoeveel wielen?");

            if (merk.Trim() != "")
            {
                auto2.merk = merk;
            }
            if (kleur.Trim() != "")
            {
                auto2.kleur = kleur;
            }
            if (wielen.Trim() != "")
            {
                auto2.aantalWielen = Convert.ToInt32(wielen);          
            }

            lblAuto2.Text =  auto2.Details();
        }

        private void btnAuto3_Click(object sender, EventArgs e) {
            lblAuto3.Text = auto3.Details();
        }

        private void btnFiets_Click(object sender, EventArgs e)
        {
            Fiets fiets = new Fiets();

            if (txtKleur.Text.Trim() != "")
            {
                fiets.kleur = txtKleur.Text;
            }
            if (txtMerk.Text.Trim() != "")
            {
                fiets.merk = txtMerk.Text;
            }
            if (txtWielen.Text.Trim() != "")
            {
                fiets.aantalWielen = Convert.ToInt16(txtWielen.Text);
            }

            fiets.fietsplakaat = chbFietsplakaat.Checked;

            lblFiets.Text =  fiets.ShowText();
        }
    }
}
