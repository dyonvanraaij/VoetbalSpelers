using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class TeamDTO
    {
        public int Id { get; set; }
        public string Teamname { get; set; }
        public int CoachId { get; set; }

        //public TeamDTO(int Id, string Teamname, int CoachId)
        //{
        //    this.Id = Id;
        //    this.Teamname = Teamname;
        //    this.CoachId = CoachId;
        //}
    }
}
