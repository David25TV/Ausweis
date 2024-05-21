using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ausweis
{
    internal class Personalausweis: Ausweis
    {
        public Fingerabdruck fingerabdruck { get; set; }

        public Personalausweis(Fingerabdruck fingerabdruck, Inhaber inhaber, int ausweisnummer, int ablaufdatum):base(inhaber, ausweisnummer, ablaufdatum)
        {
            this.fingerabdruck = fingerabdruck;
        }


    }
}
