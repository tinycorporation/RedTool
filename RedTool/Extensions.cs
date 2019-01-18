using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedTool
{
    class Extensions
    {
        #region Authentication

        internal class Authentication
        {

            public static string Login(string Username, string Password)
            {
                using (System.Net.WebClient WebClient = new System.Net.WebClient())
                {
                    WebClient.Proxy = null;

                    WebClient.Headers.Add("user-agent", Settings.Useragent_string);

                    var data = new System.Collections.Specialized.NameValueCollection
                    {
                        ["Username"] = Username,
                        ["Password"] = Password
                    };

                    byte[] response = WebClient.UploadValues(Settings.Website + "loader/php/Login.php", data);

                    return Encoding.UTF8.GetString(response);
                }
            }

            public static string Register(string Username, string Password)
            {
                using (System.Net.WebClient WebClient = new System.Net.WebClient())
                {
                    WebClient.Proxy = null;

                    WebClient.Headers.Add("user-agent", Settings.Useragent_string);

                    var data = new System.Collections.Specialized.NameValueCollection
                    {
                        ["Username"] = Username,
                        ["Password"] = Password
                    };

                    byte[] Response = WebClient.UploadValues(Settings.Website + "loader/php/Register.php", data);

                    return Encoding.UTF8.GetString(Response);
                }
            }

            public static string Activate(string Username, string License)
            {
                using (System.Net.WebClient WebClient = new System.Net.WebClient())
                {
                    WebClient.Proxy = null;

                    WebClient.Headers.Add("user-agent", Settings.Useragent_string);

                    var data = new System.Collections.Specialized.NameValueCollection
                    {
                        ["Username"] = Username,
                        ["License"] = License
                    };

                    byte[] Response = WebClient.UploadValues(Settings.Website + "loader/php/Activate.php", data);

                    return Encoding.UTF8.GetString(Response);
                }
            }

            public static string Alert(string Message)
            {
                using (System.Net.WebClient WebClient = new System.Net.WebClient())
                {
                    WebClient.Proxy = null;

                    WebClient.Headers.Add("user-agent", Settings.Useragent_string);

                    var data = new System.Collections.Specialized.NameValueCollection
                    {
                        ["Message"] = Message
                    };

                    byte[] Response = WebClient.UploadValues(Settings.Website + "loader/php/Alert.php", data);

                    return Encoding.UTF8.GetString(Response);
                }
            }
        }

        #endregion Authentication

        #region Other
        internal class Other
        {
            public static string Base64Encode(string Input)
            {
                var plainTextBytes = Encoding.UTF8.GetBytes(Input);

                return Convert.ToBase64String(plainTextBytes);
            }

            public static string Base64Decode(string Input)
            {
                var base64EncodedBytes = Convert.FromBase64String(Input);

                return Encoding.UTF8.GetString(base64EncodedBytes);
            }
        }
        #endregion Other
    }
}
