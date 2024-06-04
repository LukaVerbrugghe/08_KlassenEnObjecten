using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KlassenEnObjecten.Oefening_3
{
    internal class Koe : Dieren
    {
        public virtual string TextTonen()
        {
            return "Koetjes zegt boe. Ik weeg " + gewicht.ToString();
        }
    }
}
