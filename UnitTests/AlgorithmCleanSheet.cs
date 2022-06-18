using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmCleanSheet
    {
        [Test]
        public void CleansheetKeeper()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "keeper", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingCleanSheet();
            algorithm.Run(stats, player);

            Assert.AreEqual(105, player.Ranking_number);
        }

        [Test]
        public void CleansheetAttacker()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "attack", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingCleanSheet();
            algorithm.Run(stats, player);

            Assert.AreEqual(100, player.Ranking_number);
        }

    }
}