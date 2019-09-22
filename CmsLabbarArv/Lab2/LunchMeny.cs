using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab2
{
    class LunchMeny : Meny
    {
        public override List<MenyListing> GenerateMenu(List<Matratt> matrattLista)
        {
            var returnList = new List<MenyListing>();
            foreach(var matRatt in matrattLista)
            {
                if (matRatt.Lunch)
                    returnList.Add(new MenyListing( matRatt.Namn,
                                                    matRatt.MatrattsTyp,
                                                    matRatt.Pris));
            }
            return returnList;
        }
    }
}
