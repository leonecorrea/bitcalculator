using Api_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_Server.Controllers {
    public class CalculoController : ApiController
    {
        // GET: api/Calculo
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Calculo/5
        public string Get(int id) {
            return "value";
        }

        // POST: api/Calculo
        public Calculo Post(Calculo calculo) {

            Exchange e = new Exchange();

            //Calculo quando Bitcoins Comprados
            float bitCoinComprado = (1 / calculo.ValorCompra) * calculo.Montante;

            //Taxa de Transferência
            float bitCoinTransferido = bitCoinComprado - ((bitCoinComprado / 100) * e.TaxaCompra);

            //Ganho Após a Venda
            float ganhoVenda = calculo.ValorVenda * bitCoinTransferido;

            //Valor do Ganho após o saque incluindo sua taxa de saque
            float ganhoPosVenda = ganhoVenda - ((ganhoVenda / 100) * e.TaxaVenda);

            //Porcentagem de Lucro
            float porcentagemDeLucro = 0;
            porcentagemDeLucro = (ganhoVenda / calculo.Montante) - 1;

            //Atribuo ao objeto e as propriedades de quantidade e porcentagem de lucro
            calculo.QtdLucro = ganhoPosVenda - calculo.Montante;
            calculo.PctLucro = porcentagemDeLucro * 100;

            return calculo;
        }

        // PUT: api/Calculo/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE: api/Calculo/5
        public void Delete(int id) {
        }
    }
}
