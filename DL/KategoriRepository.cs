using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public class KategoriRepository
    {
        private List<Kategori> kategorier = new List<Kategori>();

        public void LaggTillKategori(Kategori kategori) => kategorier.Add(kategori);

        public List<Kategori> HamtaAllaKategorier() => kategorier;

        public Kategori HittaKategori(string namn)
        {
            return kategorier.FirstOrDefault(k => k.Namn == namn);
        }
    }
}
