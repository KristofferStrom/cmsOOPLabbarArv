using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab4
{
    class HusvagsAnnons : FordonsAnnons
    {
        private readonly bool harDusch;
        private readonly int antalBaddar;

        public HusvagsAnnons(string rubrik, decimal pris, 
            string beskrivning, int year,
            bool harDusch, int antalBaddar )
            :base(rubrik, pris, beskrivning, year, 0)
        {
            this.harDusch = harDusch;
            this.antalBaddar = antalBaddar;
        }

        public override string GetAnnonsText()
        {
            string s =  $@"HUSVAGN - {rubrik} {pris} 
{beskrivning}
Årsmodell: {year}  Antal bäddar:{antalBaddar}";
            if (harDusch) s += "\nDusch";
            
            return s;

        }
    }
}
