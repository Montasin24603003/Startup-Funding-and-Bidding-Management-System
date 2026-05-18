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
    public partial class AdminDashForm : Form
    {
        int id;

        string connectionString = "data source=NIGHTFURY\\SQLEXPRESS; database=StartupProject; integrated security=SSPI";

        public AdminDashForm()
        {
            InitializeComponent();
        }

        public AdminDashForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?",
                "Confirm Logout", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }

        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            AddAdminForm addadmin = new AddAdminForm(id);
            addadmin.Show();
            this.Hide();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm managerUser = new ManageUsersForm(id);
            managerUser.Show();
            this.Hide();
        }

        private void btnManageStartups_Click(object sender, EventArgs e)
        {
            ManageStartupsForm managerStartup = new ManageStartupsForm(id);
            managerStartup.Show();
            this.Hide();
        }

        private void btnManageBIds_Click(object sender, EventArgs e)
        {
            ManageBidsForm manageBid = new ManageBidsForm(id);
            manageBid.Show();
            this.Hide();
        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            AdminViewResultForm adminViewResult = new AdminViewResultForm(id);
            adminViewResult.Show();
            this.Hide();
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            AdminProfileForm adminProfile = new AdminProfileForm(id);
            adminProfile.Show();
            this.Hide();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReportForm generateReport = new GenerateReportForm(id);
            generateReport.Show();
            this.Hide();
        }


        private void LoadStatistics()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // -------------------------
                // TOTAL USERS
                // -------------------------
                SqlCommand cmdUsers = new SqlCommand("SELECT COUNT(*) FROM Users", connection);
                int totalUsers = (int)cmdUsers.ExecuteScalar();
                lblTotalUsers.Text = "Total Users: " + totalUsers;

                // -------------------------
                // TOTAL STARTUPS
                // -------------------------
                SqlCommand cmdStartups = new SqlCommand("SELECT COUNT(*) FROM Startups", connection);
                int totalStartups = (int)cmdStartups.ExecuteScalar();
                lblTotalStartups.Text = "Total Startups: " + totalStartups;
            }
        }

        private void AdminDashForm_Load(object sender, EventArgs e)
        {
            LoadStatistics();
        }
    }
}
