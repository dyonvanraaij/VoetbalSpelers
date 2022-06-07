using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class Ranking : IRanking
    {
        public List<Player> GetRankedList(int teamId)
        {
            IClub club = new Club("Ijfc");
            ITeam team = club.GetTeamById(teamId);
            List<Player> players = team.GetPlayersByTeamId(teamId);
            List<Stats> stats = new List<Stats>();
            foreach(Player player in players)
            {
                IPlayer speler = new Player(player.Id, player.Firstname, player.Lastname, player.Position, player.Teamname);
                stats.Add(speler.GetStatsById(player.Id));
            }

            // Rank players with interfaces
            List<Player> rankedPlayers = RankPlayers(players, stats);

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
                    if (player.Id.Equals(items.Player_id))
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
