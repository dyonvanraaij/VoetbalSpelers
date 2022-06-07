using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class RankingTraining : IRankingStats
    {
        public double Run(Stats stats, Player player)
        {
            player.Ranking_number += stats.Training / 10;
            return player.Ranking_number;
        }
    }
}
