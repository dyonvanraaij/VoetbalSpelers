using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class Ranking : IRanking
    {
        public List<Stats> GetRankedList(List<Stats> stats, List<Player> player)
        {
            return stats;
        }
    }
}
