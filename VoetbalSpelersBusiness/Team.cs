using System.Collections.Generic;
using Dal;

namespace VoetbalSpelersBusiness
{
    public class Team : ITeam
    {
        private int id;
        private string teamname;
        private int coachId;
        public List<Player> players = new List<Player>();
        public List<Player> GetPlayersByTeamId(int id) { return players; }

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
            set { CoachId = value; }
            get { return coachId; }
        }
        public Team(int id, string teamname, int coachId)
        {
            this.id = id;
            this.teamname = teamname;
            this.coachId = coachId;

            IPlayerData playerInterface = new PlayerData();
            List<PlayerDTO> data = playerInterface.GetPlayersByTeamId(id);
            foreach (PlayerDTO PlayerData in data)
            {
                players.Add(new Player(PlayerData.GetId(), PlayerData.GetFirstname(), PlayerData.GetLastname(), PlayerData.GetPosition(), PlayerData.GetTeamname()));
            }
        }

        public Player CreatePlayer(Player speler)
        {
            PlayerDTO data = new(speler.Id, speler.Firstname, speler.Lastname, speler.Position, speler.Teamname);
            IPlayerData playerInterface = new PlayerData();
            playerInterface.CreatePlayer(data);
            return speler;
        }
    }
}
