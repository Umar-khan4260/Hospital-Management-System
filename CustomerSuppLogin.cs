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
    public partial class CustomerSuppLogin : Form
    {
        OracleConnection con;
        public CustomerSuppLogin()
        {
            InitializeComponent();
        }

        private void CustomerSuppLogin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void CSpasscheck_CheckedChanged(object sender, EventArgs e)
        {
            bool check = CSpasscheck.Checked;
            switch (check)
            {
                case true:
                    CSpasstxt.UseSystemPasswordChar = false;
                    break;
                default:
                    CSpasstxt.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void CSloginbtn_Click(object sender, EventArgs e)
        {
            if (CSusernamtxt.Text == "" || CSpasstxt.Text == "")
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
                        string selectDate = "SELECT Email,Password FROM Customer_support_Staff WHERE Email = :username AND Password = :pass";
                        // Create a new OracleCommand object with the SQL query and the connection.
                        using (OracleCommand cmd = new OracleCommand(selectDate, con))
                        {
                            cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = CSusernamtxt.Text;
                            cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = CSpasstxt.Text;
                            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                // MessageBox.Show("Logged in Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string CSemail = CSusernamtxt.Text;
                                CustomerSuppHome CSHome = new CustomerSuppHome(CSemail);
                                CSHome.Show();
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
    }
}
