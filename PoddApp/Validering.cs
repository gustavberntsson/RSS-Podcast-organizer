using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp
{
   
        public static class Validering
        {
            public static bool KollaURL(string url)
            {
                // Kollar så URL är i korrekt format
                return Uri.TryCreate(url, UriKind.Absolute, out var uriResult) &&
                       (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            }

            public static bool KollaKategori(string category)
            {
            // Kollar så kategori inte är null eller tom
            return !string.IsNullOrEmpty(category);
            }

            public static bool KollaUniktNamn(List<AvsnittRepository> podcasts, string podcastName)
            {
                // Kollar så namnet på flödet är unikt
                return !podcasts.Any(p => p.GetNamn() == podcastName);
            }

            public static bool KollaUnikKategori(ListBox.ObjectCollection categories, string category)
            {
                // Kollar så kategori är unik
                return !categories.Contains(category);
            }

            public static bool KollaTextruta(string text)
            {
                // Kollar så textruta ej är tom
                return !string.IsNullOrWhiteSpace(text);
            }

        public static bool IsSelectedIndexValid(int index)
        {
            // Kontrollera om ett giltigt index är valt i en lista
            return index >= 0;
        }

        public static bool IsObjectNotNull(object obj)
        {
            // Kontrollera att ett objekt inte är null
            return obj != null;
        }

        public static bool KollaKategoriAnvändning(List<AvsnittRepository> allaPoddar, string kategori)
        {
            // Kontrollera om någon podcast använder den angivna kategorin
            var poddarMedKategori = allaPoddar.Where(p => p.GetKategori() == kategori).ToList();
            return poddarMedKategori.Count > 0;
        }
    }
    }
