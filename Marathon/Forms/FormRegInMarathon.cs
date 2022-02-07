using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class FormRegInMarathon : Form
    {

        double summaTotal = 145, summaType = 145, summaSet = 0;
        int idTypeDistance = 1, idSet = 1;


        Marathon_SkillsDataSet.RunnersRow runner;


        public FormRegInMarathon()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbHalf_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbHalf.Checked)
            {
                summaType = 75;
                idTypeDistance = 2;
            }
            summaTotal = summaType + summaSet;
            this.lbYourWallet.Text = "Ваш кошелек $ " + summaTotal.ToString();

        }

        private void rbVarC_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbVarC.Checked)
            {
                summaSet = 45;
                idSet = 3;
            }
            summaTotal = summaType + summaSet;
            this.lbYourWallet.Text = "Ваш кошелек $ " + summaTotal.ToString();

        }

        private void rbLittle_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbLittle.Checked)
            {
                summaType = 20;
                idTypeDistance = 3;
            }
            summaTotal = summaType + summaSet;
            this.lbYourWallet.Text = "Ваш кошелек $ " + summaTotal.ToString();
        }

        private void rbFull_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbFull.Checked)
            {
                summaType = 145;
                idTypeDistance = 1;
            }
            summaTotal = summaType + summaSet;
            this.lbYourWallet.Text = "Ваш кошелек $ " + summaTotal.ToString();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if ((double)runner.Wallet >= summaTotal)
            {
                try
                {                    
                    ordersMarathonTableAdapter1.Insert(Total.idUser, idTypeDistance, idSet, 3, 0, 0);
                    runner.Wallet -= (decimal)summaTotal;
                    this.runnersTableAdapter1.Update(runner);
                    this.lbRegWznos.Text = "$ " + runner.Wallet.ToString();
                    MessageBox.Show("Вы успешно записаны на марафон");
                }
                catch
                {
                    MessageBox.Show("При записи на марафон возникли проблемы");
                }
            }
            else
            {
                MessageBox.Show("У Вас недостаточно средств для записи на марафон");
            }
        }



        private void rbVarA_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbVarA.Checked)
            {
                summaSet = 0;
                idSet = 1;
            }
            summaTotal = summaType + summaSet;
            this.lbYourWallet.Text = "Ваш кошелек $ " + summaTotal.ToString();

        }

        private void rbVarB_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbVarB.Checked)
            {
                summaSet = 20;
                idSet = 2;
            }
            summaTotal = summaType + summaSet;
            this.lbYourWallet.Text = "Ваш кошелек $ " + summaTotal.ToString();

        }


        private void FormRegInMarathon_Load(object sender, EventArgs e)
        {
            this.lbYourWallet.Text = "Ваш кошелек $ " + summaTotal.ToString();   
                                                                                  
            runner = this.runnersTableAdapter1.GetData().FindByIDRunner(Total.idUser);
            this.lbRegWznos.Text = "$ " + runner.Wallet.ToString();

        }
    }
}
