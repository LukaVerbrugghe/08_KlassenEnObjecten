using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _08_KlassenEnObjecten {
    internal class Voertuig {
        private int _aantalWielen;
        private bool _motor;
        private string _merk, _kleur;

        public Voertuig() {
            _kleur = "onbekend";
            _merk = "onbekend";
            _motor = true;
            _aantalWielen = 4;
        }

        public int aantalWielen {
            get { 
                return _aantalWielen;
            }
            set {
                _aantalWielen = value;
            }
        }

        public bool motor {
            get {
                return _motor;
            }
            set {
                _motor = value;
            }
        }

        public string merk {
            get {
                return _merk;
            }
            set {
                _merk = value;
            }
        }

        public string kleur {
            get {
                return _kleur;
            }
            set {
                _kleur = value;
            }
        }

        public virtual string Details() {
            if(_merk != "onbekend") {
                return "Uw voertuig van het merk " + merk + " heeft als kleur " + kleur + " en " + aantalWielen.ToString() + " wielen.";
            }
            else
            {
                return "Het merk van uw voertuig is " + merk + " en de kleur is " + kleur + " met " + aantalWielen.ToString() + " wielen.";
            }
        }

        public Voertuig(string merk, string kleur, int wielen) {
            _kleur = kleur;
            _merk = merk;
            _aantalWielen = wielen;
        }
    }
}
