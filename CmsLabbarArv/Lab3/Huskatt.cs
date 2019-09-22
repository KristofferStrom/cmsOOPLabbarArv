using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab3
{
    class Huskatt : Kattdjur
    {
        public Huskatt(string color)
            :base("Huskatt",color)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"jag är en {artNamn} och säger Mjau");
        }
    }
}
