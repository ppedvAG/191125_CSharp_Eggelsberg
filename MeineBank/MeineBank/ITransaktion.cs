using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeineBank
{
    interface ITransaktion
    {
        void Überweisung(decimal betrag, Konto zielKonto);
    }
}
