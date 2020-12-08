using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Boekhouding
{
    public class Factuur
    {
        public string UniekNr { get; set; }
        public DateTime FactuurDatum { get; set; }
        public double BedragExclBTW { get; set; }
        public int BTWTarief { get; set; }
        public string Status { get; set; }
        public double BedragInclBTW { get { return BedragExclBTW + BTWBedrag; } }
        public string Omschrijving { get; set; }
        public DateTime BetaalDatum { get; set; }
        public double BTWBedrag { get { return BedragExclBTW * BTWTarief / 100.0; }  }
        public DateTime VervalDatum { get; set; }
        public Contact Contact { get; set; }
    }
}
