using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab2
{
    class Lab2
    {
        public void Run()
        {
            var lunchMeny = new LunchMeny();
            var alacarteMeny = new AlacarteMeny();

            var matRatter = new List<Matratt>();
            matRatter.Add(new Matratt("Pannkaka",75,Matratt.Typ.Vegetariskt,100) );


            var mat = new Matratt("Hamburgare", 85, Matratt.Typ.Kott, 150);
            decimal q1 = mat.GetPrice();
            decimal d = mat.Pris;

            matRatter.Add(new Matratt("Hamburgare", 85, Matratt.Typ.Kott, 150));
            matRatter.Add(new Matratt("Spagetti Carbonara", 88, Matratt.Typ.Kott, 200));

            matRatter[0].Lunch = true;
            matRatter[1].Lunch = true;
            matRatter[1].AlaCarte = true;
            matRatter[2].AlaCarte = true;

            Console.WriteLine("LUNCH");
            foreach(var l in lunchMeny.GenerateMenu(matRatter))
            {
                Console.WriteLine($"{l.GetListingAsString()}");
            }

            Console.WriteLine("ALACARTE");
            foreach (var l in alacarteMeny.GenerateMenu(matRatter))
            {
                Console.WriteLine($"{l.GetListingAsString()}");
            }

            
        }
    }
}
