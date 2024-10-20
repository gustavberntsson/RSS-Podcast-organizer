using System.Xml;
using System.ServiceModel.Syndication;
using Models;
using DL;
using System.Threading.Channels;

namespace BL;
public class PoddController
{
    private List<AvsnittRepository> allaPoddar;

    public PoddController()
    {
        allaPoddar = new List<AvsnittRepository>();
        
    }

    //Tar in en lista som parameter för att sedan kunna returnera DEN listans avsnitt, kanske onödig
    public List<Avsnitt> HamtaAllaAvsnitt(AvsnittRepository avsnittRepository)
    {
        return avsnittRepository.HamtaAllaAvsnitt();
    }

    public List<AvsnittRepository> HamtaAllaPoddar()
    {
        return allaPoddar;
    }


    public void HamtaAvsnittFranRss(string rssLank, string valdKategori)
    {
        var avsnittRepository = new AvsnittRepository();
        //Döper avsnittsrepositoriet till samma som rsslänken, används för att identifiera listan
        avsnittRepository.SetNamn(rssLank);
        XmlReader minXMLlasare = XmlReader.Create(rssLank);
        SyndicationFeed avsnittFlode = SyndicationFeed.Load(minXMLlasare);

        foreach (SyndicationItem item in avsnittFlode.Items)
        {
            Avsnitt ettAvsnitt = new Avsnitt()
            {
                Id = item.Id.ToString(),
                Rubrik = item.Title.Text,
                Beskrivning = item.Summary.Text,
                Publiceringsdatum = item.PublishDate
            };

            avsnittRepository.LaggTillAvsnitt(ettAvsnitt);

        }
        allaPoddar.Add(avsnittRepository);
    }
}
	



