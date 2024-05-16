using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KlassenEnObjecten {
    internal class Fiets : Voertuig{
        private bool _fietsplakaat;

        public Fiets() {
            _fietsplakaat = false;
        }

        public bool fietsplakaat
        {
            get
            {
                return _fietsplakaat;
            }
            set
            {
                _fietsplakaat = value;
            }
        }

        public virtual string ShowText()
        {
            if (_fietsplakaat)
            {
                return "Uw fiet van " + merk + " met kleur " + kleur + " heeft een fietsplakaat.";
            }
            else
            {
                return "Uw fiet van " + merk + " met kleur " + kleur + " heeft geen fietsplakaat.";
            }
        }

        public Fiets(bool fietsplakaat)
        {
            _fietsplakaat = fietsplakaat;
        }
    }
}
