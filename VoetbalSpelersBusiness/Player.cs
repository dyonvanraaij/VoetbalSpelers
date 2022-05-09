using Dal;
using Dal.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class Player
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
    }

}
