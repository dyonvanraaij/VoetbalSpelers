using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class Team
    {
        private int id;
        private string teamname;
        private int coachId;

        public int Id
        {
            get { return id; }
        }
        public string Teamname
        {
            set { Teamname = value; }
            get { return teamname; }
        }
        public int CoachId
        {
            get { return coachId; }
        }
        public Team(int id, string teamname, int coachId)
        {
            this.id = id;
            this.teamname = teamname;
            this.coachId = coachId;
        }
        public List<Team> teams
        {
            get { return teams; }
        }

    }
}
