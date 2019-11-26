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
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            int zahl1 = int.Parse(Console.ReadLine());

            // "Hochkomplizierte Logik"
            int erg1 = Program.Verdoppeln(zahl1);   // Variante 1
            int erg2 = Verdoppeln(44);              // Variante 2

            Console.WriteLine(erg1);
            Console.WriteLine(erg2);


            // Funktion mit 2 Ausgaben:

            Console.WriteLine("Bitte geben Sie eine ganze Zahl ein:");
            string eingabe = Console.ReadLine();

            int konvertierteZahl;

            if(int.TryParse(eingabe,out konvertierteZahl) == true)
            {
                Console.WriteLine("Es war eine Zahl: " + konvertierteZahl);
            }
            else
            {
                Console.WriteLine("Es war etwas anderes.");
            }

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }


        // Eigene Funktion:
        static int Verdoppeln(int x)
        {
            int ergebnis = x * 2;
            return ergebnis;
        }

        // Mini-Übung:
        // Funktion: Addieren: 2 Zahlen kommen rein, eine raus 

    }
}
