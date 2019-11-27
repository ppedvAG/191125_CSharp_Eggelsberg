using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiederholung_Tag2
{
    class Kreis : Grafik, IZeichenbar // Vererbung
    {
        public Kreis(string Farbe) : base(Farbe) // Gibt die Farbe an den Original-Konstruktor weiter
        {
        }


        public int Radius { get; set; }

        public double FlächeBerechnen()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Zeichnen()
        {
            //base.Zeichnen(); // Original aufgerufen
            Console.WriteLine("Ein Kreis mit der Farbe " + Farbe + " und dem Radius " + Radius + " wird gezeichnet");
        }
    }
}
