using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IPlayerData
    {
        public List<PlayerDTO> GetPlayersByTeamId(int id);
        public PlayerDTO GetPlayerById(int id);
        public PlayerDTO CreatePlayer(PlayerDTO player);
    }
}
