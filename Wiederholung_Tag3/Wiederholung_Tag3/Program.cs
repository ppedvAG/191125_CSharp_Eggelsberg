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

            // Teil 2:


            // Ziel: Liste erstellen, in der alle PrivatFahrzeuge gespeichert werden können

            // PrivatFahrzeug[]
            // List<PrivatFahrzeug>

            // Liste für alle Fahrzeuge (Auto, Schiff, Flugzeug)

            List<Fahrzeug> meineGarage = new List<Fahrzeug>();
            meineGarage.Add(new Schiff());
            meineGarage.Add(new Flugzeug());

            List<ITransportfahrzeug> meinSpeditionsUnternehmen = new List<ITransportfahrzeug>();
            meinSpeditionsUnternehmen.Add(new LKW());
            meinSpeditionsUnternehmen.Add(new Schiff());

            // meinSpeditionsUnternehmen[0];
            // meineGarage[0].

            // if(meineGarage[0].Equals(meinSpeditionsUnternehmen[0])) // Wertevergleich
            if(meineGarage[0] is Schiff)
            {
                // mach xyz mit dem Schiff
            }


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
