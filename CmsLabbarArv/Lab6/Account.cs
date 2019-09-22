using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab6
{
    class Account
    {
        private decimal saldo = 0;
        public Account(string kontoNummer)
        {
            KontoNummer = kontoNummer;
        }

        public string KontoNummer { get; }

        public decimal GetSaldo()
        {
            return saldo;
        }
        public void Deposit(decimal amount)
        {
            saldo += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if(saldo >= amount)
            {
                saldo -= amount;
                return true;
            }
            return false;
        }

    }
}
