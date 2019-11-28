using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Xml.Serialization;

namespace TextEditor
{
    // Für XML: Klasse muss public !!!
    [XmlRoot("MeinPersonenobject")]
    public class Person
    {
        [XmlAttribute("DerVorname")]
        public string Vorname { get; set; }
        [XmlAttribute("DerNachname")]
        public string Nachname { get; set; }

        [XmlIgnore]
        public int Alter { get; set; }
        public decimal Kontostand { get; set; }
    }

}
