using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmCausedOffside
    {
        [Test]
        public void OffsideAttack()
        {
            Player player = new(1, "firstname", "lastname", "attack", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingCausedOffside();
            algorithm.Run(stats, player);

            Assert.AreEqual(96, player.Ranking_number);
        }

        [Test]
        public void OffsideDefend()
        {
            Player player = new(1, "firstname", "lastname", "defend", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingCausedOffside();
            algorithm.Run(stats, player);

            Assert.AreEqual(99, player.Ranking_number);
        }

    }
}