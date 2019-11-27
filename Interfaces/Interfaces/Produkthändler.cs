using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    class Produkthändler
    {
        public int Anzahl { get; set; }
        public IProdukt Produkt { get; set; }
    }

    class Lebensmittel : IProdukt
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

    // Trick für das Erstellen von Interfaces:
    // QuickActions auf Klassenname -> Extract Interface
    class Autoreifen : IProdukt
    {
        public Autoreifen(bool sommerreifen, string name, decimal preis)
        {
            Sommerreifen = sommerreifen;
            Name = name;
            Preis = preis;
        }

        public bool Sommerreifen { get; set; }
        public string Hersteller { get; set; }

        public string Name { get; set; }
        public decimal Preis { get; set; }
    }
}
