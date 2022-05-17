using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public interface IClub
    {
        public List<Team> GetTeams();
        public Team Create(Team team);
        public Team GetTeamById(int id);
        public Coach CreateCoach(Coach coach);
    }
}
