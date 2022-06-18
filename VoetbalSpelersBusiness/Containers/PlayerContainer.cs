using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class PlayerContainer
    {
        private IStatsData statsData;
        public PlayerContainer(IStatsData statsData)
        {
            this.statsData = statsData;
        }

        public Stats GetStatsById(Player player)
        {
            StatsDTO data = statsData.GetStatsByPlayerId(player.Id);
            if (data is not null)
            {
                Stats temp = new Stats(data.GetPlayerId(), data.GetGoals(), data.GetAssists(), data.GetInjury(), data.GetKeeperClean(), data.GetYellow(), data.GetRed(), data.GetPenalHeld(),
                data.GetPenalCreated(), data.GetTraining(), data.GetCaused());
                return temp;
            }
            else
            {
                Stats temp = new Stats(0, 0, 0, false, 0, 0, 0, 0, 0, 0, 0);
                return temp;
            }
        }
    }
}
