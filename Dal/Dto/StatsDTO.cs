using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Dto
{
    public class StatsDTO
    {
        private int player_id;
        private bool injury;
        private int yellow;
        private int red;
        private int training;
        private int goals;
        private int assists;
        private int caused;
        private int keeper_clean;
        private int penal_created;
        private int penal_held;

        public int GetPlayerId()
        {
            return player_id;
        }
        public bool GetInjury()
        {
            return injury; 
        }
        public int GetYellow()
        {
            return yellow;
        }
        public int GetRed()
        {
            return red;
        }
        public int GetTraining()
        {
            return training;
        }
        public int GetGoals()
        {
            return goals;
        }
        public int GetAssists()
        {
            return assists; 
        }
        public int GetCaused()
        {
            return caused; 
        }
        public int GetKeeperClean()
        {
            return keeper_clean; 
        }
        public int GetPenalHeld()
        {
            return penal_held; 
        }
        public int GetPenalCreated()
        {
            return penal_created; 
        }
        public StatsDTO(int player_id, int goals, int assists, bool injury, int keeper_clean, int yellow, int red, int penal_held,
            int penal_created, int training, int caused)
        {
            this.player_id = player_id;
            this.injury = injury;
            this.yellow = yellow;
            this.red = red;
            this.training = training;
            this.goals = goals;
            this.assists = assists;
            this.caused = caused;
            this.keeper_clean = keeper_clean;
            this.penal_held = penal_held;
            this.penal_created = penal_created;
        }
    }
}
