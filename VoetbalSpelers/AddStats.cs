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
        public AddStats(string item)
        {
            InitializeComponent();
            playerName.Text = item;
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
