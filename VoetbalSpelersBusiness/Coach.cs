using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class Coach
    {
        private int coachId;
        private string firstname;
        private string lastname;

        public int CoachId
        {
            set { CoachId = value; }
            get { return coachId; }
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

        public Coach(int coachId, string firstname, string lastname)
        {
            this.coachId = coachId;
            this.firstname = firstname;
            this.lastname = lastname;
        }
    }
}
