using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Api_Server.Models {
    public class Account {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Error { get; set; }

        public Account(string name, string username, string password) {
            this.Name = name;
            this.Username = username;
            this.Password = password;
        }

        public MySqlConnection conection() {
            var conection = new MySql.Data.MySqlClient.MySqlConnection(ConfigurationManager.ConnectionStrings["conexaoMySql"].ConnectionString);
            return conection;
        }

        public void Signup(Account account) {
            using (var connection = conection()) {
                connection.Open();
                using (var command = new MySqlCommand("INSERT INTO bit_calculator (name,username,password) VALUES (@name, @username,@password)", connection)) {
                    command.Parameters.AddWithValue("@name", (account.Name));
                    command.Parameters.AddWithValue("@username", (account.Username));
                    command.Parameters.AddWithValue("@password", (account.Password));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}