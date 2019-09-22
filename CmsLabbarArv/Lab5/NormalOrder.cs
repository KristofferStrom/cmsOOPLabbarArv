using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab5
{
    class NormalOrder : Order
    {
        public NormalOrder(string number, DateTime date, Customer customer) 
            : base(number, date, customer)
        {
        }

        public override void Close()
        {
            
        }

        public override void Confirm()
        {
            
        }

        public void Dispatch() { }
        public void Receive() { }

    }
}
