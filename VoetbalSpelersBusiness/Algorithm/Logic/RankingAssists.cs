using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class RankingAssists : IRankingStats
    {
        public double Run(Stats stats, Player player)
        {
            switch (player.Position)
            {
                case "attack":
                    stats.Ranking_number += stats.Assists * 0.8;
                    break;
                case "midfield":
                    stats.Ranking_number += stats.Assists * 1.75;
                    break;
                case "defend":
                    stats.Ranking_number += stats.Assists * 0.5;
                    break;
                default:
                    break;
            }
            return stats.Ranking_number;
        }
    }
}
