namespace TournamentManagementSystem
{
    partial class LandingForm
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
            this.btn_login_red = new System.Windows.Forms.Button();
            this.btn_register_red = new System.Windows.Forms.Button();
            this.lbl_welcome_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login_red
            // 
            this.btn_login_red.Location = new System.Drawing.Point(327, 163);
            this.btn_login_red.Name = "btn_login_red";
            this.btn_login_red.Size = new System.Drawing.Size(129, 42);
            this.btn_login_red.TabIndex = 0;
            this.btn_login_red.Text = "Login";
            this.btn_login_red.UseVisualStyleBackColor = true;
            this.btn_login_red.Click += new System.EventHandler(this.btn_login_red_Click);
            // 
            // btn_register_red
            // 
            this.btn_register_red.Location = new System.Drawing.Point(327, 221);
            this.btn_register_red.Name = "btn_register_red";
            this.btn_register_red.Size = new System.Drawing.Size(129, 42);
            this.btn_register_red.TabIndex = 1;
            this.btn_register_red.Text = "Register";
            this.btn_register_red.UseVisualStyleBackColor = true;
            this.btn_register_red.Click += new System.EventHandler(this.btn_register_red_Click);
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
            this.lbl_welcome_txt.Location = new System.Drawing.Point(260, 75);
            this.lbl_welcome_txt.Name = "lbl_welcome_txt";
            this.lbl_welcome_txt.Size = new System.Drawing.Size(263, 45);
            this.lbl_welcome_txt.TabIndex = 2;
            this.lbl_welcome_txt.Text = "Welcome to TMS";
            this.lbl_welcome_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TournamentManagementSystem.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_welcome_txt);
            this.Controls.Add(this.btn_register_red);
            this.Controls.Add(this.btn_login_red);
            this.DoubleBuffered = true;
            this.Name = "LandingForm";
            this.Text = "Tournament Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LandingForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login_red;
        private System.Windows.Forms.Button btn_register_red;
        private System.Windows.Forms.Label lbl_welcome_txt;
    }
}

