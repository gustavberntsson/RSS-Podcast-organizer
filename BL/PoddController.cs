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


    public async Task HamtaAvsnittFranRss(string podcastNamn, string rssLank, string valdKategori)
    {
        var avsnittRepository = new AvsnittRepository();
        avsnittRepository.SetLank(rssLank);
        avsnittRepository.SetNamn(podcastNamn);
        
        var kategori = new Kategori(valdKategori);
        kategoriRepo.LaggTillKategori(kategori);
        avsnittRepository.SetKategori(kategori);

        using (XmlReader minXMLlasare = XmlReader.Create(rssLank))
        {
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
        }

        allaPoddar.Add(avsnittRepository);
        await SparaTillXml("poddar.xml");
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
    public async Task SparaTillXml(string filnamn)
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

    public async Task SparaKategorierTillXml(string filnamn, List<string> kategorier)
    {
        try
        {
            using (XmlWriter writer = XmlWriter.Create(filnamn))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Kategorier");

                foreach (var kategori in kategorier)
                {
                    writer.WriteElementString("Kategori", kategori);
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
        catch (Exception ex)
        {
        }
    }

    public List<string> LasaKategorierFranXml(string filnamn)
    {
        List<string> kategorier = new List<string>();
        try
        {
            if (File.Exists(filnamn))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filnamn);
                XmlNodeList kategoriNodes = doc.SelectNodes("//Kategori");

                if (kategoriNodes != null)
                {
                    foreach (XmlNode node in kategoriNodes)
                    {
                        if (node.InnerText != null)
                        {
                            kategorier.Add(node.InnerText);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {

        }
        return kategorier;
    }

    public void UppdateraKategoriNamnIAllaPoddar(string gammalKategori, string nyKategori)
    {
        // Hämta alla poddar
        List<AvsnittRepository> allaPoddar = HamtaAllaPoddar(); // Antar att du har en sådan metod
        bool harUppdateringar = false;

        // Uppdatera kategorin för varje podd som har den gamla kategorin
        foreach (var podd in allaPoddar)
        {
            if (podd.GetKategori().Equals(gammalKategori))
            {
                podd.SetKategori(new Kategori(nyKategori));
                harUppdateringar = true;
            }
        }

        // Spara endast om det faktiskt gjordes några ändringar
        if (harUppdateringar)
        {
            SparaTillXml("poddar.xml");
        }
    }

    private void SparaPoddarTillXml(List<AvsnittRepository> poddar)
    {
        try
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);

            XmlElement root = doc.CreateElement("Podcasts");
            doc.AppendChild(root);

            foreach (var podd in poddar)
            {
                XmlElement poddElement = doc.CreateElement("Podd");

                XmlElement namn = doc.CreateElement("Namn");
                namn.InnerText = podd.GetNamn();
                poddElement.AppendChild(namn);

                XmlElement kategori = doc.CreateElement("Kategori");
                kategori.InnerText = podd.GetKategori();
                poddElement.AppendChild(kategori);

                // Lägg till andra nödvändiga element här
                // Till exempel URL, uppdateringsfrekvens etc.

                root.AppendChild(poddElement);
            }

            doc.Save("poddar.xml");
        }
        catch (Exception ex)
        {
            
        }
    }
    //Läser in poddar och deras avsnitt från en XML-fil och återställr dem till programmet.
    public async Task LaddaFranXml(string filnamn)
    {
        if (!File.Exists(filnamn))
        {
            return;
        }

        XmlDocument doc = new XmlDocument();
        await Task.Run(() => doc.Load(filnamn)); //Ladda xml dokument asynkront

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
	



