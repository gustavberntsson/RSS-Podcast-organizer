using System.Xml;
using System.ServiceModel.Syndication;
using Models;
using DL;

namespace BL;
public class PoddController
{
    private PoddRepository poddRepository;

    public PoddController()
    {
        poddRepository = new PoddRepository();
    }

    public List<Podcast> HamtaAllaPoddar()
    {
        return poddRepository.HamtaAllaPoddar();
    }


    public void HamtaPoddarFranRss(string rssLank)
    {

        XmlReader minXMLlasare = XmlReader.Create(rssLank);
        SyndicationFeed poddFlode = SyndicationFeed.Load(minXMLlasare);

        foreach (SyndicationItem item in poddFlode.Items)
        {
            Podcast enPodd = new Podcast()
            {
                Id = item.Id.ToString(),
                Rubrik = item.Title.Text,
                Publiceringsdatum = item.PublishDate
            };

            poddRepository.LaggTillPoddar(enPodd);

        }
    }
}
	



