using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class Stats
    {
        public int PlayerId { get; set; }
        public bool Injury { get; set; }
        public int Yellow { get; set; }
        public int Red { get; set; }
        public int Training { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Caused { get; set; }
        public int KeeperClean { get; set; }
        public int PenalCreated { get; set; }
        public int PenalHeld { get; set; }

        public Stats(int player_id, int goals, int assists, bool injury, int keeper_clean, int yellow, int red, int penal_held,
            int penal_created, int training, int caused)
        {
            PlayerId = player_id;
            Injury = injury;
            Yellow = yellow;
            Red = red;
            Training = training;
            Goals = goals;
            Assists = assists;
            Caused = caused;
            KeeperClean = keeper_clean;
            PenalHeld = penal_held;
            PenalCreated = penal_created;
        }
    }

}
