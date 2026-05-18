using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Startup_Funding_and_Bidding_Management_System
{
    public partial class AdminViewResultForm : Form
    {
        int id;

        string connectionString = "data source=NIGHTFURY\\SQLEXPRESS; database=StartupProject; integrated security=SSPI";

        public AdminViewResultForm(int id)
        {
            InitializeComponent();
            this.id = id;

            string query = "SELECT * FROM Results";
            FillDataGridView(query);
        }

        private void FillDataGridView(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    datagridResults.DataSource = dataTable;
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashForm adminDash = new AdminDashForm(id);
            adminDash.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
