using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab6
{
    class User
    {
        private string userName;
        private string password;
        private List<Account> accounts = new List<Account>();

        public Account GetAccount(string kontoNummer)
        {
            foreach (var acc in accounts)
                if (acc.KontoNummer == kontoNummer) return acc;
            return null;
        }

        public void AddAccount(string kontoNummer)
        {
           accounts.Add(new Account(kontoNummer));
        }

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

    }
}
