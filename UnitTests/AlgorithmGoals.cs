using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmGoals
    {
        [Test]
        public void GoalsAttack()
        {
            Player player = new(1, "firstname", "lastname", "attack", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingGoals();
            algorithm.Run(stats, player);

            Assert.AreEqual(15, stats.Ranking_number);
        }

        [Test]
        public void GoalsMidfield()
        {
            Player player = new(1, "firstname", "lastname", "midfield", 1);
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingGoals();
            algorithm.Run(stats, player);

            Assert.AreEqual(12.5, stats.Ranking_number);
        }
    }
}