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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            List<Player> spelers;
            Database db = new Database();
            if (db.IsConnect())
            {
                spelers = db.GetSpelers();
                foreach (var st in spelers)
                {
                    listBox.Items.Add(st.Firstname + "," + st.Lastname + "," + st.Position);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void addPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = firstname_input.Text;
                string lastname = lastname_input.Text;
                string position = position_inputbox.Text.ToString();
                string teamname = teamname_input.Text;

                if (firstname == "" || lastname == "" || position == "")
                {
                    MessageBox.Show("Vul alle velden correct in");
                }
                else
                {
                    Database db = new Database();
                    db.AddPlayer(firstname, lastname, position, teamname);
                    listBox.Items.Add(firstname + "," + lastname + "," + position);
                    firstname_input.Text = "";
                    lastname_input.Text = "";
                    position_inputbox.Text = "";
                    teamname_input.Text = "";
                    MessageBox.Show("Speler toegevoegd");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error info: " + ex.Message);
            }
        }

        private void add_stats_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if (db.IsConnect())
            {
                string item = listBox.SelectedItem.ToString();
                string[] words = item.Split(',');
                Player player = db.GetPlayerFromNameAndPosition(words[0], words[1], words[2]);

                AddStats f3 = new AddStats(player);
                f3.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
