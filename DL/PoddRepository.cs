using System.Collections.Generic;
using Models;

namespace DL
{
    public class PoddRepository
    {
        private List<Podcast> poddLista = new List<Podcast>();
        
            public void LaggTillPoddar(Podcast podd)
            {
                poddLista.Add(podd);
            }
            public List<Podcast> HamtaAllaPoddar()
            {
                return poddLista;
            }
            }
            //Den här klassen ska ha metoder för att hämta och sätta värden, samt skapa våran lista
        }

