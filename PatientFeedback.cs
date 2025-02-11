using Oracle.ManagedDataAccess.Client;
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
    public partial class PatientFeedback : Form
    {
        string tempEmail;
        private string patientEmail;
        OracleConnection con;
        DataTable doctorTable;
        public PatientFeedback(string PatientEmail)
        {
            InitializeComponent();
            patientEmail = PatientEmail;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void doctordataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PatientFeedback_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);

            //******************Doctor DataGrid View**********************
            doctorTable = new DataTable();
            // Add columns to DataTable to match Doctor table in the database
            doctorTable.Columns.Add("Name");

            doctorTable.Columns.Add("Email");

            // Bind DataTable to DataGridView in each tab
            doctordataGrid.DataSource = doctorTable;
            // Fetch existing data from the database and display in DataGridView
            DocFillDataGridView();
        }

        private void DocFillDataGridView()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }


                string query = "SELECT Name,Email FROM Doctor";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                doctorTable.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    doctorTable.Rows.Add(row.ItemArray);
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

        private void homebtn_Click(object sender, EventArgs e)
        {
            patientHome patHome = new patientHome(patientEmail);
            patHome.Show();
            this.Hide();

        }

        private void SubmitFeedbackbtn_Click(object sender, EventArgs e)
        {
            if (
                !IsValidEmail(doctorEmail.Text) ||
                feedbacktxt.Text == "" 
                )
            {
                MessageBox.Show("Please Fill all Fields or a valid Email", "Failure", MessageBoxButtons.OK);
            }
            else
            {
                // Check if the database connection is not already open.
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        // wrtiting query
                        string InsertDate = "INSERT INTO Feedback VALUES ( (SELECT COALESCE(MAX(Feedback_id), 0) + 1 FROM Feedback), :patEmail, :docEmail,:FB)";
                        // Create a new OracleCommand object with the SQL query and the connection.
                        using (OracleCommand command = new OracleCommand(InsertDate, con))
                        {
                            command.Parameters.Add("patEmail", OracleDbType.Varchar2).Value = patientEmail;
                            command.Parameters.Add("docEmail", OracleDbType.Varchar2).Value = doctorEmail.Text;
                            command.Parameters.Add("FB", OracleDbType.Varchar2).Value = feedbacktxt.Text;


                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("FeedBack Inserted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh DataGridView to show newly added data


                            }
                            else
                            {
                                MessageBox.Show("Insertion Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (con.State != ConnectionState.Closed)
                        {
                            con.Close();
                        }

                    }
                }

            }
        }

        private void doctordataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            doctorEmail.Text = doctordataGrid.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
