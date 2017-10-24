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

            string apiExterna = "https://api.bitvalor.com/v1/exchanges.json"; 

            dados.Add(new Exchanges() {
                id = "1",
                name = "FoxBit",
                valorCompra = 18616.07,
                valorVenda = 18690.00,
                montante = 0.12
            });

            dados.Add(new Exchanges() {
                id = "2",
                name = "FoxBit",
                valorCompra = 18616.07,
                valorVenda = 18690.00,
                montante = 0.12
            });

            dados.Add(new Exchanges() {
                id = "3",
                name = "FoxBit",
                valorCompra = 18616.07,
                valorVenda = 18690.00,
                montante = 0.12
            });

            dados.Add(new Exchanges() {
                id = "4",
                name = "FoxBit",
                valorCompra = 18616.07,
                valorVenda = 18690.00,
                montante = 0.12
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
