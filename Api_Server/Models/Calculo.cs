using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitCalculator_Server.Models {
    public class Calculo {
        public string ExchCompra { get; set; }
        public string ValorCompra { get; set; }
        public string ExchVenda { get; set; }
        public string ValorVenda { get; set; }
        public string QtdLucro { get; set; }
        public string PctLucro { get; set; }
        public string Montante { get; set; }
    }
}