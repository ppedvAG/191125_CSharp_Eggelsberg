using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KomplexeDatentypen
{
    class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }


        public void Geburtstag()
        {
            Alter++;
        }
    }
}
