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
    public partial class HostForm : Form
    {
        String Sql;
        String hostId;
        private DatabaseConfiguration Dc { get; set; }
        private DataSet Ds { get; set; }
        public HostForm()
        {
            InitializeComponent();
            this.Dc = new DatabaseConfiguration();
            this.PopulateHostsGridView();
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

        public void PopulateHostsGridView(string sql = "select * from Users where type = 'host';")
        {
            this.Ds = this.Dc.ExecuteQuery(sql);
            this.HostGridView.AutoGenerateColumns = false;
            this.HostGridView.DataSource = this.Ds.Tables[0];
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            
            try
            {
                string SuccessMsg;
                string ErrorMsg;
                if (this.btn_save.Text == "Save")
                {
                    this.Sql = @"insert into Users (name,email,pass,gender,dob,type)
                            values('" + this.txt_name.Text + "','" + this.txt_email.Text + "','" + this.txt_pass.Text + "','" + this.cmb_gender.Text + "','" + this.date_dob.Text + "','host');";
                    SuccessMsg = "New Host added";
                    ErrorMsg = "New host adding unsuccesfull";
                }
                else
                {
                    this.Sql = @"update Users 
                     set name = '" + this.txt_name.Text + "', " +
                     "email = '" + this.txt_email.Text + "', " +
                     "pass = '" + this.txt_pass.Text + "', " +
                     "gender = '" + this.cmb_gender.Text + "', " +
                     "dob = '" + this.date_dob.Text + "', " +
                     "type = 'host' " +
                     "where id = " +this.hostId  + ";";
                    SuccessMsg = "Host profile Updated";
                    ErrorMsg = "Host profile Updating unsuccesfull";
                }
                if (this.txt_pass.Text == this.txt_confirm_pass.Text)
                {
                    
                    int count = this.Dc.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        this.cmb_gender.SelectedIndex = 0;
                        MessageBox.Show(SuccessMsg);
                        this.PopulateHostsGridView();
                        this.btn_save.Text = "Save";
                        this.ClearAll();
                    }
                    else
                    {
                        MessageBox.Show(ErrorMsg);
                    }
                }
                else
                {
                    MessageBox.Show("Password and confirm password does not match");
                }

            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateHostsGridView();
        }

        private void btn_view_all_Click(object sender, EventArgs e)
        {
            this.PopulateHostsGridView();
        }


        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you are going back to login page\n You will be logged out");
            Session.Logout();
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void HostGridView_DoubleClick(object sender, EventArgs e)
        {
            this.txt_email.Text = this.HostGridView.CurrentRow.Cells["email"].Value.ToString();
            this.txt_name.Text = this.HostGridView.CurrentRow.Cells["name"].Value.ToString();
            this.txt_pass.Text = this.HostGridView.CurrentRow.Cells["pass"].Value.ToString();
            this.txt_confirm_pass.Text = this.HostGridView.CurrentRow.Cells["pass"].Value.ToString();
            this.cmb_gender.Text = this.HostGridView.CurrentRow.Cells["gender"].Value.ToString();
            this.date_dob.Text = this.HostGridView.CurrentRow.Cells["dob"].Value.ToString();
            this.btn_save.Text = "Update";
            this.hostId = this.HostGridView.CurrentRow.Cells["id"].Value.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
        }

        private void HostForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.hostId = this.HostGridView.CurrentRow.Cells["id"].Value.ToString();
            string hostName = this.HostGridView.CurrentRow.Cells["name"].Value.ToString();
            this.Sql = @"delete from Users where id = '" + this.hostId + "';";
            int count = this.Dc.ExecuteUpdateQuery(this.Sql);

            if (count == 1)
            {
                MessageBox.Show(hostName + " Has Been Deleted");
            }
            else
            {
                MessageBox.Show("Data Deletion Failed");
            }
            this.PopulateHostsGridView();
            this.ClearAll();
        }
    }
}
