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
    public partial class TrackingInformation : Form
    {
        public TrackingInformation()
        {
            InitializeComponent();
        }

        private void lblBackToAdminFromTrack_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }

        private void TrackingInformation_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-BRIEJ2AN;Initial Catalog=LibraryManagementSystem_DB;Integrated Security=True");
            conn.Open();
            string query = "select * from TrackTable where UserID=" + Login.zID;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView3.DataSource = dt;
            dataGridView3.AutoResizeColumns();
            dataGridView3.Refresh();
            conn.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
