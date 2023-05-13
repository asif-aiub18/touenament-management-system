using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManagementSystem
{
    public static class Session
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static bool IsLoggedIn { get; set; }

        public static void Login(int userId, string username)
        {
            UserId = userId;
            Username = username;
            IsLoggedIn = true;
        }

        public static void Logout()
        {
            UserId = 0;
            Username = "";
            IsLoggedIn = false;
        }
    }
}
