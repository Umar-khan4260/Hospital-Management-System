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
    public partial class DocHome : Form
    {
        private string Docemail;
        public DocHome(string docemail)
        {
            InitializeComponent();
            Docemail = docemail;
        }

        private void DocHome_Load(object sender, EventArgs e)
        {

        }

        private void DocChkProbtn_Click(object sender, EventArgs e)
        {
            
            DocChkProfile docChkProfile = new DocChkProfile(Docemail);
            docChkProfile.Show();
            this.Hide();
        }

        private void viewRecord_Click(object sender, EventArgs e)
        {
            ViewRecord viewRecord = new ViewRecord(Docemail);
            viewRecord.Show();
            this.Hide();
        }

        private void mngAppointment_Click(object sender, EventArgs e)
        {
            DocmngAppointment docmngAppointment = new DocmngAppointment(Docemail);
            docmngAppointment.Show();
            this.Hide();
        }
    }
}
