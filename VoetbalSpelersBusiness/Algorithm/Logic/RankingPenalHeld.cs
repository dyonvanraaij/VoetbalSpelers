﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class RankingPenalHeld : IRankingStats
    {
        public double Run(Stats stats, Player player)
        {
            switch (player.Position)
            {
                case "keeper":
                    player.Ranking_number += stats.Penal_held * 1.5;
                    break;
                default:
                    break;
            }
            return player.Ranking_number;
        }
    }
}
