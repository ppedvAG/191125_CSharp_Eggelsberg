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

            // Fehler:
          

            try
            {
                k1.Abheben(-2000);
            }
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Falscher Wert im Parameter");
            //}
            catch (Exception ex) // Exception: ALLE Exceptions werden abgefangen
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
