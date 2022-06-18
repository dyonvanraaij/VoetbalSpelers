using NUnit.Framework;
using VoetbalSpelersBusiness;

namespace UnitTests
{
    public class AlgorithmInjury
    {
        [Test]
        public void InjuryTrue()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "attack", Teamname = 1, Ranking_number=100 };
            Stats stats = new(1, 0, 0, true, 0, 0, 0, 0, 0, 0, 0);
            IRankingStats algorithm = new RankingInjury();
            algorithm.Run(stats, player);

            Assert.AreEqual(-1000, player.Ranking_number);
        }

        [Test]
        public void InjuryFalse()
        {
            var player = new Player { Id = 1, Firstname = "firstname", Lastname = "lastname", Position = "attack", Teamname = 1, Ranking_number = 100 };
            Stats stats = new(1, 0, 0, false, 0, 0, 0, 0, 0, 0, 0);
            IRankingStats algorithm = new RankingInjury();
            algorithm.Run(stats, player);

            Assert.AreEqual(100, player.Ranking_number);
        }
    }
}