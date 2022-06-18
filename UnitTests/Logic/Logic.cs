using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class Logic
    {
        public Team team;
        [Test]
        public void GetAllCoachesTest()
        {
            playerDataTest playerdata = new();
            coachDataTest coachdata = new();
            teamDataTest teamdata = new();

            Club logic = new Club(teamdata, playerdata, coachdata, team);

            List<Coach> coaches = logic.GetCoaches();

            Assert.AreEqual(2, coaches.Count);

        }

        [Test]
        public void GetAllTeamsTest()
        {
            playerDataTest playerdata = new();
            coachDataTest coachdata = new();
            teamDataTest teamdata = new();

            Club logic = new Club(teamdata, playerdata, coachdata, team);

            List<Team> teams = logic.GetTeams();

            Assert.AreEqual(3, teams.Count);

        }

        [Test]
        public void GetPlayersByTeamIdTest()
        {
            playerDataTest playerdata = new();

            TeamContainer teamContainer = new(playerdata);

            Team team = new Team { Id=1 };
            List<Player> players = teamContainer.GetPlayersByTeamId(team);

            Assert.AreEqual(2, players.Count);

        }

        [Test]
        public void GetPlayerByIdTest()
        {

            playerDataTest playerdata = new();
            coachDataTest coachdata = new();
            teamDataTest teamdata = new();

            Club logic = new Club(teamdata, playerdata, coachdata, team);

            Player player = new Player { Id = 2 };
            Player playerSelected = logic.GetPlayerById(player);

            Assert.AreEqual("voornaam2", playerSelected.Firstname);
        }

        [Test]
        public void GetTeamById()
        { 
            playerDataTest playerdata = new();
            coachDataTest coachdata = new();
            teamDataTest teamdata = new();

            Club logic = new Club(teamdata, playerdata, coachdata, team);

            team = new Team { Id = 2 };
            Team selectedTeam = logic.GetTeamById(team);

            Assert.AreEqual("test2", selectedTeam.Teamname);
        }
    }
}