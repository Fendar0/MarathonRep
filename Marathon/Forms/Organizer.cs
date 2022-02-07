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
    public partial class Form_organizer : Form
    {
        public Form_organizer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            History h = new History();
            Hide();
            h.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Authorization au = new Authorization();
            Hide();
            au.ShowDialog();
            Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WorkAccount wa = new WorkAccount();
            Hide();
            wa.ShowDialog();
            Show();
        }

        private void btResults_Click(object sender, EventArgs e)
        {
            FormResultsMarathon res = new FormResultsMarathon();
            Close();
            res.ShowDialog();

        }

        private void Form_organizer_Load(object sender, EventArgs e)
        {

        }
    }
}
