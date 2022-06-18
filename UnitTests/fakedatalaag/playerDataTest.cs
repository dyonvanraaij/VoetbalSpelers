using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class playerDataTest : IPlayerData
    {
        public List<PlayerDTO> GetPlayersByTeamId(int id)
        {
            List<PlayerDTO> playerList = new();
            playerList.Add(new PlayerDTO { Id = 1, Firstname = "voornaam", Lastname = "laaste", Position = "attack", Teamname = 1 });
            playerList.Add(new PlayerDTO { Id = 2, Firstname = "voornaam", Lastname = "laaste", Position = "attack", Teamname = 1 });
            return playerList;
        }
        public PlayerDTO GetPlayerById(int id)
        {
            List<PlayerDTO> playerList = new();
            playerList.Add(new PlayerDTO { Id = 1, Firstname = "voornaam", Lastname = "laaste", Position = "attack", Teamname = 1 });
            playerList.Add(new PlayerDTO { Id = 2, Firstname = "voornaam2", Lastname = "laaste2", Position = "attack2", Teamname = 2 });
            playerList.Add(new PlayerDTO { Id = 3, Firstname = "voornaam3", Lastname = "laaste3", Position = "attack3", Teamname = 3 });

            PlayerDTO result = null;
            foreach(PlayerDTO player in playerList)
            {
                if(player.Id == id)
                {
                    result = player;
                }
            }

            return result;
        }
        public PlayerDTO CreatePlayer(PlayerDTO player)
        {
            return player;
        }
    }
}
