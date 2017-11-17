using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPIAvaliativa.Models;


namespace WebAPIAvaliativa.Controllers
{
    [EnableCors("*","*","*")]
    public class WebAPIController : ApiController
    {
        // GET: api/WebAPI
        public IEnumerable<Valor> Get()
        {
            Valor CalcSpred = new Valor();
            CalcSpred.Id = 1;
            CalcSpred.OpcaoCompra = "Bit";
            CalcSpred.ValorCompra = 1000;
            CalcSpred.OpcaoVenda = "Outro";
            CalcSpred.ValorVenda = 1200;
            CalcSpred.Montante = 1230;
            yield return CalcSpred;
        }

        // GET: api/WebAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WebAPI
        public Valor Post(Valor value)
        {
            double PrimeiraTaxaExchange = 0;
            switch (value.OpcaoCompra)
            {
                case "FB":
                    PrimeiraTaxaExchange = 1.4;
                    break;
                case "MB":
                    PrimeiraTaxaExchange = 1.6;
                    break;
                case "B2U":
                    PrimeiraTaxaExchange = 1.8;
                    break;         
            }

            double SegundaTaxaExchange = 0;
            switch (value.OpcaoVenda)
            {
                case "FB":
                    SegundaTaxaExchange = 1.4;
                    break;
                case "MB":
                    SegundaTaxaExchange = 1.6;
                    break;
                case "B2U":
                    SegundaTaxaExchange = 1.8;
                    break;

            }

            //Calculo quando Bitcoins Comprados
            float bitCoinComprado = (1 / value.ValorCompra) * value.Montante;

            //Taxa de Transferência
            double bitCoinTransferido = bitCoinComprado - ((bitCoinComprado / 100) * PrimeiraTaxaExchange);

            //Ganho Após a Venda
            double ganhoVenda = value.ValorVenda * bitCoinTransferido;

            //Valor do Ganho após o saque incluindo sua taxa de saque
            double ganhoPosVenda = ganhoVenda - ((ganhoVenda /100) * SegundaTaxaExchange);

            //Porcentagem de Lucro
            double porcentagemDeLucro = 0;
            porcentagemDeLucro = (ganhoVenda / value.Montante) - 1;

            //Atribuo ao objeto e as propriedades de quantidade e porcentagem de lucro
            value.QuantidadeLucro = ganhoPosVenda - value.Montante;
            value.PorcentagemLucro = porcentagemDeLucro * 100;

            return value;
        }

        // PUT: api/WebAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WebAPI/5
        public void Delete(int id)
        {
        }
    }
}
