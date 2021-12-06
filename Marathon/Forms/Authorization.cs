using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class Authorization : Form
    {
        Marathon_SkillsDataSet.UsersDataTable dataUsers;
        Marathon_SkillsDataSet.LoginHistoryDataTable dataLoginHistory;


        int _tiks;
        int _tiks2;
        int count = 0;
        

        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log, pas;
            pas = TBPassword.Text;
            log = TBEmail.Text;		
            dataUsers = usersTableAdapter.GetData();
            DateTime dt = DateTime.Now;
            string timeString = dt.ToLongTimeString();
            var filter = dataUsers.Where(rec => rec.Email == log && rec.Password == pas);

            if (filter.Count() == 0)   
            {
                _tiks = 0;
                _tiks2 = 0;
                count++;
                if (count > 3)
                {                    
                    TBEmail.Enabled = false;
                    TBPassword.Enabled = false;
                    SignIn.Enabled = false;                                   
                }                
                Timer.Enabled = true;
                LBIncorrect.Visible = true;

                try
                {
                    loginHistoryTableAdapter.Insert(log, TimeSpan.Parse(timeString), false);
                }
                catch
                {
                    MessageBox.Show("Ошибка в истории входа");
                }

            }
            else				 
            {
                try
                {
                    loginHistoryTableAdapter.Insert(log, TimeSpan.Parse(timeString), true);
                }
                catch
                {
                    MessageBox.Show("Вход выполнен");
                }

                Total.idUser = filter.ElementAt(0).IDUser;
                Total.idRole = filter.ElementAt(0).IDRole;
                Total.login = filter.ElementAt(0).Email;

                switch (Total.idRole)
                {
                    case 1:
                        MessageBox.Show("Вы успешно авторизовались как бегун.");
                        Runner fr = new Runner();
                        Hide();
                        fr.ShowDialog();
                        Show();
                        break;
                    case 2:
                        MessageBox.Show("Вы успешно авторизовались как спонсор.");
                        Sponsor fs = new Sponsor();
                        Hide();
                        fs.ShowDialog();
                        Show();
                        break;
                    case 3:
                        MessageBox.Show("Вы успешно авторизовались как организатор.");
                        Form_organizer fo = new Form_organizer();
                        Hide();
                        fo.ShowDialog();
                        Show();
                        break;
                }
            }       
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            TBPassword.PasswordChar = '*';
            dataLoginHistory = loginHistoryTableAdapter.GetData();
            Marathon_SkillsDataSet.LoginHistoryRow loginHR;
            try
            {
                for (int i = 0; i < dataLoginHistory.Count; i++)
                {
                    loginHR = dataLoginHistory.ElementAt(i);
                    this.loginHistoryTableAdapter.Delete
                                      (loginHR.IDHis, loginHR.Login, loginHR.TimeLogin, loginHR.ResultLogin);
                }
            }
            catch
            {
                MessageBox.Show("Не удалось удалиnь из истории входов");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            _tiks++;
            _tiks2++;
            if (_tiks2 == 3 && count < 4)
            {
                LBIncorrect.Visible = false;
                Timer.Enabled = false;
            }
            switch (count)
            {
                case 4:
                    labelTimer.Text = $"{15 - _tiks}";
                    labelTimer.Visible = true;
                    if (_tiks == 15)
                    {
                        Timer.Enabled = false;
                        labelTimer.Visible = false;
                        _tiks = 0;
                        TBEmail.Enabled = true;
                        TBPassword.Enabled = true;
                        SignIn.Enabled = true;
                        LBIncorrect.Visible = false;
                    }
                    break;
                case 5:
                    labelTimer.Text = $"{20 - _tiks}";
                    labelTimer.Visible = true;
                    if (_tiks == 20)
                    {
                        Timer.Enabled = false;
                        labelTimer.Visible = false;
                        _tiks = 0;
                        TBEmail.Enabled = true;
                        TBPassword.Enabled = true;
                        SignIn.Enabled = true;
                        LBIncorrect.Visible = false;
                    }
                    break;
                case 6:
                    Close();
                    break;
            }       
                              
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                TBPassword.PasswordChar = '*';
            else
                TBPassword.PasswordChar = '\0';

        }
    }
}
