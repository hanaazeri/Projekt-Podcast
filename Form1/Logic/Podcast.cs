using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektet.Logic
{
    public class Podcast
    {
        public string url { get; set; }
        public List<Episode> episodes { get; set; }

        public int numberOfEpisodes()
        {
            int numOfEpisodes = 0;
            foreach (var episode in episodes)
            {
                numOfEpisodes++;
            }
            return numOfEpisodes;
        }
    }

    
}
