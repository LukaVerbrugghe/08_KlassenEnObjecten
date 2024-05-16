using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_KlassenEnObjecten.Oefening_1
{
    public partial class frmOef1 : Form
    {
        public frmOef1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            Zwembad zwembad = new Zwembad();

            if (txtBreedte.Text.Trim() != "")
            {
                zwembad.breedte = Convert.ToInt16(txtBreedte.Text);
            }
            if (txtDiepte.Text.Trim() != "")
            {
                zwembad.diepte = Convert.ToInt16(txtDiepte.Text);
            }
            if (txtLengte.Text.Trim() != "")
            {
                zwembad.lengte = Convert.ToInt16(txtLengte.Text);
            }
            if (txtRandafstand.Text.Trim() != "")
            {
                zwembad.randafstand = Convert.ToInt16(txtRandafstand.Text);
            }

            lblPoolinfo.Text = zwembad.showText();
        }
    }
}
