using System.Collections.Generic;
using Dal;
using Dal.Dto;

namespace VoetbalSpelersBusiness
{
    public class Team
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
            get { return coachId; }
        }
        public Team(int id, string teamname, int coachId)
        {
            this.id = id;
            this.teamname = teamname;
            this.coachId = coachId;
         
           List<PlayerDTO> data = new PlayerData().GetPlayersByTeamId(id);
           foreach (PlayerDTO PlayerData in data)
           {
                players.Add(new Player(PlayerData.GetId(), PlayerData.GetFirstname(), PlayerData.GetLastname(), PlayerData.GetPosition(), PlayerData.GetTeamname()));
           }           
        }

        public Player GetPlayerById(int id)
        {
            PlayerDTO data = new PlayerData().GetPlayerById(id);
            Player player = new(data.GetId(), data.GetFirstname(), data.GetLastname(), data.GetPosition(), data.GetTeamname());
            return player;
        }

        public Player AddPlayer(Player speler)
        {
            PlayerDTO data = new(speler.Id, speler.Firstname, speler.Lastname, speler.Position, speler.Teamname);
            new PlayerData().CreatePlayer(data);
            return speler;
        }
    }
}
