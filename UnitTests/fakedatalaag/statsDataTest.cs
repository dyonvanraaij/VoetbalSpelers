using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class statsDataTest : IStatsData
    {
        public StatsDTO GetStatsByPlayerId(int player_id)
        {
            StatsDTO stats = new(1,1,1,false,1,1,11,1,1,1,1);
            return stats; 
        }
        public StatsDTO AddStats(StatsDTO stats)
        {
            StatsDTO newStats = stats;
            return newStats;
        }
        public StatsDTO UpdateStats(StatsDTO stats)
        {
            StatsDTO updatedStats = stats;
            return updatedStats;
        }
    }
}
