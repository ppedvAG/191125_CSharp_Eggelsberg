using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class LebensmittelHändler
    {
        public int Anzahl { get; set; }
        public Lebensmittel Produkt { get; set; }
    }

    class Lebensmittel
    {
        public string Name { get; set; }
        public decimal Preis { get; set; }
    }

    class Obst : Lebensmittel
    {
        public Obst(string name, decimal preis, string herkunft, int kcal)
        {
            Name = name;
            Preis = preis;
            Herkunft = herkunft;
            Kcal = kcal;
        }
        public string Herkunft { get; set; }
        public int Kcal { get; set; }
    }

    class Gemüse : Lebensmittel
    {
        public Gemüse(string name, decimal preis, bool bitter)
        {
            Name = name;
            Preis = preis;
            Bitter = bitter;
        }
        public bool Bitter { get; set; }
    }
}
