import { Component, OnInit } from '@angular/core';

import { Exchange } from '../classes/Exchange';
import { Http } from '@angular/http';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { ExchangeService } from '../exchange/exchange.service';
import { CalculatorService } from './calculator.service';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {
  f: FormGroup;
  exchanges: any;
  errorMenssage: any;
  mostra: boolean;
  lucro: any;

  constructor(
    private _http: Http,
    private formBuilder: FormBuilder,
    private _exchangeService: ExchangeService,
    private _calcular: CalculatorService
  ) {}

  ngOnInit() {
    // Formulario reativo
    this.f = this.formBuilder.group({
      eCompra: [null],
      vCompra: [null],
      eVenda: [null],
      vVenda: [null],
      qtddReais: [null],
      pctg: [null],
      lucro: [null]
    });

    this.getAllExchange();
  }

  getAllExchange() {
    this.exchanges = this.exchanges = this._exchangeService.getAllExchanges();
  }

  ngSubmit() {
    console.log(this.f.value);
  }

  // Ação para Calcular
  public calcular() {
    console.log('Calcular');
    this.calcularTaxas();
  }

  // Ação para compra
  public comprar() {
    console.log('Comprar');
  }

  public mostraResultado() {
    this.mostra = true;
  }

  public calcularTaxas() {
    const taxas = this._calcular.calcularTaxas(this.f.value);
    this.mostraResultado();
  }
}
