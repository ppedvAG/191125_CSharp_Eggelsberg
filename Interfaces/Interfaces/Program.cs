using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Produkthändler max = new Produkthändler();
            max.Produkt = new Obst("Apfel",1,"Steiermark",70);

            Produkthändler moritz = new Produkthändler();
            moritz.Produkt = new Gemüse("Gurke", 1, false);

            Produkthändler julia = new Produkthändler();
            julia.Produkt = new Autoreifen(false, "Michelin", 200);

            

            Console.WriteLine("----------ENDE-----------");
            Console.ReadKey();
        }
    }
}
