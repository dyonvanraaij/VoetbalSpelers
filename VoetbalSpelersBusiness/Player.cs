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
        private string teamname;
        private string fullname;

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
        public string Teamname
        {
            set { teamname = value; }
            get { return teamname; }
        }

        public string FullName
        {
            set { fullname = value; }
            get { return fullname; }
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

        private string fullnameForListbox()
        {
            return (this.firstname + this.lastname + this.position);
        }

    }

}
