using Api_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api_Server.Controllers {

    [EnableCors("*", "*", "*")]
    public class CalculoController : ApiController {

        // POST: api/Calculo
        public Calculo Post(Calculo calculo) {

            double TPE = 0;
            double Fee = 0;
            switch (calculo.OpcaoCompra) {
                case "FB":
                    TPE = 1.4;
                    Fee = 0.0003;
                    break;
                case "MB":
                    TPE = 1.6;
                    Fee = 0.0002;
                    break;
                case "B2U":
                    TPE = 1.8;
                    Fee = 0.0007;
                    break;
            }

            double TSE = 0;
            switch (calculo.OpcaoVenda) {
                case "FB":
                    TSE = 1.4;
                    break;
                case "MB":
                    TSE = 1.6;
                    break;
                case "B2U":
                    TSE = 1.8;
                    break;
            }

            //Calculando quando bitcoins foram comprados
            double bitCoinComprado = (1 / calculo.ValorCompra) * calculo.Montante;

            //Cobrando Taxa de Transferencia

            //Taxa de Fee de acordo com a Exchange
            bitCoinComprado = bitCoinComprado - Fee;

            double bitCoinDepoisDeTransferido = (bitCoinComprado) - ((bitCoinComprado / 100) * TPE);

            //Calculando ganho após vender o bitcoin
            double ganhoComVendaDoBitCoin = calculo.ValorVenda * bitCoinDepoisDeTransferido;

            //Calculando valor ganho depois do saque incluindo a taxa de saque
            double dinheiroGanhoDepoisDaVenda = ganhoComVendaDoBitCoin - ((ganhoComVendaDoBitCoin / 100) * TSE);

            //Calculando Porcentagem de Lucro
            double porcentagemDeLucro = 0;

            porcentagemDeLucro = (ganhoComVendaDoBitCoin / calculo.Montante) - 1;

            //Atribuo ao objeto as propriedades de quantidade e porcentagem de lucro
            calculo.QuantidadeLucro = dinheiroGanhoDepoisDaVenda - calculo.Montante;
            calculo.PorcentagemLucro = porcentagemDeLucro * 100;

            return calculo;
        }
    }
}