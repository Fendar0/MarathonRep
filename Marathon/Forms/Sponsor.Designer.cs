
namespace Marathon
{
    partial class Sponsor
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
            this.btProfile = new System.Windows.Forms.Button();
            this.sponsorsTableAdapter = new Marathon.Marathon_SkillsDataSetTableAdapters.SponsorsTableAdapter();
            this.usersTableAdapter = new Marathon.Marathon_SkillsDataSetTableAdapters.UsersTableAdapter();
            this.btSponsering = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btProfile
            // 
            this.btProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btProfile.Location = new System.Drawing.Point(12, 12);
            this.btProfile.Name = "btProfile";
            this.btProfile.Size = new System.Drawing.Size(177, 41);
            this.btProfile.TabIndex = 1;
            this.btProfile.Text = "Profile";
            this.btProfile.UseVisualStyleBackColor = true;
            this.btProfile.Click += new System.EventHandler(this.btProfile_Click);
            // 
            // sponsorsTableAdapter
            // 
            this.sponsorsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // btSponsering
            // 
            this.btSponsering.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSponsering.Location = new System.Drawing.Point(12, 71);
            this.btSponsering.Name = "btSponsering";
            this.btSponsering.Size = new System.Drawing.Size(177, 41);
            this.btSponsering.TabIndex = 2;
            this.btSponsering.Text = "To sponsor";
            this.btSponsering.UseVisualStyleBackColor = true;
            this.btSponsering.Click += new System.EventHandler(this.btSponsering_Click);
            // 
            // Sponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSponsering);
            this.Controls.Add(this.btProfile);
            this.Name = "Sponsor";
            this.Text = "Form_Sponsor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btProfile;
        private Marathon_SkillsDataSetTableAdapters.SponsorsTableAdapter sponsorsTableAdapter;
        private Marathon_SkillsDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button btSponsering;
    }
}