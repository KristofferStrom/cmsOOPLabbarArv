using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab2
{
    class AlacarteMeny : Meny
    {
        public override List<MenyListing> GenerateMenu(List<Matratt> matrattLista)
        {
            var returnList = new List<MenyListing>();
            foreach (var matRatt in matrattLista)
            {
                if (matRatt.AlaCarte)
                    returnList.Add(new MenyListing(matRatt.Namn,
                                                    matRatt.MatrattsTyp,
                                                    matRatt.Pris * 1.7m));
            }
            return returnList;
        }
    }
}
