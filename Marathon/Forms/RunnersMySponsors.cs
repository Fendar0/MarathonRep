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
    public partial class RunnersMySponsors : Form
    {
        public RunnersMySponsors()
        {
            InitializeComponent();
        }

        Marathon_SkillsDataSet.ListRunnersSponsorsDataTable dataSponsorsOfRunner;

        private void RunnersMySponsors_Load(object sender, EventArgs e)
        {
            Panel panel;
            Label labelName, labelSum;
            PictureBox pictureBoxSponsor;
            byte[] photo;
            System.IO.MemoryStream stream;
            Bitmap bit, bitNot;
            bitNot = new Bitmap(Resource.Anonim);
            dataSponsorsOfRunner = listRunnersSponsorsTableAdapter1.GetData(Total.idUser);
            if (dataSponsorsOfRunner.Count == 0)	
            {
                MessageBox.Show("У Вас нет спонсоров");
                tbTotalSum.Text = "0";
                tbTotalSponsor.Text = "0";
            }
            else
            {
                //Настройка панели FlowLayoutPanel: все элементы последовательно спускаются вниз
                this.flowLayoutPanelSponsors.FlowDirection = FlowDirection.TopDown;	//свеху
                this.flowLayoutPanelSponsors.AutoScroll = true;  //Полосы прокрутки
                this.flowLayoutPanelSponsors.WrapContents = false;//Нет перехода на новую строку
                this.flowLayoutPanelSponsors.Font = new Font(FontFamily.GenericMonospace, 12);
                this.flowLayoutPanelSponsors.Controls.Clear();
                //Все записи по очереди переносятся в FlowLayoutPanel
                for (int i = 0; i < dataSponsorsOfRunner.Count; i++)
                {
                    panel = new Panel();			//Контейнер для элементов одной записи
                    panel.Size = new Size(this.flowLayoutPanelSponsors.Width, 100);	//Размер
                    //Настройка фото спонсора
                    pictureBoxSponsor = new PictureBox();
                    pictureBoxSponsor.Size = new Size(panel.Width / 3, panel.Height - 10);
                    pictureBoxSponsor.Location = new Point(5, 5);
                    pictureBoxSponsor.BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxSponsor.SizeMode = PictureBoxSizeMode.Zoom;
                    //Работа с фото
                    if (dataSponsorsOfRunner.ElementAt(i).IsLogoNull())
                    {
                        pictureBoxSponsor.Image = bitNot; 			//Изображение без фото
                    }
                    else
                    {
                        photo = dataSponsorsOfRunner.ElementAt(i).Logo;//Значение поля логотипа
                        stream = new System.IO.MemoryStream(photo);
                        bit = (Bitmap)Image.FromStream(stream);
                        pictureBoxSponsor.Image = bit;			//Для отображения
                    }
                    panel.Controls.Add(pictureBoxSponsor);		//Добавить картинку в панель
                    //Добавить надпись с именем спонсора
                    labelName = new Label();
                    labelName.Location = new Point(pictureBoxSponsor.Size.Width + 5, 20);
                    labelName.Size = new Size(2 * this.flowLayoutPanelSponsors.Width / 3, 20);
                    labelName.AutoSize = false;
                    labelName.Text = "Имя: " + dataSponsorsOfRunner.ElementAt(i).FirstName;
                    panel.Controls.Add(labelName);		//Добавить надпись в панель
                    //Добавить надпись с суммой спонсирования этим спонсором
                    labelSum = new Label();
                    labelSum.Location = new Point(pictureBoxSponsor.Size.Width + 5, 45);
                    labelSum.Size = new Size(2 * this.flowLayoutPanelSponsors.Width / 3, 20);
                    labelSum.AutoSize = false;
                    labelSum.Text = "Сумма: " + dataSponsorsOfRunner.ElementAt(i).SumSponsor.ToString();
                    panel.Controls.Add(labelSum);			//Добавить надпись в панель
                    //Добавить сформированную панель добавить в FlowLayoutPanel
                    this.flowLayoutPanelSponsors.Controls.Add(panel);
                }
                //Вызвать дополнительные метода адаптера таблицы-связки
                tbTotalSum.Enabled = false;
                tbTotalSponsor.Enabled = false;
                tbTotalSum.Text = runnerSponsorTableAdapter1.SumOfRunner(Total.idUser).ToString();
                tbTotalSponsor.Text = runnerSponsorTableAdapter1.CountOfRunner(Total.idUser).ToString();
            }

        }
    }
}
