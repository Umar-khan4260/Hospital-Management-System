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
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            adminlogin admin=new adminlogin();
            admin.Show();
            this.Hide();
        }

        private void patientbtn_Click(object sender, EventArgs e)
        {
            patientlogin plogin = new patientlogin();
            plogin.Show();
            this.Hide();
        }

        private void docbtn_Click(object sender, EventArgs e)
        {
            Doclogin doclogin = new Doclogin();
            doclogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceptionistLogin RPTlogin = new ReceptionistLogin();
            RPTlogin.Show();
            this.Hide();
        }

        private void Customersupportbtn_Click(object sender, EventArgs e)
        {
            CustomerSuppLogin customerSuppLogin = new CustomerSuppLogin();
            customerSuppLogin.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
