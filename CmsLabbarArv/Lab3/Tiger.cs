using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab3
{
    class Tiger : Kattdjur
    {
        public Tiger(string color)
            : base("Tiger", color)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine($"jag är en {artNamn} och säger Grrr");
        }
    }
}
