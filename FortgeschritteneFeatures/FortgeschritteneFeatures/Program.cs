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
            //int zahl = 42;

            //Console.WriteLine(zahl.Verdoppeln());

            string Text = "Hallo Welt";
            //Text.Umdrehen();

            // LINQ:

            int[] zahlen = { 12, 5, 89, 5, 3, 2, 4, 6, 8, 9, 6, 4, 2, 2 };

            IEnumerable<int> ergebnis = from einzelneZahl in zahlen
                                        where einzelneZahl % 2 == 0 // nur gerade Zahlen
                                        select einzelneZahl;

            int[] geradeZahlen = zahlen.Where(zahl => zahl % 2 == 0)
                                       .ToArray();

            // Personen filtern

            Person[] personen = new Person[7];
            personen[0] = new Person("Tom", "Ate",10,100);
            personen[1] = new Person("Anna", "Nass",110,100000000);
            personen[2] = new Person("Peter", "Silie",20,100);
            personen[3] = new Person("Franz", "Ose",250,100);
            personen[4] = new Person("Martha", "Pfahl",40,100);
            personen[5] = new Person("Klara", "Fall",70,100);
            personen[6] = new Person("Rainer", "Zufall",140,100);

            IEnumerable<Person> ergebnis2 = from person in personen
                                            where person.Alter > 100 && person.Kontostand > 10000
                                            select person;

            Person[] ergebnisPersonen = ergebnis2.ToArray();


            GenerischeKlasse<string> demo1 = new GenerischeKlasse<string>();

            demo1.

            Console.WriteLine("---ANFANG---");
            Console.ReadKey();
        }
    }
}
