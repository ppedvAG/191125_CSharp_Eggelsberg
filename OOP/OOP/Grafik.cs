using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    // Führt dazu, dass Grafik zu einer "Vorlagenklasse" wird und nur für die Vererbung da ist
    abstract class Grafik
    {
        public string Farbe { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        // Abstrakte Methode: Angabe, was jede Klasse noch selber einbauen MUSS
        public abstract void Zeichnen(); // KEINE LOGIK !!!

        // Normale Methode
        public void Machwas()
        {
            Console.WriteLine("lalalal");
        }
    }

    class Kreis : Grafik // QuickActions -> Implement Abstract Class
    {
        public int Radius { get; set; }

        public override void Zeichnen()
        {
            Console.WriteLine("Ein Kreis wird gezeichnet");
        }
    }

    class Rechteck : Grafik
    {
        public int Höhe { get; set; }
        public int Breite { get; set; }

        public override void Zeichnen()
        {
            Console.WriteLine("Ein Rechteck wird gezeichnet");
        }
    }
}
