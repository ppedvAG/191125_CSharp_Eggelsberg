using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Person
    {
        // private ist der Standardfall wenn wir nichts hinschreiben
        //private string Vorname;
        //private string Nachname;
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

        // Autoproperty:
        // prop + TAB + TAB

        public byte Alter { get; set; } // Kurzfassung für das volle Property




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
