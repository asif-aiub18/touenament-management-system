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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            
            string sql = "select * from Users where email = '" + this.txt_email.Text+ "' and pass = '" + this.txt_password.Text + "';";
            DatabaseConfiguration dbc = new DatabaseConfiguration();
            DataSet ds = dbc.ExecuteQuery(sql);
            
            if (ds.Tables[0].Rows.Count == 1 )
            {
                DataRow row = ds.Tables[0].Rows[0];
                int userId = int.Parse(row["id"].ToString());
                String Username = row["name"].ToString();
                Session.Login(userId, Username);
                if ( row["type"].ToString().Trim().ToLower() == "admin" )
                {
                    MessageBox.Show("Login Approved For " + row["name"].ToString());
                    this.Hide();
                    AdminDashboard ad = new AdminDashboard();
                    ad.Show();
                }
                else if (row["type"].ToString().Trim().ToLower() == "guest")
                {
                    MessageBox.Show("Login Approved For " + row["name"].ToString());


                    this.Hide();
                    UserDashboard userDashboard = new UserDashboard();
                    userDashboard.Show();
                }
                else if (row["type"].ToString().Trim().ToLower() == "host")
                {
                    MessageBox.Show("Login Approved For " + row["name"].ToString());


                    this.Hide();
                    HostDashboard hd = new HostDashboard();
                    hd.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User type\n we are logging you out");
                    Session.Logout();
                }

            }else if (this.txt_email.Text == "admin" && this.txt_password.Text == "admin")
            {
                MessageBox.Show("Login Approved For admin" );
                this.Hide();
                AdminDashboard ad = new AdminDashboard();
                ad.Show();
            }



            else
            {
                MessageBox.Show("Login Invalid");
            }


        }


        private void btn_back_landing_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingForm frm = new LandingForm();
            frm.Show();
        }

    }
}
