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
    public partial class ChangePass : Form
    {
        protected string current, pass, rePass;
        public ChangePass()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //void changePassword(string Q, string P)
        //{
        //        //string current, pass, rePass;
        //        if (txtCurrent.Text == "")
        //        {
        //            MessageBox.Show("Enter current password");
        //            return;
        //        }
        //        else
        //    {  current = txtCurrent.Text;}

        //    if (txtNew.Text == "")
        //    {
        //        MessageBox.Show("Enter new password");
        //        return;
        //    }
        //    else
        //    { pass = txtNew.Text; }

        //        if (txtNew.Text != txtRe.Text)
        //        {
        //            MessageBox.Show("New password not matched");
        //            return;
        //        }
        //        else
        //        { rePass = txtRe.Text; }

        //        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
        //        conn.Open();
        //        //string query1 = "select * from UserTable where UserID='" + Login.zID + "'and Password='" + current + "'";
        //        SqlCommand cmd1 = new SqlCommand(Q, conn);
        //        cmd1.ExecuteNonQuery();
        //        SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
        //        DataSet ds1 = new DataSet();
        //        adp1.Fill(ds1);
        //        DataTable dt1 = ds1.Tables[0];
        //        if (ds1.Tables[0].Rows.Count == 1)
        //        {
        //            //string query2 = "update UserTable set Password='" + rePass + "' where UserID=" + Login.zID;
        //            SqlCommand cmd2 = new SqlCommand(P, conn);
        //            int r = cmd2.ExecuteNonQuery();
        //            if (r > 0)
        //            {
        //                MessageBox.Show("Password has been changed");
        //                txtCurrent.Text = "";
        //                txtNew.Text = "";
        //                txtRe.Text = "";
        //                this.Hide();
        //            }
        //        }
        //        else
        //        { MessageBox.Show("Current password not matched"); }
        //        conn.Close();
            
        //}

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            if (Login.userPass == true)
            {
                if (txtCurrent.Text == "")
                {
                    MessageBox.Show("Enter current password");
                    return;
                }
                else
                    current = txtCurrent.Text;
                if (txtNew.Text == "")
                {
                    MessageBox.Show("Enter new password");
                    return;
                }
                else
                    pass = txtNew.Text;
                if (txtNew.Text != txtRe.Text)
                {
                    MessageBox.Show("New password not matched");
                    return;
                }
                else
                { rePass = txtRe.Text; }

                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
                conn.Open();
                string query1 = "select * from UserTable where UserID='" + Login.zID + "'and Password='" + current + "'";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.ExecuteNonQuery();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1);
                DataTable dt1 = ds1.Tables[0];
                if (ds1.Tables[0].Rows.Count == 1)
                {
                    string query2 = "update UserTable set Password='" + rePass + "' where UserID=" + Login.zID;
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    int r = cmd2.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Password has been changed");
                        txtCurrent.Text = "";
                        txtNew.Text = "";
                        txtRe.Text = "";
                        this.Hide();
                    }
                }
                else
                { MessageBox.Show("Current password not matched"); }
                conn.Close();
            }

            if (Login.adminPass == true)
            {
                if (txtCurrent.Text == "")
                {
                    MessageBox.Show("Enter current password");
                    return;
                }
                else
                    current = txtCurrent.Text;
                if (txtNew.Text == "")
                {
                    MessageBox.Show("Enter new password");
                    return;
                }
                else
                    pass = txtNew.Text;
                if (txtNew.Text != txtRe.Text)
                {
                    MessageBox.Show("New password not matched");
                    return;
                }
                else
                { rePass = txtRe.Text; }

                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
                conn.Open();
                string query1 = "select * from AdminInfoTable where UserID='" + Login.zID + "'and Password='" + current + "'";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.ExecuteNonQuery();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1);
                DataTable dt1 = ds1.Tables[0];
                if (ds1.Tables[0].Rows.Count == 1)
                {
                    string query2 = "update AdminInfoTable set Password='" + rePass + "' where UserID=" + Login.zID;
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    int r = cmd2.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Password has been changed");
                        txtCurrent.Text = "";
                        txtNew.Text = "";
                        txtRe.Text = "";
                        this.Hide();
                    }
                }
                else
                { MessageBox.Show("Current password not matched"); }
                conn.Close();
            }

            //if (Login.userPass == true)
            //{
            //    string query1 = "select * from UserTable where UserID='" + Login.zID + "'and Password='" + current + "'";
            //    string query2 = "update UserTable set Password='" + rePass + "' where UserID=" + Login.zID;
            //    changePassword(query1, query2);
            //}
            //if (Login.adminPass == true)
            //{
            //    string query3 = "select * from AdminInfoTable where UserID='" + Login.zID + "'and Password='" + current + "'";
            //    string query4 = "update AdminInfoTable set Password='" + rePass + "' where UserID=" + Login.zID;
            //    changePassword(query3, query4);
            //}
        }
    }
}