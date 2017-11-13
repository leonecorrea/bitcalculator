using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Server.Models {
    public class Calculo {
        public string ExchCompra { get; set; }
        public float ValorCompra { get; set; }
        public string ExchVenda { get; set; }
        public float ValorVenda { get; set; }
        public float QtdLucro { get; set; }
        public float PctLucro { get; set; }
        public float Montante { get; set; }
    }
}