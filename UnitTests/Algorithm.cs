using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class Algorithm
    {

        private Player playerContext;
        private Team team;
        private TeamContainer teamContainer;
        [Test]
        public void FullAlgorithm()
        {
            List<Player> players = new List<Player>();
            players.Add(new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "keeper", Teamname = 1, Ranking_number = 100 });
            //players.Add(new Player(2, "test2", "test2", "keeper", 1));

            List<Stats> stats = new List<Stats>();
            stats.Add(new Stats(1,0,0,false,2,0,0,1,1,100,0));
            //stats.Add(new Stats(1,0,0,true,2,0,0,1,1,100,0));
            Ranking ranking = new Ranking((Player) playerContext, (TeamContainer) teamContainer, (Team)team);
            ranking.RankPlayers(players, stats);

            foreach(Player playertemp in players)
            {
                Assert.AreEqual(111.75, playertemp.Ranking_number);
            }
        }

        [Test]
        public void AlgorithmOrder()
        {
            List<Player> players = new List<Player>();
            players.Add(new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "keeper", Teamname = 1, Ranking_number = 100 });
            players.Add(new Player { Id = 2, Firstname = "firstname2", Lastname = "lastname2", Position = "keeper", Teamname = 1, Ranking_number = 100 });

            List<Stats> stats = new List<Stats>();
            stats.Add(new Stats(2, 0, 0, false, 2, 0, 0, 1, 1, 100, 0));
            stats.Add(new Stats(1, 0, 0, true, 2, 0, 0, 1, 1, 100, 0));

            Ranking ranking = new Ranking((Player)playerContext, (TeamContainer)teamContainer, (Team)team);

            ranking.RankPlayers(players, stats);
            List<Player> rankedList = ranking.SortRankedPlayers(players);

            var first = rankedList.First();

            Assert.AreEqual(111.75, first.Ranking_number);

        }
    }
}