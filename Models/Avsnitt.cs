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
        public DateTimeOffset Publiceringsdatum { get; set; }

        public string? Langd { get; set; }

        public Avsnitt()
        {

        }

        public Avsnitt(string id, string rubrik, DateTimeOffset publiceringsdatum)
        {
            Id = id;
            Rubrik = rubrik;
            Publiceringsdatum = publiceringsdatum;
        }

    }
}
