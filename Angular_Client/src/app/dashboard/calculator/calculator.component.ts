import { Component, OnInit } from '@angular/core';

import { Exchange } from '../../classes/Exchange';
import { Http } from '@angular/http';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { ExchangeService } from '../../services/exchange.service';
import { CalculatorService } from '../../services/calculator.service';
import { HistoricoDeComprasService } from '../../services/historico-de-compras.service';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {
  f: FormGroup;
  exchanges: any;
  mostra: boolean;
  public data: any;
  res1: any;
  res2: any;

  constructor(
    private _http: Http,
    private _formBuilder: FormBuilder,
    private _exchangeService: ExchangeService,
    private _calcular: CalculatorService,
    private _compra: HistoricoDeComprasService
  ) {}

  ngOnInit() {
    // Formulario reativo
    this.f = this._formBuilder.group({
      OpcaoCompra: [null],
      ValorCompra: [null],
      OpcaoVenda: [null],
      ValorVenda: [null],
      Montante: [null]
    });

    this.getAllExchange();
  }

  getAllExchange() {
    this.exchanges = this._exchangeService.getAllExchanges();
  }

  ngSubmit() {
    // console.log(this.f.value);
  }

  // Ação para Calcular
  public calcular() {
    this.calcularTaxas();
  }

  public mostraResultado(res) {
    this.mostra = true;
    console.log(res);
    this.res1 = res.PorcentagemLucro;
    this.res2 = res.QuantidadeLucro;
  }

  private calcularTaxas() {
    this._calcular
      .calcularTaxas(this.f.value)
      .then(res => this.mostraResultado(res));
  }

  // Ação para compra
  public comprar() {
    // console.log('Comprar');
    this._compra.newCompra(this.f.value);
  }
}
