
namespace VoetbalSpelers
{
    partial class AddStats
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
            this.playerName = new System.Windows.Forms.TextBox();
            this.goBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerName
            // 
            this.playerName.Enabled = false;
            this.playerName.Location = new System.Drawing.Point(140, 76);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(243, 22);
            this.playerName.TabIndex = 0;
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(307, 132);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 1;
            this.goBack.Text = "Back";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // AddStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 221);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.playerName);
            this.Name = "AddStats";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Button goBack;
    }
}