using System.Collections.Generic;
using Models;

namespace DL
{
    public class AvsnittRepository
    {
        //Privata variabler för att lagra länkar, namn och kategori av podcasten.
        private string? repositoryLank;
        private string? repositoryTitle;
        private string? repositoryKategori;
        private List<Avsnitt> avsnittLista = new List<Avsnitt>();

        //Metoder för att lägga till avsnitt och hämta alla avsnitt.
        public void LaggTillAvsnitt(Avsnitt avsnitt)
        {
            avsnittLista.Add(avsnitt);
        }
        public List<Avsnitt> HamtaAllaAvsnitt()
        {
            return avsnittLista;
        }

        //Getter och Setters för att hantera namnet, kategorin och länken av podcasten.
        public string GetNamn()
        {
            return repositoryTitle;
        }
        public string GetKategori()
        {
            return repositoryKategori;
        }
        public void SetNamn(string repositorytitle)
        {
            repositoryTitle = repositorytitle;
        }

        public void SetKategori(string repositorykategori)
        {
            repositoryKategori = repositorykategori;
        }
        public string GetLank()
        {
            return repositoryLank;
        }
        public void SetLank(string repositorylank)
        {
            repositoryLank = repositorylank;
        }

    }


}

