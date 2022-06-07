using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmPenal
    {
        [Test]
        public void PenalHeldKeeper()
        {
            Player player = new(1, "firstname", "lastname", "keeper", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 3, 10, 100, 10);
            IRankingStats algorithm = new RankingPenalHeld();
            algorithm.Run(stats, player);

            Assert.AreEqual(104.5, player.Ranking_number);
        }

        [Test]
        public void PenalCreatedKeeper()
        {
            Player player = new(1, "firstname", "lastname", "keeper", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 5, 100, 10);
            IRankingStats algorithm = new RankingPenalCreated();
            algorithm.Run(stats, player);

            Assert.AreEqual(96.25, player.Ranking_number);
        }

        [Test]
        public void PenalCreatedDefend()
        {
            Player player = new(1, "firstname", "lastname", "defend", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 5, 100, 10);
            IRankingStats algorithm = new RankingPenalCreated();
            algorithm.Run(stats, player);

            Assert.AreEqual(98, player.Ranking_number);
        }

    }
}