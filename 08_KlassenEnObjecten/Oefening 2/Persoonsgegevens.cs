using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KlassenEnObjecten.Oefening_2 {
    internal class Persoonsgegevens {
        //de properties van de class
        private string _voornaam;
        private string _achternaam;
        private DateTime _geboortedatum;
        private int _leeftijd;

        public Persoonsgegevens() {
            _voornaam = null;
            _achternaam = null;
            _geboortedatum = DateTime.MinValue;
            _leeftijd = 0;
        }

        public string voornaam {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string achternaam {
            get { return _achternaam; }
            set { _achternaam = value; }
        }

        public DateTime geboortedatum {
            get { return _geboortedatum; }
            set { _geboortedatum = value;}
        }

        public int leeftijd {
            get { return _leeftijd;}
            set { _leeftijd = value;}
        }

    }
}
