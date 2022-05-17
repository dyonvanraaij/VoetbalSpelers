using Dal;
using Dal.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalSpelersBusiness
{
    public class Stats
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

        public int Player_id
        {
            set { player_id = value; }
            get { return player_id; }
        }
        public bool Injury
        {
            get { return injury; }
        }
        public int Yellow
        {
            get { return yellow; }
        }
        public int Red
        {
            get { return red; }
        }

        public int Training
        {
            get { return training; }
        }
        public int Goals
        {
            get { return goals; }
        }
        public int Assists
        {
            get { return assists; }
        }
        public int Caused
        {
            get { return caused; }
        }
        public int Keeper_clean
        {
            get { return keeper_clean; }
        }
        public int Penal_held
        {
            get { return penal_held; }
        }
        public int Penal_created
        {
            get { return penal_created; }
        }
        public Stats(int player_id, int goals, int assists, bool injury, int keeper_clean, int yellow, int red, int penal_held,
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
