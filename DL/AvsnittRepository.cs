using System.Collections.Generic;
using Models;

namespace DL
{
    public class AvsnittRepository : IRepository
    {
        private string? repositoryLank;
        private string? repositoryTitle;
        private List<Avsnitt> avsnittLista = new List<Avsnitt>();
        private Kategori kategori; // En kategori kan associeras med ett avsnitt

        public void LaggTillAvsnitt(Avsnitt avsnitt) => avsnittLista.Add(avsnitt);
        public List<Avsnitt> HamtaAllaAvsnitt() => avsnittLista;

        public void SetNamn(string namn) => repositoryTitle = namn;
        public string GetNamn() => repositoryTitle;

        public void SetLank(string lank) => repositoryLank = lank;
        public string GetLank() => repositoryLank;

        public void SetKategori(Kategori kategori) => this.kategori = kategori; // Spara en kategori
        public string GetKategori() => kategori?.Namn; // Returnera namnet på kategorin

        // Metoder relaterade till Kategori är tomma eftersom det tillhör interface IRepository
        public void LaggTillKategori(Kategori kategori) { }
        public List<Kategori> HamtaAllaKategorier() => new List<Kategori>();
        public Kategori HittaKategori(string namn) => null;
    }
}

