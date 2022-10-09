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
    public partial class TrackTableAdmin : Form
    {
        protected int bookIDofTrack, userIDofTrack;
        public TrackTableAdmin()
        {
            InitializeComponent();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                bookIDofTrack = Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString());
                userIDofTrack = Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query = "update TrackTable set ReturnDate=GETDATE(), Fine=0 where BookID=" + bookIDofTrack + " and UserID=" + userIDofTrack+ "and ReturnDate is NULL";
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if(r>0)
            {
                
                string query2 = "select * from BookTable where BookID=" + bookIDofTrack ;
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.ExecuteNonQuery();
                SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                adp2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                int updateQuantity = Convert.ToInt32(dt2.Rows[0]["Quantity"].ToString());
                updateQuantity++;
                string query3 = "update BookTable set Quantity=" + updateQuantity + "where BookID=" + bookIDofTrack ;
                SqlCommand cmd3 = new SqlCommand(query3, conn);
                cmd3.ExecuteNonQuery();


                string query4 = "select * from TrackTable";
                SqlCommand cmd4 = new SqlCommand(query4, conn);
                cmd4.ExecuteNonQuery();
                SqlDataAdapter adp4 = new SqlDataAdapter(cmd4);
                DataSet ds4 = new DataSet();
                adp4.Fill(ds4);
                DataTable dt4 = ds4.Tables[0];
                dataGridView4.DataSource = dt4;
                dataGridView4.AutoResizeColumns();
                dataGridView4.Refresh();
                MessageBox.Show("Book returned to library");
            }
            conn.Close();
        }

        private void lblBackToHome_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            //goAdmin = true;
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query = "select * from TrackTable";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView4.DataSource = dt;
            dataGridView4.AutoResizeColumns();
            dataGridView4.Refresh();
            conn.Close();
        }

        private void TrackTableAdmin_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query = "select * from TrackTable";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView4.DataSource = dt;
            dataGridView4.AutoResizeColumns();
            dataGridView4.Refresh();
            conn.Close();
        }
    }
}
