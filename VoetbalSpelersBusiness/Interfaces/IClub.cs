using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public interface IClub
    {
        public List<TeamContainer> GetTeams();
        public void Create(TeamContainer team);
        public TeamContainer GetTeamById(int id);
        public void CreateCoach(Coach coach);
        public Player GetPlayerById(int id);
        public List<Coach> GetCoaches();
        public int GetTeamByPlayerId(int id);
        public void Edit(TeamContainer team);
    }
}
