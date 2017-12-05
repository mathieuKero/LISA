using System.Collections.Generic;

namespace WebServiceLISA.Services
{
    public class Auth
    {
        public static bool UserExists(string login,string pass)
        {
            List<string> results = new List<string>();
            using (DBConnection connection = new DBConnection("lisadb"))
            {
                results = connection.Select("SELECT username,password FROM users WHERE username = '" + login + "'");
            }
                
            return results.Count > 0;
        }

        public static bool IsValidPassword(string login,string pass)
        {
            List<string> results = new List<string>();
            using (DBConnection connection = new DBConnection("lisadb"))
            {
                results = connection.Select("SELECT username,password FROM users WHERE username = '" + login + "' AND password = '" + pass + "'");
            }

            return results.Count > 0;
        }

        public static string GetToken(string login,string pass)
        {
            List<string> results = new List<string>();
            using(DBConnection connection = new DBConnection("lisadb"))
            {
                results = connection.Select("SELECT apikey from users WHERE username = '" + login + "' AND password = '" + pass + "'");
            }

            return results[0];
        }

        public static bool IsValidToken(string token)
        {
            List<string> results = new List<string>();
            using(DBConnection conenction = new DBConnection("lisadb"))
            {
                results = conenction.Select("SELECT apikey from users WHERE apikey = '" + token + "'");
            }

            return results.Count > 0;
        }
    }
}
