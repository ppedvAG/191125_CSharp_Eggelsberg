using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kontrollstrukturen
{
    class Program
    {
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



            Console.WriteLine("----ENDE----");
            Console.ReadKey();
        }
    }
}
