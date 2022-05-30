using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CoachDTO
    {
        private int coachId;
        private string firstname;
        private string lastname;

        public int GetCoachId()
        {
            return coachId;
        }
        public string GetFirstname()
        {
            return firstname; 
        }

        public string GetLastname()
        {
            return lastname; 
        }

        public CoachDTO(int coachId, string firstname, string lastname)
        {
            this.coachId = coachId;
            this.firstname = firstname;
            this.lastname = lastname;
        }
    }
}
