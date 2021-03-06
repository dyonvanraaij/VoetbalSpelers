using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IStatsData
    {
        public StatsDTO GetStatsByPlayerId(int player_id);
        public StatsDTO AddStats(StatsDTO stats);
        public StatsDTO UpdateStats(StatsDTO stats);
    }
}
