namespace TournamentManagementSystem
{
    partial class HostDashboard
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
            this.components = new System.ComponentModel.Container();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dtp_starting_date = new System.Windows.Forms.DateTimePicker();
            this.txt_mobileno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_view_all = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back_landing = new System.Windows.Forms.Button();
            this.lbl_welcome_txt = new System.Windows.Forms.Label();
            this.cmb_venue_area = new System.Windows.Forms.ComboBox();
            this.venuesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentDataSet = new TournamentManagementSystem.tournamentDataSet();
            this.venuesTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_game_type = new System.Windows.Forms.ComboBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.venuesTableTableAdapter = new TournamentManagementSystem.tournamentDataSetTableAdapters.VenuesTableTableAdapter();
            this.tournamentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tournamentsTableAdapter = new TournamentManagementSystem.tournamentDataSetTableAdapters.TournamentsTableAdapter();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.TournamentsGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.venuesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(107, 405);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(182, 24);
            this.txt_search.TabIndex = 60;
            // 
            // dtp_starting_date
            // 
            this.dtp_starting_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_starting_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_starting_date.Location = new System.Drawing.Point(190, 185);
            this.dtp_starting_date.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_starting_date.Name = "dtp_starting_date";
            this.dtp_starting_date.Size = new System.Drawing.Size(259, 20);
            this.dtp_starting_date.TabIndex = 57;
            // 
            // txt_mobileno
            // 
            this.txt_mobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobileno.Location = new System.Drawing.Point(190, 217);
            this.txt_mobileno.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mobileno.Name = "txt_mobileno";
            this.txt_mobileno.Size = new System.Drawing.Size(259, 23);
            this.txt_mobileno.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(24, 220);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Mobile No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(24, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Starting Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(24, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cost: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Game Type:";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(12, 404);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(82, 26);
            this.btn_search.TabIndex = 34;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_view_all
            // 
            this.btn_view_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_all.Location = new System.Drawing.Point(814, 405);
            this.btn_view_all.Margin = new System.Windows.Forms.Padding(2);
            this.btn_view_all.Name = "btn_view_all";
            this.btn_view_all.Size = new System.Drawing.Size(111, 59);
            this.btn_view_all.TabIndex = 33;
            this.btn_view_all.Text = "View All";
            this.btn_view_all.UseVisualStyleBackColor = true;
            this.btn_view_all.Click += new System.EventHandler(this.btn_view_all_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(381, 305);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(91, 57);
            this.btn_clear.TabIndex = 32;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(280, 305);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 59);
            this.btn_delete.TabIndex = 30;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(180, 305);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(82, 59);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back_landing
            // 
            this.btn_back_landing.Location = new System.Drawing.Point(977, 12);
            this.btn_back_landing.Name = "btn_back_landing";
            this.btn_back_landing.Size = new System.Drawing.Size(75, 23);
            this.btn_back_landing.TabIndex = 61;
            this.btn_back_landing.Text = "Back";
            this.btn_back_landing.UseVisualStyleBackColor = true;
            this.btn_back_landing.Click += new System.EventHandler(this.btn_back_landing_Click);
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
            this.lbl_welcome_txt.Location = new System.Drawing.Point(18, 12);
            this.lbl_welcome_txt.Name = "lbl_welcome_txt";
            this.lbl_welcome_txt.Size = new System.Drawing.Size(267, 45);
            this.lbl_welcome_txt.TabIndex = 62;
            this.lbl_welcome_txt.Text = "Host Tournament";
            this.lbl_welcome_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_venue_area
            // 
            this.cmb_venue_area.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.venuesTableBindingSource, "id", true));
            this.cmb_venue_area.DataSource = this.venuesTableBindingSource1;
            this.cmb_venue_area.DisplayMember = "name";
            this.cmb_venue_area.FormattingEnabled = true;
            this.cmb_venue_area.Location = new System.Drawing.Point(190, 156);
            this.cmb_venue_area.Name = "cmb_venue_area";
            this.cmb_venue_area.Size = new System.Drawing.Size(259, 21);
            this.cmb_venue_area.TabIndex = 64;
            this.cmb_venue_area.ValueMember = "id";
            // 
            // venuesTableBindingSource
            // 
            this.venuesTableBindingSource.DataMember = "VenuesTable";
            this.venuesTableBindingSource.DataSource = this.tournamentDataSet;
            // 
            // tournamentDataSet
            // 
            this.tournamentDataSet.DataSetName = "tournamentDataSet";
            this.tournamentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // venuesTableBindingSource1
            // 
            this.venuesTableBindingSource1.DataMember = "VenuesTable";
            this.venuesTableBindingSource1.DataSource = this.tournamentDataSetBindingSource;
            // 
            // tournamentDataSetBindingSource
            // 
            this.tournamentDataSetBindingSource.DataSource = this.tournamentDataSet;
            this.tournamentDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(24, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Venue:";
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
            this.cmb_game_type.Location = new System.Drawing.Point(190, 92);
            this.cmb_game_type.Name = "cmb_game_type";
            this.cmb_game_type.Size = new System.Drawing.Size(259, 21);
            this.cmb_game_type.TabIndex = 66;
            this.cmb_game_type.Text = "Select Game Type";
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(190, 244);
            this.txt_description.Margin = new System.Windows.Forms.Padding(2);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(259, 23);
            this.txt_description.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(24, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Description:";
            // 
            // venuesTableTableAdapter
            // 
            this.venuesTableTableAdapter.ClearBeforeFill = true;
            // 
            // tournamentsBindingSource
            // 
            this.tournamentsBindingSource.DataMember = "Tournaments";
            this.tournamentsBindingSource.DataSource = this.tournamentDataSetBindingSource;
            // 
            // tournamentsTableAdapter
            // 
            this.tournamentsTableAdapter.ClearBeforeFill = true;
            // 
            // txt_cost
            // 
            this.txt_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cost.Location = new System.Drawing.Point(190, 125);
            this.txt_cost.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(259, 23);
            this.txt_cost.TabIndex = 70;
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
            this.TournamentsGridView.Location = new System.Drawing.Point(107, 502);
            this.TournamentsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.TournamentsGridView.Name = "TournamentsGridView";
            this.TournamentsGridView.ReadOnly = true;
            this.TournamentsGridView.RowHeadersWidth = 51;
            this.TournamentsGridView.RowTemplate.Height = 24;
            this.TournamentsGridView.Size = new System.Drawing.Size(854, 228);
            this.TournamentsGridView.TabIndex = 71;
            this.TournamentsGridView.DoubleClick += new System.EventHandler(this.TournamentsGridView_DoubleClick);
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
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(896, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 72;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // HostDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TournamentManagementSystem.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 766);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.TournamentsGridView);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_game_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_venue_area);
            this.Controls.Add(this.lbl_welcome_txt);
            this.Controls.Add(this.btn_back_landing);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dtp_starting_date);
            this.Controls.Add(this.txt_mobileno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_view_all);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.DoubleBuffered = true;
            this.Name = "HostDashboard";
            this.Text = "HostDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HostDashboard_FormClosed);
            this.Load += new System.EventHandler(this.HostDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venuesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tournamentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TournamentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DateTimePicker dtp_starting_date;
        private System.Windows.Forms.TextBox txt_mobileno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_view_all;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_back_landing;
        private System.Windows.Forms.Label lbl_welcome_txt;
        private System.Windows.Forms.ComboBox cmb_venue_area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_game_type;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tournamentDataSetBindingSource;
        private tournamentDataSet tournamentDataSet;
        private System.Windows.Forms.BindingSource venuesTableBindingSource;
        private tournamentDataSetTableAdapters.VenuesTableTableAdapter venuesTableTableAdapter;
        private System.Windows.Forms.BindingSource venuesTableBindingSource1;
        private System.Windows.Forms.BindingSource tournamentsBindingSource;
        private tournamentDataSetTableAdapters.TournamentsTableAdapter tournamentsTableAdapter;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.DataGridView TournamentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button btn_logout;
    }
}