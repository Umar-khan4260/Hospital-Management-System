using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Database_project
{
    public partial class patientlogin : Form
    {
        OracleConnection con;
        string Patientemail;
        public patientlogin()
        {
            InitializeComponent();
        }

        private void patientusernamtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientpasstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void patientpasscheck_CheckedChanged(object sender, EventArgs e)
        {
            bool check = patientpasscheck.Checked;
            switch (check)
            {
                case true:
                    patientpasstxt.UseSystemPasswordChar = false;
                    break;
                default:
                    patientpasstxt.UseSystemPasswordChar = true;
                    break;
            }

        }

        private void patientloginbtn_Click(object sender, EventArgs e)
        {
            if (patientusernamtxt.Text == "" || patientpasstxt.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                        string selectDate = "SELECT Email,Password FROM Patient WHERE Email = :username AND Password = :pass";
                        // Create a new OracleCommand object with the SQL query and the connection.
                        using (OracleCommand cmd = new OracleCommand(selectDate, con))
                        {
                            cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = patientusernamtxt.Text;
                            cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = patientpasstxt.Text;
                            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                //  MessageBox.Show("Logged in Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string Patientemail = patientusernamtxt.Text;
                                patientHome patHome = new patientHome(Patientemail);
                                patHome.Show();
                                this.Hide();


                            }
                            else
                            {
                                MessageBox.Show("Incorrect UserName/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }

        private void patientsignup_Click(object sender, EventArgs e)
        {
            
            patientsignup pntsign = new patientsignup();
            pntsign.Show();
            this.Hide();
        }

        private void patientlogin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
