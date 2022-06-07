using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmCleanSheet
    {
        [Test]
        public void CleansheetKeeper()
        {
            Player player = new(1, "firstname", "lastname", "keeper", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingCleanSheet();
            algorithm.Run(stats, player);

            Assert.AreEqual(105, player.Ranking_number);
        }

        [Test]
        public void CleansheetAttacker()
        {
            Player player = new(1, "firstname", "lastname", "attack", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingCleanSheet();
            algorithm.Run(stats, player);

            Assert.AreEqual(100, player.Ranking_number);
        }

    }
}