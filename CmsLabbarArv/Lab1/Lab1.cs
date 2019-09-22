using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab1
{
    class Lab1
    {
        public void Run()
        {
            var t1 = new Triangle(12, 5);
            var t2 = new Triangle(12, 10);
            var t3 = new Rectangle(11, 11);

            Console.WriteLine( $"{t1.Area()} {t2.Area()} {t3.Area()}");
        }
    }
}
