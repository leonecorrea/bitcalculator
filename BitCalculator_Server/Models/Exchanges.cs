using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCalculator_Server.Models {
    public class Exchanges {
        public string id { get; set; }
        public string name { get; set; }
        public double valorVenda { get; set; }
        public double valorCompra { get; set; }
        public double montante { get; set; }
    }
}