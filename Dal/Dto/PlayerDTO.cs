using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class PlayerDTO
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
        public int Teamname { get; set; }

        //public int GetId() { return Id; }
        //public string GetFirstname() { return Firstname; }
        //public string GetLastname() { return Lastname; }
        //public string GetPosition() { return Position; }
        //public int GetTeamname() { return Teamname; }

        //public PlayerDTO(int id, string firstname, string lastname, string position, int teamname)
        //{
        //    this.id = id;
        //    this.firstname = firstname;
        //    this.lastname = lastname;
        //    this.position = position;
        //    this.teamname = teamname;
        //}
    }
}
