using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ITeamData
    {
        public List<TeamDTO> GetTeams();
        public TeamDTO GetTeamById(int id);
        public TeamDTO GetTeamByPlayerId(int id);
        public void Create(TeamDTO team);
        public void Edit(TeamDTO teamDTO);
    }
}
