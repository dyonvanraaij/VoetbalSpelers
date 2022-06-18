using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class RankingCleanSheet : IRankingStats
    {
        public double Run(Stats stats, Player player)
        {
            switch (player.Position)
            {
                case "keeper":
                    player.Ranking_number += stats.KeeperClean * 0.5;
                    break;
                default:
                    break;
            }
            return player.Ranking_number;
        }
    }
}
