using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class Club
    {
        public ITeamData teamData;
        public IPlayerData playerData;
        public ICoachData coachData;
        public Team teamContext;

        public List<Team> teams = new List<Team>();
        public List<Coach> coaches = new List<Coach>();

        public Club(ITeamData teamData, IPlayerData playerData, ICoachData coachData, Team teamContext)
        {
            this.teamData = teamData;
            this.playerData = playerData;
            this.coachData = coachData;
            this.teamContext = teamContext;
        }
        public List<Team> GetTeams()
        {
            List<TeamDTO> data = teamData.GetTeams();
            foreach (TeamDTO TeamData in data)
            {
                Team teamContext = new();
                teamContext.Id = TeamData.Id;
                teamContext.Teamname = TeamData.Teamname;
                teamContext.CoachId = TeamData.CoachId;
                teams.Add(teamContext);
            }
            return teams;
        }

        public void Create(Team team)
        {
            TeamDTO teamDTO = new();
            teamDTO.Id = team.Id;
            teamDTO.Teamname = team.Teamname;
            teamDTO.CoachId = team.CoachId;
            teamData.Create(teamDTO);
        }

        public Team GetTeamById(Team team)
        {
            TeamDTO teamDTO = teamData.GetTeamById(team.Id);
            Team teamContext = new();
            teamContext.Id = teamDTO.Id;
            teamContext.Teamname = teamDTO.Teamname;
            teamContext.CoachId = teamDTO.CoachId;

            return teamContext;
        }

        public void CreateCoach(Coach coach)
        {
            CoachDTO coachDTO = new();
            coachDTO.CoachId = coach.CoachId;
            coachDTO.Firstname = coach.Firstname;
            coachDTO.Lastname = coach.Lastname;
            coachData.CreateCoach(coachDTO);
        }
        public Player GetPlayerById(Player player)
        {
            PlayerDTO playerDTO = playerData.GetPlayerById(player.Id);
            Player speler = new();
            speler.Id = playerDTO.Id;
            speler.Firstname = playerDTO.Firstname;
            speler.Lastname = playerDTO.Lastname;
            speler.Position = playerDTO.Position;
            speler.Teamname = playerDTO.Teamname;

            return speler;
        }

        public List<Coach> GetCoaches()
        {
            List<CoachDTO> data = coachData.GetCoaches();
            foreach (CoachDTO coachData in data)
            {
                Coach coach = new();
                coach.CoachId = coachData.CoachId;
                coach.Firstname = coachData.Firstname;
                coach.Lastname = coachData.Lastname;
                coaches.Add(coach);
            }
            return coaches;

        }

        public Team GetTeamByPlayerId(Player player)
        {
            TeamDTO teamDto = teamData.GetTeamByPlayerId(player.Id);
            Team teamContext = new();
            teamContext.Id = teamDto.Id;
            teamContext.Teamname = teamDto.Teamname;
            teamContext.CoachId = teamDto.CoachId;

            return teamContext;
        }

        public void Edit(Team team)
        {
            TeamDTO teamDTO = new();
            teamDTO.Id = team.Id;
            teamDTO.Teamname = team.Teamname;
            teamDTO.CoachId = team.CoachId;
            teamData.Edit(teamDTO);
        }
    }
}
