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
    public partial class Dashboard : Form
    {
        private bool isNew = false;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query = "select * from BookTable";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Refresh();
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                int bID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
                conn.Open();
                string query = "select * from BookTable where BookID=" + bID;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                txtID.Text = dt.Rows[0]["BookID"].ToString();
                txtName.Text = dt.Rows[0]["BookName"].ToString();
                txtAuthors.Text = dt.Rows[0]["Authors"].ToString();
                txtShelfNo.Text = dt.Rows[0]["ShelfNo"].ToString();
                txtQuantity.Text = dt.Rows[0]["Quantity"].ToString();
                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string bName, authors;
            int bID, shelf, quantity;
           
            bName = txtName.Text;
            authors = txtAuthors.Text;
            shelf = Convert.ToInt32(txtShelfNo.Text);
            quantity = Convert.ToInt32(txtQuantity.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query;
            if (isNew == true)
            {
                query = "insert into BookTable (BookName,Authors,ShelfNo,Quantity) values('" + bName + "','" + authors + "'," + shelf + "," + quantity + ")";
                isNew = false;
            }
            else
            {
                bID = Convert.ToInt32(txtID.Text);
                query = "update BookTable set BookName='" + bName + "', Authors='" + authors + "', ShelfNo=" + shelf + " , Quantity= " + quantity + " where BookID= " + bID;
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            int r=cmd.ExecuteNonQuery();
            if (r > 0)
            {
                query = "select * from BookTable";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.Refresh();
                MessageBox.Show("Operation successful");
            }
            conn.Close();
            txtID.Text = "";
            txtName.Text = "";
            txtAuthors.Text = "";
            txtShelfNo.Text = "";
            txtQuantity.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAuthors.Text = "";
            txtShelfNo.Text = "";
            txtQuantity.Text = "";
            isNew = true;

        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            int bID = Convert.ToInt32(txtID.Text);
            string query = "delete from BookTable where BookID=" + bID;
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                query = "select * from BookTable";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.Refresh();
                MessageBox.Show("Operation successful");
            }
            conn.Close();
            txtID.Text = "";
            txtName.Text = "";
            txtAuthors.Text = "";
            txtShelfNo.Text = "";
            txtQuantity.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchBookAdmin.Text == "")
                MessageBox.Show("Write something to search");
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
                conn.Open();
                string srch = txtSearchBookAdmin.Text;
                string query = "select * from BookTable where BookID like '%" + srch + "%' OR BookName like '%" + srch + "%' OR Authors like '%" + srch + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                //if (ds.Tables[0].Rows.Count == 1)
                //{
                //    MessageBox.Show("No data found");
                //}
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAuthors.Text = "";
            txtShelfNo.Text = "";
            txtQuantity.Text = "";
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query = "select * from BookTable";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Refresh();
            conn.Close();
        }

        private void lblGoHome_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
