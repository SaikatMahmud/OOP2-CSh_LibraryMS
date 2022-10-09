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
    public partial class HomePage : Form
    {
        protected string userid, username, bookid, bookname;
        protected int updateFine;
        public HomePage()
        {
            InitializeComponent();
        }

        private void lblChangePass_Click(object sender, EventArgs e)
        {
            ChangePass cngpass = new ChangePass();
            cngpass.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        protected void loadFine()
        {
            updateFine = 0;
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query = "select * from TrackTable where UserID=" + Login.zID + " and Fine is not NULL";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            for (int i=0; i<(ds.Tables[0].Rows.Count); i++)
            {
                updateFine += Convert.ToInt32(dt.Rows[i]["Fine"].ToString());
            }
            conn.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                MessageBox.Show("Write something to search");
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
                conn.Open();
                string srch = txtSearch.Text;
                string query = "select * from BookTable where BookID like '%" + srch + "%' OR BookName like '%" + srch + "%' OR Authors like '%" + srch + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView2.DataSource = dt;
                dataGridView2.AutoResizeColumns();
                dataGridView2.Refresh();
                //if (ds.Tables[0].Rows.Count == 1)
                //{
                //    MessageBox.Show("No data found");
                //}
                conn.Close();
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            loadFine();

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();

            string query1 = "select * from UserTable where UserID=" + Login.zID;
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);
            DataTable dt1 = ds1.Tables[0];
            lblWelcome.Text = "Welcome, "+ (dt1.Rows[0]["UserName"].ToString());
            lblFine.Text = "Fine: " + updateFine;
            txtID.Text = dt1.Rows[0]["UserID"].ToString();
            txtName.Text = dt1.Rows[0]["Name"].ToString();
            txtMobile.Text = dt1.Rows[0]["Mobile"].ToString();
            txtEmail.Text = dt1.Rows[0]["Email"].ToString();
            userid =Convert.ToString(Login.zID);
            username= dt1.Rows[0]["UserName"].ToString();

            string query2 = "select * from BookTable";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            adp2.Fill(ds2);
            DataTable dt2 = ds2.Tables[0];
            dataGridView2.DataSource = dt2;
            dataGridView2.AutoResizeColumns();
            dataGridView2.Refresh();

            conn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            loadFine();
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query1 = "select * from UserTable where UserID=" + Login.zID;
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            adp1.Fill(ds1);
            DataTable dt1 = ds1.Tables[0];
            lblWelcome.Text = "Welcome, " + (dt1.Rows[0]["UserName"].ToString());
            lblFine.Text = "Fine: " + updateFine;
            txtID.Text = dt1.Rows[0]["UserID"].ToString();
            txtName.Text = dt1.Rows[0]["Name"].ToString();
            txtMobile.Text = dt1.Rows[0]["Mobile"].ToString();
            txtEmail.Text = dt1.Rows[0]["Email"].ToString();
            //userid = Convert.ToString(Login.zID);
            //username = dt1.Rows[0]["UserName"].ToString();

            string query2 = "select * from BookTable";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            DataSet ds2 = new DataSet();
            adp2.Fill(ds2);
            DataTable dt2 = ds2.Tables[0];
            dataGridView2.DataSource = dt2;
            dataGridView2.AutoResizeColumns();
            dataGridView2.Refresh();

            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name, mob, email;
            if (txtName.Text == "")
            {
                MessageBox.Show("Name can not be empty");
                return;
            }
            else
            {
                name = txtName.Text;
            }
            if (txtMobile.Text == "")
            {
                MessageBox.Show("Mobile can not be empty");
                return;
            }
            else
            {
                mob = txtMobile.Text;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email can not be empty");
                return;
            }
            else
            {
                email = txtEmail.Text;
            }
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query = "update UserTable set Name='" + name + "', Mobile='" + mob + "', Email='" + email + "' where UserID= " + Login.zID;
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                string query1 = "select * from UserTable where UserID=" + Login.zID;
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                cmd1.ExecuteNonQuery();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                adp1.Fill(ds1);
                DataTable dt1 = ds1.Tables[0];
                //lblWelcome.Text = "Welcome, " + (dt1.Rows[0]["UserName"].ToString());
                txtName.Text = dt1.Rows[0]["Name"].ToString();
                txtMobile.Text = dt1.Rows[0]["Mobile"].ToString();
                txtEmail.Text = dt1.Rows[0]["Email"].ToString();
                //userid = Convert.ToString(Login.zID);
                //username = dt1.Rows[0]["UserName"].ToString();
                MessageBox.Show("Update successful");
            }
            conn.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.zID = 0;
            Login.userPass = false;
            Login lgin = new Login();
            lgin.Show();
            this.Hide();
        }

        private void btnBorrowInfo_Click(object sender, EventArgs e)
        {
            TrackingInformation trck = new TrackingInformation();
            trck.Show();

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query5 = "select * from TrackTable where UserID=" + Login.zID + "and ReturnDate is NULL and BookID='"+bookid+"'";
            SqlCommand cmd5 = new SqlCommand(query5, conn);
            cmd5.ExecuteNonQuery();
            SqlDataAdapter adp5 = new SqlDataAdapter(cmd5);
            DataSet ds5 = new DataSet();
            adp5.Fill(ds5);
            DataTable dt5 = ds5.Tables[0];
            if (ds5.Tables[0].Rows.Count < 1)
            {
                string query0 = "select * from TrackTable where UserID=" + Login.zID + "and ReturnDate is NULL";
                SqlCommand cmd0 = new SqlCommand(query0, conn);
                cmd0.ExecuteNonQuery();
                SqlDataAdapter adp0 = new SqlDataAdapter(cmd0);
                DataSet ds0 = new DataSet();
                adp0.Fill(ds0);
                DataTable dt0 = ds0.Tables[0];
                if (ds0.Tables[0].Rows.Count < 5)
                {
                    string query2 = "select * from BookTable where BookID='" + bookid + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.ExecuteNonQuery();
                    SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
                    DataSet ds2 = new DataSet();
                    adp2.Fill(ds2);
                    DataTable dt2 = ds2.Tables[0];
                    int updateQuantity = Convert.ToInt32(dt2.Rows[0]["Quantity"].ToString());
                    if (updateQuantity > 0)
                    {
                        updateQuantity--;
                        string query1 = "insert into TrackTable (BookID,BookName,UserID,UserName,BorrowDate) values ('" + bookid + "','" + bookname + "','" + userid + "','" + username + "',GETDATE())";
                        SqlCommand cmd1 = new SqlCommand(query1, conn);
                        cmd1.ExecuteNonQuery();
                        string query3 = "update BookTable set Quantity=" + updateQuantity + "where BookID='" + bookid + "'";
                        SqlCommand cmd3 = new SqlCommand(query3, conn);
                        int r = cmd3.ExecuteNonQuery();
                        if (r > 0)
                        {
                            string query4 = "select * from BookTable";
                            SqlCommand cmd4 = new SqlCommand(query4, conn);
                            cmd4.ExecuteNonQuery();
                            SqlDataAdapter adp4 = new SqlDataAdapter(cmd4);
                            DataSet ds4 = new DataSet();
                            adp4.Fill(ds4);
                            DataTable dt4 = ds4.Tables[0];
                            dataGridView2.DataSource = dt4;
                            dataGridView2.AutoResizeColumns();
                            dataGridView2.Refresh();
                            MessageBox.Show("Book borrowed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book currenty unavailable");
                    }
                }
                else
                {
                    MessageBox.Show("Borrow limit max 5 !");
                }
            }
            else
            {
                MessageBox.Show("Book already borrowed !");
            }
            conn.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int bID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
                conn.Open();
                string query = "select * from BookTable where BookID=" + bID;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                bookid = dt.Rows[0]["BookID"].ToString();
                bookname = dt.Rows[0]["BookName"].ToString();
                conn.Close();
            }
        }
    }
}