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
    public partial class AdminProfileForm : Form
    {
        int id;
        string connectionString = "data source=NIGHTFURY\\SQLEXPRESS; database=StartupProject; integrated security=SSPI";

        public AdminProfileForm(int id)
        {
            InitializeComponent();
            this.id = id;
            LoadDetails();
        }

        private void LoadDetails()
        {
            string query = "SELECT UserID, Name, Email, Password FROM Users WHERE UserID = @id";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        lblID.Text = reader["UserID"].ToString();
                        tbName.Text = reader["Name"].ToString();
                        tbEmail.Text = reader["Email"].ToString();
                        tbPassword.Text = reader["Password"].ToString();

                    }
                    else
                    {
                        MessageBox.Show("No details found for the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashForm adminDash = new AdminDashForm(id);
            adminDash.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newName = tbName.Text.Trim();
            string newEmail = tbEmail.Text.Trim();
            string newPassword = tbPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newEmail) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Users SET Name = @Name, Email = @Email, Password = @Password WHERE UserID = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Name", newName);
                    command.Parameters.AddWithValue("@Email", newEmail);
                    command.Parameters.AddWithValue("@Password", newPassword);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminDashForm adminDash = new AdminDashForm(id);
                        adminDash.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("No record was updated. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to delete this profile?",
               "Confirm Deletion",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Users WHERE UserID = @Id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoginForm login = new LoginForm();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No profile was found to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
