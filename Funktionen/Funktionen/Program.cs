using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            //int zahl1 = int.Parse(Console.ReadLine());

            //// "Hochkomplizierte Logik"
            //int erg1 = Program.Verdoppeln(zahl1);   // Variante 1
            //int erg2 = Verdoppeln(44);              // Variante 2

            //Console.WriteLine(erg1);
            //Console.WriteLine(erg2);


            //// Funktion mit 2 Ausgaben:

            //Console.WriteLine("Bitte geben Sie eine ganze Zahl ein:");
            //string eingabe = Console.ReadLine();

            //int konvertierteZahl;

            //if(int.TryParse(eingabe,out konvertierteZahl) == true)
            //{
            //    Console.WriteLine("Es war eine Zahl: " + konvertierteZahl);
            //}
            //else
            //{
            //    Console.WriteLine("Es war etwas anderes.");
            //}

            //// Überladen von Methoden
            //Console.WriteLine(Addieren(12,3));
            //Console.WriteLine(Addieren(12,3,5));

            //// params
            //Console.WriteLine(Sum(1,2,3));
            //Console.WriteLine(Sum(1));
            //Console.WriteLine(Sum(1,6,3,1,3,4,7,9,9,6,4,2,2,3,4,6));

            //MachEtwas("Hallo");
            //MachEtwas("Welt",99);

            // Übung: Zahlen einlesen und den Durchschnitt berechnen:

            // 1) Abfrage, wie viele Zahlen wir einlesen wollen

            Console.WriteLine("Bitte geben Sie die Anzahl der Zahlen ein:");
            int anzahl = int.Parse(Console.ReadLine());

            int[] alleZahlen = new int[anzahl];

            // 2) Zahlen einlesen
            for (int i = 0; i < anzahl; i++) // i < alleZahlen.Length
            {
                alleZahlen[i] = int.Parse(Console.ReadLine());
            }

            // 3)
            Console.WriteLine(BerechneDurchschnitt(alleZahlen));


            // Optional: mit Params die Unterstützung für mehrere Werte einbauen
            Console.WriteLine(BerechneDurchschnitt(12,3));
            Console.WriteLine(BerechneDurchschnitt(12,3,7,9,8,5,4,3,2,1));
            Console.WriteLine(BerechneDurchschnitt(994,3,2,1));

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        static double BerechneDurchschnitt(params int[] zahlen)
        {
            // 1):
            return zahlen.Average();

            // 2):
            // return zahlen.Sum() / zahlen.Length;

            // 3):
            //int sum = 0;
            //for (int i = 0; i < zahlen.Length; i++)
            //{
            //    sum += zahlen[i];
            //}
            //return sum / zahlen.Length;

            // 4):
            //double sum = 0;
            //foreach (int zahl in zahlen)
            //{
            //    sum += zahl; // in "zahl" steht quasi "zahlen[i]" drinnen
            //}
            //return sum / zahlen.Length;

        }




        // Eigene Funktion:
        static int Verdoppeln(int x)
        {
            int ergebnis = x * 2;
            return ergebnis;
        }

        // Mini-Übung:
        // Funktion: Addieren: 2 Zahlen kommen rein, eine raus 


        static int Addieren(int z1, int z2)
        {
            return z1 + z2;
        }
        static int Addieren(int z1, int z2,int z3)
        {
            return z1 + z2 + z3;
        }
        static int Addieren(int z1, int z2, int z3, int z4)
        {
            return z1 + z2 + z3 + z4;
        }

        static int Sum(params int[] zahlen)
        {
            return zahlen.Sum();
        }


        static void MachEtwas(string text, int zahl = 5)
        {
            Console.WriteLine("Mach Etwas mit dem Text: " + text +  " und der Zahl " + zahl);
        }
    }
}
