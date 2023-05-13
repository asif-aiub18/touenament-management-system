namespace TournamentManagementSystem
{
    partial class AdminDashboard
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_welcome_txt = new System.Windows.Forms.Label();
            this.btn_host_operation = new System.Windows.Forms.Button();
            this.btn_venue_operation = new System.Windows.Forms.Button();
            this.HostGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenuesGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HostGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VenuesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(978, 11);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_welcome_txt
            // 
            this.lbl_welcome_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_welcome_txt.AutoSize = true;
            this.lbl_welcome_txt.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome_txt.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_txt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_welcome_txt.Location = new System.Drawing.Point(12, 26);
            this.lbl_welcome_txt.Name = "lbl_welcome_txt";
            this.lbl_welcome_txt.Size = new System.Drawing.Size(113, 45);
            this.lbl_welcome_txt.TabIndex = 63;
            this.lbl_welcome_txt.Text = "Admin";
            this.lbl_welcome_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_host_operation
            // 
            this.btn_host_operation.Location = new System.Drawing.Point(188, 452);
            this.btn_host_operation.Name = "btn_host_operation";
            this.btn_host_operation.Size = new System.Drawing.Size(99, 57);
            this.btn_host_operation.TabIndex = 64;
            this.btn_host_operation.Text = "Host Operation";
            this.btn_host_operation.UseVisualStyleBackColor = true;
            this.btn_host_operation.Click += new System.EventHandler(this.btn_host_operation_Click);
            // 
            // btn_venue_operation
            // 
            this.btn_venue_operation.Location = new System.Drawing.Point(784, 452);
            this.btn_venue_operation.Name = "btn_venue_operation";
            this.btn_venue_operation.Size = new System.Drawing.Size(99, 57);
            this.btn_venue_operation.TabIndex = 65;
            this.btn_venue_operation.Text = "Venue Operation";
            this.btn_venue_operation.UseVisualStyleBackColor = true;
            this.btn_venue_operation.Click += new System.EventHandler(this.btn_venue_operation_Click);
            // 
            // HostGridView
            // 
            this.HostGridView.AllowUserToAddRows = false;
            this.HostGridView.AllowUserToDeleteRows = false;
            this.HostGridView.BackgroundColor = System.Drawing.Color.White;
            this.HostGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HostGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.gender,
            this.dob});
            this.HostGridView.Location = new System.Drawing.Point(20, 103);
            this.HostGridView.Margin = new System.Windows.Forms.Padding(2);
            this.HostGridView.Name = "HostGridView";
            this.HostGridView.ReadOnly = true;
            this.HostGridView.RowHeadersWidth = 51;
            this.HostGridView.RowTemplate.Height = 24;
            this.HostGridView.Size = new System.Drawing.Size(504, 306);
            this.HostGridView.TabIndex = 68;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "NAME";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "GENDER";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "DATE OF BIRTH";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // VenuesGridView
            // 
            this.VenuesGridView.AllowUserToAddRows = false;
            this.VenuesGridView.AllowUserToDeleteRows = false;
            this.VenuesGridView.BackgroundColor = System.Drawing.Color.White;
            this.VenuesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VenuesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.rent,
            this.area,
            this.type});
            this.VenuesGridView.Location = new System.Drawing.Point(549, 103);
            this.VenuesGridView.Margin = new System.Windows.Forms.Padding(2);
            this.VenuesGridView.Name = "VenuesGridView";
            this.VenuesGridView.ReadOnly = true;
            this.VenuesGridView.RowHeadersWidth = 51;
            this.VenuesGridView.RowTemplate.Height = 24;
            this.VenuesGridView.Size = new System.Drawing.Size(504, 306);
            this.VenuesGridView.TabIndex = 70;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn12.HeaderText = "ID";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn13.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // rent
            // 
            this.rent.DataPropertyName = "rent";
            this.rent.HeaderText = "Venue Rent";
            this.rent.Name = "rent";
            this.rent.ReadOnly = true;
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "Venue Area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type Of Game";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(897, 11);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 71;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TournamentManagementSystem.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 768);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.VenuesGridView);
            this.Controls.Add(this.HostGridView);
            this.Controls.Add(this.btn_venue_operation);
            this.Controls.Add(this.btn_host_operation);
            this.Controls.Add(this.lbl_welcome_txt);
            this.Controls.Add(this.btn_back);
            this.DoubleBuffered = true;
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.HostGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VenuesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_welcome_txt;
        private System.Windows.Forms.Button btn_host_operation;
        private System.Windows.Forms.Button btn_venue_operation;
        private System.Windows.Forms.DataGridView HostGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridView VenuesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Button btn_logout;
    }
}