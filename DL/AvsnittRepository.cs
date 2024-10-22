using System.Collections.Generic;
using Models;

namespace DL
{
    public class AvsnittRepository
    {
        private string? repositoryLank;
        private string? repositoryTitle;
        private string? repositoryKategori;
        private List<Avsnitt> avsnittLista = new List<Avsnitt>();
        
        public void LaggTillAvsnitt(Avsnitt avsnitt)
        {
            avsnittLista.Add(avsnitt);
        }
        public List<Avsnitt> HamtaAllaAvsnitt()
        {
            return avsnittLista;
        }
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

