namespace Startup_Funding_and_Bidding_Management_System
{
    partial class GuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.gstbtn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gstbtn2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(39, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gstbtn1
            // 
            this.gstbtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gstbtn1.Location = new System.Drawing.Point(62, 134);
            this.gstbtn1.Margin = new System.Windows.Forms.Padding(4);
            this.gstbtn1.Name = "gstbtn1";
            this.gstbtn1.Size = new System.Drawing.Size(215, 107);
            this.gstbtn1.TabIndex = 10;
            this.gstbtn1.Text = "Market Insights";
            this.gstbtn1.UseVisualStyleBackColor = false;
            this.gstbtn1.Click += new System.EventHandler(this.gstbtn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(318, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "You are browing as a Guest";
            // 
            // gstbtn2
            // 
            this.gstbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gstbtn2.Location = new System.Drawing.Point(505, 134);
            this.gstbtn2.Margin = new System.Windows.Forms.Padding(4);
            this.gstbtn2.Name = "gstbtn2";
            this.gstbtn2.Size = new System.Drawing.Size(229, 107);
            this.gstbtn2.TabIndex = 12;
            this.gstbtn2.Text = "View Guest StartUp";
            this.gstbtn2.UseVisualStyleBackColor = false;
            this.gstbtn2.Click += new System.EventHandler(this.gstbtn2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(301, 273);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 124);
            this.button3.TabIndex = 11;
            this.button3.Text = "Live Bid Tracker";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gstbtn2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gstbtn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button gstbtn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gstbtn2;
        private System.Windows.Forms.Button button3;
    }
}