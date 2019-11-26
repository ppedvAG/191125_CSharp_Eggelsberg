using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Person
    {
        // private ist der Standardfall wenn wir nichts hinschreiben
        public string Vorname;
        public string Nachname;
        public byte Alter;
        public decimal Kontostand;

        public void Geburtstag()
        {
            Alter++;
        }

    }
}
