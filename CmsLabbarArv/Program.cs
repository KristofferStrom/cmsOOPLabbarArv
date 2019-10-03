using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv
{
    class PuckoException : Exception
    {
        public PuckoException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Test()
        {
            Console.Write("Ange tal1:");
            int i;
            while (true)
            {
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ange ett tal pucko");
                }
            }


            Console.Write("Ange tal2:");
            int j;
            while (int.TryParse(Console.ReadLine(), out j) == false)
                Console.WriteLine("Ange ett tal pucko");
            Console.WriteLine("Nu delar vi");

            if (j == 0)
                throw new PuckoException("Du har matat in en 0:a");

            int r = i / j;
            Console.WriteLine(r);
        }

        static void Main(string[] args)
        {


            while (true)
            {
                try
                {
                    Test();
                    break;
                }
                catch( PuckoException qqq)
                {
                    Console.WriteLine("bla bla");
                }
                catch (FileNotFoundException f)
                {
                    //WriteToFile(e);
                    Console.WriteLine("Kolla så hårddisken inte brinner för vi kunde inte spare ");
                }
                catch (DivideByZeroException gg)
                {
                    //WriteToFile(e);
                    Console.WriteLine("Skriv inte in 0");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //WriteToFile(e);


                }
            }

            var l = new Lab1.Lab1();
            l.Run();
        }
    }
}
