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
            LebensmittelHändler max = new LebensmittelHändler();
            max.Produkt = new Obst("Apfel",1,"Steiermark",70);

            LebensmittelHändler moritz = new LebensmittelHändler();
            moritz.Produkt = new Gemüse("Gurke", 1, false);

            LebensmittelHändler julia = new LebensmittelHändler();
            julia.Produkt = new Obst("Orange", 3, "Spanien", 90);

            Console.WriteLine("----------ENDE-----------");
            Console.ReadKey();
        }
    }
}
