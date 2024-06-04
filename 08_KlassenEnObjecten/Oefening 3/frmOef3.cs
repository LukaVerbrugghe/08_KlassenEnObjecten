using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_KlassenEnObjecten.Oefening_3
{
    public partial class frmOef3 : Form
    {
        public frmOef3()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            
            switch (txtDier.Text) {
                case "Slang":
                    Slang slang = new Slang();
                    slang.gewicht = Convert.ToInt16(txtGewicht.Text);
                    lblBoodschap.Text = slang.TextTonen();
                    break;
                case "Koe":
                    Koe koe = new Koe();
                    koe.gewicht = Convert.ToInt16(txtGewicht.Text);
                    lblBoodschap.Text = koe.TextTonen();
                    break;
                case "Varken":
                    Varken varken = new Varken();
                    varken.gewicht = Convert.ToInt16( txtGewicht.Text);
                    lblBoodschap.Text = varken.TextTonen();
                    break;
                default:
                    lblBoodschap.Text = "Geef iets deftigs in patzak!";
                    break;
            }
        }
    }
}
