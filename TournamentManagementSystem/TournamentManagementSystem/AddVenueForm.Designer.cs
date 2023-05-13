namespace TournamentManagementSystem
{
    partial class AddVenueForm
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
            this.lbl_game_type = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_fee = new System.Windows.Forms.MaskedTextBox();
            this.txt_name = new System.Windows.Forms.MaskedTextBox();
            this.cmb_venue_area = new System.Windows.Forms.ComboBox();
            this.cmb_game_type = new System.Windows.Forms.ComboBox();
            this.btn_back_landing = new System.Windows.Forms.Button();
            this.btn_view_all = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_welcome_txt = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VenuesGridView = new System.Windows.Forms.DataGridView();
            this.btn_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VenuesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_game_type
            // 
            this.lbl_game_type.AutoSize = true;
            this.lbl_game_type.Location = new System.Drawing.Point(17, 163);
            this.lbl_game_type.Name = "lbl_game_type";
            this.lbl_game_type.Size = new System.Drawing.Size(74, 13);
            this.lbl_game_type.TabIndex = 24;
            this.lbl_game_type.Text = "Type of Game";
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Location = new System.Drawing.Point(17, 137);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(63, 13);
            this.lbl_area.TabIndex = 23;
            this.lbl_area.Text = "Venue Area";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(17, 105);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(59, 13);
            this.lbl_email.TabIndex = 20;
            this.lbl_email.Text = "Venue Fee";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(17, 76);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(69, 13);
            this.lbl_name.TabIndex = 19;
            this.lbl_name.Text = "Venue Name";
            // 
            // txt_fee
            // 
            this.txt_fee.Location = new System.Drawing.Point(117, 99);
            this.txt_fee.Name = "txt_fee";
            this.txt_fee.Size = new System.Drawing.Size(272, 20);
            this.txt_fee.TabIndex = 18;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(116, 73);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(273, 20);
            this.txt_name.TabIndex = 17;
            // 
            // cmb_venue_area
            // 
            this.cmb_venue_area.FormattingEnabled = true;
            this.cmb_venue_area.Items.AddRange(new object[] {
            "    Dhaka",
            "    Chittagong",
            "    Cox\'s Bazar",
            "    Sylhet",
            "    Sundarbans",
            "    Bandarban",
            "    Rangamati",
            "    Khulna",
            "    Rajshahi",
            "    Paharpur",
            "    Comilla",
            "    Pabna",
            "    Narayanganj",
            "    Mymensingh",
            "    Barisal",
            "    Bogra",
            "    Jessore",
            "    Kushtia",
            "    Tangail",
            "    Gazipur",
            "    Rangpur",
            "    Dinajpur",
            "    Faridpur",
            "    Brahmanbaria",
            "    Jamalpur",
            "    Narsingdi",
            "    Sirajganj",
            "    Noakhali",
            "    Jhenaidah",
            "    Chuadanga",
            "    Narail",
            "    Magura",
            "    Meherpur",
            "    Sherpur",
            "    Habiganj",
            "    Maulvibazar",
            "    Barguna",
            "    Bhola",
            "    Patuakhali",
            "    Satkhira",
            "    Joypurhat",
            "    Kishoreganj"});
            this.cmb_venue_area.Location = new System.Drawing.Point(117, 133);
            this.cmb_venue_area.Name = "cmb_venue_area";
            this.cmb_venue_area.Size = new System.Drawing.Size(272, 21);
            this.cmb_venue_area.TabIndex = 25;
            // 
            // cmb_game_type
            // 
            this.cmb_game_type.FormattingEnabled = true;
            this.cmb_game_type.Items.AddRange(new object[] {
            "    Cricket",
            "    Football",
            "    Field Hockey",
            "    Tennis",
            "    Badminton",
            "    Table Tennis",
            "    Athletics",
            "    Boxing",
            "    Chess",
            "    Shooting",
            "    Archery",
            "    Cycling",
            "    Kabaddi"});
            this.cmb_game_type.Location = new System.Drawing.Point(116, 163);
            this.cmb_game_type.Name = "cmb_game_type";
            this.cmb_game_type.Size = new System.Drawing.Size(272, 21);
            this.cmb_game_type.TabIndex = 26;
            // 
            // btn_back_landing
            // 
            this.btn_back_landing.Location = new System.Drawing.Point(1008, 12);
            this.btn_back_landing.Name = "btn_back_landing";
            this.btn_back_landing.Size = new System.Drawing.Size(75, 23);
            this.btn_back_landing.TabIndex = 28;
            this.btn_back_landing.Text = "Back";
            this.btn_back_landing.UseVisualStyleBackColor = true;
            this.btn_back_landing.Click += new System.EventHandler(this.btn_back_landing_Click);
            // 
            // btn_view_all
            // 
            this.btn_view_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_all.Location = new System.Drawing.Point(116, 278);
            this.btn_view_all.Margin = new System.Windows.Forms.Padding(2);
            this.btn_view_all.Name = "btn_view_all";
            this.btn_view_all.Size = new System.Drawing.Size(137, 60);
            this.btn_view_all.TabIndex = 39;
            this.btn_view_all.Text = "View All";
            this.btn_view_all.UseVisualStyleBackColor = true;
            this.btn_view_all.Click += new System.EventHandler(this.btn_view_all_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(257, 278);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(134, 60);
            this.btn_clear.TabIndex = 38;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(306, 201);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 59);
            this.btn_update.TabIndex = 37;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(211, 201);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 59);
            this.btn_delete.TabIndex = 36;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(116, 201);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(82, 59);
            this.btn_save.TabIndex = 40;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            this.lbl_welcome_txt.Location = new System.Drawing.Point(12, 13);
            this.lbl_welcome_txt.Name = "lbl_welcome_txt";
            this.lbl_welcome_txt.Size = new System.Drawing.Size(176, 45);
            this.lbl_welcome_txt.TabIndex = 64;
            this.lbl_welcome_txt.Text = "Add Venue";
            this.lbl_welcome_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type Of Game";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "Venue Area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // rent
            // 
            this.rent.DataPropertyName = "rent";
            this.rent.HeaderText = "Venue Rent";
            this.rent.Name = "rent";
            this.rent.ReadOnly = true;
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
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // VenuesGridView
            // 
            this.VenuesGridView.AllowUserToAddRows = false;
            this.VenuesGridView.AllowUserToDeleteRows = false;
            this.VenuesGridView.BackgroundColor = System.Drawing.Color.White;
            this.VenuesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VenuesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.rent,
            this.area,
            this.type});
            this.VenuesGridView.Location = new System.Drawing.Point(20, 386);
            this.VenuesGridView.Margin = new System.Windows.Forms.Padding(2);
            this.VenuesGridView.Name = "VenuesGridView";
            this.VenuesGridView.ReadOnly = true;
            this.VenuesGridView.RowHeadersWidth = 51;
            this.VenuesGridView.RowTemplate.Height = 24;
            this.VenuesGridView.Size = new System.Drawing.Size(1040, 228);
            this.VenuesGridView.TabIndex = 65;
            this.VenuesGridView.DoubleClick += new System.EventHandler(this.VenuesGridView_DoubleClick);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(927, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 66;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // AddVenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TournamentManagementSystem.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 625);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.VenuesGridView);
            this.Controls.Add(this.lbl_welcome_txt);
            this.Controls.Add(this.btn_view_all);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_back_landing);
            this.Controls.Add(this.cmb_game_type);
            this.Controls.Add(this.cmb_venue_area);
            this.Controls.Add(this.lbl_game_type);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_fee);
            this.Controls.Add(this.txt_name);
            this.DoubleBuffered = true;
            this.Name = "AddVenueForm";
            this.Text = "AddVenueForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddVenueForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.VenuesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_game_type;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.MaskedTextBox txt_fee;
        private System.Windows.Forms.MaskedTextBox txt_name;
        private System.Windows.Forms.ComboBox cmb_venue_area;
        private System.Windows.Forms.ComboBox cmb_game_type;
        private System.Windows.Forms.Button btn_back_landing;
        private System.Windows.Forms.Button btn_view_all;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_welcome_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView VenuesGridView;
        private System.Windows.Forms.Button btn_logout;
    }
}