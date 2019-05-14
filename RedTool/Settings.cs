using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedTool
{
    class Settings
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public static int Administrator { get; }

        public static int Admin;

        //public static string License { get; set; }

        public static string Useragent_string = "RedTool";

        public static string Website = "http://192.168.1.106:80/";
    }
}
