using Dal;
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
        public List<Coach> coaches = new List<Coach>();

        public Club(string name)
        {
            this.name = name;
            
        }
        public List<Team> GetTeams()
        {
            ITeamData teamInterface = new TeamData();
            List<TeamDTO> data = teamInterface.GetTeams();
            foreach (TeamDTO TeamData in data)
            {
                teams.Add(new Team(TeamData.GetId(), TeamData.GetTeamname(), TeamData.GetCoachId()));
            }
            return teams;
        }

        public Team Create(Team team)
        {
            TeamDTO teamDTO = new(team.Id, team.Teamname, team.CoachId);
            ITeamData teamInterface = new TeamData();
            teamInterface.Create(teamDTO);
            return team;
        }

        public Team GetTeamById(int id)
        {
            ITeamData teamInterface = new TeamData();
            TeamDTO teamDTO = teamInterface.GetTeamById(id);
            Team team = new(teamDTO.GetId(), teamDTO.GetTeamname(), teamDTO.GetCoachId());
            return team;
        }

        public Coach CreateCoach(Coach coach)
        {
            CoachDTO coachDTO = new(coach.CoachId, coach.Firstname, coach.Lastname);
            ICoachData coachInterface = new CoachData();
            coachInterface.CreateCoach(coachDTO);
            return coach;
        }
        public Player GetPlayerById(int id)
        {
            IPlayerData playerInterface = new PlayerData();
            PlayerDTO data = playerInterface.GetPlayerById(id);
            Player player = new(data.GetId(), data.GetFirstname(), data.GetLastname(), data.GetPosition(), data.GetTeamname());
            return player;
        }

        public List<Coach> GetCoaches()
        {
            ICoachData clubInterface = new CoachData();
            List<CoachDTO> data = clubInterface.GetCoaches();
            foreach (CoachDTO coachData in data)
            {
                coaches.Add(new Coach(coachData.GetCoachId(), coachData.GetFirstname(), coachData.GetLastname()));
            }
            return coaches;

        }

        public int GetTeamByPlayerId(int id)
        {
            ITeamData clubInterface = new TeamData();
            int teamId = clubInterface.GetTeamByPlayerId(id);
            int test = teamId;
            return teamId;
        }

        public Team Edit(Team team)
        {
            TeamDTO teamDTO = new(team.Id, team.Teamname, team.CoachId);
            ITeamData teamInterface = new TeamData();
            teamInterface.Edit(teamDTO);
            return team;
        }
    }
}
