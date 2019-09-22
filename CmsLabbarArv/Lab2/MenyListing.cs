using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab2
{
    class MenyListing
    {
        private readonly string namn;
        private readonly Matratt.Typ typ;
        private readonly decimal pris;

        public MenyListing(string namn, Matratt.Typ typ, decimal pris)
        {
            this.namn = namn;
            this.typ = typ;
            this.pris = pris;
        }

        public string GetListingAsString()
        {
            return $"{namn} {pris}";
        }
    }
}
