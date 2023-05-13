namespace TournamentManagementSystem
{
    partial class UserDashboard
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
            this.btn_back_landing = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            this.TournamentsGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_review = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back_landing
            // 
            this.btn_back_landing.Location = new System.Drawing.Point(944, 12);
            this.btn_back_landing.Name = "btn_back_landing";
            this.btn_back_landing.Size = new System.Drawing.Size(75, 23);
            this.btn_back_landing.TabIndex = 12;
            this.btn_back_landing.Text = "Back";
            this.btn_back_landing.UseVisualStyleBackColor = true;
            this.btn_back_landing.Click += new System.EventHandler(this.btn_back_landing_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "Show All Games";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(148, 139);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(130, 60);
            this.btn_.TabIndex = 15;
            this.btn_.Text = "Filter Games";
            this.btn_.UseVisualStyleBackColor = true;
            // 
            // TournamentsGridView
            // 
            this.TournamentsGridView.AllowUserToAddRows = false;
            this.TournamentsGridView.AllowUserToDeleteRows = false;
            this.TournamentsGridView.BackgroundColor = System.Drawing.Color.White;
            this.TournamentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TournamentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.game_type,
            this.area,
            this.fee,
            this.date,
            this.address,
            this.phone,
            this.description});
            this.TournamentsGridView.Location = new System.Drawing.Point(12, 246);
            this.TournamentsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.TournamentsGridView.Name = "TournamentsGridView";
            this.TournamentsGridView.ReadOnly = true;
            this.TournamentsGridView.RowHeadersWidth = 51;
            this.TournamentsGridView.RowTemplate.Height = 24;
            this.TournamentsGridView.Size = new System.Drawing.Size(994, 348);
            this.TournamentsGridView.TabIndex = 72;
            this.TournamentsGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TournamentsGridView_MouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // game_type
            // 
            this.game_type.DataPropertyName = "game_type";
            this.game_type.HeaderText = "Game Type";
            this.game_type.Name = "game_type";
            this.game_type.ReadOnly = true;
            // 
            // area
            // 
            this.area.DataPropertyName = "name";
            this.area.HeaderText = "Venue Area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // fee
            // 
            this.fee.DataPropertyName = "fee";
            this.fee.HeaderText = "Fee";
            this.fee.Name = "fee";
            this.fee.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "area";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // btn_review
            // 
            this.btn_review.Location = new System.Drawing.Point(284, 139);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(130, 60);
            this.btn_review.TabIndex = 73;
            this.btn_review.Text = "Give Review";
            this.btn_review.UseVisualStyleBackColor = true;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(863, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 74;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TournamentManagementSystem.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 619);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_review);
            this.Controls.Add(this.TournamentsGridView);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_back_landing);
            this.DoubleBuffered = true;
            this.Name = "UserDashboard";
            this.Text = "UserDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserDashboard_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.TournamentsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back_landing;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.DataGridView TournamentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button btn_review;
        private System.Windows.Forms.Button btn_logout;
    }
}