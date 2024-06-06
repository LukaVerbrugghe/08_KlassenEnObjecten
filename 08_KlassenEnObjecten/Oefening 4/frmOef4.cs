using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_KlassenEnObjecten.Oefening_4 {
    public partial class frmOef4 : Form {

        //nieuw object aanmaken van Dranken
        Dranken cola = new Dranken();
        Dranken water = new Dranken();

        public frmOef4() {
            InitializeComponent();


        }

        private void btnVulColaAan_Click(object sender, EventArgs e) {
            cola.drankAanvullen();
            lblAantalFlesjesCola.Text = "Aantal flesjes cola beschikbaar: " + cola.returnAantalFlesjesAlsString();
        }

        private void btnKoopCola_Click(object sender, EventArgs e) {
            cola.drankKopen();
            lblAantalFlesjesCola.Text = "Aantal flesjes cola beschikbaar: " + cola.returnAantalFlesjesAlsString();
        }

        private void btnVulWaterAan_Click(object sender, EventArgs e) {
            water.drankAanvullen();
            lblAantalFlesjesWater.Text = "Aantal flesjes water beschikbaar: " + water.returnAantalFlesjesAlsString();
        }

        private void btnKoopWater_Click(object sender, EventArgs e) {
            water.drankKopen();
            lblAantalFlesjesWater.Text = "Aantal flesjes water beschikbaar: " + water.returnAantalFlesjesAlsString();
        }
    }
}
