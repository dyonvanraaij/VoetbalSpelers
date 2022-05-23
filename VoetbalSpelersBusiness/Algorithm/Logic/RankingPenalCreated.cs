using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class RankingPenalCreated : IRankingStats
    {
        public double Run(Stats stats, Player player)
        {
            switch (player.Position)
            {
                case "keeper":
                    stats.Ranking_number -= stats.Penal_created * 0.75;
                    break;
                case "defend":
                    stats.Ranking_number -= stats.Penal_created * 0.4;
                    break;
                default:
                    break;
            }
            return stats.Ranking_number;
        }
    }
}
