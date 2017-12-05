using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceLISA.Services
{
    public class DBConnection : IDisposable
    {
        private MySqlConnection _Connection;

        public MySqlConnection MYSQLConnection;

        public DBConnection(string dbname)
        {
            string credentials = "Server=localhost" + ";Database=" + dbname + ";Uid=root;Pwd=not24get;";
            this._Connection = new MySqlConnection(credentials);
            this._Connection.Open();
        }

        public List<string> Select(string sql)
        {
            List<string> results = new List<string>();
            MySqlCommand cmd = new MySqlCommand(sql,_Connection);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    for(int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Add(reader.GetValue(i).ToString());
                    }
                }
            }

            return results;
        }

        public void Dispose()
        {
            this._Connection.Close();
            this._Connection.Dispose();
        }
    }
}
