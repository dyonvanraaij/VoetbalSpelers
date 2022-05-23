using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmCommitment
    {
        [Test]
        public void TrainingCommitment()
        {
            Player player = new(1, "firstname", "lastname", "attack", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingTraining();
            algorithm.Run(stats, player);

            Assert.AreEqual(10, stats.Ranking_number);
        }
    }
}