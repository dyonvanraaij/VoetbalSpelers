using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class teamDataTest : ITeamData
    {
        public List<TeamDTO> GetTeams()
        {
            List<TeamDTO> teamsList = new List<TeamDTO>();
            teamsList.Add(new TeamDTO { Id=1, Teamname="test1", CoachId=1});
            teamsList.Add(new TeamDTO { Id=2, Teamname="test2", CoachId=1});
            teamsList.Add(new TeamDTO { Id=3, Teamname="test3", CoachId=2});
            return teamsList;
        }

        public TeamDTO GetTeamById(int id)
        {
            List<TeamDTO> teamsList = GetTeams();
            TeamDTO teamSelected = new();
            foreach (TeamDTO team in teamsList)
            {
                if (team.Id == id)
                {
                    teamSelected.Id = team.Id;
                    teamSelected.Teamname = team.Teamname;
                    teamSelected.CoachId = team.CoachId;
                }
            }
            return teamSelected;
        }

        public TeamDTO GetTeamByPlayerId(int id)
        {
            TeamDTO teamSelected = new();
            
            return teamSelected;
        }

        public void Create(TeamDTO team)
        {
            
        }

        public void Edit(TeamDTO team)
        {          
        }
    }
}
