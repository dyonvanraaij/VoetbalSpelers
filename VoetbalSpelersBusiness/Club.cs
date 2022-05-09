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
    public class Club
    {
        private string name;
        public List<Team> teams = new List<Team>();
        public List<Team> GetTeams() { return teams; }

        public Club(string name)
        {
            this.name = name;
            List<TeamDTO> data = new TeamData().GetTeams();
            foreach (TeamDTO TeamData in data)
            {
                teams.Add(new Team(TeamData.GetId(), TeamData.GetTeamname(), TeamData.GetCoachId()));
            }
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
