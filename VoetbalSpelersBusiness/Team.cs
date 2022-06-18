using System.Collections.Generic;
using Dal;

namespace VoetbalSpelersBusiness
{
    public class Team
    {
        public int Id { set; get; }
        public string Teamname { set; get; }
        public int CoachId { set; get; }

        //public List<Player> players = new List<Player>();
        //public List<Team> teams = new List<Team>();

        //public ITeamData teamData;
        //public IPlayerData playerData;
        //public ICoachData coachData;

        //public Team(ITeamData teamData, IPlayerData playerData, ICoachData coachData)
        //{
        //    this.teamData = teamData;
        //    this.playerData = playerData;
        //    this.coachData = coachData;
        //}

        //public List<Player> GetPlayersByTeamId(int id)
        //{
        //    List<PlayerDTO> data = playerData.GetPlayersByTeamId(id);
        //    foreach (PlayerDTO PlayerData in data)
        //    {
        //        Player speler = new();
        //        speler.Id = PlayerData.Id;
        //        speler.Firstname = PlayerData.Firstname;
        //        speler.Lastname = PlayerData.Lastname;
        //        speler.Position = PlayerData.Position;
        //        speler.Teamname = PlayerData.Teamname;
        //        players.Add(speler);
        //    }
        //    return players;
        //}

        //public Player CreatePlayer(Player speler)
        //{
        //    PlayerDTO data = new();
        //    data.Id = speler.Id;
        //    data.Firstname = speler.Firstname;
        //    data.Lastname = speler.Lastname;
        //    data.Position = speler.Position;
        //    data.Teamname = speler.Teamname;
        //    playerData.CreatePlayer(data);
        //    return speler;
        //}
    }
}
