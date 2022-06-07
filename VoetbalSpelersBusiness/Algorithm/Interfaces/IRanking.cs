using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public interface IRanking
    {
        public List<Player> GetRankedList(int teamId);
    }
}
