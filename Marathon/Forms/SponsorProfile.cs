using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class SponsorProfile : Form
    {

        string command;
        Marathon_SkillsDataSet.UsersDataTable dataUsers;
        Marathon_SkillsDataSet.UsersRow rowUser;
        Marathon_SkillsDataSet.SponsorsDataTable dataSponsor;
        Marathon_SkillsDataSet.SponsorsRow rowSponsor;

        public SponsorProfile(string command)
        {
            InitializeComponent();
            this.command = command;
        }

        private void buttonAdditionProfile_Click(object sender, EventArgs e)
        {
            byte[] photo = null;
            string sponsorName = tbName.Text;
            if (sponsorName == "")
            {
                MessageBox.Show("Не заполнили имя");
                return;
            }
            string numberCard = maskedtbCard.Text;
            int monthCard = int.Parse(cbMonth.Text);
            int yearCard = int.Parse(cbYear.Text);
            decimal summa = decimal.Parse(tbWallet.Text);
            if (pbPhoto.Image != null)
            {
                photo = File.ReadAllBytes(openFileDialog.FileName);	//в массив
            }
            try
            {
                this.sponsorsTableAdapter.Insert(Total.idUser, sponsorName, numberCard, monthCard, yearCard, summa, photo);
                MessageBox.Show("Ваш профиль добавлен в систему");
                buttonAdditionProfile.Visible = false;
                buttonPhoto.Enabled = false;
                buttonGoSponsor.Enabled = true;		//доступ к функционалу спонсора
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении профиля");
            }

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string sponsorName = tbName.Text;
            if (sponsorName == "")
            {
                MessageBox.Show("Не заполнили имя или фамилию");
                return;
            }
            rowSponsor.FirstName = sponsorName;
            rowSponsor.NumberCard = maskedtbCard.Text;
            rowSponsor.MonthCard = int.Parse(cbMonth.Text);
            rowSponsor.YearCard = int.Parse(cbYear.Text);
            rowSponsor.TotalSum = decimal.Parse(tbWallet.Text);
            if (pbPhoto.Image != null)
            {
                MemoryStream stream = new System.IO.MemoryStream();	//Промежуточный поток 
                pbPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                rowSponsor.Logo = stream.ToArray();
            }
            else
            {
                rowSponsor.Logo = null;
            }
            try
            {
                this.sponsorsTableAdapter.Update(rowSponsor);
                MessageBox.Show("Ваш профиль обновлен в системе");
                buttonPhoto.Enabled = false;
                buttonGoSponsor.Enabled = true;		//доступ к функционалу спонсора
            }
            catch
            {
                MessageBox.Show("Ошибка при обновлении профиля");
            }
        }

    

    private void buttonPhoto_Click(object sender, EventArgs e)
        {
            if (buttonPhoto.Text == "Выбрать фото")
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbPathPhoto.Text = openFileDialog.FileName;
                    pbPhoto.Load(openFileDialog.FileName);
                    buttonPhoto.Text = "Удалить фото";
                }
            }
            else
            {
                tbPathPhoto.Text = "";
                pbPhoto.Image = null;
                buttonPhoto.Text = "Выбрать фото";
            }

        }

        private void SponsorProfile_Load(object sender, EventArgs e)
        {
            buttonAdditionProfile.Visible = false;
            btEdit.Visible = false;
            buttonGoSponsor.Enabled = true;
            tbWallet.Enabled = false;
            tbPathPhoto.Enabled = false;
            openFileDialog.Filter = "jpeg|*.jpeg|jpg|*.jpg|png|*.png";
            openFileDialog.InitialDirectory = Application.StartupPath + @"\PhotoSponsors";
            openFileDialog.Title = "Выбрать фото для спонсора";
            dataUsers = this.usersTableAdapter.GetData();
            rowUser = dataUsers.FindByIDUser(Total.idUser);
            lbID.Text = "Ваш номер: " + rowUser.IDUser.ToString();
            lbLogin.Text = "Ваш логин: " + rowUser.Email;
            lbPassword.Text = "Ваш пароль: " + rowUser.Password;
            cbMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cbMonth.Items.Add(i.ToString());
            }
            cbMonth.Text = cbMonth.Items[0].ToString();
            cbYear.Items.Clear();
            for (int i = DateTime.Now.Year-5; i <= DateTime.Now.Year+5; i++)
            {
                cbYear.Items.Add(i.ToString());
            }
            cbYear.Text = cbYear.Items[0].ToString();
            switch (command)
            {
                case "Addition":
                    buttonAdditionProfile.Visible = true;
                    buttonGoSponsor.Enabled = false;
                    tbWallet.Text = "0,00";
                    break;
                case "ViewEdit":
                    btEdit.Visible = true;
                    dataSponsor = this.sponsorsTableAdapter.GetData();
                    rowSponsor = dataSponsor.FindByIDSponsor(Total.idUser);
                    tbWallet.Text = rowSponsor.TotalSum.ToString();
                    tbName.Text = rowSponsor.FirstName;
                    maskedtbCard.Text = rowSponsor.NumberCard;
                    cbMonth.Text = rowSponsor.MonthCard.ToString();
                    cbYear.Text = rowSponsor.YearCard.ToString();
                    //Обработка фото
                    if (rowSponsor.IsLogoNull())
                    {
                        pbPhoto.Image = Resource.Anonim;
                    }
                    else
                    {
                        byte[] photo = rowSponsor.Logo;
                        MemoryStream stream = new MemoryStream(photo);
                        Image bit = Image.FromStream(stream);
                        pbPhoto.Image = bit;
                    }
                    break;
            }

        }

        private void buttonGoSponsor_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
