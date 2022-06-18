using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmCausedOffside
    {
        [Test]
        public void OffsideAttack()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "attack", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingCausedOffside();
            algorithm.Run(stats, player);

            Assert.AreEqual(96, player.Ranking_number);
        }

        [Test]
        public void OffsideDefend()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "defend", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingCausedOffside();
            algorithm.Run(stats, player);

            Assert.AreEqual(99, player.Ranking_number);
        }

    }
}