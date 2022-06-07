using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class RankingGoals : IRankingStats
    {
        public double Run(Stats stats, Player player)
        {
            switch (player.Position)
            {
                case "attack":
                    player.Ranking_number += stats.Goals * 1.5;
                    break;
                case "midfield":
                    player.Ranking_number += stats.Goals * 1.25;
                    break;
                case "defend":
                    player.Ranking_number += stats.Goals;
                    break;
                default:
                    break;
            }
            return player.Ranking_number;
        }
    }
}
