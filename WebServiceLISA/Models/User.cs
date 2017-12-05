using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceLISA.Services;

namespace WebServiceLISA.Models
{
    public class User
    {
        private string _Name;
        private string _Password;
        private string _Username;
        private string _Token = TokenGenerator.Generate();

        public string Name { get => this._Name; set => this._Name = value; }
        public string Password { get => this._Password; set => this._Password = value; }
        public string Username { get => this._Username; set => this._Username = value; }
        public string Token { get => this._Token; }

        public void Save()
        {
            string credentials = "Server=localhost" + ";Database=lisadb;Uid=root;Pwd=not24get;";
            MySqlConnection connection = new MySqlConnection(credentials);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = connection,
                CommandText = "INSERT INTO users VALUES(NULL,'" + this._Name + "','" + this._Password + "','" + this._Token + "','" + this._Username + "');"
            };
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
