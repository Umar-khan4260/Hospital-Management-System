using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_project
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            timer1.Start();
        }
        int startingpoint = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startingpoint += 10;
            progressBar1.Value = startingpoint;
            if(progressBar1.Value==100)
            {
                timer1.Stop();
                progressBar1.Value = 0;
                mainpage form = new mainpage();
                this.Hide();
                form.Show();
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            Panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
