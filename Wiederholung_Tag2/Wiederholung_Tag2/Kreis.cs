using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiederholung_Tag2
{
    class Kreis : Grafik // Vererbung
    {
        public Kreis(string Farbe) : base(Farbe) // Gibt die Farbe an den Original-Konstruktor weiter
        {
        }


        public int Radius { get; set; }

        public override void Zeichnen()
        {
            //base.Zeichnen(); // Original aufgerufen
            Console.WriteLine("Ein Kreis mit der Farbe " + Farbe + " und dem Radius " + Radius + " wird gezeichnet");
        }



        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


    }
}
