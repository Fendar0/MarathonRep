namespace Marathon
{
    partial class FormResultsMarathon
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
            this.btBack = new System.Windows.Forms.Button();
            this.btFixed = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ordersMarathonTableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.OrdersMarathonTableAdapter();
            this.typeDistanceTableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.TypeDistanceTableAdapter();
            this.resultsMarathonTableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.ResultsMarathonTableAdapter();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(595, 310);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(189, 43);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // btFixed
            // 
            this.btFixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFixed.Location = new System.Drawing.Point(595, 241);
            this.btFixed.Name = "btFixed";
            this.btFixed.Size = new System.Drawing.Size(189, 63);
            this.btFixed.TabIndex = 1;
            this.btFixed.Text = "Зафиксировать результаты";
            this.btFixed.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(577, 341);
            this.tabControl.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(595, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // ordersMarathonTableAdapter1
            // 
            this.ordersMarathonTableAdapter1.ClearBeforeFill = true;
            // 
            // typeDistanceTableAdapter1
            // 
            this.typeDistanceTableAdapter1.ClearBeforeFill = true;
            // 
            // resultsMarathonTableAdapter1
            // 
            this.resultsMarathonTableAdapter1.ClearBeforeFill = true;
            // 
            // FormResultsMarathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 358);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btFixed);
            this.Controls.Add(this.btBack);
            this.Name = "FormResultsMarathon";
            this.Text = "Результаты";
            this.Load += new System.EventHandler(this.FormResultsMarathon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btFixed;
        private System.Windows.Forms.TabControl tabControl;
        private Marathon_SkillsDataSetTableAdapters.OrdersMarathonTableAdapter ordersMarathonTableAdapter1;
        private Marathon_SkillsDataSetTableAdapters.TypeDistanceTableAdapter typeDistanceTableAdapter1;
        private Marathon_SkillsDataSetTableAdapters.ResultsMarathonTableAdapter resultsMarathonTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}