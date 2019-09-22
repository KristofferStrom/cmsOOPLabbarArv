using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab4
{
    class Lab4
    {
        public void Run()
        {
            var annonser = new List<FordonsAnnons>();
            annonser.Add(new BilAnnons("Cool 240",250000,"Riktigt snygg med bra radio",
                1980,49000,"Blå",false,true));
            annonser.Add(new HusvagsAnnons("Hemmabygge", 30000, "Ej besiktad",
                2016, false, 4));
            annonser.Add(new MotorCykelAnnons("Kawasaki Super Special", 40000, "Snyggast",
                2014, 3000, 800,MotorCykelAnnons.DrivTyp.Kedja));

            foreach(var annons in annonser)
            {
                Console.WriteLine(annons.GetAnnonsText() + "\n");
            }
        }
    }
}
