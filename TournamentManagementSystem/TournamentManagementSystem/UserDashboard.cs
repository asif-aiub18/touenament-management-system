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
    public partial class UserDashboard : Form
    {
        String Sql;
        String tourID;
        private DatabaseConfiguration Dac { get; set; }
        private DataSet Ds { get; set; }
        public UserDashboard()
        {
            InitializeComponent();
            this.Dac = new DatabaseConfiguration();
            this.PopulateGridView();
        }

        private void UserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void PopulateGridView(string sql = "SELECT Tournaments.id,Tournaments.game_type,Tournaments.fee, VenuesTable.name, Tournaments.date, VenuesTable.area, Tournaments.phone, Tournaments.description ,Tournaments.venue_id FROM Tournaments INNER JOIN VenuesTable ON Tournaments.venue_id = VenuesTable.id;")
        {
            /*string sql = "SELECT Tournaments.fee, VenuesTable.name, Tournaments.date, Tournaments.address, Tournaments.phone, Tournaments.description FROM Tournaments INNER JOIN VenuesTable ON Tournaments.venue_id = VenuesTable.id"
            */
            this.Ds = this.Dac.ExecuteQuery(sql);
            this.TournamentsGridView.AutoGenerateColumns = false;
            this.TournamentsGridView.DataSource = this.Ds.Tables[0];
        }

        private void TournamentsGridView_MouseClick(object sender, MouseEventArgs e)
        {
            this.tourID = this.TournamentsGridView.CurrentRow.Cells["id"].Value.ToString();
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            if(this.tourID == null || this.tourID.Length == 0 || this.tourID == "")
            {
                MessageBox.Show("Please select a Tournament details by single mouse click");
            }
            else
            {

            this.Hide();
            UserReview ur = new UserReview(this.tourID);
            ur.Show();
            }
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
    }
}
