using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public interface IRepository
    {
        void LaggTillAvsnitt(Avsnitt avsnitt);
        List<Avsnitt> HamtaAllaAvsnitt();
        void SetNamn(string namn);
        string GetNamn();
        void SetLank(string lank);
        string GetLank();
        void SetKategori(Kategori kategori);
        string GetKategori();

        void LaggTillKategori(Kategori kategori);
        List<Kategori> HamtaAllaKategorier();
        Kategori HittaKategori(string namn);
    }
}
