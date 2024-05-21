using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ausweis
{
    internal class Ausweis
    {


        public Inhaber inhaber { get; set; }

        public int Ausweisnummer { get; set; }

        public int Ablaufdatum { get; set; }

        public Ausweis(Inhaber inhaber, int ausweisnummer, int ablaufdatum)
        {
            this.inhaber = inhaber;
            Ausweisnummer = ausweisnummer;
            Ablaufdatum = ablaufdatum;
        }
    }
}
