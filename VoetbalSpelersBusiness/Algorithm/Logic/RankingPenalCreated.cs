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
                    player.Ranking_number -= stats.PenalCreated * 0.75;
                    break;
                case "defend":
                    player.Ranking_number -= stats.PenalCreated * 0.4;
                    break;
                default:
                    break;
            }
            return player.Ranking_number;
        }
    }
}
