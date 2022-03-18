using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelers
{
    class Player
    {
        private string firstname;
        private string lastname;
        private string position;
        private string teamname;

        public string Firstname
        {
            get { return firstname; }
        }

        public string Lastname
        {
            get { return lastname; }
        }

        public string Position
        {
            get { return position; }
        }
        public string Teamname
        {
            get { return teamname; }
        }
        public Player(string firstname, string lastname, string position, string teamname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.position = position;
            this.teamname = teamname;
        }

        public List<Player> spelers
        {
            get { return spelers; }
        }

    }
}
