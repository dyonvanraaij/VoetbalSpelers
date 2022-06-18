using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmPenal
    {
        [Test]
        public void PenalHeldKeeper()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "keeper", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 3, 10, 100, 10);
            IRankingStats algorithm = new RankingPenalHeld();
            algorithm.Run(stats, player);

            Assert.AreEqual(104.5, player.Ranking_number);
        }

        [Test]
        public void PenalCreatedKeeper()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "keeper", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 5, 100, 10);
            IRankingStats algorithm = new RankingPenalCreated();
            algorithm.Run(stats, player);

            Assert.AreEqual(96.25, player.Ranking_number);
        }

        [Test]
        public void PenalCreatedDefend()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "defend", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 5, 100, 10);
            IRankingStats algorithm = new RankingPenalCreated();
            algorithm.Run(stats, player);

            Assert.AreEqual(98, player.Ranking_number);
        }

    }
}