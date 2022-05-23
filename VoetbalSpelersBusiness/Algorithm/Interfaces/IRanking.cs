using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    interface IRanking
    {
        public List<Stats> GetRankedList(List<Stats> stats, List<Player> player);
    }
}
