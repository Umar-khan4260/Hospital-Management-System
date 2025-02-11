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
using Oracle.ManagedDataAccess.Client;

namespace Database_project
{
    public partial class adminlogin : Form
    {

        OracleConnection con;
        public adminlogin()
        {
            InitializeComponent();
        }

        private void usernamtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passcheck_CheckedChanged(object sender, EventArgs e)
        {
            bool check = passcheck.Checked;
            switch (check)
            {
                case true:
                    passtxt.UseSystemPasswordChar = false;
                    break;
                default:
                    passtxt.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usernamtxt.Text == "" || passtxt.Text == "")
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
                        string selectDate = "SELECT email,password FROM Admin WHERE email = :username AND password = :pass";
                        // Create a new OracleCommand object with the SQL query and the connection.
                        using (OracleCommand cmd = new OracleCommand(selectDate, con))
                        {
                            cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = usernamtxt.Text;
                            cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = passtxt.Text;
                            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                string adminEmail = usernamtxt.Text;
                               // MessageBox.Show("Logged in Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AdminHome adminHome = new AdminHome(adminEmail);
                                adminHome.Show();
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



            //if (usernamtxt.Text == "" || passtxt.Text == "")
            //{
            //    MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //else
            //{
            //    // Check if the database connection is not already open.
            //    if (con.State != ConnectionState.Open)
            //    {
            //        MessageBox.Show("connection opened");
            //        try
            //        {
            //            con.Open();

            //            // wrtiting query
            //            string selectDate = "SELECT * FROM Admin WHERE email = :username AND password = :pass";
            //            // Create a new OracleCommand object with the SQL query and the connection.
            //            using (OracleCommand cmd = new OracleCommand(selectDate, con))
            //            {
            //                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = usernamtxt.Text;
            //                cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = passtxt.Text;
            //                //OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            //                //DataTable table = new DataTable();
            //                //adapter.Fill(table);
            //                using (OracleDataReader reader = cmd.ExecuteReader())
            //                {
            //                    if (reader.Read())
            //                    {
            //                        MessageBox.Show("Logged in Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //                        AdminHome adminHome = new AdminHome();
            //                        adminHome.Show();
            //                        this.Hide();
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("Incorrect UserName/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    }
            //                }

            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        finally
            //        {
            //            con.Close();
            //        }
            //    }
            //}

        }

        private void adminlogin_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE=localhost:1521/XE;USER ID=HMS;PASSWORD=123";
            con = new OracleConnection(conStr);
        }
    }
}
