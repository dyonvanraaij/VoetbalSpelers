using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmCarts
    {

        [Test]
        public void YellowCart()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "keeper", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingYellowCarts();
            algorithm.Run(stats, player);

            Assert.AreEqual(95, player.Ranking_number);
        }

        [Test]
        public void RedCart()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "attack", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingRedCarts();
            algorithm.Run(stats, player);

            Assert.AreEqual(90, player.Ranking_number);
        }

    }
}