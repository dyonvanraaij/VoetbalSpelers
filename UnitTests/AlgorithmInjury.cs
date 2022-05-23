using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmInjury
    {
        [Test]
        public void InjuryTrue()
        {
            Player player = new(1, "firstname", "lastname", "attack", 1);
            Stats stats = new(1, 0, 0, true, 0, 0, 0, 0, 0, 0, 0);
            IRankingStats algorithm = new RankingInjury();
            algorithm.Run(stats, player);

            Assert.AreEqual(-1000, stats.Ranking_number);
        }

        [Test]
        public void InjuryFalse()
        {
            Player player = new(1, "firstname", "lastname", "attack", 1);
            Stats stats = new(1, 0, 0, false, 0, 0, 0, 0, 0, 0, 0);
            IRankingStats algorithm = new RankingInjury();
            algorithm.Run(stats, player);

            Assert.AreEqual(0, stats.Ranking_number);
        }
    }
}