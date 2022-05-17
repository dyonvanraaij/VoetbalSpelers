using Dal;
using Dal.Data;
using Dal.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class Club : IClub
    {
        private string name;
        public List<Team> teams = new List<Team>();

        public Club(string name)
        {
            this.name = name;
            
        }
        public List<Team> GetTeams()
        {
            List<TeamDTO> data = new TeamData().GetTeams();
            foreach (TeamDTO TeamData in data)
            {
                teams.Add(new Team(TeamData.GetId(), TeamData.GetTeamname(), TeamData.GetCoachId()));
            }
            return teams;
        }

        public Team Create(Team team)
        {
            TeamDTO teamDTO = new(team.Id, team.Teamname, team.CoachId);
            new TeamData().Create(teamDTO);
            return team;
        }

        public Team GetTeamById(int id)
        {
            TeamDTO teamDTO = new TeamData().GetTeamById(id);
            Team team = new(teamDTO.GetId(), teamDTO.GetTeamname(), teamDTO.GetCoachId());
            return team;
        }

        public Coach CreateCoach(Coach coach)
        {
            CoachDTO coachDTO = new(coach.CoachId, coach.Firstname, coach.Lastname);
            new CoachData().CreateCoach(coachDTO);
            return coach;
        }
    }
}
