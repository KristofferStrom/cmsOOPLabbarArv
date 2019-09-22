using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab2
{
    abstract class Meny
    {
        public abstract List<MenyListing> GenerateMenu(List<Matratt> matrattLista);
    }
}
