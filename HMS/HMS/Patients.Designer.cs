namespace HMS
{
    partial class Patients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.labelDisease = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textboxDoctor = new Guna.UI2.WinForms.Guna2TextBox();
            this.textboxDisease = new Guna.UI2.WinForms.Guna2TextBox();
            this.textboxAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.textboxName = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewPatients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelClose = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDoctors = new Guna.UI2.WinForms.Guna2Button();
            this.buttonHome = new Guna.UI2.WinForms.Guna2Button();
            this.labelTag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelDoctor.ForeColor = System.Drawing.Color.Purple;
            this.labelDoctor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDoctor.Location = new System.Drawing.Point(256, 379);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(69, 25);
            this.labelDoctor.TabIndex = 50;
            this.labelDoctor.Text = "Doctor";
            // 
            // labelDisease
            // 
            this.labelDisease.AutoSize = true;
            this.labelDisease.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelDisease.ForeColor = System.Drawing.Color.Purple;
            this.labelDisease.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDisease.Location = new System.Drawing.Point(250, 308);
            this.labelDisease.Name = "labelDisease";
            this.labelDisease.Size = new System.Drawing.Size(75, 25);
            this.labelDisease.TabIndex = 49;
            this.labelDisease.Text = "Disease";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelAge.ForeColor = System.Drawing.Color.Purple;
            this.labelAge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAge.Location = new System.Drawing.Point(280, 240);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(45, 25);
            this.labelAge.TabIndex = 48;
            this.labelAge.Text = "Age";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.Purple;
            this.labelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelName.Location = new System.Drawing.Point(264, 168);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 25);
            this.labelName.TabIndex = 47;
            this.labelName.Text = "Name";
            // 
            // textboxDoctor
            // 
            this.textboxDoctor.BorderColor = System.Drawing.Color.Purple;
            this.textboxDoctor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxDoctor.DefaultText = "";
            this.textboxDoctor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxDoctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxDoctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxDoctor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxDoctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxDoctor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxDoctor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxDoctor.Location = new System.Drawing.Point(368, 356);
            this.textboxDoctor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxDoctor.Name = "textboxDoctor";
            this.textboxDoctor.PasswordChar = '\0';
            this.textboxDoctor.PlaceholderText = "";
            this.textboxDoctor.SelectedText = "";
            this.textboxDoctor.Size = new System.Drawing.Size(229, 48);
            this.textboxDoctor.TabIndex = 45;
            // 
            // textboxDisease
            // 
            this.textboxDisease.BorderColor = System.Drawing.Color.Purple;
            this.textboxDisease.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxDisease.DefaultText = "";
            this.textboxDisease.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxDisease.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxDisease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxDisease.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxDisease.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxDisease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxDisease.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxDisease.Location = new System.Drawing.Point(368, 287);
            this.textboxDisease.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxDisease.Name = "textboxDisease";
            this.textboxDisease.PasswordChar = '\0';
            this.textboxDisease.PlaceholderText = "";
            this.textboxDisease.SelectedText = "";
            this.textboxDisease.Size = new System.Drawing.Size(229, 48);
            this.textboxDisease.TabIndex = 44;
            // 
            // textboxAge
            // 
            this.textboxAge.BorderColor = System.Drawing.Color.Purple;
            this.textboxAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxAge.DefaultText = "";
            this.textboxAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxAge.Location = new System.Drawing.Point(368, 221);
            this.textboxAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxAge.Name = "textboxAge";
            this.textboxAge.PasswordChar = '\0';
            this.textboxAge.PlaceholderText = "";
            this.textboxAge.SelectedText = "";
            this.textboxAge.Size = new System.Drawing.Size(229, 48);
            this.textboxAge.TabIndex = 43;
            // 
            // textboxName
            // 
            this.textboxName.BorderColor = System.Drawing.Color.Purple;
            this.textboxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxName.DefaultText = "";
            this.textboxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxName.Location = new System.Drawing.Point(368, 150);
            this.textboxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxName.Name = "textboxName";
            this.textboxName.PasswordChar = '\0';
            this.textboxName.PlaceholderText = "";
            this.textboxName.SelectedText = "";
            this.textboxName.Size = new System.Drawing.Size(229, 48);
            this.textboxName.TabIndex = 42;
            // 
            // buttonDelete
            // 
            this.buttonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDelete.FillColor = System.Drawing.Color.Purple;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(499, 507);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(126, 45);
            this.buttonDelete.TabIndex = 41;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonUpdate.FillColor = System.Drawing.Color.Purple;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(350, 507);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(126, 45);
            this.buttonUpdate.TabIndex = 40;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.Color.Purple;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(199, 507);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 45);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewPatients
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPatients.ColumnHeadersHeight = 20;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPatients.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewPatients.Location = new System.Drawing.Point(646, 148);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.RowHeadersVisible = false;
            this.dataGridViewPatients.RowHeadersWidth = 51;
            this.dataGridViewPatients.RowTemplate.Height = 24;
            this.dataGridViewPatients.Size = new System.Drawing.Size(522, 293);
            this.dataGridViewPatients.TabIndex = 38;
            this.dataGridViewPatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewPatients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewPatients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewPatients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewPatients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewPatients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewPatients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewPatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Purple;
            this.dataGridViewPatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewPatients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewPatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewPatients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewPatients.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridViewPatients.ThemeStyle.ReadOnly = false;
            this.dataGridViewPatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewPatients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPatients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewPatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewPatients.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridViewPatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewPatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellContentClick);
            // 
            // labelPassword
            // 
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPassword.ForeColor = System.Drawing.Color.Purple;
            this.labelPassword.Location = new System.Drawing.Point(368, 33);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(470, 47);
            this.labelPassword.TabIndex = 36;
            this.labelPassword.Text = "Hospital Management System";
            // 
            // labelClose
            // 
            this.labelClose.BackColor = System.Drawing.Color.Transparent;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelClose.ForeColor = System.Drawing.Color.Purple;
            this.labelClose.Location = new System.Drawing.Point(1153, 24);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(15, 27);
            this.labelClose.TabIndex = 35;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
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
            this.buttonMedicine.Location = new System.Drawing.Point(23, 348);
            this.buttonMedicine.Name = "buttonMedicine";
            this.buttonMedicine.Size = new System.Drawing.Size(131, 45);
            this.buttonMedicine.TabIndex = 34;
            this.buttonMedicine.Text = "Medicine";
            this.buttonMedicine.Click += new System.EventHandler(this.buttonMedicine_Click);
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
            this.buttonDoctors.Location = new System.Drawing.Point(23, 248);
            this.buttonDoctors.Name = "buttonDoctors";
            this.buttonDoctors.Size = new System.Drawing.Size(131, 45);
            this.buttonDoctors.TabIndex = 33;
            this.buttonDoctors.Text = "Doctors";
            this.buttonDoctors.Click += new System.EventHandler(this.buttonDoctors_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonHome.FillColor = System.Drawing.Color.Purple;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Location = new System.Drawing.Point(23, 148);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(131, 45);
            this.buttonHome.TabIndex = 32;
            this.buttonHome.Text = "Home";
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // labelTag
            // 
            this.labelTag.AutoSize = true;
            this.labelTag.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelTag.ForeColor = System.Drawing.Color.Purple;
            this.labelTag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTag.Location = new System.Drawing.Point(577, 83);
            this.labelTag.Name = "labelTag";
            this.labelTag.Size = new System.Drawing.Size(79, 25);
            this.labelTag.TabIndex = 51;
            this.labelTag.Text = "Patients";
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.labelTag);
            this.Controls.Add(this.labelDoctor);
            this.Controls.Add(this.labelDisease);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textboxDoctor);
            this.Controls.Add(this.textboxDisease);
            this.Controls.Add(this.textboxAge);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.buttonMedicine);
            this.Controls.Add(this.buttonDoctors);
            this.Controls.Add(this.buttonHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.Label labelDisease;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2TextBox textboxDoctor;
        private Guna.UI2.WinForms.Guna2TextBox textboxDisease;
        private Guna.UI2.WinForms.Guna2TextBox textboxAge;
        private Guna.UI2.WinForms.Guna2TextBox textboxName;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2Button buttonUpdate;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewPatients;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelClose;
        private Guna.UI2.WinForms.Guna2Button buttonMedicine;
        private Guna.UI2.WinForms.Guna2Button buttonDoctors;
        private Guna.UI2.WinForms.Guna2Button buttonHome;
        private System.Windows.Forms.Label labelTag;
    }
}