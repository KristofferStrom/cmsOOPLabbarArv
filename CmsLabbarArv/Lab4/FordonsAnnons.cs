using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab4
{
    class FordonsAnnons
    {
        protected readonly string rubrik;
        protected readonly decimal pris;
        protected readonly string beskrivning;
        protected readonly int year;
        protected readonly int antalMil;

        public FordonsAnnons(string rubrik, decimal pris, string beskrivning, int year, int antalMil )
        {
            this.rubrik = rubrik;
            this.pris = pris;
            this.beskrivning = beskrivning;
            this.year = year;
            this.antalMil = antalMil;
        }

        public virtual string GetAnnonsText()
        {
            return "";
        }
    }
}
