using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class Player : IPlayer
    {
        private int id;
        private string firstname;
        private string lastname;
        private string position;
        private int teamname;
        private double ranking_number;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Firstname
        {
            set { firstname = value; }
            get { return firstname; }
        }

        public string Lastname
        {
            set { lastname = value; }
            get { return lastname; }
        }

        public string Position
        {
            set { position = value; }
            get { return position; }
        }
        public int Teamname
        {
            set { teamname = value; }
            get { return teamname; }
        }

        public double Ranking_number
        {
            set { ranking_number = value; }
            get { return ranking_number; }
        }
        object IPlayer.Teamname => throw new NotImplementedException();

        public Player(int id, string firstname, string lastname, string position, int teamname, double ranking_number = 100)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.position = position;
            this.teamname = teamname;
            this.ranking_number = ranking_number;
        }
        public Stats GetStatsById(int id)
        {
            IStatsData statsInterface = new StatsData();
            StatsDTO data = statsInterface.GetStatsByPlayerId(id);
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
        public StatsDTO AddStats(Stats stats)
        {
            StatsDTO statsDTO = new(stats.Player_id, stats.Goals, stats.Assists, stats.Injury, stats.Keeper_clean, stats.Yellow, stats.Red, stats.Penal_held, stats.Penal_created,
                stats.Training, stats.Caused);
            IStatsData statsInterface = new StatsData();
            StatsDTO add = statsInterface.AddStats(statsDTO);
            return add;
        }

        public StatsDTO UpdateStats(Stats stats)
        {
            StatsDTO statsDTO = new(stats.Player_id, stats.Goals, stats.Assists, stats.Injury, stats.Keeper_clean, stats.Yellow, stats.Red, stats.Penal_held, stats.Penal_created,
                stats.Training, stats.Caused);
            IStatsData statsInterface = new StatsData();
            StatsDTO add = statsInterface.UpdateStats(statsDTO);
            return add;
        }
    }

}
