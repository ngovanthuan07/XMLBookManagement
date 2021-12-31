using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLCK
{
    class StaticUser
    {
        private static string username;
        private static string password;

        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }
    }
}
