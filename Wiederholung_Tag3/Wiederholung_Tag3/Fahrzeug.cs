using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiederholung_Tag3
{
    abstract class Fahrzeug
    {
        public int Geschwindigkeit { get; set; }

        public abstract void Beschleunigen();
        public abstract void Bremsen();
    }

    abstract class PrivatFahrzeug : Fahrzeug
    {
        public string Inhaber { get; set; }
        public int Kilometerstand { get; set; }

        public void Fahren(int stunden)
        {
            Kilometerstand += Geschwindigkeit * stunden;
        }
    }

    class Auto : PrivatFahrzeug
    {
        public Auto(string Inhaber, int Kilometerstand)
        {
            this.Inhaber = Inhaber;
            this.Kilometerstand = Kilometerstand;
        }


        public override void Beschleunigen()
        {
            Geschwindigkeit += 20;
        }

        public override void Bremsen()
        {
            Geschwindigkeit -= 20;
        }
    }

    class Motorrad : PrivatFahrzeug
    {
        public override void Beschleunigen()
        {
            Geschwindigkeit += 30;
        }

        public override void Bremsen()
        {
            Geschwindigkeit -= 30;
        }
    }


    interface ITransportfahrzeug 
    {
        int AnzahlPersonen { get; set; }
        int MaximalesLadegewicht { get; set; }
        bool GefahrengutTransport { get; set; }
    }

    class Schiff : Fahrzeug, ITransportfahrzeug
    {
        public int AnzahlPersonen { get; set; }
        public int MaximalesLadegewicht { get; set; }
        public bool GefahrengutTransport { get; set; }

        public override void Beschleunigen()
        {
            Geschwindigkeit += 10;
        }

        public override void Bremsen()
        {
            Geschwindigkeit -= 10;
        }
    }


    class Flugzeug : Fahrzeug, ITransportfahrzeug
    {
        public int AnzahlPersonen { get; set; }
        public int MaximalesLadegewicht { get; set; }
        public bool GefahrengutTransport { get; set; }
        public int Tragfläche { get; set; }

        public override void Beschleunigen()
        {
            Geschwindigkeit += 80;
        }

        public override void Bremsen()
        {
            Geschwindigkeit -= 80;
        }
    }


    class LKW : PrivatFahrzeug, ITransportfahrzeug
    {
        public int AnzahlPersonen { get; set; }
        public int MaximalesLadegewicht { get; set; }
        public bool GefahrengutTransport { get; set; }
        public double Höhe { get; set; }

        public override void Beschleunigen()
        {
            Geschwindigkeit += 30;
        }

        public override void Bremsen()
        {
            Geschwindigkeit -= 30;
        }
    }
}
