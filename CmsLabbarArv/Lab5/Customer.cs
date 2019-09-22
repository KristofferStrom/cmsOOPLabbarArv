using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab5
{
    class Customer
    {
        private readonly string name;
        private readonly string location;

        public Customer(string name, string location)
        {
            this.name = name;
            this.location = location;
        }
    }
}
