using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Server.Models {
    public class Exchange {
        public string Id { get; set; }
        public string Nome { get; set; }
        public double ValorCompra { get; set; }
        public double ValorVenda { get; set; }
        public float TaxaCompra { get; set; }
        public float TaxaVenda { get; set; }
    }
}