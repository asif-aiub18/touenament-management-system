namespace TournamentManagementSystem
{
    partial class Registration
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
            this.txt_name = new System.Windows.Forms.MaskedTextBox();
            this.date_dob = new System.Windows.Forms.DateTimePicker();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_back_landing = new System.Windows.Forms.Button();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.lbl_confirm_pass = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_confirm_pass = new System.Windows.Forms.MaskedTextBox();
            this.txt_pass = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.MaskedTextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(258, 87);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(272, 20);
            this.txt_name.TabIndex = 1;
            // 
            // date_dob
            // 
            this.date_dob.Location = new System.Drawing.Point(258, 230);
            this.date_dob.Name = "date_dob";
            this.date_dob.Size = new System.Drawing.Size(272, 20);
            this.date_dob.TabIndex = 5;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(159, 90);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Name";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(159, 211);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 8;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(159, 236);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(28, 13);
            this.lbl_dob.TabIndex = 9;
            this.lbl_dob.Text = "DoB";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(338, 285);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_back_landing
            // 
            this.btn_back_landing.Location = new System.Drawing.Point(713, 12);
            this.btn_back_landing.Name = "btn_back_landing";
            this.btn_back_landing.Size = new System.Drawing.Size(75, 23);
            this.btn_back_landing.TabIndex = 11;
            this.btn_back_landing.Text = "Back";
            this.btn_back_landing.UseVisualStyleBackColor = true;
            this.btn_back_landing.Click += new System.EventHandler(this.btn_back_landing_Click);
            // 
            // cmb_gender
            // 
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_gender.Location = new System.Drawing.Point(259, 203);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(272, 21);
            this.cmb_gender.TabIndex = 12;
            this.cmb_gender.Text = "Select your gender";
            // 
            // lbl_confirm_pass
            // 
            this.lbl_confirm_pass.AutoSize = true;
            this.lbl_confirm_pass.Location = new System.Drawing.Point(159, 177);
            this.lbl_confirm_pass.Name = "lbl_confirm_pass";
            this.lbl_confirm_pass.Size = new System.Drawing.Size(91, 13);
            this.lbl_confirm_pass.TabIndex = 16;
            this.lbl_confirm_pass.Text = "Confirm Password";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(159, 151);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(53, 13);
            this.lbl_pass.TabIndex = 15;
            this.lbl_pass.Text = "Password";
            // 
            // txt_confirm_pass
            // 
            this.txt_confirm_pass.Location = new System.Drawing.Point(259, 174);
            this.txt_confirm_pass.Name = "txt_confirm_pass";
            this.txt_confirm_pass.Size = new System.Drawing.Size(272, 20);
            this.txt_confirm_pass.TabIndex = 14;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(258, 148);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(272, 20);
            this.txt_pass.TabIndex = 13;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(259, 113);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(272, 20);
            this.txt_email.TabIndex = 2;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(159, 119);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 7;
            this.lbl_email.Text = "Email";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(456, 285);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TournamentManagementSystem.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_confirm_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.txt_confirm_pass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.btn_back_landing);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.date_dob);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.DoubleBuffered = true;
            this.Name = "Registration";
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_name;
        private System.Windows.Forms.DateTimePicker date_dob;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_back_landing;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.Label lbl_confirm_pass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.MaskedTextBox txt_confirm_pass;
        private System.Windows.Forms.MaskedTextBox txt_pass;
        private System.Windows.Forms.MaskedTextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_reset;
    }
}