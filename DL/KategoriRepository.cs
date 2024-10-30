using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public class KategoriRepository : IRepository
    {
        private List<Kategori> kategorier = new List<Kategori>();

        public void LaggTillKategori(Kategori kategori) => kategorier.Add(kategori);
        public List<Kategori> HamtaAllaKategorier() => kategorier;
        public Kategori HittaKategori(string namn) => kategorier.FirstOrDefault(k => k.Namn == namn);

        // Metoder för Avsnitt, behöver inte implementeras, så alla värden returneras tomma där applicerbart
        public void LaggTillAvsnitt(Avsnitt avsnitt) { }
        public List<Avsnitt> HamtaAllaAvsnitt() => new List<Avsnitt>(); // Returnera tom lista
        public void SetNamn(string namn) { }
        public string GetNamn() => ""; // Returnera tom sträng
        public void SetLank(string lank) { }
        public string GetLank() => ""; // Returnera tom sträng
        public void SetKategori(Kategori kategori) { }
        public string GetKategori() => ""; // Returnera tom sträng
    }
}
