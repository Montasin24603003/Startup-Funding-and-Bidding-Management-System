namespace Startup_Funding_and_Bidding_Management_System
{
    partial class AdminDashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashForm));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.lblAdminDash = new System.Windows.Forms.Label();
            this.btnManageStartups = new System.Windows.Forms.Button();
            this.btnManageBIds = new System.Windows.Forms.Button();
            this.btnViewResult = new System.Windows.Forms.Button();
            this.btnAdminProfile = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblTotalStartups = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(25, 357);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 41);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.Location = new System.Drawing.Point(101, 124);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(137, 46);
            this.btnAddAdmin.TabIndex = 1;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.Location = new System.Drawing.Point(305, 124);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(137, 46);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // lblAdminDash
            // 
            this.lblAdminDash.AutoSize = true;
            this.lblAdminDash.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminDash.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDash.ForeColor = System.Drawing.Color.White;
            this.lblAdminDash.Location = new System.Drawing.Point(236, 38);
            this.lblAdminDash.Name = "lblAdminDash";
            this.lblAdminDash.Size = new System.Drawing.Size(353, 33);
            this.lblAdminDash.TabIndex = 3;
            this.lblAdminDash.Text = "Welcome to Admin Dashboard";
            // 
            // btnManageStartups
            // 
            this.btnManageStartups.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStartups.Location = new System.Drawing.Point(507, 124);
            this.btnManageStartups.Name = "btnManageStartups";
            this.btnManageStartups.Size = new System.Drawing.Size(160, 46);
            this.btnManageStartups.TabIndex = 4;
            this.btnManageStartups.Text = "Manage Startups";
            this.btnManageStartups.UseVisualStyleBackColor = true;
            this.btnManageStartups.Click += new System.EventHandler(this.btnManageStartups_Click);
            // 
            // btnManageBIds
            // 
            this.btnManageBIds.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBIds.Location = new System.Drawing.Point(101, 210);
            this.btnManageBIds.Name = "btnManageBIds";
            this.btnManageBIds.Size = new System.Drawing.Size(137, 46);
            this.btnManageBIds.TabIndex = 5;
            this.btnManageBIds.Text = "Manage Bids";
            this.btnManageBIds.UseVisualStyleBackColor = true;
            this.btnManageBIds.Click += new System.EventHandler(this.btnManageBIds_Click);
            // 
            // btnViewResult
            // 
            this.btnViewResult.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewResult.Location = new System.Drawing.Point(305, 210);
            this.btnViewResult.Name = "btnViewResult";
            this.btnViewResult.Size = new System.Drawing.Size(137, 46);
            this.btnViewResult.TabIndex = 6;
            this.btnViewResult.Text = "View Result";
            this.btnViewResult.UseVisualStyleBackColor = true;
            this.btnViewResult.Click += new System.EventHandler(this.btnViewResult_Click);
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminProfile.Location = new System.Drawing.Point(507, 210);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(160, 46);
            this.btnAdminProfile.TabIndex = 7;
            this.btnAdminProfile.Text = "Admin Profile";
            this.btnAdminProfile.UseVisualStyleBackColor = true;
            this.btnAdminProfile.Click += new System.EventHandler(this.btnAdminProfile_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(297, 289);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(150, 46);
            this.btnGenerateReport.TabIndex = 8;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalUsers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalUsers.Location = new System.Drawing.Point(231, 394);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(20, 23);
            this.lblTotalUsers.TabIndex = 9;
            this.lblTotalUsers.Text = "_";
            // 
            // lblTotalStartups
            // 
            this.lblTotalStartups.AutoSize = true;
            this.lblTotalStartups.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalStartups.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStartups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalStartups.Location = new System.Drawing.Point(408, 394);
            this.lblTotalStartups.Name = "lblTotalStartups";
            this.lblTotalStartups.Size = new System.Drawing.Size(20, 23);
            this.lblTotalStartups.TabIndex = 10;
            this.lblTotalStartups.Text = "_";
            // 
            // AdminDashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalStartups);
            this.Controls.Add(this.lblTotalUsers);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnAdminProfile);
            this.Controls.Add(this.btnViewResult);
            this.Controls.Add(this.btnManageBIds);
            this.Controls.Add(this.btnManageStartups);
            this.Controls.Add(this.lblAdminDash);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.btnLogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashForm";
            this.Load += new System.EventHandler(this.AdminDashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Label lblAdminDash;
        private System.Windows.Forms.Button btnManageStartups;
        private System.Windows.Forms.Button btnManageBIds;
        private System.Windows.Forms.Button btnViewResult;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label lblTotalStartups;
    }
}