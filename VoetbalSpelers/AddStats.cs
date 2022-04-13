using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoetbalSpelers
{
    public partial class AddStats : Form
    {
        public AddStats(Player player)
        {
            InitializeComponent();
            playerInformation(player);
            checkPositionForInputs(player);
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {

            bool injury_input = bool.Parse(injury.Text);
            int player_id = Int32.Parse(id_placeholder.Text);
            int yellow_input = Int32.Parse(yellow_carts.Text);
            int red_input = Int32.Parse(red_carts.Text);
            int training_input = Int32.Parse(training_commitment.Text);
            int goals_input = Int32.Parse(goals_scored.Text);
            int assists_input = Int32.Parse(assists.Text);
            int caused_input = Int32.Parse(caused_offside.Text);
            int keeper_clean_input = Int32.Parse(keeper_clean.Text);
            int penal_created_input = Int32.Parse(penal_created.Text);
            int penal_held_input = Int32.Parse(penal_held.Text);

            Stats stats = new Stats(player_id, goals_input, assists_input, injury_input, keeper_clean_input, yellow_input, 
                red_input, penal_held_input, penal_created_input, training_input, caused_input);
            insert_or_update_stats(stats);
        }
        private void playerInformation(Player player)
        {
            id_placeholder.Text = player.Id.ToString();
            name_placeholder.Text = player.Firstname + " " + player.Lastname;
            position_placeholder.Text = player.Position;
            teamname_placeholder.Text = player.Teamname;
        }

        private void checkPositionForInputs(Player player)
        {
            switch (player.Position)
            {
                case "keeper":
                    goals_scored.Enabled = false;
                    assists.Enabled = false;
                    caused_offside.Enabled = false;
                    break;
                case "defend":
                    penal_held.Enabled = false;
                    keeper_clean.Enabled = false;
                    break;
                case "midfield":
                    penal_held.Enabled = false;
                    keeper_clean.Enabled = false;
                    penal_created.Enabled = false;
                    break;
                case "attack":
                    penal_held.Enabled = false;
                    keeper_clean.Enabled = false;
                    penal_created.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void insert_or_update_stats(Stats stats)
        {
            try
            {
                // Injury werkt niet blijft false
                Database db = new Database();
                bool exists = db.DoesStatsExistsById(stats.Player_id);

                if (exists.ToString() == "True")
                {
                    try
                    {
                        Database dbase = new Database();
                        dbase.UpdateStats(stats);
                        this.Close();
                        MessageBox.Show("Statestieken zijn geupdate");
                    }
                    catch (Exception ex) { MessageBox.Show("Error info: " + ex.Message); }
            }
                else
            {
                Database dbase = new Database();
                dbase.AddStats(stats);
                this.Close();
                MessageBox.Show("Statestieken toegevoegd");
            }
        }
            catch (Exception ex) { MessageBox.Show("Error info: " + ex.Message); }
                this.Close();
            }
    }
}
