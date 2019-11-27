using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiederholung_Tag2
{
    class Grafik
    {
        /// <summary>
        /// Der Konstruktor für die Klasse "Grafik". Hier werden Standardwerte gesetzt
        /// </summary>
        /// <param name="Farbe">Die Farbe der Grafik</param>
        public Grafik(string Farbe)
        {
            this.Farbe = Farbe;
        }

        /* Mehrzeiliges Kommentar
         * 
         */

        public int X { get; set; }
        public int Y { get; set; }
        public string Farbe { get; set; }

        // Jeder, der von Grafik erbt, kann sein eigenes "Zeichnen" mit "override" machen
        public virtual void Zeichnen()
        {
            Console.WriteLine("Eine Grafik mit der Farbe " + Farbe + " wird gezeichnet");
        }

    }
}
