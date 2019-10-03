using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab2
{
    class Matratt
    {
        private readonly string namn;
        private readonly decimal pris;
        private readonly Typ typ;
        private readonly int antalKalorier;

        public decimal GetPrice() { return pris; }

        public decimal Pris { get { return pris; } }
        public Typ MatrattsTyp { get { return typ; }  }
        public string Namn { get { return namn; }  }

        public bool Lunch { get; set; }
        public bool AlaCarte { get; set; }

        public enum Typ{
            None,
            Vegetariskt,
            Vegansk,
            Kott
        }
        public Matratt(string namn, decimal pris, Typ typ, int antalKalorier)
        {
            this.namn = namn;
            this.pris = pris;
            this.typ = typ;
            this.antalKalorier = antalKalorier;
        }
    }
}
