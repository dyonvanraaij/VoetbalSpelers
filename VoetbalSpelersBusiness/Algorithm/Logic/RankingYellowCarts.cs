using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class RankingYellowCarts : IRankingStats
    {
        public double Run(Stats stats, Player player)
        {   
            stats.Ranking_number -= stats.Yellow * 0.5;
            return stats.Ranking_number;
        }
    }
}
