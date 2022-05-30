using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class PlayerDTO
    {
        private int id;
        private string firstname;
        private string lastname;
        private string position;
        private int teamname;

        public int GetId() { return id; }
        public string GetFirstname() { return firstname; }
        public string GetLastname() { return lastname; }
        public string GetPosition() { return position; }
        public int GetTeamname() { return teamname; }

        public PlayerDTO(int id, string firstname, string lastname, string position, int teamname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.position = position;
            this.teamname = teamname;
        }
    }
}
