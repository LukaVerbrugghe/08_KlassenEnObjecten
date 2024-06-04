using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KlassenEnObjecten.Oefening_3
{
    internal class Slang : Dieren
    {
        public virtual string TextTonen()
        {
            return "SSSSSSSST, ik weegs " + gewicht.ToString();
        }
    }
}
