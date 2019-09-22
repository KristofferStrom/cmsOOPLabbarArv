using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab3
{
    class Lab3
    {
        public void Run()
        {
            var lista = new List<Kattdjur>();
            lista.Add(new Tiger("White"));
            lista.Add(new Tiger("Yellow"));
            lista.Add(new Huskatt("Yellow"));
            lista.Add(new Huskatt("Black"));
            foreach (var kattDjur in lista)
                kattDjur.MakeSound();
        }
    }
}
