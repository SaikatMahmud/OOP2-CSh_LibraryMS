using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LMS_GUI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            Login lgin = new Login();
            lgin.Show();
            this.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string name, mobile, email, gender = " ", username, password;
            DateTime dob = Convert.ToDateTime(dateTimePicker1.Text);
            if(txtName.Text== "")
            {
                MessageBox.Show("Name not provided");
                return;
            }
            else
            {
                name = txtName.Text;
            }
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username not provided");
                return;
            }
            else
            {
                username = txtUsername.Text;
            }
            if (txtMobile.Text == "")
            {
                MessageBox.Show("Mobile not provided");
                return;
            }
            else
            {
                mobile = txtMobile.Text;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email not provided");
                return;
            }
            else
            {
                email = txtEmail.Text;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password not provided");
                return;
            }
            else
            {
                password = txtPassword.Text;
            }

            if (rbtnMale.Checked)
            { gender = "Male"; }
            else if (rbtnFemale.Checked)
            { gender = "Female"; }
            else if (rbtnOther.Checked)
            { gender = "Other"; }
            else if (!rbtnMale.Checked || !rbtnFemale.Checked || !rbtnOther.Checked)
            {
                MessageBox.Show("Gender not selected");
                return;
            }

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query="insert into UserTable (Name,Mobile,Email,Gender,DOB,UserName,Password) values ('" + name + "','" + mobile + "','" + email + "', '" + gender + "', '" + dob + "', '" + username + "', '" + password + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int row=cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Signup Successful");
                Login lgin = new Login();
                lgin.Show();
                this.Hide();
            }
            conn.Close();
        }
    }
}
