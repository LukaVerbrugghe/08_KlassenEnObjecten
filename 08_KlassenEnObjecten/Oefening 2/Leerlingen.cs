using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KlassenEnObjecten.Oefening_2 {
    internal class Leerlingen : Persoonsgegevens {
        private string _klas;
        private string _volledigeNaam;

        public Leerlingen() {
            _klas = null;
            _volledigeNaam = null;
        }

        public string klas {
            get { return _klas; }
            set { _klas = value; }
        }

        public string volledigeNaam { 
            get {  return _volledigeNaam; } 
            set {  _volledigeNaam = value; } 
        }

        
    }
}
