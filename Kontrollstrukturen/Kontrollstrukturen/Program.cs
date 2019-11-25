using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kontrollstrukturen
{
    class Program
    {
        // Definition für das Enum / eigene Datentypen
        enum Wochentag 
        { 
            Montag,
            Dienstag,
            Mittwoch,
            Donnerstag,
            Freitag,
            Samstag,
            Sonntag
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            // Schnellvariante: int zahl = Convert.ToInt32(Console.ReadLine());
            
            string eingabe = Console.ReadLine(); // Eingabe als string gespeichert
            int zahl = Convert.ToInt32(eingabe); // Zeichenkette zu einer Zahl konvertiert

            // IF - Codeblock:

            // if(BEDINGUNG)
            if(zahl < 50)
            {
                // Codeblock wird ausgeführt, wenn die Zahl kleiner als 50 ist
                Console.WriteLine("Die Zahl '{0}' ist kleiner als 50",zahl);
            }
            // Alternative: Wird überprüft, wenn die erste Bedingung nicht stimmt
            // else if (BEDINGUNG)
            else if(zahl < 100)
            {
                Console.WriteLine("Die Zahl '{0}' ist kleiner als 100",zahl);
            }
            // "Letzte Möglichkeit" -> Wenn alles andere "false" ist
            // else
            else
            {
                Console.WriteLine("Die Zahl '{0}' ist größer als 100",zahl);
            }

            // Vergleich von Zeichenketten :
            // string.Compare


            // Verknüpfungsoperator:

            // Logisches AND &&
            // Logisches OR  ||
            // Logisches XOR ^
            // Invertieren   !

            // Situation: Zahl zwischen 0 und 100

            if( zahl > 0 && zahl < 100)
            {
                Console.WriteLine("Die Zahl ist größer als 0 und kleiner als 100");
            }



            // Bedinungsgesteuerte Schleife:

            int demoZahl = 10;
            while(demoZahl < 100)
            {
                demoZahl++;
                Console.WriteLine("Zahl {0} ist kleiner als 100",demoZahl);
            }

            string passwort = "";
            while(passwort != "geheim")
            {
                Console.WriteLine("Bitte geben Sie Ihr Passwort ein:");
                passwort = Console.ReadLine();
            }

            // Arrays:

            // Schreibweise Variante 1:
            int[] zahlen1 = new int[5]; // Index: 0,1,2,3,4
            zahlen1[0] = 5;
            zahlen1[1] = 10; // Befüllen
            // ...

            // Schreibweise Variante 2:
            int[] zahlen2 = new int[] { 5, 10, 15 }; // Größe: 3 , Index: 0,1,2

            // Schreibweise Variante 3:
            int[] zahlen3 = { 12, 99, 7, 4 }; // Größe: 4, Index: 0,1,2,3

            // Starten F5
            // Haltepunkt F9
            // Einzelschritt: F10 oder F11


            // in ein Array hineinschreiben
            zahlen1[3] = 55;

            // ein Array auslesen
            Console.WriteLine(zahlen1[3]);


            // For - Schleife:

            // for + TAB + TAB
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < zahlen3.Length; i++)
            {
                Console.WriteLine(zahlen3[i]);
            }


            // Schleifen steuern:
            for (int i = 0; i < 10000; i++)
            {
                // Schleife früher beenden:
                if (i == 99)
                    break;      // beendet die Schleife
            }

            for (int i = 0; i < 10000; i++)
            {
                // Schleifenschritt überspringen:
                if (i % 2 == 0) // gerade Zahl
                    continue;   // gehe zum nächsten durchgang

                Console.WriteLine(i); // nur ungerade Zahlen ausgeben

            }


            // Enum verwenden:
            Wochentag heute = Wochentag.Montag;
            if (heute == Wochentag.Montag)
            {
                Console.WriteLine("Juhu es ist Montag !!!");
            }
            else if (heute == Wochentag.Dienstag)
                ; // .....
            else if (heute == Wochentag.Mittwoch)
                ; // ....

            // Switch: Switch + TAB + TAB

            switch (heute)
            {
                case Wochentag.Montag:
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Unter der Woche");
                    break;
                case Wochentag.Freitag:
                    Console.WriteLine("Fast-Wochenende");
                    break;
                case Wochentag.Samstag:
                case Wochentag.Sonntag:
                    Console.WriteLine("Wochenende");
                    break;
                default: // Quasi der "else"-Fall
                    break;
            }

            Console.WriteLine("----ENDE----");
            Console.ReadKey();
        }
    }
}
