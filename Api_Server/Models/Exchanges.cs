using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCalculator_Server.Models {
    public class Exchanges {
        public string Id { get; set; }
        public string Name { get; set; }
        public double ValorVenda { get; set; }
        public double ValorCompra { get; set; }
    }
}