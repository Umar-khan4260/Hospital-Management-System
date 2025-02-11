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
    public partial class ViewRecord : Form
    {
        OracleConnection con;
        DataTable AppointmentTable;
        private string DocEmail;
        public ViewRecord(string docEmail)
        {
            InitializeComponent();
            DocEmail = docEmail;
        }

        private void ViewRecord_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);


            AppointmentTable = new DataTable();
            // Add columns to DataTable to match Doctor table in the database
            AppointmentTable.Columns.Add("Appointment ID", typeof(int));
            AppointmentTable.Columns.Add("Patient Email");
            AppointmentTable.Columns.Add("Doctor Email");
            AppointmentTable.Columns.Add("Appointment Date", typeof(DateTime));
            AppointmentTable.Columns.Add("Appointment Time");
            AppointmentTable.Columns.Add("Appointment Status");

            // Bind DataTable to DataGridView in each tab
            dataGridView.DataSource = AppointmentTable;
            // Fetch existing data from the database and display in DataGridView
            FillDataGridView();


        }

        private void FillDataGridView()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string query = "SELECT * FROM Appointment WHERE Doctor_Email = :DoctorEmail";
                OracleDataAdapter adapter = new OracleDataAdapter(query, con);
                adapter.SelectCommand.Parameters.Add(new OracleParameter("DoctorEmail", DocEmail));

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                AppointmentTable.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    AppointmentTable.Rows.Add(row.ItemArray);
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

            //try
            //{
            //    if (con.State != ConnectionState.Open)
            //    {
            //        con.Open();
            //    }



            //    string query = "SELECT * FROM Appointment WHERE  Doctor_Email=" + DocEmail;
            //    OracleDataAdapter adapter = new OracleDataAdapter(query, con);
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);
            //    AppointmentTable.Clear();
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        AppointmentTable.Rows.Add(row.ItemArray);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error Fetching Data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    con.Close();
            //}
        }



        private void homebtn_Click(object sender, EventArgs e)
        {
            DocHome docHome = new DocHome(DocEmail);
            docHome.Show();
            this.Hide();
        }
    }
}
