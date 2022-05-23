using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class RankingRedCarts : IRankingStats
    {
        public double Run(Stats stats, Player player)
        {
            stats.Ranking_number -= stats.Red;
            return stats.Ranking_number;
        }
    }
}
