using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelers
{
    public class Player
    {
        private int id;
        private string firstname;
        private string lastname;
        private string position;
        private string teamname;

        public int Id
        {
            set { Id = value; }
            get { return id; }  
        }
        public string Firstname
        {
            set { Firstname = value; }
            get { return firstname; }
        }

        public string Lastname
        {
            set { Lastname = value; }
            get { return lastname; }
        }

        public string Position
        {
            set { Position = value; }
            get { return position; }
        }
        public string Teamname
        {
            set { Teamname = value; }
            get { return teamname; }
        }
        public Player(int id, string firstname, string lastname, string position, string teamname)
        {
            this.id = id;
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
