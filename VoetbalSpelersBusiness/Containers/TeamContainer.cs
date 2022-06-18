using System.Collections.Generic;
using Dal;

namespace VoetbalSpelersBusiness
{
    public class TeamContainer
    {
        public List<Player> players = new List<Player>();
        public List<Team> teams = new List<Team>();

        public IPlayerData playerData;

        public TeamContainer(IPlayerData playerData)
        {
            this.playerData = playerData;
        }

        public List<Player> GetPlayersByTeamId(Team team)
        {
            List<PlayerDTO> data = playerData.GetPlayersByTeamId(team.Id);
            foreach (PlayerDTO PlayerData in data)
            {
                Player speler = new();
                speler.Id = PlayerData.Id;
                speler.Firstname = PlayerData.Firstname;
                speler.Lastname = PlayerData.Lastname;
                speler.Position = PlayerData.Position;
                speler.Teamname = PlayerData.Teamname;
                players.Add(speler);
            }
            return players;
        }

        public Player CreatePlayer(Player speler)
        {
            PlayerDTO data = new();
            data.Id = speler.Id;
            data.Firstname = speler.Firstname;
            data.Lastname = speler.Lastname;
            data.Position = speler.Position;
            data.Teamname = speler.Teamname;
            playerData.CreatePlayer(data);
            return speler;
        }
    }
}
