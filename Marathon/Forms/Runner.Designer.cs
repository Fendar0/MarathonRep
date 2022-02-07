
namespace Marathon
{
    partial class Runner
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
            this.button1 = new System.Windows.Forms.Button();
            this.runnersCountryTableAdapter = new Marathon.Marathon_SkillsDataSetTableAdapters.RunnersCountryTableAdapter();
            this.btMySponsor = new System.Windows.Forms.Button();
            this.btSignUp = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Профиль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // runnersCountryTableAdapter
            // 
            this.runnersCountryTableAdapter.ClearBeforeFill = true;
            // 
            // btMySponsor
            // 
            this.btMySponsor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMySponsor.Location = new System.Drawing.Point(12, 59);
            this.btMySponsor.Name = "btMySponsor";
            this.btMySponsor.Size = new System.Drawing.Size(221, 41);
            this.btMySponsor.TabIndex = 1;
            this.btMySponsor.Text = "Мои спонсоры";
            this.btMySponsor.UseVisualStyleBackColor = true;
            this.btMySponsor.Click += new System.EventHandler(this.btMySponsor_Click);
            // 
            // btSignUp
            // 
            this.btSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSignUp.Location = new System.Drawing.Point(12, 106);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(221, 47);
            this.btSignUp.TabIndex = 2;
            this.btSignUp.Text = "Запись на марафон";
            this.btSignUp.UseVisualStyleBackColor = true;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(12, 212);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(221, 47);
            this.btBack.TabIndex = 3;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Результаты марафона";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Runner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 273);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.btMySponsor);
            this.Controls.Add(this.button1);
            this.Name = "Runner";
            this.Text = "Бегун";
            this.Load += new System.EventHandler(this.Runner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Marathon_SkillsDataSetTableAdapters.RunnersCountryTableAdapter runnersCountryTableAdapter1;
        private Marathon_SkillsDataSetTableAdapters.RunnersCountryTableAdapter runnersCountryTableAdapter;
        private System.Windows.Forms.Button btMySponsor;
        private System.Windows.Forms.Button btSignUp;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button button2;
    }
}