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
    public partial class WorkAccount : Form
    {
        Marathon_SkillsDataSet.UsersDataTable dataUsers;


        public WorkAccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.groupBoxAccount.Enabled = true;
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            this.buttonInsert.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string log = textBoxLogin.Text;
            string pas = textBoxPassword.Text;

            if (String.IsNullOrEmpty(log) || String.IsNullOrEmpty(pas))
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            int pos = log.IndexOf('@');
            if (pos < 0)
            {
                MessageBox.Show("В логине отсутствуют обязательный символ @");
                return;
            }

            pos = log.IndexOf('.');
            if (pos < 0)
            {
                MessageBox.Show("В логине отсутствуют обязательный символ .");
                return;
            }
            if ((int)comboBoxRole.SelectedValue == 3)
            {
                MessageBox.Show("Нельзя добавлять нового организатора."
                    + Environment.NewLine + "Выберите другою роль");
                return;
            }

            var filter = dataUsers.Where(rec => rec.Email == log && rec.Password == pas);
            if (filter.Count() == 0)
            {
                try
                {
                    usersTableAdapter.Insert(log, pas, (int)comboBoxRole.SelectedValue);
                    MessageBox.Show("Данные о новом пользователе успешно сохранены в БД");
                    WorkAccount_Load(null, null);	
                }
                catch
                {
                    MessageBox.Show("При добавлении нового пользователя возникли проблемы");
                    return;
                }
            }
            else			
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован в системе." +
                                                    Environment.NewLine + " Введите другие данные");
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void WorkAccount_Load(object sender, EventArgs e)
        {           
            dataUsers = this.usersTableAdapter.GetData();
            var filter = dataUsers.Where(rec => rec.IDRole == 1 || rec.IDRole == 2);
            int totalCount = filter.Count();
            this.dataGridViewAccounts.DataSource = filter.CopyToDataTable();
            this.dataGridViewAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccounts.Select();
            this.comboBoxRole.DataSource = this.rolesTableAdapter.GetData();
            this.comboBoxRole.DisplayMember = "Title";
            this.comboBoxRole.ValueMember = "IDRole";
            this.groupBoxAccount.Enabled = false;
            this.buttonInsert.Enabled = false;
        }

        private void dataGridViewAccounts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;
            textBoxLogin.Text = dataGridViewAccounts.Rows[numRow].Cells[1].Value.ToString();
            textBoxPassword.Text = dataGridViewAccounts.Rows[numRow].Cells[2].Value.ToString();
            comboBoxRole.SelectedValue = (int)dataGridViewAccounts.Rows[numRow].Cells[3].Value;
        }
    }
}
