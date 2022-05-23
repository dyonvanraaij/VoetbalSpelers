using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class RankingInjury : IRankingStats
    {
        public double Run(Stats stats, Player player)
        {
            if (stats.Injury == true)
            {
                return stats.Ranking_number = -1000;
            } else
            {
                return stats.Ranking_number = 0;
            }
        
        }
    }
}