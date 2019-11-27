using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KomplexeDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays:
            int[] zahlen = new int[5];
            zahlen[0] = 12;
            zahlen[1] = 9;
            // ....

            // List<T> (T ist ein Platzhalter)

            List<int> zahlenListe = new List<int>();
            List<string> stringListe = new List<string>();
            // ...

            zahlenListe.Add(12);
            zahlenListe.Add(9);
            zahlenListe.Add(7);
            zahlenListe.Add(3);

            Console.WriteLine(zahlenListe[0]);
            Console.WriteLine(zahlenListe[1]);
            Console.WriteLine(zahlenListe[2]);

            // Praktische Features:

            // zahlenListe.Remove(7);
            // zahlenListe.Count; // anstelle von Length !!!
            // zahlenListe.Clear(); // Alles löschen
            // zahlenListe.Sort(); // Sortieren der Liste

            Console.WriteLine("---ANFANG---");
            Console.ReadKey();
        }
    }
}
