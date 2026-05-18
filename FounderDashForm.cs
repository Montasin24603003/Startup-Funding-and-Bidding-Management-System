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
    
    public partial class AdminAddUser : Form
    {
        int id;
        public AdminAddUser()
        {
            InitializeComponent();
        }

        public AdminAddUser(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageUsersForm mu = new ManageUsersForm(id);
            mu.ShowDialog();
            this.Hide();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=NIGHTFURY\\SQLEXPRESS; database=StartupProject; integrated security=SSPI";

            string name = tbName.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
            string role = "";

            if (rbFounder.Checked)
            {
                role = "Founder";
            }

            else if (rbInvestor.Checked)
            {
                role = "Investor";
            }

            else
            {
                MessageBox.Show("Please select a Role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                 string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Users (Name, Email, Password, Role) VALUES (@Name, @Email, @Password, @Role)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                       ManageUsersForm manageUser = new ManageUsersForm(id);
                        manageUser.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Failed to create the profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
