namespace TournamentManagementSystem
{
    partial class HostForm
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
            this.lbl_welcome_txt = new System.Windows.Forms.Label();
            this.lbl_confirm_pass = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_confirm_pass = new System.Windows.Forms.MaskedTextBox();
            this.txt_pass = new System.Windows.Forms.MaskedTextBox();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.date_dob = new System.Windows.Forms.DateTimePicker();
            this.txt_email = new System.Windows.Forms.MaskedTextBox();
            this.txt_name = new System.Windows.Forms.MaskedTextBox();
            this.btn_back_landing = new System.Windows.Forms.Button();
            this.btn_view_all = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.HostGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HostGridView)).BeginInit();
            this.SuspendLayout();
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
            this.lbl_welcome_txt.Location = new System.Drawing.Point(22, 24);
            this.lbl_welcome_txt.Name = "lbl_welcome_txt";
            this.lbl_welcome_txt.Size = new System.Drawing.Size(250, 45);
            this.lbl_welcome_txt.TabIndex = 65;
            this.lbl_welcome_txt.Text = "Host Operations";
            this.lbl_welcome_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_confirm_pass
            // 
            this.lbl_confirm_pass.AutoSize = true;
            this.lbl_confirm_pass.Location = new System.Drawing.Point(33, 171);
            this.lbl_confirm_pass.Name = "lbl_confirm_pass";
            this.lbl_confirm_pass.Size = new System.Drawing.Size(91, 13);
            this.lbl_confirm_pass.TabIndex = 78;
            this.lbl_confirm_pass.Text = "Confirm Password";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(33, 145);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(53, 13);
            this.lbl_pass.TabIndex = 77;
            this.lbl_pass.Text = "Password";
            // 
            // txt_confirm_pass
            // 
            this.txt_confirm_pass.Location = new System.Drawing.Point(133, 168);
            this.txt_confirm_pass.Name = "txt_confirm_pass";
            this.txt_confirm_pass.Size = new System.Drawing.Size(272, 20);
            this.txt_confirm_pass.TabIndex = 76;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(132, 142);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(272, 20);
            this.txt_pass.TabIndex = 75;
            // 
            // cmb_gender
            // 
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_gender.Location = new System.Drawing.Point(133, 197);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(272, 21);
            this.cmb_gender.TabIndex = 74;
            this.cmb_gender.Text = "Select your gender";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(33, 230);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(28, 13);
            this.lbl_dob.TabIndex = 72;
            this.lbl_dob.Text = "DoB";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(33, 205);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 71;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(33, 113);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 70;
            this.lbl_email.Text = "Email";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(33, 84);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 69;
            this.lbl_name.Text = "Name";
            // 
            // date_dob
            // 
            this.date_dob.Location = new System.Drawing.Point(132, 224);
            this.date_dob.Name = "date_dob";
            this.date_dob.Size = new System.Drawing.Size(272, 20);
            this.date_dob.TabIndex = 68;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(133, 107);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(272, 20);
            this.txt_email.TabIndex = 67;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(132, 81);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(272, 20);
            this.txt_name.TabIndex = 66;
            // 
            // btn_back_landing
            // 
            this.btn_back_landing.Location = new System.Drawing.Point(1023, 12);
            this.btn_back_landing.Name = "btn_back_landing";
            this.btn_back_landing.Size = new System.Drawing.Size(75, 23);
            this.btn_back_landing.TabIndex = 79;
            this.btn_back_landing.Text = "Back";
            this.btn_back_landing.UseVisualStyleBackColor = true;
            this.btn_back_landing.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_view_all
            // 
            this.btn_view_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_all.Location = new System.Drawing.Point(132, 292);
            this.btn_view_all.Margin = new System.Windows.Forms.Padding(2);
            this.btn_view_all.Name = "btn_view_all";
            this.btn_view_all.Size = new System.Drawing.Size(122, 40);
            this.btn_view_all.TabIndex = 83;
            this.btn_view_all.Text = "View All";
            this.btn_view_all.UseVisualStyleBackColor = true;
            this.btn_view_all.Click += new System.EventHandler(this.btn_view_all_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(258, 292);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(122, 40);
            this.btn_clear.TabIndex = 82;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(258, 261);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 27);
            this.btn_delete.TabIndex = 80;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(188, 261);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(66, 27);
            this.btn_save.TabIndex = 84;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            this.email,
            this.pass,
            this.gender,
            this.dob});
            this.HostGridView.Location = new System.Drawing.Point(11, 340);
            this.HostGridView.Margin = new System.Windows.Forms.Padding(2);
            this.HostGridView.Name = "HostGridView";
            this.HostGridView.ReadOnly = true;
            this.HostGridView.RowHeadersWidth = 51;
            this.HostGridView.RowTemplate.Height = 24;
            this.HostGridView.Size = new System.Drawing.Size(1073, 306);
            this.HostGridView.TabIndex = 85;
            this.HostGridView.DoubleClick += new System.EventHandler(this.HostGridView_DoubleClick);
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
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // pass
            // 
            this.pass.DataPropertyName = "pass";
            this.pass.HeaderText = "Password";
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
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
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(942, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 86;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // HostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TournamentManagementSystem.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1110, 657);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.HostGridView);
            this.Controls.Add(this.btn_view_all);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_back_landing);
            this.Controls.Add(this.lbl_confirm_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.txt_confirm_pass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.date_dob);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_welcome_txt);
            this.DoubleBuffered = true;
            this.Name = "HostForm";
            this.Text = "HostForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HostForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.HostGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome_txt;
        private System.Windows.Forms.Label lbl_confirm_pass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.MaskedTextBox txt_confirm_pass;
        private System.Windows.Forms.MaskedTextBox txt_pass;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DateTimePicker date_dob;
        private System.Windows.Forms.MaskedTextBox txt_email;
        private System.Windows.Forms.MaskedTextBox txt_name;
        private System.Windows.Forms.Button btn_back_landing;
        private System.Windows.Forms.Button btn_view_all;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView HostGridView;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
    }
}