namespace Marathon
{
    partial class RunnersMySponsors
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
            this.btExit = new System.Windows.Forms.Button();
            this.flowLayoutPanelSponsors = new System.Windows.Forms.FlowLayoutPanel();
            this.tbTotalSum = new System.Windows.Forms.TextBox();
            this.tbTotalSponsor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.runnerSponsorTableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.RunnerSponsorTableAdapter();
            this.runnersOdSponsorsTableAdapter2 = new Marathon.Marathon_SkillsDataSetTableAdapters.RunnersOdSponsorsTableAdapter();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Location = new System.Drawing.Point(356, 316);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(140, 62);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelSponsors
            // 
            this.flowLayoutPanelSponsors.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelSponsors.Name = "flowLayoutPanelSponsors";
            this.flowLayoutPanelSponsors.Size = new System.Drawing.Size(484, 298);
            this.flowLayoutPanelSponsors.TabIndex = 2;
            // 
            // tbTotalSum
            // 
            this.tbTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTotalSum.Location = new System.Drawing.Point(174, 316);
            this.tbTotalSum.Name = "tbTotalSum";
            this.tbTotalSum.Size = new System.Drawing.Size(176, 29);
            this.tbTotalSum.TabIndex = 3;
            // 
            // tbTotalSponsor
            // 
            this.tbTotalSponsor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTotalSponsor.Location = new System.Drawing.Point(174, 351);
            this.tbTotalSponsor.Name = "tbTotalSponsor";
            this.tbTotalSponsor.Size = new System.Drawing.Size(176, 29);
            this.tbTotalSponsor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total funding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount sponsors";
            // 
            // runnerSponsorTableAdapter1
            // 
            this.runnerSponsorTableAdapter1.ClearBeforeFill = true;
            // 
            // runnersOdSponsorsTableAdapter2
            // 
            this.runnersOdSponsorsTableAdapter2.ClearBeforeFill = true;
            // 
            // RunnersMySponsors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotalSponsor);
            this.Controls.Add(this.tbTotalSum);
            this.Controls.Add(this.flowLayoutPanelSponsors);
            this.Controls.Add(this.btExit);
            this.Name = "RunnersMySponsors";
            this.Text = "RunnersMySponsors";
            this.Load += new System.EventHandler(this.RunnersMySponsors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSponsors;
        private System.Windows.Forms.TextBox tbTotalSum;
        private System.Windows.Forms.TextBox tbTotalSponsor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Marathon_SkillsDataSetTableAdapters.RunnerSponsorTableAdapter runnerSponsorTableAdapter1;
        private Marathon_SkillsDataSetTableAdapters.RunnersOdSponsorsTableAdapter runnersOdSponsorsTableAdapter2;
    }
}