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

    public partial class CustomerSuppHome : Form
    {
        private string CSemail;
        public CustomerSuppHome(string csEmail)
        {
            InitializeComponent();
            CSemail = csEmail;
        }

        private void CustomerSuppHome_Load(object sender, EventArgs e)
        {

        }

        private void chkprofilebtn_Click(object sender, EventArgs e)
        {
            CustomerSupportChkProfile customerSupportChkProfile = new CustomerSupportChkProfile(CSemail);
            customerSupportChkProfile.Show();
            this.Hide();
        }

        private void viewfeedback_Click(object sender, EventArgs e)
        {
            CusViewFeedback cusViewFeedback = new CusViewFeedback(CSemail);
            cusViewFeedback.Show();
            this.Hide();
        }
    }
}
