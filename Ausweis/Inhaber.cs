using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ausweis
{
    internal class Inhaber
    {
    public string Vorname { get; set; }
    
    public string Nachname { get; set; }

    public string gemeldeter_Wohnort { get; set; }

    public string Augenfarbe { get; set; }

    public int Körpergröße { get; set; }

    public int Geburtsdatum { get; set; }

        public Inhaber(string vorname, string nachname, string gemeldeter_Wohnort, string augenfarbe, int körpergröße, int geburtsdatum)
        {
            Vorname = vorname;
            Nachname = nachname;
            this.gemeldeter_Wohnort = gemeldeter_Wohnort;
            Augenfarbe = augenfarbe;
            Körpergröße = körpergröße;
            Geburtsdatum = geburtsdatum;
        }
    }
}
