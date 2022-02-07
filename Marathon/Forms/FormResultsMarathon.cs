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
    public partial class FormResultsMarathon : Form
    {

        Marathon_SkillsDataSet.ResultsMarathonDataTable dataResult;
        Marathon_SkillsDataSet.TypeDistanceDataTable dataTypeDist;
        Marathon_SkillsDataSet.OrdersMarathonDataTable dataSortTimeRun;
        int countTab;
        DataGridView[] dgv;
        string[] typeDist;

        public FormResultsMarathon()
        {
            InitializeComponent();
            Application.OpenForms["Authorization"].Show();
        }

        private void ShowTableByTypeDist(DataGridView dgv, string typeDist)
        {
            this.comboBox1.Visible = false;
            dataResult = this.resultsMarathonTableAdapter1.GetData();
            var filter = dataResult.Where(x => x.TitleDistance == typeDist);
            if (Total.idRole == 1)
            {
                this.comboBox1.Visible = true;
                if (comboBox1.Text == comboBox1.Items[1].ToString())
                {                    
                    filter = dataResult.Where(x => x.TitleDistance == typeDist && x.IDRunner == Total.idUser);
                }
            }
            if (filter.Count() == 0)					
            {
                dgv.DataSource = null;				
            }
            else                       
            {
                dgv.DataSource = filter.CopyToDataTable();  
            }
            dgv.Width = this.tabControl.Width - 10;
            dgv.Height = this.tabControl.Height - 10;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ScrollBars = ScrollBars.Both;
            dgv.AllowUserToAddRows = false;			
            dgv.AutoGenerateColumns = false;	
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
            }
            dgv.Columns["FIO"].Visible = true;
            dgv.Columns["FIO"].HeaderText = "ФИО";
            dgv.Columns["FIO"].ReadOnly = true; ;
            dgv.Columns["TimeRun"].Visible = true;
            dgv.Columns["TimeRun"].HeaderText = "Время пробега";
            dgv.Columns["TitleCountry"].Visible = true;
            dgv.Columns["TitleCountry"].HeaderText = "Страна";
            dgv.Columns["TitleCountry"].ReadOnly = true;
            if (Total.idRole == 3)			
            {
                btFixed.Visible = true;		
                dgv.Columns["TimeRun"].ReadOnly = false;
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    if ((decimal)dgv.Rows[i].Cells["TimeRun"].Value == 0)
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = Color.Cyan;
                    }
                    else
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = SystemColors.Control;
                    }
                }
            }
            if (Total.idRole == 1 || Total.idRole == 2)	
            {
                btFixed.Visible = false;		
                dgv.Columns["TimeRun"].ReadOnly = true; 
                dgv.Columns["Place"].HeaderText = "Место";
                dgv.Columns["Place"].Visible = true;
                dgv.Columns["Place"].ReadOnly = true;
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    switch ((int)dgv.Rows[i].Cells["Place"].Value)
                    {
                        case 1:
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.Gold;	
                            break;
                        case 2:
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.Silver;	
                            break;
                        case 3:
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.RosyBrown;	
                            break;
                        default:
                            dgv.Rows[i].DefaultCellStyle.BackColor = SystemColors.Control;  
                            break;
                    }
                }
            }
        }

        private void FormResultsMarathon_Load(object sender, EventArgs e)
        {
            TabPage tabPage;			
            dataTypeDist = this.typeDistanceTableAdapter1.GetData();
            countTab = dataTypeDist.Count();		
            typeDist = new string[countTab];	
            dgv = new DataGridView[countTab];	
            for (int i = 0; i < countTab; i++)		
            {
                typeDist[i] = dataTypeDist.ElementAt(i).Title;
                tabPage = new TabPage(typeDist[i]); 	
                dgv[i] = new DataGridView(); 
                //dgv[i].CellEndEdit += dataGridViewResult_CellEndEdit;
                tabPage.Controls.Add(dgv[i]); 		
                tabControl.TabPages.Add(tabPage);
            }
            Marathon_SkillsDataSet.OrdersMarathonRow ordersRow;	
            for (int i = 0; i < countTab; i++)	
            {
                dataSortTimeRun = this.ordersMarathonTableAdapter1.GetDataByTimeRun(i + 1);
                for (int j = 0; j < dataSortTimeRun.Count(); j++)
                {
                    ordersRow = dataSortTimeRun.ElementAt(j);
                    ordersRow.Place = j + 1;		
                    this.ordersMarathonTableAdapter1.Update(ordersRow);
                }
            }
            for (int i = 0; i < countTab; i++)
            {
                ShowTableByTypeDist(dgv[i], typeDist[i]);
            }
            this.comboBox1.Text = this.comboBox1.Items[0].ToString();
            if (Total.idRole == 1)
            {
                this.comboBox1.Visible = true;
            }
            else
            {
                this.comboBox1.Visible = false;
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btFixed_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < countTab; i++)
                {
                    for (int row = 0; row < dgv[i].RowCount; row++)
                    {
                        this.ordersMarathonTableAdapter1.UpdateQueryTimeRun((decimal)dgv[i].Rows[row].Cells["TimeRun"].Value,
                                                                 (int)dgv[i].Rows[row].Cells["IDRunner"].Value, i + 1);
                    }
                }
                MessageBox.Show("Все результаты занесены");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при сохранении результатов");
            }
        }
    }
}

