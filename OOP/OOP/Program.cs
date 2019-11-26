using System;

namespace OOP // Objektorientierte Programmieren
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# arbeitet immer mit Objekten
            // Technisch gesehen leitet sich in C# alles von der Klasse "Object" ab

            // Da alles ein "object" ist, darf in einer object-Variable alles drinnen stehen:
            object o1 = 42;
            object o2 = "Hallo Welt";
            object o3 = new Random();

            // Path
            // -> Kontext: Ordnerpfad im Dateisystem
            // -> Kontext: Oberfläche: Linie

            // Eine Person erstellen:

            Person p1 = new Person(); // new Person() um ein neues Personenobjekt zu erstellen
            p1.Vorname = "Tom";
            p1.Nachname = "Ate";

            Person p2 = new Person();
            p2.Vorname = "Anna";
            p2.Nachname = "Nass";

            Console.WriteLine(p1.Vorname);
            Console.WriteLine(p2.Vorname);

            p1.Alter = 50;
            p2.Alter = 50;
            Console.WriteLine(p1.Alter);
            p1.Geburtstag();
            Console.WriteLine(p1.Alter);
            Console.WriteLine(p2.Alter);


            //// Array von Personen

            //Person[] allePersonen = new Person[5];
            //allePersonen[0] = new Person();
            //allePersonen[1] = new Person();
            //// ...

            //allePersonen[0].Vorname = "demo";
            //// ....

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
