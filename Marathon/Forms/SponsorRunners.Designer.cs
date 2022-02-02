namespace Marathon
{
    partial class SponsorRunners
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btMinusAmount = new System.Windows.Forms.Button();
            this.btPlusAmount = new System.Windows.Forms.Button();
            this.btSponsering = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbTotalSum = new System.Windows.Forms.TextBox();
            this.tbTotalCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanelRunners1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.runnerSponsorTableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.RunnerSponsorTableAdapter();
            this.sponsorsTableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.SponsorsTableAdapter();
            this.runnersTableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.RunnersTableAdapter();
            this.runners1TableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.Runners1TableAdapter();
            this.runnersCountryTableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.RunnersCountryTableAdapter();
            this.runnersOdSponsorsTableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.RunnersOdSponsorsTableAdapter();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Runner sponsor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select runner";
            // 
            // cbSelect
            // 
            this.cbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(315, 47);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(250, 32);
            this.cbSelect.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sponsored amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAmount.Location = new System.Drawing.Point(315, 101);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.ReadOnly = true;
            this.tbAmount.Size = new System.Drawing.Size(250, 29);
            this.tbAmount.TabIndex = 7;
            // 
            // btMinusAmount
            // 
            this.btMinusAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMinusAmount.Location = new System.Drawing.Point(477, 148);
            this.btMinusAmount.Name = "btMinusAmount";
            this.btMinusAmount.Size = new System.Drawing.Size(88, 33);
            this.btMinusAmount.TabIndex = 9;
            this.btMinusAmount.Text = "-100$";
            this.btMinusAmount.UseVisualStyleBackColor = true;
            this.btMinusAmount.Click += new System.EventHandler(this.btMinusAmount_Click);
            // 
            // btPlusAmount
            // 
            this.btPlusAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPlusAmount.Location = new System.Drawing.Point(342, 148);
            this.btPlusAmount.Name = "btPlusAmount";
            this.btPlusAmount.Size = new System.Drawing.Size(88, 33);
            this.btPlusAmount.TabIndex = 10;
            this.btPlusAmount.Text = "+100$";
            this.btPlusAmount.UseVisualStyleBackColor = true;
            this.btPlusAmount.Click += new System.EventHandler(this.btPlusAmount_Click);
            // 
            // btSponsering
            // 
            this.btSponsering.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSponsering.Location = new System.Drawing.Point(241, 317);
            this.btSponsering.Name = "btSponsering";
            this.btSponsering.Size = new System.Drawing.Size(223, 41);
            this.btSponsering.TabIndex = 11;
            this.btSponsering.Text = "Runner sponsering";
            this.btSponsering.UseVisualStyleBackColor = true;
            this.btSponsering.Click += new System.EventHandler(this.btSponsering_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back to sponsor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTotalSum
            // 
            this.tbTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTotalSum.Location = new System.Drawing.Point(315, 197);
            this.tbTotalSum.Name = "tbTotalSum";
            this.tbTotalSum.ReadOnly = true;
            this.tbTotalSum.Size = new System.Drawing.Size(250, 29);
            this.tbTotalSum.TabIndex = 13;
            // 
            // tbTotalCount
            // 
            this.tbTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTotalCount.Location = new System.Drawing.Point(315, 263);
            this.tbTotalCount.Name = "tbTotalCount";
            this.tbTotalCount.ReadOnly = true;
            this.tbTotalCount.Size = new System.Drawing.Size(250, 29);
            this.tbTotalCount.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Total sponsorship fees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Number of sponsored runners";
            // 
            // flowLayoutPanelRunners1
            // 
            this.flowLayoutPanelRunners1.Location = new System.Drawing.Point(572, 82);
            this.flowLayoutPanelRunners1.Name = "flowLayoutPanelRunners1";
            this.flowLayoutPanelRunners1.Size = new System.Drawing.Size(353, 276);
            this.flowLayoutPanelRunners1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(627, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Your sponsored runners";
            // 
            // runnerSponsorTableAdapter1
            // 
            this.runnerSponsorTableAdapter1.ClearBeforeFill = true;
            // 
            // sponsorsTableAdapter1
            // 
            this.sponsorsTableAdapter1.ClearBeforeFill = true;
            // 
            // runnersTableAdapter1
            // 
            this.runnersTableAdapter1.ClearBeforeFill = true;
            // 
            // runners1TableAdapter1
            // 
            this.runners1TableAdapter1.ClearBeforeFill = true;
            // 
            // runnersCountryTableAdapter1
            // 
            this.runnersCountryTableAdapter1.ClearBeforeFill = true;
            // 
            // runnersOdSponsorsTableAdapter1
            // 
            this.runnersOdSponsorsTableAdapter1.ClearBeforeFill = true;
            // 
            // SponsorRunners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 370);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flowLayoutPanelRunners1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTotalCount);
            this.Controls.Add(this.tbTotalSum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSponsering);
            this.Controls.Add(this.btPlusAmount);
            this.Controls.Add(this.btMinusAmount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SponsorRunners";
            this.Text = "SponsorRunners";
            this.Load += new System.EventHandler(this.SponsorRunners_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button btMinusAmount;
        private System.Windows.Forms.Button btPlusAmount;
        private System.Windows.Forms.Button btSponsering;
        private System.Windows.Forms.Button button1;
        private Marathon_SkillsDataSetTableAdapters.RunnerSponsorTableAdapter runnerSponsorTableAdapter1;
        private Marathon_SkillsDataSetTableAdapters.SponsorsTableAdapter sponsorsTableAdapter1;
        private Marathon_SkillsDataSetTableAdapters.RunnersTableAdapter runnersTableAdapter1;
        private Marathon_SkillsDataSetTableAdapters.Runners1TableAdapter runners1TableAdapter1;
        private System.Windows.Forms.TextBox tbTotalSum;
        private System.Windows.Forms.TextBox tbTotalCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRunners1;
        private System.Windows.Forms.Label label6;
        private Marathon_SkillsDataSetTableAdapters.RunnersCountryTableAdapter runnersCountryTableAdapter1;
        private Marathon_SkillsDataSetTableAdapters.RunnersOdSponsorsTableAdapter runnersOdSponsorsTableAdapter1;
    }
}