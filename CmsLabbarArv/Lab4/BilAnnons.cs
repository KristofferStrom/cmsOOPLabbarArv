using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab4
{
    class BilAnnons : FordonsAnnons
    {
        private readonly string color;
        private readonly bool summerWheels;
        private readonly bool winterWheels;

        public BilAnnons(string rubrik, decimal pris, 
            string beskrivning, int year, int antalMil,
            string color, bool summerWheels, bool winterWheels)
            :base(rubrik, pris, beskrivning, year, antalMil)
        {
            this.color = color;
            this.summerWheels = summerWheels;
            this.winterWheels = winterWheels;
        }

        public override string GetAnnonsText()
        {
            string s =  $@"BIL - {rubrik} {color} {pris} 
{beskrivning}
Årsmodell: {year} Antal mil: {antalMil}";
            if (summerWheels) s += "\nSommardäck ingår";
            if (winterWheels) s += "\nVinterdäck ingår";
            return s;

        }
    }
}
