using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FortgeschritteneFeatures
{
    class Person
    {
        public Person(string vorname, string nachname, byte alter, decimal kontostand)
        {
            Vorname = vorname;
            Nachname = nachname;
            Alter = alter;
            Kontostand = kontostand;
        }

        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }
    }
}
