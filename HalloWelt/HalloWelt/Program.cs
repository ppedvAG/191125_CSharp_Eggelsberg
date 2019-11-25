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


            // Berechnung (Lösung)

            Console.WriteLine("Bitte geben Sie zwei Zahlen ein:");
            int zahl1 = int.Parse(Console.ReadLine());
            int zahl2 = int.Parse(Console.ReadLine());

            // -> Berechnung: + Operator

            int ergebnis = zahl1 + zahl2;

            Console.WriteLine(ergebnis);
            // Übung: Datentypen korrigieren damit die Berechnung funktioniert 

            // Operatoren:

            int z1 = 5;
            int z2 = 10;

            int erg = z1 + z2; // Binärer Operator: 2 Zahlen

            Console.WriteLine(z1);
            z1++;   // Wert um 1 erhöhen
            // Entspricht: z1 = z1 + 1;
            Console.WriteLine(z1);
            z1 += 10; // Wert um 10 erhöhen
            // Entspricht: z1 = z1 + 10;

            // Datentypen:

            int ganzeZahl = 10;
            double kommazahl = 5.999;

            // Alternative zu int.parse:
            int ergInt = Convert.ToInt32(ganzeZahl + kommazahl);
            double ergDbl = ganzeZahl + kommazahl;

            // Math-Klasse

            Console.WriteLine(ergInt);
            Console.WriteLine(ergDbl);

            Console.WriteLine("Die Summe von {0} und  {1} ist {2}", z1, z2, erg);


            // int = int + int 
            int erg5 = 12 + Convert.ToInt32(55.9999);
            Console.WriteLine(erg5);

            // int = int(double)
            int erg6 = Convert.ToInt32(12 + 55.9999);
            Console.WriteLine(erg6);


            Console.ReadKey();
            // Programm starten: F5
        }
    }
}
