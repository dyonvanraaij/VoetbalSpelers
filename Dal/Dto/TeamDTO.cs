using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class TeamDTO
    {
        private int id;
        private string teamname;
        private int coachId;

        public int GetId()
        {
            return id;
        }
        public string GetTeamname()
        {
            return teamname; 
        }
        public int GetCoachId()
        {
            return coachId; 
        }
        public TeamDTO(int id, string teamname, int coachId)
        {
            this.id = id;
            this.teamname = teamname;
            this.coachId = coachId;
        }
    }
}
