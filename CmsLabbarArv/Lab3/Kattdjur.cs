using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab3
{
    abstract class Kattdjur
    {
        protected readonly string artNamn;
        private readonly string color;

        public Kattdjur(string artNamn, string color)
        {
            this.artNamn = artNamn;
            this.color = color;
        }

        public abstract void MakeSound();
    }
}
