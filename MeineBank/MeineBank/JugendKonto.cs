using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeineBank
{
    class JugendKonto : Konto
    {
        public JugendKonto(string inhaber, decimal kontostand) : base(inhaber, kontostand)
        {
        }

        public override void Überweisung(decimal betrag, Konto zielKonto)
        {
            if(betrag > 100)
            {
                throw new InvalidOperationException("Sie dürfen nicht mehr als 100€ überweisen");
                // Console.WriteLine("Sie dürfen nicht mehr als 100€ überweisen");
            }
            else if (betrag > Kontostand)
            {
                throw new InvalidOperationException("Sie dürfen nicht mehr überweisen als Sie besitzen");
                //Console.WriteLine("Sie dürfen nicht mehr überweisen als Sie besitzen");
            }
            else // Alles Geht
            {
                //// Variante 1: CopyPaste
                ////Eigenes Konto (this. == aktuelle Instanz)
                //this.Abheben(betrag);
                ////Fremdes Konto
                //zielKonto.Einzahlen(betrag);

                // Variante 2:
                base.Überweisung(betrag, zielKonto); // Es gibt ja schon eine Logik
            }
        }
    }
}
