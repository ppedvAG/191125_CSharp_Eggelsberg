using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiederholung_Tag3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto audi = new Auto("Michi Z",1234);

            Console.WriteLine(audi.Kilometerstand);
            audi.Beschleunigen();
            audi.Beschleunigen();
            audi.Beschleunigen();

            audi.Fahren(3);

            Console.WriteLine(audi.Kilometerstand);


            LKW man = new LKW();
            man.GefahrengutTransport = false;
            man.Höhe = 2.5;
            man.MaximalesLadegewicht = 2000;

            man.Beschleunigen();
            man.Beschleunigen();
            man.Beschleunigen();

            man.Fahren(10);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
