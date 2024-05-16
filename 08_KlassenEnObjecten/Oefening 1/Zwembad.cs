using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KlassenEnObjecten.Oefening_1
{
    internal class Zwembad
    {
        private double _diepte;
        private double _lengte;
        private double _breedte;
        private double _randafstand;

        public Zwembad() { 
            _diepte = 0;
            _lengte = 0;
            _breedte = 0;
            _randafstand = 0;
        }

        public double diepte
        {
            get { return _diepte; }
            set { _diepte = value; }
        }

        public double lengte
        {
            get { return _lengte; }
            set { _lengte = value; }
        }

        public double breedte
        {
            get { return _breedte; }
            set { _breedte = value; }
        }

        public double randafstand{
            get { return _randafstand; }
            set { _randafstand = value; }
        }

        public virtual string showText()
        {
            return "Diepte: " + diepte + " meter\nLengte: " + lengte + " meter\nBreedte: " + breedte + " meter\nAfstand tot rand: " + randafstand + " meter\n\n\nJe hebt " + Convert.ToString((breedte * (diepte - randafstand) * lengte) * 1000) + " liter water nodig.\nHet volume is " + Convert.ToString(((breedte * (diepte - randafstand) * lengte) * 1000) / 1000) + " kubieke meter.";
        }

        public Zwembad(double diepte, double lengte, double breedte, double randafstand)
        {
            _diepte = diepte;
            _lengte = lengte;
            _breedte = breedte;
            _randafstand = randafstand;
        }
    }
}
