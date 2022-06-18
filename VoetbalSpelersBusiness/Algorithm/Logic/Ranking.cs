using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class Ranking : IRanking
    {
        private Player playerContext;
        private TeamContainer teamContainer;
        private Team team;

        public Ranking(Player playerContext, TeamContainer teamContainer, Team team)
        {
            this.playerContext = playerContext;
            this.teamContainer = teamContainer;
            this.team = team;
        }
        public List<Player> GetRankedList(int teamId)
        {
            team.Id = teamId;
            List<Player> players = teamContainer.GetPlayersByTeamId(team);
            List<Player> spelers = new List<Player>();
            List<Stats> stats = new List<Stats>();
            foreach(Player player in players)
            {
                Player playertemp = new();
                playertemp.Id = player.Id;
                playertemp.Firstname = player.Firstname;
                playertemp.Lastname = player.Lastname;
                playertemp.Position = player.Position;
                playertemp.Teamname = player.Teamname;
                playertemp.Ranking_number = 100;
                spelers.Add(playertemp);
                stats.Add(playerContext.GetStatsById(player));
            }

            // Rank players with interfaces
            List<Player> rankedPlayers = RankPlayers(spelers, stats);

            //Sort players before return
            List<Player> SortedList = SortRankedPlayers(rankedPlayers);

            return SortedList;
        }

        public List<IRankingStats> GetInterfaces()
        {
            List<IRankingStats> rankingInterfaces = new List<IRankingStats>();
            rankingInterfaces.Add(new RankingInjury());
            rankingInterfaces.Add(new RankingGoals());
            rankingInterfaces.Add(new RankingAssists());
            rankingInterfaces.Add(new RankingYellowCarts());
            rankingInterfaces.Add(new RankingRedCarts());
            rankingInterfaces.Add(new RankingCausedOffside());
            rankingInterfaces.Add(new RankingCleanSheet());
            rankingInterfaces.Add(new RankingPenalCreated());
            rankingInterfaces.Add(new RankingPenalHeld());
            rankingInterfaces.Add(new RankingTraining());

            return rankingInterfaces;
        }

        public List<Player> SortRankedPlayers(List<Player> rankedPlayers)
        {
            List<Player> SortedList = rankedPlayers.OrderBy(o => o.Ranking_number).ToList();
            SortedList.Reverse();

            return SortedList;
        }

        public List<Player> RankPlayers(List<Player> players, List<Stats> stats)
        {
            List<Player> rankedPlayers = new List<Player>();
            List<IRankingStats> rankingInterfaces = GetInterfaces();

            foreach (Player player in players)
            {
                foreach (Stats items in stats)
                {
                    if (player.Id.Equals(items.PlayerId))
                    {
                        foreach (IRankingStats ranking in rankingInterfaces)
                        {
                            player.Ranking_number = ranking.Run(items, player);
                        }
                        rankedPlayers.Add(player);
                    }
                }
            }

            return rankedPlayers;
        }
    }
}
