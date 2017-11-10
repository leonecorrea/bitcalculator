using BitCalculator_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BitCalculator_Server.Controllers {
    [EnableCors("*","*","*")]
    public class ExchangesController : ApiController {
        // GET: api/Exchanges
        public List<Exchanges> Get() {

            List<Exchanges> exchanges = new List<Exchanges>();

            exchanges.Add(new Exchanges() {
                Id = "FXB",
                Name = "FoxBit",
                ValorCompra = 25228.20,
                ValorVenda = 25235.00
            });

            exchanges.Add(new Exchanges() {
                Id = "B2Y",
                Name = "Bitcoin To You",
                ValorCompra = 24530.00,
                ValorVenda = 24748.38
            });

            exchanges.Add(new Exchanges() {
                Id = "MBC",
                Name = "Mercado Bitcoin",
                ValorCompra = 18616.07,
                ValorVenda = 18690.00
            });

            exchanges.Add(new Exchanges() {
                Id = "NGC",
                Name = "Negocie Coins",
                ValorCompra = 18616.07,
                ValorVenda = 18690.00
            });

            return exchanges;
        }

        // GET: api/Exchanges/5
        public Exchanges Get(string id) {
            Exchanges exchange = new Exchanges();
            exchange.Id = id;
            return exchange;
        }

        // POST: api/Exchanges
        public void Post([FromBody]string value) {
        }

        // PUT: api/Exchanges/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE: api/Exchanges/5
        public void Delete(int id) {
        }
    }
}
