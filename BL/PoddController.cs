using System.Xml;
using System.ServiceModel.Syndication;
using Models;
using DL;
using System.Threading.Channels;

namespace BL;
public class PoddController
{
    private AvsnittRepository avsnittRepository;

    public PoddController()
    {
        avsnittRepository = new AvsnittRepository();
    }

    public List<Avsnitt> HamtaAllaAvsnitt()
    {
        return avsnittRepository.HamtaAllaAvsnitt();
    }


    public void HamtaAvsnittFranRss(string rssLank)
    {

        XmlReader minXMLlasare = XmlReader.Create(rssLank);
        SyndicationFeed avsnittFlode = SyndicationFeed.Load(minXMLlasare);

        foreach (SyndicationItem item in avsnittFlode.Items)
        {
            Avsnitt ettAvsnitt = new Avsnitt()
            {
                Id = item.Id.ToString(),
                Rubrik = item.Title.Text,
                Publiceringsdatum = item.PublishDate
            };

            avsnittRepository.LaggTillAvsnitt(ettAvsnitt);

        }
    }
}
	



