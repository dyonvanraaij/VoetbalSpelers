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
                    player.Ranking_number += stats.Assists * 0.8;
                    break;
                case "midfield":
                    player.Ranking_number += stats.Assists * 1.75;
                    break;
                case "defend":
                    player.Ranking_number += stats.Assists * 0.5;
                    break;
                default:
                    break;
            }
            return player.Ranking_number;
        }
    }
}
