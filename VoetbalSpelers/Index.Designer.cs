
namespace VoetbalSpelers
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.addPlayer = new System.Windows.Forms.Button();
            this.firstname_input = new System.Windows.Forms.TextBox();
            this.lastname_input = new System.Windows.Forms.TextBox();
            this.add_stats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamname_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.position_inputbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(454, 50);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(269, 324);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // addPlayer
            // 
            this.addPlayer.Location = new System.Drawing.Point(139, 181);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(75, 23);
            this.addPlayer.TabIndex = 1;
            this.addPlayer.Text = "Submit";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // firstname_input
            // 
            this.firstname_input.Location = new System.Drawing.Point(139, 51);
            this.firstname_input.Name = "firstname_input";
            this.firstname_input.Size = new System.Drawing.Size(100, 22);
            this.firstname_input.TabIndex = 2;
            // 
            // lastname_input
            // 
            this.lastname_input.Location = new System.Drawing.Point(139, 79);
            this.lastname_input.Name = "lastname_input";
            this.lastname_input.Size = new System.Drawing.Size(100, 22);
            this.lastname_input.TabIndex = 3;
            // 
            // add_stats
            // 
            this.add_stats.Location = new System.Drawing.Point(626, 393);
            this.add_stats.Name = "add_stats";
            this.add_stats.Size = new System.Drawing.Size(97, 23);
            this.add_stats.TabIndex = 4;
            this.add_stats.Text = "Add stats";
            this.add_stats.UseVisualStyleBackColor = true;
            this.add_stats.Click += new System.EventHandler(this.add_stats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "*Firstname:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "*Lastname:";
            // 
            // teamname_input
            // 
            this.teamname_input.Location = new System.Drawing.Point(139, 137);
            this.teamname_input.Name = "teamname_input";
            this.teamname_input.ReadOnly = true;
            this.teamname_input.Size = new System.Drawing.Size(100, 22);
            this.teamname_input.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "*Position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Teamname";
            // 
            // position_inputbox
            // 
            this.position_inputbox.FormattingEnabled = true;
            this.position_inputbox.Items.AddRange(new object[] {
            "keeper",
            "defend",
            "midfield",
            "attack"});
            this.position_inputbox.Location = new System.Drawing.Point(139, 108);
            this.position_inputbox.Name = "position_inputbox";
            this.position_inputbox.Size = new System.Drawing.Size(121, 24);
            this.position_inputbox.TabIndex = 11;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.position_inputbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teamname_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_stats);
            this.Controls.Add(this.lastname_input);
            this.Controls.Add(this.firstname_input);
            this.Controls.Add(this.addPlayer);
            this.Controls.Add(this.listBox);
            this.Name = "Index";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.TextBox firstname_input;
        private System.Windows.Forms.TextBox lastname_input;
        private System.Windows.Forms.Button add_stats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teamname_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox position_inputbox;
    }
}

