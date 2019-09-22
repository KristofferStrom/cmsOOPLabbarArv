using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab5
{
    class Lab5
    {
        public void Run()
        {
            var customer = new Customer("Stefan", "Nacka");
            var specOrder = new SpecialOrder("1234", DateTime.Now,customer);
        }
    }
}
