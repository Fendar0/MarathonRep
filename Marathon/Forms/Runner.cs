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
    public partial class Runner : Form
    {
        Marathon_SkillsDataSet.RunnersCountryDataTable dataRunners; 
        Marathon_SkillsDataSet.RunnersCountryRow rowRunner;		


        public Runner()
        {
            InitializeComponent();
        }

        private void Runner_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataRunners = this.runnersCountryTableAdapter.GetData();
            rowRunner = dataRunners.FindByIDRunner(Total.idUser);
            if (rowRunner == null)
            {
                MessageBox.Show("У Вас не заполнен профиль."
                    + Environment.NewLine + "Надо его заполнить для дальнейшей работы");
                RunnerProfile frp = new RunnerProfile("Addition");
                this.Hide();
                frp.ShowDialog();
                this.Show();
            }
            else if (rowRunner != null)
            {
                MessageBox.Show("У Вас заполнен профиль."
                                    + Environment.NewLine + "Можете работат в системе");
                RunnerProfile frp = new RunnerProfile("ViewEdit");
                this.Hide();
                frp.ShowDialog();
                this.Show();
            }
        }

        private void btMySponsor_Click(object sender, EventArgs e)
        {
            RunnersMySponsors rms = new RunnersMySponsors();
            Hide();
            rms.ShowDialog();
            Show();

        }
    }
}
