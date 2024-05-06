namespace HMS
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.buttonDoctors = new Guna.UI2.WinForms.Guna2Button();
            this.buttonPatients = new Guna.UI2.WinForms.Guna2Button();
            this.buttonMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelClose = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDoctors
            // 
            this.buttonDoctors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDoctors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDoctors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDoctors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDoctors.FillColor = System.Drawing.Color.Purple;
            this.buttonDoctors.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDoctors.ForeColor = System.Drawing.Color.White;
            this.buttonDoctors.Location = new System.Drawing.Point(108, 151);
            this.buttonDoctors.Name = "buttonDoctors";
            this.buttonDoctors.Size = new System.Drawing.Size(180, 45);
            this.buttonDoctors.TabIndex = 5;
            this.buttonDoctors.Text = "Doctors";
            this.buttonDoctors.Click += new System.EventHandler(this.buttonDoctors_Click);
            // 
            // buttonPatients
            // 
            this.buttonPatients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPatients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPatients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPatients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPatients.FillColor = System.Drawing.Color.Purple;
            this.buttonPatients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPatients.ForeColor = System.Drawing.Color.White;
            this.buttonPatients.Location = new System.Drawing.Point(108, 251);
            this.buttonPatients.Name = "buttonPatients";
            this.buttonPatients.Size = new System.Drawing.Size(180, 45);
            this.buttonPatients.TabIndex = 6;
            this.buttonPatients.Text = "Patients";
            this.buttonPatients.Click += new System.EventHandler(this.buttonPatients_Click);
            // 
            // buttonMedicine
            // 
            this.buttonMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMedicine.FillColor = System.Drawing.Color.Purple;
            this.buttonMedicine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMedicine.ForeColor = System.Drawing.Color.White;
            this.buttonMedicine.Location = new System.Drawing.Point(108, 351);
            this.buttonMedicine.Name = "buttonMedicine";
            this.buttonMedicine.Size = new System.Drawing.Size(180, 45);
            this.buttonMedicine.TabIndex = 7;
            this.buttonMedicine.Text = "Medicine";
            this.buttonMedicine.Click += new System.EventHandler(this.buttonMedicine_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelClose
            // 
            this.labelClose.BackColor = System.Drawing.Color.Transparent;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelClose.ForeColor = System.Drawing.Color.Purple;
            this.labelClose.Location = new System.Drawing.Point(357, 25);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(15, 27);
            this.labelClose.TabIndex = 9;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click_1);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 504);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMedicine);
            this.Controls.Add(this.buttonPatients);
            this.Controls.Add(this.buttonDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonDoctors;
        private Guna.UI2.WinForms.Guna2Button buttonPatients;
        private Guna.UI2.WinForms.Guna2Button buttonMedicine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelClose;
    }
}