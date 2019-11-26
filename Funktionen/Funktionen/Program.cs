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

            // Überladen von Methoden
            Console.WriteLine(Addieren(12,3));
            Console.WriteLine(Addieren(12,3,5));

            // params
            Console.WriteLine(Sum(1,2,3));
            Console.WriteLine(Sum(1));
            Console.WriteLine(Sum(1,6,3,1,3,4,7,9,9,6,4,2,2,3,4,6));

            MachEtwas("Hallo");
            MachEtwas("Welt",99);

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
