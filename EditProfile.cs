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
    public partial class AdminAddStartup : Form
    {
        int id;

        string connectionString = "data source=NIGHTFURY\\SQLEXPRESS; database=StartupProject; integrated security=SSPI";

        public AdminAddStartup()
        {
            InitializeComponent();
        }

        public AdminAddStartup(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashForm adminDash = new AdminDashForm(id);
            this.Hide();
            adminDash.Show();
        }


        private void ClearFields()
        {
            tbTitle.Clear();
            rtbDescription.Clear();
            tbAmount.Clear();
            tbEquity.Clear();
            dtpDeadline.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text) ||
               string.IsNullOrWhiteSpace(rtbDescription.Text) ||
               string.IsNullOrWhiteSpace(tbAmount.Text) ||
               string.IsNullOrWhiteSpace(tbEquity.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                string query = "INSERT INTO Startups (UserID, Title, Description, RequiredAmount, EquityOffered, Deadline) VALUES (@UserID, @Title, @Description, @RequiredAmount, @EquityOffered, @Deadline)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", id);
                        command.Parameters.AddWithValue("@Title", tbTitle.Text.Trim());
                        command.Parameters.AddWithValue("@Description", rtbDescription.Text.Trim());
                        command.Parameters.AddWithValue("@RequiredAmount", Convert.ToDecimal(tbAmount.Text));
                        command.Parameters.AddWithValue("@EquityOffered", Convert.ToDecimal(tbEquity.Text));
                        command.Parameters.AddWithValue("@Deadline", dtpDeadline.Value.Date);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Startup saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
