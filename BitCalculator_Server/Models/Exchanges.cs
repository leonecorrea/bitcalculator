using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCalculator_Server.Models {
    public class Exchanges {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ValorVenda { get; set; }
        public double ValorCompra { get; set; }
        public double Montante { get; set; }
    }
}