using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmCommitment
    {
        [Test]
        public void TrainingCommitment()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "attack", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingTraining();
            algorithm.Run(stats, player);

            Assert.AreEqual(110, player.Ranking_number);
        }
    }
}