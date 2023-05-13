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
    public partial class AdminDashboard : Form
    {

        String Sql;
        private DatabaseConfiguration Dac { get; set; }
        private DataSet Ds { get; set; }
        public AdminDashboard()
        {
            InitializeComponent();
            this.Dac = new DatabaseConfiguration();
            this.PopulateVenuesGridView();
            this.PopulateHostsGridView();
        }
        public void PopulateVenuesGridView(string sql = "select * from VenuesTable;")
        {
            this.Ds = this.Dac.ExecuteQuery(sql);
            this.VenuesGridView.AutoGenerateColumns = false;
            this.VenuesGridView.DataSource = this.Ds.Tables[0];
        }
        public void PopulateHostsGridView(string sql = "select * from Users where type = 'host';")
        {
            this.Ds = this.Dac.ExecuteQuery(sql);
            this.HostGridView.AutoGenerateColumns = false;
            this.HostGridView.DataSource = this.Ds.Tables[0];
        }

        
        private void btn_venue_operation_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddVenueForm addVenueForm = new AddVenueForm();
            addVenueForm.ShowDialog();
        }

        private void btn_host_operation_Click(object sender, EventArgs e)
        {
            this.Hide();
            HostForm hf = new HostForm();
            hf.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
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

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

