using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Podcast
    {
        public string? PodcastTitel { get; set; }
        public string? Id { get; set; }
        public string? Rubrik { get; set; }
        public DateTimeOffset Publiceringsdatum { get; set; }

        public string? Langd { get; set; }

        public Podcast()
        {

        }

        public Podcast(string podcastTitel, string id, string rubrik, DateTimeOffset publiceringsdatum)
        {
            PodcastTitel = "Mitt flöde 1";
            Id = id;
            Rubrik = rubrik;
            Publiceringsdatum = publiceringsdatum;
        }
    }
}
