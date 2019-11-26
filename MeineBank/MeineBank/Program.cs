using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeineBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k1 = new Konto("Michael Zöhling", 10000000);

            Console.WriteLine(k1.Kontostand);
            k1.Abheben(5000000);
            Console.WriteLine(k1.Kontostand);

            k1.Einzahlen(2);
            Console.WriteLine(k1.Kontostand);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
