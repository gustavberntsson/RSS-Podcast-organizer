using System.Collections.Generic;
using Models;

namespace DL
{
    public class AvsnittRepository
    {
        //Privata variabler för att lagra länkar, namn och kategori av podcasten.
        private string? repositoryLank;
        private string? repositoryTitle;
        private KategoriRepository kategoriRepo = new KategoriRepository();
        private List<Avsnitt> avsnittLista = new List<Avsnitt>();

        //Metoder för att lägga till avsnitt och hämta alla avsnitt.
        public void LaggTillAvsnitt(Avsnitt avsnitt) => avsnittLista.Add(avsnitt);
        public List<Avsnitt> HamtaAllaAvsnitt() => avsnittLista;

        //Getter och Setters för att hantera namnet, kategorin och länken av podcasten.
        public void SetNamn(string namn) => repositoryTitle = namn;
        public string GetNamn() => repositoryTitle;

        public void SetLank(string lank) => repositoryLank = lank;
        public string GetLank() => repositoryLank;

        public void SetKategori(Kategori kategori) => kategoriRepo.LaggTillKategori(kategori);
        public string GetKategori() => kategoriRepo.HamtaAllaKategorier().FirstOrDefault()?.Namn;
}


}

