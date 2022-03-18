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
                    listBox.Items.Add(st.Firstname + " " + st.Lastname + ", " + st.Position);
                }
            }
            int count = listBox.Items.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                if (listBox.Items[i].ToString() == " ")
                {
                    listBox.Items.RemoveAt(i);
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
                string position = position_input.Text;
                string teamname = teamname_input.Text;

                if (firstname == "" || lastname == "" || position == "")
                {
                    MessageBox.Show("Vul alle velden in");
                }
                else
                {
                    Database db = new Database();
                    Player player = new Player(firstname, lastname, position, teamname);
                    db.AddPlayer(player);
                    listBox.Items.Add(player.Firstname + " " + player.Lastname + ", " + player.Position);
                    firstname_input.Text = "";
                    lastname_input.Text = "";
                    position_input.Text = "";
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
            string item = listBox.SelectedItem.ToString();
            AddStats f2 = new AddStats(item);
            f2.Show();
            //this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
