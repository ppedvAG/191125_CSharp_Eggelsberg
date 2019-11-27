using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiederholung_Tag2
{
    class Recheck : Grafik , IZeichenbar
    {
        public Recheck(string Farbe) : base(Farbe)
        {
        }

        public int Höhe { get; set; }
        public int Breite { get; set; }

        public double FlächeBerechnen()
        {
            return Höhe * Breite;
        }

        public override void Zeichnen()
        {
            Console.WriteLine("Ein Rechteck mit der Farbe " + Farbe + ", der Höhe " + Höhe + " und der Breite " + Breite + " wird gezeichnet");
        }
    }
}
