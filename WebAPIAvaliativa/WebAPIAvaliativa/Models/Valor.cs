using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIAvaliativa.Models
{
    public class Valor
    {
        public int Id { get; set; }
        public string OpcaoCompra { get; set; }
        public float ValorCompra { get; set; }
        public string OpcaoVenda { get; set; }
        public float ValorVenda { get; set; }
        public float Montante { get; set; }
        public double QuantidadeLucro { get; set; }
        public double PorcentagemLucro { get; set; }
    }
}