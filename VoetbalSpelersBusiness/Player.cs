using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class Player
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
        public int Teamname { get; set; }
        public double Ranking_number { get; set; }

        //public Player(int id, string firstname, string lastname, string position, int teamname, double ranking_number = 100)
        //{
        //    this.id = id;
        //    this.firstname = firstname;
        //    this.lastname = lastname;
        //    this.position = position;
        //    this.teamname = teamname;
        //    this.ranking_number = ranking_number;
        //}
        public Stats GetStatsById(Player player)
        {
            IStatsData statsInterface = new StatsData();
            StatsDTO data = statsInterface.GetStatsByPlayerId(player.Id);
            if (data is not null)
            {
                Stats temp = new Stats(data.GetPlayerId(), data.GetGoals(), data.GetAssists(), data.GetInjury(), data.GetKeeperClean(), data.GetYellow(), data.GetRed(), data.GetPenalHeld(),
                data.GetPenalCreated(), data.GetTraining(), data.GetCaused());
                return temp;
            } else
            {
                Stats temp = new Stats(0, 0, 0, false, 0, 0, 0, 0, 0, 0, 0);
                return temp;
            }
        }
    }

}
