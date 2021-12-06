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
    public partial class History : Form
    {
        Marathon_SkillsDataSet.LoginHistoryDataTable dataLoginHistory;
        

        public History()
        {
            InitializeComponent();
        }

        string inputtype;
        int count;
        string check = null;

        private void History_Load(object sender, EventArgs e)
        {
            dataLoginHistory = loginHistoryTableAdapter.GetData();
            dataGridView1.DataSource = dataLoginHistory;
            dataGridView1.Columns["IDHis"].Visible = false;

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("ResultLogin = true", inputtype);
            count = dataGridView1.RowCount;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("ResultLogin = false or ResultLogin = true", check);
            tbCount.Text = "Amount successful \nlogins: " + count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_organizer or = new Form_organizer();
            Hide();
            or.ShowDialog();
            Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputtype = (string)comboBox1.Text;
            switch(inputtype)
            {
                case "All": inputtype = null;
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("ResultLogin = false or ResultLogin = true", inputtype);
                    break;
                case "Successful": inputtype = "true";
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("ResultLogin = true", inputtype);
                    break;
                case "Unsuccessful": inputtype = "false";
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("ResultLogin = false", inputtype);
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Login like '%{0}%'", tbSearchLogin.Text);
        }
    }
}
