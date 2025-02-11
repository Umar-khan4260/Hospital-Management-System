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
    public partial class Doclogin : Form
    {
        OracleConnection con;
        public Doclogin()
        {
            InitializeComponent();
        }

        private void Doclogin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void Docusernamtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Docpasstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Docpasscheck_CheckedChanged(object sender, EventArgs e)
        {
            bool check = Docpasscheck.Checked;
            switch (check)
            {
                case true:
                    Docpasstxt.UseSystemPasswordChar = false;
                    break;
                default:
                    Docpasstxt.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void Docloginbtn_Click(object sender, EventArgs e)
        {
            if (Docusernamtxt.Text == "" || Docpasstxt.Text == "")
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
                        string selectDate = "SELECT Email,Password FROM Doctor WHERE Email = :username AND Password = :pass";
                        // Create a new OracleCommand object with the SQL query and the connection.
                        using (OracleCommand cmd = new OracleCommand(selectDate, con))
                        {
                            cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = Docusernamtxt.Text;
                            cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = Docpasstxt.Text;
                            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                string docEmail=Docusernamtxt.Text;
                                // MessageBox.Show("Logged in Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DocHome docHome = new DocHome(docEmail);
                                docHome.Show();
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
        
        private void Docsignup_Click(object sender, EventArgs e)
        {


        }
    }
}
