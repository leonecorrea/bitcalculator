using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Server.Models {
    public class Compra {
        private int Id { get; set; }
        private string ECompra { get; set; }
        private string VCompra { get; set; }
        private string EVenda { get; set; }
        private string VVenda { get; set; }
        private double Montante { get; set; }
        private float QtdLucro { get; set; }
        private float PctLucro { get; set; }

        public Compra(int id, string eCompra, string vCompra, string eVenda, string vVenda,
        double montante, float qrdLucro, float pctLucro) {
            this.Id = id;
            this.ECompra = eCompra;
            this.VCompra = vCompra;
            this.EVenda = eVenda;
            this.VVenda = vVenda;
            this.Montante = montante;
            this.QtdLucro = qrdLucro;
            this.PctLucro = pctLucro;
        }
    }
}