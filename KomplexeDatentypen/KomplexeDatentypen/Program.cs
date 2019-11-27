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

            // Andwendungsfall:
            // Praktisch für Fälle wo die Anzahl der Elemente unbekannt ist

            // Mini-Übung:
            // Benutzer soll solange Zahlen in eine Liste einfügen, bis er
            // "q" eingibt

            // -> Aus allen Zahlen der Liste der Durchschnitt berechnet


            List<double> alleEingaben = new List<double>();
            string eingabe;



            do
            {

                Console.WriteLine("Bitte geben Sie eine Zahl oder 'q' fürs Beenden ein:");
                eingabe = Console.ReadLine();

                if (eingabe == "q")
                {
                    // ENDE
                    // Endberechnung: 
                    Console.WriteLine("Der Durchschnitt ist: " + alleEingaben.Average());
                }
                else
                {
                    // Zahl für die Liste
                    alleEingaben.Add(double.Parse(eingabe));
                }
            } while (eingabe != "q");




            Console.WriteLine("---ANFANG---");
            Console.ReadKey();
        }
    }
}
