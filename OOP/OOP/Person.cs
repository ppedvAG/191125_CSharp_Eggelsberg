using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Person
    {
        // Konstruktor:
        // ctor + TAB + TAB

        public Person(byte alter) // Ideal für Startwerte
        {
            Vorname = "Max";
            Nachname = "Mustermann";
            Alter = alter;
        }

        public Person(string vn, string nn) // Ideal für Startwerte
        {
            Vorname = vn;
            Nachname = nn;
            Alter = 0;
        }

        public Person(decimal Kontostand, string vorname, string nachname, byte alter)
        {
            this.Kontostand = Kontostand; // Kontostand == Parameter, this.Kontostand == Property
            Vorname = vorname;
            Nachname = nachname;
            Alter = alter;
        }


        // Erstellen von einem Konstruktor:
        // ab VS 2015
        // Rechtsklick -> Quick Actions and Refactoring -> Generate Constructor



        // private ist der Standardfall wenn wir nichts hinschreiben
        // private string Vorname;
        // private string Nachname;
        // private byte Alter;


        private decimal kontostand; // Coderichtlinie: private Felder wird immer kleingeschrieben

        public decimal Kontostand
        {
            get // Lesezugriff
            {
                return kontostand;
            }
            set // Schreibzugriff
            {
                if( value < 0)
                    Console.WriteLine("Kontostand darf nicht unter 0 gesetzt werden !!!");
                else
                    kontostand = value; // value ist der neue Wert, der mit "=" gesetzt wird
            }
        }


        // Kürzel für ganze Properties mit privatem Feld:
        // propfull + TAB + TAB 


        private string vorname;

        public string Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }

        public string Nachname { get; set; }
        // Autoproperty:
        // prop + TAB + TAB

        public byte Alter { get; set; } // Kurzfassung für das volle Property


        // ReadOnly-Property:
        public string GanzerName
        {
            get
            {
                return Vorname + " " + Nachname;
            }
        }



        // Methoden für den Zugriff: (wie in Java)
        //public decimal KontostandAuslesen()
        //{
        //    return Kontostand; // 1:1 auslesen
        //}

        //private void KontostandSetzen(decimal neuerKontostand)
        //{
        //    if(neuerKontostand < 0)
        //    {
        //        Console.WriteLine("Der Kontostand darf nicht unter 0 !!!!");
        //    }
        //    else
        //        Kontostand = neuerKontostand;
        //}



        public void Geburtstag()
        {
            Alter++;
        }

    }
}
