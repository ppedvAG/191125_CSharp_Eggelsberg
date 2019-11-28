using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortgeschritteneFeatures
{
    class Program
    {
        static void Main(string[] args)
        {

            // Erweiterungsmethoden:
            int zahl = 42;

            Console.WriteLine(zahl.Verdoppeln());

            string Text = "Hallo Welt";
            Text.Umdrehen();

            Console.WriteLine("---ANFANG---");
            Console.ReadKey();
        }
    }
}
