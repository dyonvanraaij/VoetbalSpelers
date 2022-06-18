using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmGoals
    {
        [Test]
        public void GoalsAttack()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "attack", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingGoals();
            algorithm.Run(stats, player);

            Assert.AreEqual(115, player.Ranking_number);
        }

        [Test]
        public void GoalsMidfield()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "midfield", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 10, 10, true, 10, 10, 10, 10, 10, 100, 10);
            IRankingStats algorithm = new RankingGoals();
            algorithm.Run(stats, player);

            Assert.AreEqual(112.5, player.Ranking_number);
        }
    }
}