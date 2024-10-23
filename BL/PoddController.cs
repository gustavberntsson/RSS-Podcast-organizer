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


    public void HamtaAvsnittFranRss(string podcastNamn, string rssLank, string valdKategori)
    {
        var avsnittRepository = new AvsnittRepository();
        avsnittRepository.SetLank(rssLank);
        
        avsnittRepository.SetNamn(podcastNamn);
        
        avsnittRepository.SetKategori(valdKategori);

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
        SparaTillXml("poddar.xml");
    }

    public void SparaTillXml(string filnamn)
    {
        using (XmlWriter writer = XmlWriter.Create(filnamn))
        {
            writer.WriteStartDocument();
            writer.WriteStartElement("Podcasts");

            foreach (var avsnittRepository in allaPoddar)
            {
                writer.WriteStartElement("Podcast");
                writer.WriteElementString("Namn", avsnittRepository.GetNamn());
                writer.WriteElementString("Kategori", avsnittRepository.GetKategori());
                writer.WriteElementString("RssLank", avsnittRepository.GetLank());

                writer.WriteStartElement("Avsnitt");
                foreach (var avsnitt in avsnittRepository.HamtaAllaAvsnitt())
                {
                    writer.WriteStartElement("Avsnitt");
                    writer.WriteElementString("Id", avsnitt.Id);
                    writer.WriteElementString("Rubrik", avsnitt.Rubrik);
                    writer.WriteElementString("Beskrivning", avsnitt.Beskrivning);
                    writer.WriteElementString("Publiceringsdatum", avsnitt.Publiceringsdatum.ToString());
                    writer.WriteEndElement(); // Avsnitt
                }

                writer.WriteEndElement(); // Avsnitt
                writer.WriteEndElement(); // Podcast
            }

            writer.WriteEndElement(); // Podcasts
            writer.WriteEndDocument();
        }
    }
    public void LaddaFranXml(string filnamn)
    {
        if (!File.Exists(filnamn))
        {
            return;
        }

        XmlDocument doc = new XmlDocument();
        doc.Load(filnamn);

        XmlNodeList podcastNodes = doc.SelectNodes("/Podcasts/Podcast");
        foreach (XmlNode podcastNode in podcastNodes)
        {
            var avsnittRepository = new AvsnittRepository();
            avsnittRepository.SetNamn(podcastNode["Namn"].InnerText);
            avsnittRepository.SetKategori(podcastNode["Kategori"].InnerText);
            avsnittRepository.SetLank(podcastNode["RssLank"].InnerText);

            XmlNodeList avsnittNodes = podcastNode.SelectNodes("Avsnitt/Avsnitt");
            foreach (XmlNode avsnittNode in avsnittNodes)
            {
                Avsnitt avsnitt = new Avsnitt()
                {
                    Id = avsnittNode["Id"].InnerText,
                    Rubrik = avsnittNode["Rubrik"].InnerText,
                    Beskrivning = avsnittNode["Beskrivning"].InnerText,
                    Publiceringsdatum = DateTimeOffset.Parse(avsnittNode["Publiceringsdatum"].InnerText)
                };

                avsnittRepository.LaggTillAvsnitt(avsnitt);
            }

            allaPoddar.Add(avsnittRepository);
        }
    }
}
	



