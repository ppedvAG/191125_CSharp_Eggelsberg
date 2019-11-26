using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeineBank
{
    class Konto
    {
        // Konstruktor
        public Konto(string inhaber, decimal kontostand)
        {
            Inhaber = inhaber;
            Kontostand = kontostand;
        }

        // Autoproperty
        public string Inhaber { get; set; } // Autoproperty, da keine Validierung notwending ist

        // Feld
        private decimal kontostand;

        // Property
        public decimal Kontostand
        {
            get { return kontostand; }
            private set 
            {
                if(value > 0)
                    kontostand = value; 
                else
                    Console.WriteLine("Kontostand darf nicht kleiner als 0 werden !!!");
            }
        }

        // Methode
        public void Einzahlen(decimal betrag)
        {
            if(betrag > 0)
                Kontostand += betrag;
                // Kontostand = Kontostand + betrag;
            else
                Console.WriteLine("Sie dürfen keinen negativen Betrag einzahlen !!!");
        }

        // Methode
        public void Abheben (decimal betrag)
        {
            if (betrag > 0)
                Kontostand -= betrag;
            else
                Console.WriteLine("Sie dürfen keinen negativen Betrag abheben");
        }

    }
}
