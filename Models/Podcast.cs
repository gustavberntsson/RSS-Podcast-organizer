using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Podcast
    {
        public string? Id { get; set; }
        public string? Rubrik { get; set; }
        public DateTimeOffset Publiceringsdatum { get; set; }

        public Podcast()
        {

        }

        public Podcast(string id, string rubrik, DateTimeOffset publiceringsdatum)
        {
            Id = id;
            Rubrik = rubrik;
            Publiceringsdatum = publiceringsdatum;
        }
    }
}
