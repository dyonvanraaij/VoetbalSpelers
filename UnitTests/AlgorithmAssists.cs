using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmAssist
    {
        [Test]
        public void AssistsAttack()
        {
            Player player = new(1, "firstname", "lastname", "attack", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingAssists();
            algorithm.Run(stats, player);

            Assert.AreEqual(8, stats.Ranking_number);
        }

        [Test]
        public void AssistsMidfield()
        {
            Player player = new(1, "firstname", "lastname", "midfield", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingAssists();
            algorithm.Run(stats, player);

            Assert.AreEqual(17.5, stats.Ranking_number);
        }
    }
}