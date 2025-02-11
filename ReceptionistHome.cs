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
    public partial class ReceptionistHome : Form
    {
        private string RptEmail;
        public ReceptionistHome(string rptEmail)
        {
            InitializeComponent();
            RptEmail = rptEmail;
        }

        private void ReceptionistHome_Load(object sender, EventArgs e)
        {

        }

        private void chkprofilebtn_Click(object sender, EventArgs e)
        {
            ReceptionistChkProfile receptionistChkProfile = new ReceptionistChkProfile(RptEmail);
            receptionistChkProfile.Show();
            this.Hide();
        }
    }
}
