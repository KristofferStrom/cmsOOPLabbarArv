using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab5
{
    abstract class Order
    {
        private readonly string number;
        private readonly DateTime date;
        private readonly Customer customer;

        public Order(string number, DateTime date, Customer customer)
        {
            this.number = number;
            this.date = date;
            this.customer = customer;
        }

        public abstract void Confirm();
        public abstract void Close();
    }
}
