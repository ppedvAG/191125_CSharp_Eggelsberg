using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiederholung_Tag1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie einen Text ein:");
            string eingabe = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            int zahl1 = Convert.ToInt32(Console.ReadLine()); // Variante 1
            // int zahl2 = int.Parse(Console.ReadLine());       // Variante 2

            if (zahl1 % 2 == 1)
            {
                for (int i = 0; i < zahl1; i++)
                {
                    Console.WriteLine(eingabe);
                }
            }
            else
            {
                // string passwort = Console.ReadLine();
                //while (passwort != "geheim")
                //{
                //    Console.WriteLine("Bitte geben Sie das korrekte Passwort ein:");
                //    passwort = Console.ReadLine();
                //}

                string passwort = "";
                do
                {
                    Console.WriteLine("Bitte geben Sie das korrekte Passwort ein:");
                    passwort = Console.ReadLine();
                } while (passwort != "geheim");

            }


            Random generator = new Random();
            int[] alleZahlen = new int[5000];

            for (int i = 0; i < alleZahlen.Length; i++)
            {
                alleZahlen[i] = generator.Next(1, 101); // Exklusive 101 -> 1 bis 100
            }

            Console.WriteLine(alleZahlen.Sum());

            

            // cw + TAB + TAB
            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
