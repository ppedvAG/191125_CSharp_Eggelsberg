using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Kunde : Person // Kunde erbt von Person
    {
        public int Kundennummer { get; set; }

        public void MachEtwasMitEinemKunden()
        {
            Console.WriteLine("Geschäftsessen...");
        }

        // override + MethodeAuswählen + TAB

        public override void Geburtstag()
        {
            Console.WriteLine("ICH BIN EIN KUNDE -> KUDNENGEBURTSTAG");
            Alter += 2;
        }
    }
}
