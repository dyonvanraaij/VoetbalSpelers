using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmCarts
    {
        [Test]
        public void YellowCart()
        {
            Player player = new(1, "firstname", "lastname", "keeper", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingYellowCarts();
            algorithm.Run(stats, player);

            Assert.AreEqual(-5, stats.Ranking_number);
        }

        [Test]
        public void RedCart()
        {
            Player player = new(1, "firstname", "lastname", "attack", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingRedCarts();
            algorithm.Run(stats, player);

            Assert.AreEqual(-10, stats.Ranking_number);
        }

    }
}