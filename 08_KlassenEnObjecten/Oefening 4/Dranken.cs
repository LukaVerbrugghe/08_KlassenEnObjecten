using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_KlassenEnObjecten.Oefening_4 {
    internal class Dranken {
        private int _aantal;
        private int _limiet;

        public Dranken() {
            _aantal = 0;
            _limiet = 50;
        }

        public int Aantal {
            get { return _aantal; } 
            set {  _aantal = value; }
        }

        public int Limiet {
            get { return _limiet; }
            set { _limiet = value; }
        }

        public virtual void drankAanvullen() {
            //checken of de drank wel aangevuld kan worden
            if (_aantal == _limiet)
            {
                //automaat zit vol
                //error weergeven
                MessageBox.Show("De automaat is vol.", "Error: Automaat vol", MessageBoxButtons.OK);
            }
            else {
                //drankje aanvullen
                _aantal++;
            }
        }

        public virtual void drankKopen() {
            //checken of er nog dranken beschikbaar zijn
            if (_aantal == 0)
            {
                //automaat is leeg
                //error weergeven
                MessageBox.Show("De automaat is leeg. U krijgt geen terugbetaling.", "Error: Automaat leeg", MessageBoxButtons.OK);
            }
            else
            {
                //drankje kopen
                _aantal--;
            }
        }

        public virtual string returnAantalFlesjesAlsString() {
            return Convert.ToString(_aantal);
        }



        public Dranken(int aantal, int limiet) {
            _aantal = aantal;
            _limiet = limiet;
        }

    }
}
