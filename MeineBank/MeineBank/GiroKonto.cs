using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeineBank
{
    class GiroKonto : Konto
    {
        public GiroKonto(string inhaber, decimal kontostand) : base(inhaber, kontostand)
        {
        }

        public override void Überweisung(decimal betrag, Konto zielKonto)
        {
            // Suffix:
            //int zahl1 = 5;
            //double zahl2 = 12.5D;
            //long zahl3 = 1234L;
            //ulong zahl4 = 1234UL;
            //float zahl5 = 123.123F;
            //decimal zahl6 = 123.123M;

            if (betrag < 0)
                throw new ArgumentException("Sie dürfen keinen negativen Betrag überweisen");

            this.Abheben(betrag * 1.03m); // + Überweisungsgebühr von 3%
            zielKonto.Einzahlen(betrag);
        }

    }
}
