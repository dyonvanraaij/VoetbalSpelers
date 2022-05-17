using Dal;
using Dal.Dto;
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

        object IPlayer.Teamname => throw new NotImplementedException();

        public Player(int id, string firstname, string lastname, string position, int teamname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.position = position;
            this.teamname = teamname;
        }
        public Stats GetStatsById(int id)
        {
            StatsDTO data = new StatsData().GetStatsByPlayerId(id);
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
            StatsDTO add = new StatsData().AddStats(statsDTO);
            return add;
        }

        public StatsDTO UpdateStats(Stats stats)
        {
            StatsDTO statsDTO = new(stats.Player_id, stats.Goals, stats.Assists, stats.Injury, stats.Keeper_clean, stats.Yellow, stats.Red, stats.Penal_held, stats.Penal_created,
                stats.Training, stats.Caused);
            StatsDTO add = new StatsData().UpdateStats(statsDTO);
            return add;
        }
    }

}
