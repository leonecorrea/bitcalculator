using BitCalculator_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BitCalculator_Server.Controllers
{
    [EnableCors("*","*","*")]
    public class ExchangesController : ApiController
    {
        // GET: api/Exchanges
        public List<Exchanges> Get() {

            List<Exchanges> dados = new List<Exchanges>();

            dados.Add(new Exchanges() {
                Id = 1,
                Name = "FoxBit",
                ValorCompra = 18616.07,
                ValorVenda = 18690.00,
                Montante = 0.12
            });

            dados.Add(new Exchanges() {
                Id = 2,
                Name = "FoxBit",
                ValorCompra = 18616.07,
                ValorVenda = 18690.00,
                Montante = 0.12
            });

            dados.Add(new Exchanges() {
                Id = 3,
                Name = "FoxBit",
                ValorCompra = 18616.07,
                ValorVenda = 18690.00,
                Montante = 0.12
            });

            dados.Add(new Exchanges() {
                Id = 4,
                Name = "FoxBit",
                ValorCompra = 18616.07,
                ValorVenda = 18690.00,
                Montante = 0.12
            });

            return dados;
        }

        // GET: api/Exchanges/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Exchanges
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Exchanges/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Exchanges/5
        public void Delete(int id)
        {
        }
    }
}
