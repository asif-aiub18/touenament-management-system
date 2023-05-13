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
    public partial class UserReview : Form
    {
        String Sql;
        private DatabaseConfiguration Dac { get; set; }
        private DataSet Ds { get; set; }
        private int tourID;
        public UserReview(string tourId)
        {
            InitializeComponent();
             this.Dac = new DatabaseConfiguration();
            this.tourID=int.Parse(tourId);
            this.SetDetails();
        }
        private void SetDetails()
        {
            //            this.Sql ="SELECT Tournaments.id,Tournaments.game_type,Tournaments.fee, VenuesTable.name, Tournaments.date, VenuesTable.area, Tournaments.phone, Tournaments.description ,Tournaments.venue_id FROM Tournaments Where Tournaments.id = '"+tourId+"'INNER JOIN VenuesTable ON Tournaments.venue_id = VenuesTable.id;";
            this.Sql = "SELECT Tournaments.id, Tournaments.game_type, Tournaments.fee, VenuesTable.name, Tournaments.date, VenuesTable.area, Tournaments.phone, Tournaments.description, Tournaments.venue_id, Users.name AS host_name FROM Tournaments INNER JOIN VenuesTable ON Tournaments.venue_id = VenuesTable.id INNER JOIN Users ON Tournaments.host_id = Users.id WHERE Tournaments.id = '" + this.tourID + "';";
            DataSet ds = this.Dac.ExecuteQuery(this.Sql);
            DataRow row = ds.Tables[0].Rows[0];
            this.lbl_fee.Text = row["fee"].ToString();
            this.lbl_description.Text = row["Description"].ToString();
            this.lbl_game_name.Text = row["game_type"].ToString();
            this.lbl_location.Text = row["area"].ToString();
            this.lbl_host_name.Text = row["host_name"].ToString();


        }
        private void UserReview_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            this.Sql = "insert into Reviews (user_id,tournament_id,review) values('" + Session.UserId + "','" + this.tourID + "','" + this.txt_crimedetails.Text + "')";
            int count = this.Dac.ExecuteUpdateQuery(this.Sql);
            if (count == 1)
            {
                MessageBox.Show("Review Submitted Successfully");
            }
            else
            {
                MessageBox.Show("Review can not be submitted");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard ur = new UserDashboard();
            ur.Show();
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
