using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt
    {
        // ? Kan vara null
        public string? Id { get; set; }
        public string? Rubrik { get; set; }
        public string? Beskrivning { get; set; }

        //Standardkonstruktor. Skapar instans för att kunna sätta egenskaper senare.
        public Avsnitt()
        {

        }

        //Overloading (överskuggning). Inte samma som overriding ofc
        public Avsnitt(string id, string rubrik, string beskrivning)
        {
            Id = id;
            Rubrik = rubrik;
            Beskrivning = beskrivning;
        }

    }
}
