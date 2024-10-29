using System.Xml;
using System.ServiceModel.Syndication;
using Models;
using DL;
using System.Threading.Channels;

namespace BL;
public class PoddController
{
    private List<AvsnittRepository> allaPoddar;
    private KategoriRepository kategoriRepo = new KategoriRepository();

    public PoddController()
    {
        allaPoddar = new List<AvsnittRepository>();
        
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
        
        var kategori = new Kategori(valdKategori);
        kategoriRepo.LaggTillKategori(kategori);
        avsnittRepository.SetKategori(kategori);

        XmlReader minXMLlasare = XmlReader.Create(rssLank);
        SyndicationFeed avsnittFlode = SyndicationFeed.Load(minXMLlasare);

        foreach (SyndicationItem item in avsnittFlode.Items)
        {
            string beskrivning = HamtaBeskrivning(item);

            var ettAvsnitt = new Avsnitt(
                item.Id.ToString(),
                item.Title.Text,
                beskrivning);

            avsnittRepository.LaggTillAvsnitt(ettAvsnitt);

        }
        allaPoddar.Add(avsnittRepository);
        SparaTillXml("poddar.xml");
    }
    private string HamtaBeskrivning(SyndicationItem item)
    {
        if (item.Summary != null && !string.IsNullOrEmpty(item.Summary.Text))
            return item.Summary.Text;

        if (item.Content is TextSyndicationContent textContent)
            return textContent.Text;

        return "Ingen beskrivning hittades för avsnittet";
    }

    //Sparar alla poddar och deras avsnitt till en XML-fil
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
                    writer.WriteEndElement(); // Avsnitt
                }

                writer.WriteEndElement(); // Avsnitt
                writer.WriteEndElement(); // Podcast
            }

            writer.WriteEndElement(); // Podcasts
            writer.WriteEndDocument();

            //Avslutat XML-dokumentet
        }
    }

    //Läser in poddar och deras avsnitt från en XML-fil och återställr dem till programmet.
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
            
            var kategoriNamn = podcastNode["Kategori"].InnerText;
            var kategori = new Kategori(kategoriNamn);
            avsnittRepository.SetKategori(kategori); // Sätt Kategori-objektet

            avsnittRepository.SetLank(podcastNode["RssLank"].InnerText);

            XmlNodeList avsnittNodes = podcastNode.SelectNodes("Avsnitt/Avsnitt");
            foreach (XmlNode avsnittNode in avsnittNodes)
            {
                Avsnitt avsnitt = new Avsnitt()
                {
                    Id = avsnittNode["Id"].InnerText,
                    Rubrik = avsnittNode["Rubrik"].InnerText,
                    Beskrivning = avsnittNode["Beskrivning"].InnerText
                };

                avsnittRepository.LaggTillAvsnitt(avsnitt);
            }

            allaPoddar.Add(avsnittRepository);
        }
    }
}
	



