using Api_Server.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Api_Server.Controllers {
    public class CompraController : Controller {
        // GET: Compra
        public List<Compra> Get() {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection("Server=localhost;Database=bit_calculation;Uid=admin;Pwd=admin;")) {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM compras", connection);

                using (var reader = cmd.ExecuteReader()) {

                    List<Compra> list = new List<Compra>();

                    while (reader.Read()) {
                        list.Add(new Compra(
                            Convert.ToInt32(reader["id"]),
                            reader["eCompra"].ToString(),
                            reader["vCompra"].ToString(),
                            reader["eVenda"].ToString(),
                            reader["vVenda"].ToString(),
                            double.Parse(reader["montante"].ToString()),
                            float.Parse(reader["qtdLucro"].ToString()),
                            float.Parse(reader["pctLucro"].ToString())
                        ));
                    }
                    connection.Close();

                    return (list);
                }
            }
        }

        public Compra New(Compra compra) {



            return compra;
        }
    }
}