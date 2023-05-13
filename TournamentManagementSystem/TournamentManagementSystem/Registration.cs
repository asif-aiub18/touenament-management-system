using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentManagementSystem
{
    public partial class Registration : Form
    {
        String Sql; 
        private DatabaseConfiguration Dc { get; set; }
        private DataSet Ds { get; set; }
        public Registration()
        {
            InitializeComponent();
            this.Dc = new DatabaseConfiguration(); 
        }

        private void btn_submit_Click(object sender, EventArgs e)

        {
            
            try
            {
                if (this.txt_pass.Text == this.txt_confirm_pass.Text)
                {
                    this.Sql = @"insert into Users (name,email,pass,gender,dob,type)
                            values('" + this.txt_name.Text + "','" + this.txt_email.Text + "','" + this.txt_pass.Text + "','" + this.cmb_gender.Text + "','" + this.date_dob.Text + "','guest');";

                    int count = this.Dc.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        this.cmb_gender.SelectedIndex = 0;
                        MessageBox.Show("Registration Successful\nYou can login now");
                        this.Hide();
                        Login login = new Login();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registration Unsuccessful\nYou Should try again later");
                    }
                }
                else
                {
                    MessageBox.Show("Password and confirm password does not match");
                }

            }catch(Exception exec)
            {
                MessageBox.Show(exec.Message);
            }
            
        }
        private void ClearAll()
        {
            this.txt_confirm_pass.Clear();
            this.txt_email.Clear();
            this.txt_name.Clear();
            this.txt_pass.Clear();
            this.cmb_gender.SelectedIndex = -1;
            this.date_dob.Text = "";
        }

        private void btn_back_landing_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingForm frm = new LandingForm();
            frm.Show();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
