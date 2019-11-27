using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiederholung_Tag2
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafik g1 = new Grafik("Rot");
            Kreis k1 = new Kreis("Gelb");
            k1.Radius = 5;
            Recheck r1 = new Recheck("Grün");
            r1.Höhe = 10;
            r1.Breite = 20;

            g1.Zeichnen();
            k1.Zeichnen();
            r1.Zeichnen();

            Console.WriteLine(k1.FlächeBerechnen() + "cm²");
            Console.WriteLine(r1.FlächeBerechnen() + "cm²");

            // Polymorphie:

            Console.WriteLine("-------------------Polymorphie------------------");
            Grafik g2 = new Kreis("Violett"); // Geht, da ein Kreis alles kann, was eine Grafik kann (+ bissi mehr)
            g2.Zeichnen();

            // Kreis k2 = new Grafik("Orange"); // Geht nicht, da die Grafik nicht alles kann, was ein Kreis kann

            IZeichenbar zeichnung = new Recheck("Grau");
            zeichnung.

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }


        public static int Addieren(int z1, int z2)
        {
            return z1 + z2;
        }

        /// <summary>
        /// Minusrechnung
        /// </summary>
        /// <param name="z1">Der erste Operand</param>
        /// <param name="z2">Der zweite Operand</param>
        /// <returns>Operand 1 minus Operand 2</returns>
        public static int Subtrahieren(int z1, int z2)
        {
            return z1 - z2;
        }


    }
}
