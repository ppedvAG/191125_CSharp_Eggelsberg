using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeineBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konto k1 = new Konto("Michael Zöhling", 10000000);

            //Console.WriteLine(k1.Kontostand);
            //k1.Abheben(5000000);
            //Console.WriteLine(k1.Kontostand);

            //k1.Einzahlen(2);
            //Console.WriteLine(k1.Kontostand);

            //// Fehler:


            //try
            //{
            //    k1.Abheben(-2000);
            //}
            ////catch (ArgumentException ex)
            ////{
            ////    Console.WriteLine("Falscher Wert im Parameter");
            ////}
            //catch (Exception ex) // Exception: ALLE Exceptions werden abgefangen
            //{
            //    Console.WriteLine(ex.Message);
            //}


            // Variante mit der Liste:

            // 1) Konten aufbauen:

            List<JugendKonto> jugendkonten = new List<JugendKonto>();
            jugendkonten.Add(new JugendKonto("Tom Ate", 1000));
            jugendkonten.Add(new JugendKonto("Anna Nass", 1000));
            jugendkonten.Add(new JugendKonto("Peter Silie", 1000));
            jugendkonten.Add(new JugendKonto("Franz Ose", 1000));
            jugendkonten.Add(new JugendKonto("Martha Pfahl", 1000));

            List<GiroKonto> girokonten = new List<GiroKonto>();
            girokonten.Add(new GiroKonto("Bill Dung", 1000));
            girokonten.Add(new GiroKonto("Axel Schweiß", 1000));
            girokonten.Add(new GiroKonto("Anna Bolika", 1000));
            girokonten.Add(new GiroKonto("Albert Tross", 1000));
            girokonten.Add(new GiroKonto("Frank N Stein", 1000));

            // 2) Mit einer Schleife die Überweisung starten
            Random generator = new Random();


            for (int i = 0; i < jugendkonten.Count; i++) // wichtig ! Count statt Length,da es kein Array ist
            {
                try
                {
                    jugendkonten[i].Überweisung(generator.Next(0, 200), girokonten[i]);
                    Console.WriteLine("Transaktion Nr " + (i + 1)); // keinesfalls i++ nehmen !!! 

                    Console.WriteLine($"JK {jugendkonten[i].Inhaber}: {jugendkonten[i].Kontostand}");
                    Console.WriteLine($"GK {girokonten[i].Inhaber}: {girokonten[i].Kontostand}");
                    Console.WriteLine("----------------");
                }
                catch (Exception)
                {
                    Console.WriteLine("Überweisung abgebrochen: Betrag ist zu hoch! ");
                }

            }

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
