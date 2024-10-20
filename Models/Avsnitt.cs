using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt
    {
        public string? Id { get; set; }
        public string? Rubrik { get; set; }
        public string? Beskrivning { get; set; }
        public DateTimeOffset Publiceringsdatum { get; set; }

        public Avsnitt()
        {

        }

        public Avsnitt(int avsnittsid, string id, string rubrik, string beskrivning, DateTimeOffset publiceringsdatum)
        {

            Id = id;
            Rubrik = rubrik;
            Beskrivning = beskrivning;
            Publiceringsdatum = publiceringsdatum;
        }

    }
}
