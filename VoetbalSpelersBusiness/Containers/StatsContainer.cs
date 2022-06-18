using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class StatsContainer
    {
        private IStatsData statsData;
        private Player player;
        public StatsContainer(IStatsData statsData, Player player)
        {
            this.statsData = statsData;
            this.player = player;
        }

        public void AddOrUpdateStats(Stats stats)
        {
            player.Id = stats.PlayerId;

            Stats oldStats = player.GetStatsById(player);
            if (oldStats.PlayerId == 0)
            {
                AddStats(stats);
            }
            else
            {
                stats.Goals += oldStats.Goals;
                stats.Assists += oldStats.Assists;
                stats.KeeperClean += oldStats.KeeperClean;
                stats.Yellow += oldStats.Yellow;
                stats.Red += oldStats.Red;
                stats.PenalHeld += oldStats.PenalHeld;
                stats.PenalCreated += oldStats.PenalCreated;
                stats.Caused += oldStats.Caused;
                Stats updatedStats = new(stats.PlayerId, stats.Goals, stats.Assists, stats.Injury, stats.KeeperClean, stats.Yellow,
                    stats.Red, stats.PenalHeld, stats.PenalCreated, stats.Training, stats.Caused);
                UpdateStats(updatedStats);
            }
        }

        public void AddStats(Stats stats)
        {
            StatsDTO statsDTO = new(stats.PlayerId, stats.Goals, stats.Assists, stats.Injury, stats.KeeperClean, stats.Yellow, stats.Red, stats.PenalHeld, stats.PenalCreated,
                stats.Training, stats.Caused);
            statsData.AddStats(statsDTO);
        }

        public void UpdateStats(Stats stats)
        {
            StatsDTO statsDTO = new(stats.PlayerId, stats.Goals, stats.Assists, stats.Injury, stats.KeeperClean, stats.Yellow, stats.Red, stats.PenalHeld, stats.PenalCreated,
                stats.Training, stats.Caused);
            statsData.UpdateStats(statsDTO);
        }
    }
}
