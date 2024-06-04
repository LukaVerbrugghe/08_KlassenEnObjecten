using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KlassenEnObjecten.Oefening_3
{
    internal class Dieren
    {
        private int _gewicht;

        public Dieren()
        {
            _gewicht = 0;
        }

        public int gewicht {
            set { _gewicht = value; }
            get { return _gewicht; }
        }


        public Dieren(int gewicht)
        {
            _gewicht = gewicht;
        }
    }
}
