using System.Collections.Generic;
using Models;

namespace DL
{
    public class AvsnittRepository
    {
        private List<Avsnitt> avsnittLista = new List<Avsnitt>();
        
            public void LaggTillAvsnitt(Avsnitt avsnitt)
            {
                avsnittLista.Add(avsnitt);
            }
            public List<Avsnitt> HamtaAllaAvsnitt()
            {
                return avsnittLista;
            }
            }
            //Den här klassen ska ha metoder för att hämta och sätta värden, samt skapa våran lista
        }

