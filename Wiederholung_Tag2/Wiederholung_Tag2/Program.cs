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
            Recheck r1 = new Recheck("Grün");

            g1.Zeichnen();
            k1.Zeichnen();
            r1.Zeichnen();

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
