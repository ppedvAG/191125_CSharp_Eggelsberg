using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kommentar : Keine Befehle, sondern Beschreibung
            Console.WriteLine("Hallo Welt");

            // Ganze Zahlen
            int meineZahl = 12;
            int a = 5, b = 10, c = 15;

            // Zeichenketten
            string test = "testString";
            string t1 = "Hallo", t2 = "Welt", t3 = "!";

            // Gleitkommazahl:
            double pi = 3.14; // punkt als Komma

            // Neue Werte zuweisen:

            meineZahl = 42;
            meineZahl = 60;
            meineZahl = 0;

            Console.WriteLine(meineZahl);

            Console.WriteLine($"Der aktuelle Wert von meineZahl ist: {meineZahl}");
            Console.WriteLine("Der aktuelle Wert von meineZahl ist: " + meineZahl);

            // Zeichenkette einlesen:
            Console.WriteLine("Bitte geben Sie einen Text ein:");
            string eingabe = Console.ReadLine();
            Console.WriteLine("Deine Eingabe war:" + eingabe);

            // Zahl einlesen:
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            int neueZahl = int.Parse(Console.ReadLine());
            Console.WriteLine(neueZahl);


            // Berechnung (falsch !!!!)

            Console.WriteLine("Bitte geben Sie zwei Zahlen ein:");
            string zahl1 = Console.ReadLine();
            string zahl2 = Console.ReadLine();

            // -> Berechnung: + Operator

            string ergebnis = zahl1 + zahl2;

            Console.WriteLine(ergebnis);
            // Übung: Datentypen korrigieren damit die Berechnung funktioniert 


            Console.ReadKey();
            // Programm starten: F5
        }
    }
}
