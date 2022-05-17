using Dal.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public interface IPlayer
    {
        public string Firstname { get; }
        public string Lastname { get; }
        object Teamname { get; }
        public Stats GetStatsById(int id);
        public StatsDTO AddStats(Stats stats);
        public StatsDTO UpdateStats(Stats stats);
    }
}
