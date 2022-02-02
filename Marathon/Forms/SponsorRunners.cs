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
    public partial class SponsorRunners : Form
    {
        public SponsorRunners()
        {
            InitializeComponent();
        }

        decimal sum;
        Marathon_SkillsDataSet.RunnersOdSponsorsDataTable dataRunnersOfSponsor;


        private void btSponsering_Click(object sender, EventArgs e)
        {

            int idRunner;
            ShowList();			
            MessageBox.Show("Все суммы обновлены");
            sum = decimal.Parse(tbAmount.Text);		
            var dataSponsors = this.sponsorsTableAdapter1.GetData();
            var rowSponsor = dataSponsors.FindByIDSponsor(Total.idUser);
            rowSponsor.TotalSum += sum;		
            try
            {
                this.sponsorsTableAdapter1.Update(rowSponsor);
            }
            catch
            {
                MessageBox.Show("Не удалось обновить общую сумму в таблице спонсоров");
                return;
            }

            idRunner = (int)cbSelect.SelectedValue;	
            var rowRunner = runnersTableAdapter1.GetData().FindByIDRunner(idRunner);
            rowRunner.Wallet += sum;
            try
            {
                runnersTableAdapter1.Update(rowRunner);
            }
            catch
            {
                MessageBox.Show("Не удалось обновить сумму в таблице бегуна");
                return;
            }

            var dataRunnerSponsor = runnerSponsorTableAdapter1.GetData().
                        Where(rec => rec.IDRunner == idRunner && rec.IDSponsor == Total.idUser);
            if (dataRunnerSponsor.Count() == 0)		
            {
                try
                {
                    runnerSponsorTableAdapter1.Insert(idRunner, Total.idUser, sum);
                }
                catch
                {
                    MessageBox.Show("Добавился новый бегун в таблице-связке");
                    return;
                }
            }
            else					
            {
                var rowRunnerSponsor = dataRunnerSponsor.First(); //Единственная запись в таблице
                rowRunnerSponsor.SumSponsor += sum;	
                try
                {
                    runnerSponsorTableAdapter1.Update(rowRunnerSponsor); 	//Обновить
                }
                catch
                {
                    MessageBox.Show("Не удалось обновить сумму в таблице-связке");
                    return;
                }
            }
            MessageBox.Show("Все суммы обновлены");
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SponsorRunners_Load(object sender, EventArgs e)
        {
            sum = 0;
            ShowList();

            tbAmount.Text = sum.ToString();
            tbAmount.Enabled = false;
            cbSelect.DataSource = this.runnersCountryTableAdapter1.GetData();
            cbSelect.DisplayMember = "FIOCountry";
            cbSelect.ValueMember = "IDRunner";
        }

        private void ShowList()
        {
            Panel panel;
            Label labelName, labelLastname, labelSum;
            PictureBox pictureBoxRunner;
            byte[] photo;
            System.IO.MemoryStream stream;
            Bitmap bit, bitNot;
            bitNot = new Bitmap(Resource.Anonim);
            dataRunnersOfSponsor = runnersOdSponsorsTableAdapter1.GetDataByIDSponsor(Total.idUser);
            if (dataRunnersOfSponsor.Count == 0)
            {
                MessageBox.Show("У Вас нет спонсируемых бегунов");
                tbTotalSum.Text = "0";
                tbTotalCount.Text = "0";
            }
            else
            {
                //Настройка панели FlowLayoutPanel: все записи последовательно спускаются вниз
                flowLayoutPanelRunners1.FlowDirection = FlowDirection.TopDown;	//свеху
                flowLayoutPanelRunners1.AutoScroll = true;		//Полосы прокрутки
                flowLayoutPanelRunners1.WrapContents = false;	//В одной строке
                flowLayoutPanelRunners1.Font = new Font(FontFamily.GenericMonospace, 12);
                flowLayoutPanelRunners1.Controls.Clear();
                //Все записи по очереди переносятся в FlowLayoutPanel
                for (int i = 0; i < dataRunnersOfSponsor.Count; i++)
                {
                    panel = new Panel();		//Контейнер для элементов одной записи
                    panel.Size = new Size(this.flowLayoutPanelRunners1.Width, 100);	//Размер
                    //Настройка фото бегуна
                    pictureBoxRunner = new PictureBox();
                    pictureBoxRunner.Size = new Size(panel.Width / 3, panel.Height - 10);
                    pictureBoxRunner.Location = new Point(5, 5);
                    pictureBoxRunner.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxRunner.SizeMode = PictureBoxSizeMode.Zoom;
                    //Работа с фото
                    if (dataRunnersOfSponsor.ElementAt(i).IsPhotoNull())
                    {
                        pictureBoxRunner.Image = bitNot;    
                    }
                    else
                    {
                        photo = dataRunnersOfSponsor.ElementAt(i).Photo;	
                        stream = new System.IO.MemoryStream(photo);
                        bit = (Bitmap)Image.FromStream(stream);
                        pictureBoxRunner.Image = bit;		
                    }
                    panel.Controls.Add(pictureBoxRunner);
                    labelName = new Label();
                    labelName.Location = new Point(pictureBoxRunner.Size.Width + 5, 20);
                    labelName.Size = new Size(2 * this.flowLayoutPanelRunners1.Width / 3, 20);
                    labelName.AutoSize = false;
                    labelName.Text = "Name: " + dataRunnersOfSponsor.ElementAt(i).FirstName;
                    panel.Controls.Add(labelName);
                    labelLastname = new Label();
                    labelLastname.Location = new Point(pictureBoxRunner.Size.Width + 5, 45);
                    labelLastname.Size = new Size(2 * this.flowLayoutPanelRunners1.Width / 3, 20);
                    labelLastname.AutoSize = false;
                    labelLastname.Text = "Surname: " + dataRunnersOfSponsor.ElementAt(i).LastName;
                    panel.Controls.Add(labelLastname);
                    labelSum = new Label();
                    labelSum.Location = new Point(pictureBoxRunner.Size.Width + 5, 70);
                    labelSum.Size = new Size(2 * this.flowLayoutPanelRunners1.Width / 3, 20);
                    labelSum.AutoSize = false;
                    labelSum.Text =
                               "Amount: " + dataRunnersOfSponsor.ElementAt(i).SumSponsor.ToString();
                    panel.Controls.Add(labelSum);
                    this.flowLayoutPanelRunners1.Controls.Add(panel);
                }
                tbTotalSum.Text =
                      this.runnerSponsorTableAdapter1.SummaOfSponsor(Total.idUser).ToString();
                tbTotalCount.Text =
                       this.runnerSponsorTableAdapter1.CountOfSponsor(Total.idUser).ToString();
            }

        }

        private void btPlusAmount_Click(object sender, EventArgs e)
        {            
            sum += 100;
            tbAmount.Text = sum.ToString();
        }

        private void btMinusAmount_Click(object sender, EventArgs e)
        {
            sum -= 100;
            tbAmount.Text = sum.ToString();
        }
    }
}
