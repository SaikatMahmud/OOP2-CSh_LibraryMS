using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS_GUI
{
    
    public partial class Login : Form
    {
        internal static bool userPass = false;
        internal static bool adminPass = false;
        internal static int zID;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNotRegistered_Click(object sender, EventArgs e)
        {
            SignUp sgup = new SignUp();
            sgup.Show();
            this.Hide();

        }
        void runFineCalculateTable()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query = "update TrackTable set Fine=50 where DATEDIFF(d, BorrowDate, GETDATE())>=10 and ReturnDate is NULL";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        internal void btnLogin_Click(object sender, EventArgs e)
        {
            string username, pass;
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username not provided");
                return;
            }
            else
            {
                username = txtUsername.Text;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password not provided");
                return;
            }
            else
            {
                pass = txtPassword.Text;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query1 = "select * from UserTable where UserName= '" + username + "' AND Password='" + pass + "'";
            string query2 = "select * from AdminInfoTable where UserName= '" + username + "' AND Password='" + pass + "'";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            //if (row1>1)
            // {
            //     MessageBox.Show("Login Successful");
            //     HomePage hmpg = new HomePage();
            //     hmpg.Show();
            //     this.Hide();
            // }
            //if (row2 >1)
            // {
            //     MessageBox.Show("Login Successful");
            //     Admin ad = new Admin();
            //     ad.Show();
            //     this.Hide();
            // }
            // //if ((row1 == 0 && row1 > 1) || (row2 == 0 && row2 > 1))
            // else
            // { 
            //     MessageBox.Show("Login failed (invalid login data)");
            // }
            //if (row1 == 0 && row1 > 1)
            //{
            //    MessageBox.Show("Login failed (invalid login data)");
            //}
            //else if (row1==1)
            //{
            //    HomePage hmpg = new HomePage();
            //    hmpg.Show();
            //    this.Hide();
            //    MessageBox.Show("Login Successful");

            //}

            SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            adp1.Fill(ds1);
            adp2.Fill(ds2);
            DataTable dt1 = ds1.Tables[0];
            DataTable dt2 = ds2.Tables[0];
            if (ds1.Tables[0].Rows.Count == 1)
            {
                zID = Convert.ToInt32(dt1.Rows[0]["UserID"].ToString());
                userPass = true;
                HomePage hmpg = new HomePage();
                hmpg.Show();
                //goHomeUser = true;
                this.Hide();
                MessageBox.Show("Login Successful");  
                runFineCalculateTable(); 
            }
            else if (ds2.Tables[0].Rows.Count == 1)
            {
                zID = Convert.ToInt32(dt2.Rows[0]["UserID"].ToString());
                adminPass = true;
                Admin ad = new Admin();
                ad.Show();
                //goAdmin = true;
                this.Hide();
                MessageBox.Show("Login Successful as Admin");
                runFineCalculateTable();
            }
            else
            { MessageBox.Show("Invalid Username or Password"); }
            conn.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}


