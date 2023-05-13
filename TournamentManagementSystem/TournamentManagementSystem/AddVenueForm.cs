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
    public partial class AddVenueForm : Form
    {
        String Sql;
        private DatabaseConfiguration Dac { get; set; }
        private DataSet Ds { get; set; }
        String venueId;
        public AddVenueForm()
        {
            InitializeComponent();
            this.Dac = new DatabaseConfiguration();
            this.PopulateGridView();
        }
        public void PopulateGridView(string sql = "select * from VenuesTable;")
        {
            this.Ds = this.Dac.ExecuteQuery(sql);
            this.VenuesGridView.AutoGenerateColumns = false;
            this.VenuesGridView.DataSource = this.Ds.Tables[0];
        }

        private void btn_view_all_Click(object sender, EventArgs e)
        {
            string sql = "select * from VenuesTable;";
            this.PopulateGridView(sql);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Sql = @"insert into VenuesTable (name,rent,area,type,admin_id)
            values ('" + this.txt_name.Text + "' ,'" + this.txt_fee.Text + "','" + this.cmb_venue_area.Text + "','" + this.cmb_game_type.Text.Trim() + "','"+Session.UserId+"');";
            
            int count = this.Dac.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show("New Venue Added");
            }
            else
            {
                MessageBox.Show("Venue Addition Failed");
            }
            this.PopulateGridView();

        }

        private void VenuesGridView_DoubleClick(object sender, EventArgs e)
        {
            this.venueId = this.VenuesGridView.CurrentRow.Cells["id"].Value.ToString();
            this.txt_name.Text = this.VenuesGridView.CurrentRow.Cells["name"].Value.ToString();
            this.txt_fee.Text = this.VenuesGridView.CurrentRow.Cells["rent"].Value.ToString();
            this.cmb_venue_area.Text = this.VenuesGridView.CurrentRow.Cells["area"].Value.ToString();
            this.cmb_game_type.Text = this.VenuesGridView.CurrentRow.Cells["type"].Value.ToString();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            this.Sql = "Update VenuesTable " +
               "set name = '" + this.txt_name.Text + "', " +
               "rent = '" + this.txt_fee.Text + "', " +
               "area = '" + this.cmb_venue_area.Text + "', " +
               "type = '" + this.cmb_game_type.Text + "' " +
               "where id = " + this.venueId + ";";



            MessageBox.Show(this.Sql);

            int count = this.Dac.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show("Venue's Data Updated");
            }
            else
            {
                MessageBox.Show("Data Insertion Failed");
            }
            this.PopulateGridView();
            this.ClearAll();
        }
        private void ClearAll()
        {
            this.txt_name.Clear();
            this.txt_fee.Clear();
            this.cmb_game_type.SelectedIndex = -1;
            this.cmb_venue_area.SelectedIndex = -1;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.venueId = this.VenuesGridView.CurrentRow.Cells["id"].Value.ToString();
            string venueName = this.VenuesGridView.CurrentRow.Cells["name"].Value.ToString();
            this.Sql = @"delete from VenuesTable where id = '" + venueId + "';";
            int count = this.Dac.ExecuteUpdateQuery(this.Sql);

            if (count == 1)
            {
                MessageBox.Show(venueName + " Has Been Deleted");
            }
            else
            {
                MessageBox.Show("Data Deletion Failed");
            }
            this.PopulateGridView();
            this.ClearAll();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            string sql = "select * from VenuesTable;";
            this.PopulateGridView(sql);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you are going back to login page\n You will be logged out");
            Session.Logout();
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_back_landing_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
        }

        private void AddVenueForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
