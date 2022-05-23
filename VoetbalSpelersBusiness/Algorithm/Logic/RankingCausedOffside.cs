using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class RankingCausedOffside : IRankingStats
    {
        public double Run(Stats stats, Player player)
        {
            switch (player.Position)
            {
                case "defend":
                    stats.Ranking_number -= stats.Caused * 0.1;
                    break;
                case "midfield":
                    stats.Ranking_number -= stats.Caused * 0.25;
                    break;
                case "attack":
                    stats.Ranking_number -= stats.Caused * 0.4;
                    break;
                default:
                    break;
            }
            return stats.Ranking_number;
        }
    }
}
