using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public interface ITeam
    {
        public int Id { get; }
        public string Teamname { get; }
        public List<Player> GetPlayersByTeamId(int id);
        public Player CreatePlayer(Player speler);

    }
}
