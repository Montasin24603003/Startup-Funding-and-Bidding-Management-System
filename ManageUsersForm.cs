namespace Startup_Funding_and_Bidding_Management_System
{
    partial class GuestViewStartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestViewStartUp));
            this.gststartlbl1 = new System.Windows.Forms.Label();
            this.gstViewStartUpbtn2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gstStartupbt1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gststartlbl1
            // 
            this.gststartlbl1.AutoSize = true;
            this.gststartlbl1.Location = new System.Drawing.Point(287, 39);
            this.gststartlbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gststartlbl1.Name = "gststartlbl1";
            this.gststartlbl1.Size = new System.Drawing.Size(199, 16);
            this.gststartlbl1.TabIndex = 7;
            this.gststartlbl1.Text = "Do you want to see our startups?";
            this.gststartlbl1.Click += new System.EventHandler(this.gststartlbl1_Click);
            // 
            // gstViewStartUpbtn2
            // 
            this.gstViewStartUpbtn2.Location = new System.Drawing.Point(570, 39);
            this.gstViewStartUpbtn2.Margin = new System.Windows.Forms.Padding(4);
            this.gstViewStartUpbtn2.Name = "gstViewStartUpbtn2";
            this.gstViewStartUpbtn2.Size = new System.Drawing.Size(100, 28);
            this.gstViewStartUpbtn2.TabIndex = 6;
            this.gstViewStartUpbtn2.Text = "Show";
            this.gstViewStartUpbtn2.UseVisualStyleBackColor = true;
            this.gstViewStartUpbtn2.Click += new System.EventHandler(this.gstViewStartUpbtn2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(739, 325);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gstStartupbt1
            // 
            this.gstStartupbt1.Location = new System.Drawing.Point(22, 411);
            this.gstStartupbt1.Margin = new System.Windows.Forms.Padding(4);
            this.gstStartupbt1.Name = "gstStartupbt1";
            this.gstStartupbt1.Size = new System.Drawing.Size(100, 28);
            this.gstStartupbt1.TabIndex = 4;
            this.gstStartupbt1.Text = "Back";
            this.gstStartupbt1.UseVisualStyleBackColor = true;
            this.gstStartupbt1.Click += new System.EventHandler(this.gstStartupbt1_Click);
            // 
            // GuestViewStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gststartlbl1);
            this.Controls.Add(this.gstViewStartUpbtn2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gstStartupbt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestViewStartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestViewStartUp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gststartlbl1;
        private System.Windows.Forms.Button gstViewStartUpbtn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gstStartupbt1;
    }
}