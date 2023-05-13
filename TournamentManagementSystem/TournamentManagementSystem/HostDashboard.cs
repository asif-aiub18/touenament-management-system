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

    public partial class HostDashboard : Form
    {
        String Sql;
        String tourID;
        private DatabaseConfiguration Dac { get; set; }
        private DataSet Ds { get; set; }
        public HostDashboard()
        {
            InitializeComponent();
            this.Dac = new DatabaseConfiguration();
            this.PopulateGridView();


        }

        
        public void PopulateGridView( string sql = "SELECT Tournaments.id,Tournaments.game_type,Tournaments.fee, VenuesTable.name, Tournaments.date, VenuesTable.area, Tournaments.phone, Tournaments.description ,Tournaments.venue_id FROM Tournaments INNER JOIN VenuesTable ON Tournaments.venue_id = VenuesTable.id;")
        {
            /*string sql = "SELECT Tournaments.fee, VenuesTable.name, Tournaments.date, Tournaments.address, Tournaments.phone, Tournaments.description FROM Tournaments INNER JOIN VenuesTable ON Tournaments.venue_id = VenuesTable.id"
            */this.Ds = this.Dac.ExecuteQuery(sql);
            this.TournamentsGridView.AutoGenerateColumns = false;
            this.TournamentsGridView.DataSource = this.Ds.Tables[0];
        }

        private void HostDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tournamentDataSet.Tournaments' table. You can move, or remove it, as needed.
            this.tournamentsTableAdapter.Fill(this.tournamentDataSet.Tournaments);
            // TODO: This line of code loads data into the 'tournamentDataSet.VenuesTable' table. You can move, or remove it, as needed.
            this.venuesTableTableAdapter.Fill(this.tournamentDataSet.VenuesTable);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string SuccessMsg;
            string ErrorMsg;
            
            if (this.btn_save.Text == "Save")
            {
                this.Sql = @"insert into Tournaments (fee, date,game_type, phone, description,venue_id,host_id)
                values ('"  + this.txt_cost.Text + "','"  + this.dtp_starting_date.Text.Trim() + "','" + this.cmb_game_type.Text.Trim() + "','" + this.txt_mobileno.Text + "','" + this.txt_description.Text + "','" + this.cmb_venue_area.SelectedValue + "','"+Session.UserId+"')";
                SuccessMsg = "New Tournament Added";
                ErrorMsg = "Tournament Addition Failed";

            }
            else
            {
                this.Sql = @"UPDATE Tournaments SET fee = '" + this.txt_cost.Text + "', date = '" + this.dtp_starting_date.Text.Trim() + "',game_type = '" + this.cmb_game_type.Text.Trim() + "', phone = '" + this.txt_mobileno.Text + "', description = '" + this.txt_description.Text + "', venue_id = '" + this.cmb_venue_area.SelectedValue + "' WHERE id = " + this.tourID;
                SuccessMsg = " Tournament Details Updated";
                ErrorMsg = "Tournament Details Update Failed";

            }

            int count = this.Dac.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(SuccessMsg);
                }
                else
                {
                    MessageBox.Show(ErrorMsg);
                }
            this.PopulateGridView();
            this.clearAll();
            this.btn_save.Text = "Save";
            
        }

        private void TournamentsGridView_DoubleClick(object sender, EventArgs e)
        {
           
            this.txt_cost.Text = this.TournamentsGridView.CurrentRow.Cells["fee"].Value.ToString();
            this.txt_description.Text = this.TournamentsGridView.CurrentRow.Cells["description"].Value.ToString();
            this.txt_mobileno.Text = this.TournamentsGridView.CurrentRow.Cells["phone"].Value.ToString();
            this.dtp_starting_date.Text = this.TournamentsGridView.CurrentRow.Cells["date"].Value.ToString();
            this.cmb_venue_area.Text = this.TournamentsGridView.CurrentRow.Cells["area"].Value.ToString();
            this.cmb_game_type.Text = this.TournamentsGridView.CurrentRow.Cells["game_type"].Value.ToString();
            this.btn_save.Text = "Update";
            this.tourID = this.TournamentsGridView.CurrentRow.Cells["id"].Value.ToString();

        }
        private void clearAll()
        {
            this.txt_cost.Clear();
            this.txt_description.Clear();
            this.txt_mobileno.Clear();
            this.txt_search.Clear();
            this.cmb_game_type.SelectedIndex = -1;
            this.cmb_venue_area.SelectedIndex = -1;
            this.dtp_starting_date.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearAll();
            this.PopulateGridView();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.tourID = this.TournamentsGridView.CurrentRow.Cells["id"].Value.ToString();
            string venueName = this.TournamentsGridView.CurrentRow.Cells["area"].Value.ToString();
            this.Sql = @"delete from Tournaments where id = '" + tourID + "';";
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
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchQuery = this.txt_search.Text; // Replace with user input
            this.Sql = @"SELECT Tournaments.id, Tournaments.fee, VenuesTable.name, Tournaments.date, VenuesTable.area, Tournaments.phone, Tournaments.description, Tournaments.venue_id 
            FROM Tournaments 
            INNER JOIN VenuesTable ON Tournaments.venue_id = VenuesTable.id 
            WHERE Tournaments.description LIKE '%" + searchQuery + "%'" +
            "OR Tournaments.description LIKE '%" + searchQuery + "%'" +
            "OR Tournaments.fee LIKE '%" + searchQuery + "%'" +
            "OR Tournaments.date LIKE '%" + searchQuery + "%'" +
            "OR Tournaments.id LIKE '%" + searchQuery + "%'" +
            "OR Tournaments.game_type LIKE '%" + searchQuery + "%'" +
            "OR VenuesTable.name LIKE '%" + searchQuery + "%'" +
            "OR VenuesTable.area LIKE '%" + searchQuery + "%'" +
            "OR Tournaments.phone LIKE '%" + searchQuery + "%'";
            this.PopulateGridView(this.Sql);

        }

        private void btn_view_all_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btn_back_landing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you are going back to login page\n You will be logged out");
            Session.Logout();
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you are going back to login page\n You will be logged out");
            Session.Logout();
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void HostDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
