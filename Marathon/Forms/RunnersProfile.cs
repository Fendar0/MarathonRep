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
    public partial class RunnerProfile : Form
    {

        string command;						//С какой целью открывается форма
        Marathon_SkillsDataSet.UsersDataTable dataUsers;		//все данные
        Marathon_SkillsDataSet.UsersRow rowUser;		//Отдельная строка таблицы

        Marathon_SkillsDataSet.RunnersDataTable dataRunners;
        Marathon_SkillsDataSet.RunnersRow rowRunner;

        public RunnerProfile(string command)
        {
            InitializeComponent();
            this.command = command;
        }

        private void RunnerProfil_Load(object sender, EventArgs e)
        {
            //Начальные настройки интерфейса
            buttonAdditionProfile.Visible = false;
            buttonGoRunner.Enabled = true;
            textBoxWallet.Enabled = false;
            textBoxPathPhoto.Enabled = false;
            openFileDialog.Filter = "jpg|*.jpg|png|*.png";
            //Данные из таблицы Users, которые нельзя менять
            dataUsers = this.usersTableAdapter.GetData();
            rowUser = dataUsers.FindByIDUser(Total.idUser);
            lbID.Text = "Ваш номер: " + rowUser.IDUser;
            lbLogin.Text = "Ваш логин: " + rowUser.Email;
            lbPassword.Text = "Ваш пароль: " + rowUser.Password;
            //Настройка списков
            cbCountries.DataSource = countriesTableAdapter.GetData();
            cbCountries.DisplayMember = "Title";
            cbCountries.ValueMember = "IDCountry";            
            switch (command)	//С какой целью будет открываться форма
            {
                case "Addition":	//Цель - добавление
                    buttonAdditionProfile.Visible = true;
                    buttonGoRunner.Enabled = false;
                    textBoxWallet.Text = "0,00";
                    break;
                case "ViewEdit":
                    dataRunners = runnersTableAdapter.GetData();
                    rowRunner = dataRunners.FindByIDRunner(Total.idUser);
                    textBoxWallet.Text = rowRunner.Wallet.ToString();
                    tbName.Text = rowRunner.FirstName;
                    tbLastname.Text = rowRunner.LastName;
                    cbGenders.SelectedValue = rowRunner.Sex;
                    dtPickerBirthday.Value = rowRunner.Birthday;
                    cbCountries.SelectedValue = rowRunner.IDCountry;
                    maskedtbPhone.Text = rowRunner.PhoneNumber;
                    if (rowRunner.IsPhotoNull())
                    {
                        pbPhoto.Image = Resource.Anonim;
                    }
                    else
                    {
                        byte[] photo = rowRunner.Photo;
                        MemoryStream stream = new MemoryStream(photo);
                        Image bit = Image.FromStream(stream);
                        pbPhoto.Image = bit;
                    }
                    break;
            }

        }

        private void buttonAdditionProfile_Click(object sender, EventArgs e)
        {
            byte[] photo = null;
            string runnerName = tbName.Text;
            string runnerLastname = tbLastname.Text;
            if (runnerName == "" || runnerLastname == "")
            {
                MessageBox.Show("Не заполнили имя или фамилию");
                return;
            }
            string idGender = cbGenders.Text;
            DateTime birthday = dtPickerBirthday.Value;
            int idCountry = (int)cbCountries.SelectedValue;
            string phone = maskedtbPhone.Text;
            decimal wallet = decimal.Parse(textBoxWallet.Text);
            if (pbPhoto.Image != null)
            {
                photo = File.ReadAllBytes(openFileDialog.FileName); 
            }
            try
            {
                runnersTableAdapter.Insert(Total.idUser, runnerName, runnerLastname, idGender, birthday, idCountry, phone, wallet, null);
                MessageBox.Show("Ваш профиль добавлен в систему");
                buttonAdditionProfile.Visible = false;
                buttonPhoto.Enabled = false;
                buttonGoRunner.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении профиля");
            }

        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            if (buttonPhoto.Text == "Выбрать фото")
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxPathPhoto.Text = openFileDialog.FileName;
                    pbPhoto.Load(openFileDialog.FileName);
                    buttonPhoto.Text = "Удалить фото";
                }
            }
            else
            {
                textBoxPathPhoto.Text = "";
                pbPhoto.Image = null;
                buttonPhoto.Text = "Выбрать фото";
            }

        }

        private void buttonGoRunner_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string runnerName = tbName.Text;
            string runnerLastname = tbLastname.Text;
            if (runnerName == "" || runnerLastname == "")
            {
                MessageBox.Show("Не заполнили имя или фамилию");
                return;
            }
            rowRunner.FirstName = runnerName;
            rowRunner.LastName = runnerLastname;
            rowRunner.Sex = (string)cbGenders.SelectedValue;
            rowRunner.Birthday = dtPickerBirthday.Value;
            rowRunner.IDCountry = (int)cbCountries.SelectedValue;
            rowRunner.PhoneNumber = maskedtbPhone.Text;
            rowRunner.Wallet = decimal.Parse(textBoxWallet.Text);
            //Подготовка к сохранению фото в БД
            if (pbPhoto.Image != null)
            {
                MemoryStream stream = new System.IO.MemoryStream();	//Промежуточный поток
                pbPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                rowRunner.Photo = stream.ToArray();
            }
            else
            {
                rowRunner.Photo = null;
            }
            try
            {
                //Перенести измененные данные в БД
                runnersTableAdapter.Update(rowRunner);
                MessageBox.Show("Ваш профиль обновлен в системе");
                buttonPhoto.Enabled = false;
                buttonGoRunner.Enabled = true;		//Открыт доступ к функционалу бегуна
            }
            catch
            {
                MessageBox.Show("Ошибка при обновлении профиля");
            }

        }
    }
}
