namespace Startup_Funding_and_Bidding_Management_System
{
    partial class FounderDashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FounderDashForm));
            this.lblFounderDashboard = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAddStartup = new System.Windows.Forms.Button();
            this.btnViewStartup = new System.Windows.Forms.Button();
            this.btnViewBids = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFounderDashboard
            // 
            this.lblFounderDashboard.AutoSize = true;
            this.lblFounderDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblFounderDashboard.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFounderDashboard.ForeColor = System.Drawing.Color.White;
            this.lblFounderDashboard.Location = new System.Drawing.Point(223, 46);
            this.lblFounderDashboard.Name = "lblFounderDashboard";
            this.lblFounderDashboard.Size = new System.Drawing.Size(373, 33);
            this.lblFounderDashboard.TabIndex = 0;
            this.lblFounderDashboard.Text = "Welcome to Founder Dashboard";
            this.lblFounderDashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(45, 368);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(83, 40);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddStartup
            // 
            this.btnAddStartup.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStartup.Location = new System.Drawing.Point(136, 218);
            this.btnAddStartup.Name = "btnAddStartup";
            this.btnAddStartup.Size = new System.Drawing.Size(130, 54);
            this.btnAddStartup.TabIndex = 2;
            this.btnAddStartup.Text = "Add Startup";
            this.btnAddStartup.UseVisualStyleBackColor = true;
            this.btnAddStartup.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnViewStartup
            // 
            this.btnViewStartup.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStartup.Location = new System.Drawing.Point(355, 218);
            this.btnViewStartup.Name = "btnViewStartup";
            this.btnViewStartup.Size = new System.Drawing.Size(130, 54);
            this.btnViewStartup.TabIndex = 3;
            this.btnViewStartup.Text = "View Startups";
            this.btnViewStartup.UseVisualStyleBackColor = true;
            this.btnViewStartup.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnViewBids
            // 
            this.btnViewBids.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBids.Location = new System.Drawing.Point(540, 218);
            this.btnViewBids.Name = "btnViewBids";
            this.btnViewBids.Size = new System.Drawing.Size(130, 54);
            this.btnViewBids.TabIndex = 4;
            this.btnViewBids.Text = "View Bids";
            this.btnViewBids.UseVisualStyleBackColor = true;
            this.btnViewBids.Click += new System.EventHandler(this.button4_Click);
            // 
            // FounderDashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewBids);
            this.Controls.Add(this.btnViewStartup);
            this.Controls.Add(this.btnAddStartup);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblFounderDashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FounderDashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Founder Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFounderDashboard;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAddStartup;
        private System.Windows.Forms.Button btnViewStartup;
        private System.Windows.Forms.Button btnViewBids;
    }
}