using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Database_project
{
    public partial class AdminViewFeedback : Form
    {
        private string adminemail;
        OracleConnection con;
        DataTable FeedbackTable;
        public AdminViewFeedback(string Adminemail)
        {
            InitializeComponent();
            adminemail = Adminemail;
        }

        private void AdminViewFeedback_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);


            FeedbackTable = new DataTable();
            // Add columns to DataTable to match Doctor table in the database
            FeedbackTable.Columns.Add("Feedback ID");
            FeedbackTable.Columns.Add("Patient Email");
            FeedbackTable.Columns.Add("Doctor Email");
            FeedbackTable.Columns.Add("Feedback");

            // Bind DataTable to DataGridView in each tab
            FeedbackdataGrid.DataSource = FeedbackTable;
            // Fetch existing data from the database and display in DataGridView
            AppointmentFillDataGridView();
        }

        private void AppointmentFillDataGridView()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }


                string query = "SELECT * FROM Feedback";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                FeedbackTable.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    FeedbackTable.Rows.Add(row.ItemArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Fetching Data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(adminemail);
            adminHome.Show();
            this.Hide();
        }
    }
}
