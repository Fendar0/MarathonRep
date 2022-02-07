namespace Marathon
{
    partial class FormRegInMarathon
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
            this.btRegister = new System.Windows.Forms.Button();
            this.lbYourWallet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbVznos = new System.Windows.Forms.Label();
            this.rbFull = new System.Windows.Forms.RadioButton();
            this.rbHalf = new System.Windows.Forms.RadioButton();
            this.rbLittle = new System.Windows.Forms.RadioButton();
            this.rbVarC = new System.Windows.Forms.RadioButton();
            this.rbVarB = new System.Windows.Forms.RadioButton();
            this.rbVarA = new System.Windows.Forms.RadioButton();
            this.ordersMarathonTableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.OrdersMarathonTableAdapter();
            this.runnersTableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.RunnersTableAdapter();
            this.lbRegWznos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBack.Location = new System.Drawing.Point(5, 253);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(200, 47);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btRegister
            // 
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRegister.Location = new System.Drawing.Point(435, 253);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(200, 47);
            this.btRegister.TabIndex = 5;
            this.btRegister.Text = "Регистрация";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // lbYourWallet
            // 
            this.lbYourWallet.AutoSize = true;
            this.lbYourWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYourWallet.Location = new System.Drawing.Point(5, 4);
            this.lbYourWallet.Name = "lbYourWallet";
            this.lbYourWallet.Size = new System.Drawing.Size(126, 24);
            this.lbYourWallet.TabIndex = 6;
            this.lbYourWallet.Text = "Ваш кошелек";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLittle);
            this.groupBox1.Controls.Add(this.rbHalf);
            this.groupBox1.Controls.Add(this.rbFull);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(5, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 165);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид марафона";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbVarC);
            this.groupBox2.Controls.Add(this.rbVarA);
            this.groupBox2.Controls.Add(this.rbVarB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(314, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 216);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Варианты комплектов";
            // 
            // lbVznos
            // 
            this.lbVznos.AutoSize = true;
            this.lbVznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVznos.Location = new System.Drawing.Point(1, 199);
            this.lbVznos.Name = "lbVznos";
            this.lbVznos.Size = new System.Drawing.Size(231, 24);
            this.lbVznos.TabIndex = 9;
            this.lbVznos.Text = "Регистрационный взнос";
            // 
            // rbFull
            // 
            this.rbFull.AutoSize = true;
            this.rbFull.Location = new System.Drawing.Point(6, 39);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(300, 28);
            this.rbFull.TabIndex = 10;
            this.rbFull.TabStop = true;
            this.rbFull.Text = "42 км Полный комплект ($ 145)";
            this.rbFull.UseVisualStyleBackColor = true;
            this.rbFull.CheckedChanged += new System.EventHandler(this.rbFull_CheckedChanged);
            // 
            // rbHalf
            // 
            this.rbHalf.AutoSize = true;
            this.rbHalf.Location = new System.Drawing.Point(6, 82);
            this.rbHalf.Name = "rbHalf";
            this.rbHalf.Size = new System.Drawing.Size(271, 28);
            this.rbHalf.TabIndex = 11;
            this.rbHalf.TabStop = true;
            this.rbHalf.Text = "21 км Полемараффон ($ 75)";
            this.rbHalf.UseVisualStyleBackColor = true;
            this.rbHalf.CheckedChanged += new System.EventHandler(this.rbHalf_CheckedChanged);
            // 
            // rbLittle
            // 
            this.rbLittle.AutoSize = true;
            this.rbLittle.Location = new System.Drawing.Point(6, 126);
            this.rbLittle.Name = "rbLittle";
            this.rbLittle.Size = new System.Drawing.Size(267, 28);
            this.rbLittle.TabIndex = 12;
            this.rbLittle.TabStop = true;
            this.rbLittle.Text = "5 км Малый марафон ($ 20)";
            this.rbLittle.UseVisualStyleBackColor = true;
            this.rbLittle.CheckedChanged += new System.EventHandler(this.rbLittle_CheckedChanged);
            // 
            // rbVarC
            // 
            this.rbVarC.AutoSize = true;
            this.rbVarC.Location = new System.Drawing.Point(6, 155);
            this.rbVarC.Name = "rbVarC";
            this.rbVarC.Size = new System.Drawing.Size(307, 52);
            this.rbVarC.TabIndex = 15;
            this.rbVarC.TabStop = true;
            this.rbVarC.Text = "Вариант С ($ 45) Варинт В+\r\nфутболка + сувенирный буклет";
            this.rbVarC.UseVisualStyleBackColor = true;
            this.rbVarC.CheckedChanged += new System.EventHandler(this.rbVarC_CheckedChanged);
            // 
            // rbVarB
            // 
            this.rbVarB.AutoSize = true;
            this.rbVarB.Location = new System.Drawing.Point(6, 97);
            this.rbVarB.Name = "rbVarB";
            this.rbVarB.Size = new System.Drawing.Size(292, 52);
            this.rbVarB.TabIndex = 14;
            this.rbVarB.TabStop = true;
            this.rbVarB.Text = "Вариант В ($ 20) Варивант А+\r\nбейсболка + бутылка воды";
            this.rbVarB.UseVisualStyleBackColor = true;
            this.rbVarB.CheckedChanged += new System.EventHandler(this.rbVarB_CheckedChanged);
            // 
            // rbVarA
            // 
            this.rbVarA.AutoSize = true;
            this.rbVarA.Location = new System.Drawing.Point(6, 39);
            this.rbVarA.Name = "rbVarA";
            this.rbVarA.Size = new System.Drawing.Size(293, 52);
            this.rbVarA.TabIndex = 13;
            this.rbVarA.TabStop = true;
            this.rbVarA.Text = "Вариант А ($ 0)\r\nномер бегуна + RFID бреслет";
            this.rbVarA.UseVisualStyleBackColor = true;
            this.rbVarA.CheckedChanged += new System.EventHandler(this.rbVarA_CheckedChanged);
            // 
            // ordersMarathonTableAdapter1
            // 
            this.ordersMarathonTableAdapter1.ClearBeforeFill = true;
            // 
            // runnersTableAdapter1
            // 
            this.runnersTableAdapter1.ClearBeforeFill = true;
            // 
            // lbRegWznos
            // 
            this.lbRegWznos.AutoSize = true;
            this.lbRegWznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRegWznos.Location = new System.Drawing.Point(5, 223);
            this.lbRegWznos.Name = "lbRegWznos";
            this.lbRegWznos.Size = new System.Drawing.Size(20, 24);
            this.lbRegWznos.TabIndex = 10;
            this.lbRegWznos.Text = "$";
            // 
            // FormRegInMarathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 309);
            this.Controls.Add(this.lbRegWznos);
            this.Controls.Add(this.lbVznos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbYourWallet);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btBack);
            this.Name = "FormRegInMarathon";
            this.Text = "Регистрация на марафон";
            this.Load += new System.EventHandler(this.FormRegInMarathon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label lbYourWallet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLittle;
        private System.Windows.Forms.RadioButton rbHalf;
        private System.Windows.Forms.RadioButton rbFull;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbVarC;
        private System.Windows.Forms.RadioButton rbVarA;
        private System.Windows.Forms.RadioButton rbVarB;
        private System.Windows.Forms.Label lbVznos;
        private Marathon_SkillsDataSetTableAdapters.OrdersMarathonTableAdapter ordersMarathonTableAdapter1;
        private Marathon_SkillsDataSetTableAdapters.RunnersTableAdapter runnersTableAdapter1;
        private System.Windows.Forms.Label lbRegWznos;
    }
}