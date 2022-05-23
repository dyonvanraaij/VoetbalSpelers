using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public interface IRankingStats
    {
        public double Run(Stats stats, Player player);
    }
}
