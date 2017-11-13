using Api_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api_Server.Controllers {
    [EnableCors("*","*","*")]
    public class ExchangeController : ApiController {
        // GET: api/Exchanges
        public List<Exchange> Get() {

            List<Exchange> exchanges = new List<Exchange>();

            exchanges.Add(new Exchange() {
                Id = "FXB",
                Nome = "FoxBit",
                ValorCompra = 25228.20,
                ValorVenda = 25235.00,
                TaxaCompra = 1.4,
                TaxaVenda = 1.4
            });

            exchanges.Add(new Exchange() {
                Id = "B2Y",
                Nome = "Bitcoin To You",
                ValorCompra = 24530.00,
                ValorVenda = 24748.38,
                TaxaCompra = 1.4,
                TaxaVenda = 1.4
            });

            exchanges.Add(new Exchange() {
                Id = "MBC",
                Nome = "Mercado Bitcoin",
                ValorCompra = 18616.07,
                ValorVenda = 18690.00,
                TaxaCompra = 1.4,
                TaxaVenda = 1.4
            });

            exchanges.Add(new Exchange() {
                Id = "NGC",
                Nome = "Negocie Coins",
                ValorCompra = 18616.07,
                ValorVenda = 18690.00,
                TaxaCompra = 1.4,
                TaxaVenda = 1.4
            });

            return exchanges;
        }

        // GET: api/Exchanges/5
        public Exchange Get(string id) {
            Exchange exchange = new Exchange();

            // Faremos aqui a busca dos dados no banco

            return exchange;
        }

        // PUT: api/Exchanges/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE: api/Exchanges/5
        public void Delete(int id) {
        }
    }
}
