using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KlassenEnObjecten.Oefening_3
{
    internal class Varken : Dieren
    {
        public virtual string TextTonen()
        {
            return "Knor, knor, knor ik weeg " + gewicht.ToString();
        }
    }
}
