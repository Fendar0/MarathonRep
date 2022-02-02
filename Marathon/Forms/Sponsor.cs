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
    public partial class Sponsor : Form
    {

        Marathon_SkillsDataSet.SponsorsDataTable dataSponsors;
        Marathon_SkillsDataSet.SponsorsRow rowSponsor;

        public Sponsor()
        {
            InitializeComponent();
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            dataSponsors = this.sponsorsTableAdapter.GetData();
            //Ищем профиль того аккаунта, который вошел в сисему
            rowSponsor = dataSponsors.FindByIDSponsor(Total.idUser);
            if (rowSponsor == null)
            {
                MessageBox.Show("У Вас не заполнен профиль."
                    + Environment.NewLine + "Надо его заполнить для дальнейшей работы");
                //Конструктору передается команда о добавлении
                SponsorProfile fsp = new SponsorProfile("Addition");
                this.Hide();
                fsp.ShowDialog();
                this.Show();
            }
            else if(rowSponsor != null)
            {
                MessageBox.Show("У Вас заполнен профиль."
                                    + Environment.NewLine + "Можете работат в системе");
                SponsorProfile fsp = new SponsorProfile("ViewEdit");
                this.Hide();
                fsp.ShowDialog();
                this.Show();

            }
        }

        private void btSponsering_Click(object sender, EventArgs e)
        {
            SponsorRunners fsr = new SponsorRunners();
            Hide();
            fsr.ShowDialog();
            Show();

        }
    }
}
